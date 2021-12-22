
public class Cp3TableView
	extends android.view.ViewGroup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_scrollTo:(II)V:GetScrollTo_IIHandler\n" +
			"n_scrollBy:(II)V:GetScrollBy_IIHandler\n" +
			"n_computeHorizontalScrollExtent:()I:GetComputeHorizontalScrollExtentHandler\n" +
			"n_computeHorizontalScrollOffset:()I:GetComputeHorizontalScrollOffsetHandler\n" +
			"n_computeHorizontalScrollRange:()I:GetComputeHorizontalScrollRangeHandler\n" +
			"n_computeVerticalScrollExtent:()I:GetComputeVerticalScrollExtentHandler\n" +
			"n_computeVerticalScrollOffset:()I:GetComputeVerticalScrollOffsetHandler\n" +
			"n_computeVerticalScrollRange:()I:GetComputeVerticalScrollRangeHandler\n" +
			"n_removeView:(Landroid/view/View;)V:GetRemoveView_Landroid_view_View_Handler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_drawChild:(Landroid/graphics/Canvas;Landroid/view/View;J)Z:GetDrawChild_Landroid_graphics_Canvas_Landroid_view_View_JHandler\n" +
			"";
		mono.android.Runtime.register ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.Cp3TableView, App1.Android", Cp3TableView.class, __md_methods);
	}


	public Cp3TableView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Cp3TableView.class)
			mono.android.TypeManager.Activate ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.Cp3TableView, App1.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public Cp3TableView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == Cp3TableView.class)
			mono.android.TypeManager.Activate ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.Cp3TableView, App1.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public Cp3TableView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == Cp3TableView.class)
			mono.android.TypeManager.Activate ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.Cp3TableView, App1.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public Cp3TableView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == Cp3TableView.class)
			mono.android.TypeManager.Activate ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.Cp3TableView, App1.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public boolean onInterceptTouchEvent (android.view.MotionEvent p0)
	{
		return n_onInterceptTouchEvent (p0);
	}

	private native boolean n_onInterceptTouchEvent (android.view.MotionEvent p0);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public void scrollTo (int p0, int p1)
	{
		n_scrollTo (p0, p1);
	}

	private native void n_scrollTo (int p0, int p1);


	public void scrollBy (int p0, int p1)
	{
		n_scrollBy (p0, p1);
	}

	private native void n_scrollBy (int p0, int p1);


	public int computeHorizontalScrollExtent ()
	{
		return n_computeHorizontalScrollExtent ();
	}

	private native int n_computeHorizontalScrollExtent ();


	public int computeHorizontalScrollOffset ()
	{
		return n_computeHorizontalScrollOffset ();
	}

	private native int n_computeHorizontalScrollOffset ();


	public int computeHorizontalScrollRange ()
	{
		return n_computeHorizontalScrollRange ();
	}

	private native int n_computeHorizontalScrollRange ();


	public int computeVerticalScrollExtent ()
	{
		return n_computeVerticalScrollExtent ();
	}

	private native int n_computeVerticalScrollExtent ();


	public int computeVerticalScrollOffset ()
	{
		return n_computeVerticalScrollOffset ();
	}

	private native int n_computeVerticalScrollOffset ();


	public int computeVerticalScrollRange ()
	{
		return n_computeVerticalScrollRange ();
	}

	private native int n_computeVerticalScrollRange ();


	public void removeView (android.view.View p0)
	{
		n_removeView (p0);
	}

	private native void n_removeView (android.view.View p0);


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public boolean drawChild (android.graphics.Canvas p0, android.view.View p1, long p2)
	{
		return n_drawChild (p0, p1, p2);
	}

	private native boolean n_drawChild (android.graphics.Canvas p0, android.view.View p1, long p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
