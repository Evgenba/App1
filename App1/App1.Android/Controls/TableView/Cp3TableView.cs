using System;
using System.Collections.Generic;
using System.Linq;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using App1.Android;
using App1.Extensions;
using Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters;
using ItemViewType = Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters.ItemViewType;
using Math = System.Math;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView
{
    [Register(nameof(Cp3TableView))]
    public class Cp3TableView : ViewGroup
    {
        public Cp3TableView(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        /// <summary>
        /// Simple constructor to use when creating a view from code
        /// </summary>
        /// <param name="context">The Context the view is running in, through which it can access the current theme, resources, etc</param>
        public Cp3TableView(Android.Content.Context context)
            : this(context, (IAttributeSet)null)
        {
        }

        public Cp3TableView(Android.Content.Context context, IAttributeSet attrs)
            : this(context, attrs, -1)
        {
        }

        public Cp3TableView(Android.Content.Context context, IAttributeSet attrs, int defStyleAttr)
            : this(context, attrs, defStyleAttr, -1)
        {
        }

        public Cp3TableView(Android.Content.Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes)
            : base(context, attrs, defStyleAttr, defStyleRes)
        {
            InitializeTableView(context, attrs);
        }


        private void InitializeTableView(Android.Content.Context context, IAttributeSet attrs)
        {
            this.headView = null;
            this.rowViewList = new List<View>();
            this.columnViewList = new List<View>();
            this.bodyViewTable = new List<List<View>>();

            this.NeedRelayout = true;

            this.shadows = new ImageView[4];
            this.shadows[0] = new ImageView(context);
            this.shadows[0].SetImageResource(Resource.Drawable.shadow_left);
            this.shadows[1] = new ImageView(context);
            this.shadows[1].SetImageResource(Resource.Drawable.shadow_top);
            this.shadows[2] = new ImageView(context);
            this.shadows[2].SetImageResource(Resource.Drawable.shadow_right);
            this.shadows[3] = new ImageView(context);
            this.shadows[3].SetImageResource(Resource.Drawable.shadow_bottom);

            this.shadowSize = Resources.GetDimensionPixelSize(Resource.Dimension.shadow_size);

            this.flinger = new Flinger(context, this);
            ViewConfiguration configuration = ViewConfiguration.Get(context);
            this.touchSlop = configuration.ScaledTouchSlop;
            this.minimumVelocity = configuration.ScaledMinimumFlingVelocity;
            this.maximumVelocity = configuration.ScaledMaximumFlingVelocity;

            this.SetWillNotDraw(false);
        }

        // hack for scroll (fix H/V scrolling at once, to avoid diagonal scroll)
        // 0 - initial, 1 - Horizontal, 2 - Vertical
        private int currentDirection;

        private int currentX;
        private int currentY;

        private ITableAdapter adapter; //BaseTableAdapter
        private int scrollX;
        private int scrollY;
        private int firstRow;
        private int firstColumn;
        private int[] widths;
        private int[] heights;

//    @SuppressWarnings("unused")
        private View headView;

        private List<View> rowViewList;
        private List<View> columnViewList;
        private List<List<View>> bodyViewTable;

        private int rowCount;
        private int columnCount;

        private int width;
        private int height;

        private Cp3TableRecycler recycler;

        private TableAdapterDataSetObserver tableAdapterDataSetObserver;
        internal bool NeedRelayout;

        private ImageView[] shadows;
        private int shadowSize;

        private int minimumVelocity;
        private int maximumVelocity;

        private Flinger flinger;

        private VelocityTracker velocityTracker;

        private int touchSlop;


        /// <summary>
        /// Returns the adapter currently associated with this widget
        /// </summary>
        /// <returns>The adapter used to provide this view's content</returns>
        public ITableAdapter GetAdapter()
        {
            return adapter;
        }

        /// <summary>
        /// Sets the data behind this TableFixHeaders
        /// </summary>
        /// <param name="adapter">The ITableAdapter which is responsible for maintaining the data backing this list and for producing a view to represent an item in that data set</param>
        public void SetAdapter(ITableAdapter adapter)
        {
            if (this.adapter != null)
            {
                this.adapter.UnregisterDataSetObserver(tableAdapterDataSetObserver);
            }

            this.adapter = adapter;
            tableAdapterDataSetObserver = new TableAdapterDataSetObserver();
            tableAdapterDataSetObserver.TableView = this;
            this.adapter.RegisterDataSetObserver(tableAdapterDataSetObserver);

            // todo: do we need here Context at all?
            this.recycler = new Cp3TableRecycler(adapter.GetViewTypeCount());

            scrollX = 0;
            scrollY = 0;
            firstColumn = 0;
            firstRow = 0;

            NeedRelayout = true;
            RequestLayout();
        }

        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            switch (ev.Action)
            {
                case MotionEventActions.Down:
                    currentX = (int)ev.RawX;
                    currentY = (int)ev.RawY;
                    break;

                case MotionEventActions.Move:
                    int x2 = Math.Abs(currentX - (int)ev.RawX);
                    int y2 = Math.Abs(currentY - (int)ev.RawY);
                    if (x2 > touchSlop || y2 > touchSlop)
                    {
                        return true;
                    }

                    break;
            }

            return false;
        }

        public override bool OnTouchEvent(MotionEvent motionEvent)
        {
            velocityTracker ??= VelocityTracker.Obtain();

            velocityTracker.AddMovement(motionEvent); // add this movement to it

            switch (motionEvent.Action)
            {
                case MotionEventActions.Down:
                    if (!flinger.IsFinished)
                    {
                        // If scrolling, then stop now
                        flinger.ForceFinished();
                    }

                    currentX = (int)motionEvent.RawX;
                    currentY = (int)motionEvent.RawY;
                    break;

                case MotionEventActions.Move:
                    int x2 = (int)motionEvent.RawX;
                    int y2 = (int)motionEvent.RawY;
                    int diffX = currentX - x2;
                    int diffY = currentY - y2;
                    currentX = x2;
                    currentY = y2;

                    if (currentDirection == 1)
                    {
                        ScrollBy(diffX, 0);
                    }
                    else if (currentDirection == 2)
                    {
                        ScrollBy(0, diffY);
                    }
                    else if (Math.Abs(diffX) > Math.Abs(diffY))
                    {
                        currentDirection = 1;
                        ScrollBy(diffX, 0);
                    }
                    else
                    {
                        currentDirection = 2;
                        ScrollBy(0, diffY);
                    }

                    break;

                case MotionEventActions.Up:
                    currentDirection = 0;
                    var velocityTracker = this.velocityTracker;
                    velocityTracker.ComputeCurrentVelocity(1000, maximumVelocity);
                    int velocityX = (int)velocityTracker.XVelocity;
                    int velocityY = (int)velocityTracker.YVelocity;

                    if (Math.Abs(velocityX) > minimumVelocity || Math.Abs(velocityY) > minimumVelocity)
                    {
                        flinger.Start(getActualScrollX(), getActualScrollY(), velocityX, velocityY, getMaxScrollX(),
                            getMaxScrollY());
                    }
                    else
                    {
                        if (this.velocityTracker != null)
                        {
                            // If the velocity less than threshold
                            this.velocityTracker.Recycle(); // recycle the tracker
                            this.velocityTracker = null;
                        }
                    }

                    break;
            }

            return true;
        }

        public override void ScrollTo(int x, int y)
        {
            if (NeedRelayout)
            {
                scrollX = x;
                firstColumn = 0;

                scrollY = y;
                firstRow = 0;
            }
            else
            {
                ScrollBy(x - SumArray(widths, 1, firstColumn) - scrollX, y - SumArray(heights, 1, firstRow) - scrollY);
            }
        }

        public override void ScrollBy(int x, int y)
        {
            scrollX += x;
            scrollY += y;

            if (NeedRelayout)
            {
                return;
            }

            ScrollBounds();

            /*
             * TODO Improve the algorithm. Think big diagonal movements. If we are
             * in the top left corner and scrollBy to the opposite corner. We will
             * have created the views from the top right corner on the X part and we
             * will have eliminated to generate the right at the Y.
             */
            if (scrollX == 0)
            {
                // no op
            }
            else if (scrollX > 0)
            {
                while (widths[firstColumn + 1] < scrollX)
                {
                    if (!rowViewList.IsNullOrEmpty())
                    {
                        removeLeft();
                    }

                    scrollX -= widths[firstColumn + 1];
                    firstColumn++;
                }

                while (getFilledWidth() < width)
                {
                    addRight();
                }
            }
            else
            {
                while (!rowViewList.IsNullOrEmpty() &&
                       getFilledWidth() - widths[firstColumn + rowViewList.Count] >= width)
                {
                    removeRight();
                }

                if (rowViewList.IsNullOrEmpty())
                {
                    while (scrollX < 0)
                    {
                        firstColumn--;
                        scrollX += widths[firstColumn + 1];
                    }

                    while (getFilledWidth() < width)
                    {
                        addRight();
                    }
                }
                else
                {
                    while (0 > scrollX)
                    {
                        addLeft();
                        firstColumn--;
                        scrollX += widths[firstColumn + 1];
                    }
                }
            }

            if (scrollY == 0)
            {
                // no op
            }
            else if (scrollY > 0)
            {
                while (heights[firstRow + 1] < scrollY)
                {
                    if (!columnViewList.IsNullOrEmpty())
                    {
                        removeTop();
                    }

                    scrollY -= heights[firstRow + 1];
                    firstRow++;
                }

                while (getFilledHeight() < height)
                {
                    addBottom();
                }
            }
            else
            {
                while (!columnViewList.IsNullOrEmpty() &&
                       getFilledHeight() - heights[firstRow + columnViewList.Count] >= height)
                {
                    removeBottom();
                }

                if (columnViewList.IsNullOrEmpty())
                {
                    while (scrollY < 0)
                    {
                        firstRow--;
                        scrollY += heights[firstRow + 1];
                    }

                    while (getFilledHeight() < height)
                    {
                        addBottom();
                    }
                }
                else
                {
                    while (0 > scrollY)
                    {
                        addTop();
                        firstRow--;
                        scrollY += heights[firstRow + 1];
                    }
                }
            }

            RepositionViews();

            ShadowsVisibility();

            AwakenScrollBars();
        }


        protected override int ComputeHorizontalScrollExtent()
        {
            /*
             * The expected value is: percentageOfViewScrolled * computeHorizontalScrollRange()
             */
            float tableSize = width - widths[0];
            float contentSize = SumArray(widths) - widths[0];
            float percentageOfVisibleView = tableSize / contentSize;

            return (int)Math.Round(percentageOfVisibleView * tableSize);
        }

        protected override int ComputeHorizontalScrollOffset()
        {
            /*
             * The expected value is between 0 and computeHorizontalScrollRange() - computeHorizontalScrollExtent()
             */
            float maxScrollX = SumArray(widths) - width;
            float percentageOfViewScrolled = getActualScrollX() / maxScrollX;
            int maxHorizontalScrollOffset = width - widths[0] - ComputeHorizontalScrollExtent();

            return widths[0] + (int)Math.Round(percentageOfViewScrolled * maxHorizontalScrollOffset);
        }

        protected override int ComputeHorizontalScrollRange()
        {
            /*
             * The base measure
             */
            return width;
        }

        protected override int ComputeVerticalScrollExtent()
        {
            /*
             * The expected value is: percentageOfViewScrolled * computeVerticalScrollRange()
             */
            float tableSize = height - heights[0];
            float contentSize = SumArray(heights) - heights[0];
            float percentageOfVisibleView = tableSize / contentSize;

            return (int)Math.Round(percentageOfVisibleView * tableSize);
        }

        /*
         * The expected value is between 0 and computeVerticalScrollRange() - computeVerticalScrollExtent()
         */
        protected override int ComputeVerticalScrollOffset()
        {
            float maxScrollY = SumArray(heights) - height;
            float percentageOfViewScrolled = getActualScrollY() / maxScrollY;
            int maxHorizontalScrollOffset = height - heights[0] - ComputeVerticalScrollExtent();

            return heights[0] + (int)Math.Round(percentageOfViewScrolled * maxHorizontalScrollOffset);
        }

        /*
         * The base measure
         */
        protected override int ComputeVerticalScrollRange()
        {
            return height;
        }

        public int getActualScrollX()
        {
            return scrollX + SumArray(widths, 1, firstColumn);
        }

        public int getActualScrollY()
        {
            return scrollY + SumArray(heights, 1, firstRow);
        }

        private int getMaxScrollX()
        {
            return Math.Max(0, SumArray(widths) - width);
        }

        private int getMaxScrollY()
        {
            return Math.Max(0, SumArray(heights) - height);
        }

        private int getFilledWidth()
        {
            return widths[0] + SumArray(widths, firstColumn + 1, rowViewList.Count) - scrollX;
        }

        private int getFilledHeight()
        {
            return heights[0] + SumArray(heights, firstRow + 1, columnViewList.Count) - scrollY;
        }

        private void addLeft()
        {
            addLeftOrRight(firstColumn - 1, 0);
        }

        private void addTop()
        {
            addTopAndBottom(firstRow - 1, 0);
        }

        private void addRight()
        {
            int size = rowViewList.Count;
            addLeftOrRight(firstColumn + size, size);
        }

        private void addBottom()
        {
            int size = columnViewList.Count;
            addTopAndBottom(firstRow + size, size);
        }

        private void addLeftOrRight(int column, int index)
        {
            View view = MakeView(-1, column, widths[column + 1], heights[0]);

            // todo: check it!!! was add method
            // todo: can be used as array, to avoid Insert (originally was Add method)
            rowViewList.Insert(index, view);

            int i = firstRow;

            foreach (var list in bodyViewTable)
            {
                view = MakeView(i, column, widths[column + 1], heights[i + 1]);

                // todo: check it!!! was add method
                // todo: can be used as array, to avoid Insert (originally was Add method)
                list.Insert(index, view);
                i++;
            }
        }

        private void addTopAndBottom(int row, int index)
        {
            View view = MakeView(row, -1, widths[0], heights[row + 1]);

            // todo: check it!!! was add method
            // todo: can be used as array, to avoid Insert (originally was Add method)
            columnViewList.Insert(index, view);

            List<View> list = new List<View>();
            int size = rowViewList.Count + firstColumn;
            for (int i = firstColumn; i < size; i++)
            {
                view = MakeView(row, i, widths[i + 1], heights[row + 1]);
                list.Add(view);
            }

            // todo: check it!!! was add method
            // todo: can be used as array, to avoid Insert (originally was Add method)
            bodyViewTable.Insert(index, list);
        }

        private void removeLeft()
        {
            removeLeftOrRight(0);
        }

        private void removeTop()
        {
            removeTopOrBottom(0);
        }

        private void removeRight()
        {
            removeLeftOrRight(rowViewList.Count - 1);
        }

        private void removeBottom()
        {
            removeTopOrBottom(columnViewList.Count - 1);
        }

        private void removeLeftOrRight(int position)
        {
            var viewToRemove = rowViewList[position];
            RemoveView(viewToRemove);
            rowViewList.RemoveAt(position);

            foreach (var list in bodyViewTable)
            {
                var viewToRemove1 = list[position];
                RemoveView(viewToRemove1);
                rowViewList.RemoveAt(position);
                list.RemoveAt(position);
            }
        }

        private void removeTopOrBottom(int position)
        {
            var viewToRemove = columnViewList[position];
            RemoveView(viewToRemove);
            columnViewList.RemoveAt(position);

            var bodyViewsToRemove = bodyViewTable[position];
            foreach (var bodyView in bodyViewsToRemove)
            {
                RemoveView(bodyView);
            }

            bodyViewTable.RemoveAt(position);
        }

        public override void RemoveView(View? view)
        {
            base.RemoveView(view);

            int typeView = (int)view.GetTag(Resource.Id.tag_type_view);
            if (typeView != ITableAdapter.IGNORE_ITEM_VIEW_TYPE)
            {
                recycler.AddRecycledView(view, typeView);
            }
        }

        private void RepositionViews()
        {
            int left, top, right, bottom, i;

            left = widths[0] - scrollX;
            i = firstColumn;

            foreach (var rowView in rowViewList)
            {
                right = left + widths[++i];
                rowView.Layout(left, 0, right, heights[0]);
                left = right;
            }

            top = heights[0] - scrollY;
            i = firstRow;

            foreach (var columnView in columnViewList)
            {
                bottom = top + heights[++i];
                columnView.Layout(0, top, widths[0], bottom);
                top = bottom;
            }

            top = heights[0] - scrollY;
            i = firstRow;

            foreach (var bodyViews in bodyViewTable)
            {
                bottom = top + heights[++i];
                left = widths[0] - scrollX;
                int j = firstColumn;

                foreach (var bodyView in bodyViews)
                {
                    right = left + widths[++j];
                    bodyView.Layout(left, top, right, bottom);
                    left = right;
                }

                top = bottom;
            }

            Invalidate();
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            var widthMode = MeasureSpec.GetMode(widthMeasureSpec);
            var heightMode = MeasureSpec.GetMode(heightMeasureSpec);
            var widthSize = MeasureSpec.GetSize(widthMeasureSpec);
            var heightSize = MeasureSpec.GetSize(heightMeasureSpec);

            int w;
            int h;

            if (adapter != null)
            {
                this.rowCount = adapter.GetRowCount();
                this.columnCount = adapter.GetColumnCount();

                widths = new int[columnCount + 1];
                for (int i = -1; i < columnCount; i++)
                {
                    widths[i + 1] += adapter.GetWidth(i);
                }

                heights = new int[rowCount + 1];
                for (int i = -1; i < rowCount; i++)
                {
                    heights[i + 1] += adapter.GetHeight(i);
                }

                if (widthMode == MeasureSpecMode.AtMost)
                {
                    w = Math.Min(widthSize, SumArray(widths));
                }
                else if (widthMode == MeasureSpecMode.Unspecified)
                {
                    w = SumArray(widths);
                }
                else
                {
                    w = widthSize;
                    int sumArray = SumArray(widths);
                    if (sumArray < widthSize)
                    {
                        float factor = widthSize / (float)sumArray;
                        for (int i = 1; i < widths.Length; i++)
                        {
                            widths[i] = (int)Math.Round(widths[i] * factor);
                        }

                        widths[0] = widthSize - SumArray(widths, 1, widths.Length - 1);
                    }
                }

                if (heightMode == MeasureSpecMode.AtMost)
                {
                    h = Math.Min(heightSize, SumArray(heights));
                }
                else if (heightMode == MeasureSpecMode.Unspecified)
                {
                    h = SumArray(heights);
                }
                else
                {
                    h = heightSize;
                }
            }
            else
            {
                if (heightMode == MeasureSpecMode.AtMost || widthMode == MeasureSpecMode.Unspecified)
                {
                    w = 0;
                    h = 0;
                }
                else
                {
                    w = widthSize;
                    h = heightSize;
                }
            }

            if (firstRow >= rowCount || getMaxScrollY() - getActualScrollY() < 0)
            {
                firstRow = 0;
                scrollY = int.MaxValue;
            }

            if (firstColumn >= columnCount || getMaxScrollX() - getActualScrollX() < 0)
            {
                firstColumn = 0;
                scrollX = int.MaxValue;
            }

            SetMeasuredDimension(w, h);
        }

        private int SumArray(IEnumerable<int> array)
        {
            return array.Sum();
        }

        private int SumArray(int[] array, int firstIndex, int count)
        {
            var itemsToSkip = firstIndex == 0 ? 0 : firstIndex - 1;
            var sum = array
                .Skip(itemsToSkip)
                .Take(count)
                .Sum();

            return sum;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            if (NeedRelayout || changed)
            {
                NeedRelayout = false;
                ResetTable();

                if (adapter != null)
                {
                    width = r - l;
                    height = b - t;

                    int left, top, right, bottom;

                    right = Math.Min(width, SumArray(widths));
                    bottom = Math.Min(height, SumArray(heights));

                    AddShadow(shadows[0], widths[0], 0, widths[0] + shadowSize, bottom);
                    AddShadow(shadows[1], 0, heights[0], right, heights[0] + shadowSize);
                    AddShadow(shadows[2], right - shadowSize, 0, right, bottom);
                    AddShadow(shadows[3], 0, bottom - shadowSize, right, bottom);

                    headView = makeAndSetup(-1, -1, 0, 0, widths[0], heights[0]);

                    ScrollBounds();
                    AdjustFirstCellsAndScroll();

                    left = widths[0] - scrollX;
                    for (int i = firstColumn; i < columnCount && left < width; i++)
                    {
                        right = left + widths[i + 1];
                        View view = makeAndSetup(-1, i, left, 0, right, heights[0]);
                        rowViewList.Add(view);
                        left = right;
                    }

                    top = heights[0] - scrollY;
                    for (int i = firstRow; i < rowCount && top < height; i++)
                    {
                        bottom = top + heights[i + 1];
                        View view = makeAndSetup(i, -1, 0, top, widths[0], bottom);
                        columnViewList.Add(view);
                        top = bottom;
                    }

                    top = heights[0] - scrollY;
                    for (int i = firstRow; i < rowCount && top < height; i++)
                    {
                        bottom = top + heights[i + 1];
                        left = widths[0] - scrollX;
                        var list = new List<View>();
                        for (int j = firstColumn; j < columnCount && left < width; j++)
                        {
                            right = left + widths[j + 1];
                            View view = makeAndSetup(i, j, left, top, right, bottom);
                            list.Add(view);
                            left = right;
                        }

                        bodyViewTable.Add(list);
                        top = bottom;
                    }

                    ShadowsVisibility();
                }
            }
        }

        private void ScrollBounds()
        {
            scrollX = ScrollBounds(scrollX, firstColumn, widths, width);
            scrollY = ScrollBounds(scrollY, firstRow, heights, height);
        }

        private int ScrollBounds(int desiredScroll, int firstCell, int[] sizes, int viewSize)
        {
            if (desiredScroll == 0)
            {
                // no op
            }
            else if (desiredScroll < 0)
            {
                desiredScroll = Math.Max(desiredScroll, -SumArray(sizes, 1, firstCell));
            }
            else
            {
                desiredScroll = Math.Min(desiredScroll,
                    Math.Max(0, SumArray(sizes, firstCell + 1, sizes.Length - 1 - firstCell) + sizes[0] - viewSize));
            }

            return desiredScroll;
        }

        private void AdjustFirstCellsAndScroll()
        {
            int[] values;

            values = AdjustFirstCellsAndScroll(scrollX, firstColumn, widths);
            scrollX = values[0];
            firstColumn = values[1];

            values = AdjustFirstCellsAndScroll(scrollY, firstRow, heights);
            scrollY = values[0];
            firstRow = values[1];
        }

        private int[] AdjustFirstCellsAndScroll(int scroll, int firstCell, int[] sizes)
        {
            if (scroll == 0)
            {
                // no op
            }
            else if (scroll > 0)
            {
                while (sizes[firstCell + 1] < scroll)
                {
                    firstCell++;
                    scroll -= sizes[firstCell];
                }
            }
            else
            {
                while (scroll < 0)
                {
                    scroll += sizes[firstCell];
                    firstCell--;
                }
            }

            return new int[] { scroll, firstCell };
        }

        private void ShadowsVisibility()
        {
            int actualScrollX = getActualScrollX();
            int actualScrollY = getActualScrollY();

            int[] remainPixels =
            {
                actualScrollX,
                actualScrollY,
                getMaxScrollX() - actualScrollX,
                getMaxScrollY() - actualScrollY,
            };

            for (int i = 0; i < shadows.Length; i++)
            {
                SetAlpha(shadows[i], Math.Min(remainPixels[i] / (float)shadowSize, 1));
            }
        }

        private void SetAlpha(ImageView imageView, float alpha)
        {
            imageView.SetAlpha((int)Math.Round(alpha * 255));
        }

        private void AddShadow(ImageView imageView, int l, int t, int r, int b)
        {
            imageView.Layout(l, t, r, b);
            AddView(imageView);
        }

        private void ResetTable()
        {
            headView = null;
            rowViewList.Clear();
            columnViewList.Clear();
            bodyViewTable.Clear();

            RemoveAllViews();
        }

        private View makeAndSetup(int row, int column, int left, int top, int right, int bottom)
        {
            View view = MakeView(row, column, right - left, bottom - top);
            view.Layout(left, top, right, bottom);
            return view;
        }

        protected override bool DrawChild(Canvas canvas, View child, long drawingTime)
        {
            bool ret;

            var row = (int)child.GetTag(Resource.Id.tag_row);
            var column = (int)child.GetTag(Resource.Id.tag_column);
            // row == null => Shadow view
            if (row == null || (row == -1 && column == -1))
            {
                ret = base.DrawChild(canvas, child, drawingTime);
            }
            else
            {
                canvas.Save();
                if (row == -1)
                {
                    canvas.ClipRect(widths[0], 0, canvas.Width, canvas.Height);
                }
                else if (column == -1)
                {
                    canvas.ClipRect(0, heights[0], canvas.Width, canvas.Height);
                }
                else
                {
                    canvas.ClipRect(widths[0], heights[0], canvas.Width, canvas.Height);
                }

                ret = base.DrawChild(canvas, child, drawingTime);

                canvas.Restore();
            }

            return ret;
        }

        private View MakeView(int row, int column, int w, int h)
        {
            ItemViewType itemViewType = adapter.GetItemViewType(row, column);

            View recycledView;
            if ((int)itemViewType == ITableAdapter.IGNORE_ITEM_VIEW_TYPE)
            {
                recycledView = null;
            }
            else
            {
                recycledView = recycler.GetRecycledView(itemViewType);
            }

            View view = adapter.GetView(row, column, recycledView, this);
            view.SetTag(Resource.Id.tag_type_view, (int)itemViewType);
            view.SetTag(Resource.Id.tag_row, row);
            view.SetTag(Resource.Id.tag_column, column);

            view.Measure(MeasureSpec.MakeMeasureSpec(w, MeasureSpecMode.Exactly),
                MeasureSpec.MakeMeasureSpec(h, MeasureSpecMode.Exactly));

            AddTableView(view, row, column);

            return view;
        }

        private void AddTableView(View view, int row, int column)
        {
            // todo: research magic numbers (4, 5)
            if (row == -1 && column == -1)
            {
                AddView(view, ChildCount - 4);
            }
            else if (row == -1 || column == -1)
            {
                AddView(view, ChildCount - 5);
            }
            else
            {
                AddView(view, 0);
            }
        }
    }
}