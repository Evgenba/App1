using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Android.App;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using App1.Android;
using Deloitte.Mobile.Cp3.DataAdapters;
using Deloitte.Mobile.Cp3.DataAdapters.Abstract;
using Enum = System.Enum;
using String = Java.Lang.String;

namespace Deloitte.Mobile.Cp3.Droid.Controls.TableView.Adapters
{
    public enum ItemViewType
    {
        TopLeft = 0,
        ColumnHeader,
        RowHeader,
        Cell,
        SectionTitle
    }


    internal class NexusTypes
    {
        private string name;
        private List<Nexus> list;

        public NexusTypes(string name)
        {
            this.name = name;
            list = new List<Nexus>();
        }

        public int size()
        {
            return list.Count;
        }

        public Nexus get(int i)
        {
            return list[i];
        }
    }

    internal class Nexus
    {
        public List<string> Data;

        private Nexus(string name, string company, string version, string api, string storage, string inches, string ram)
        {
            Data = new List<string>
            {
                name,
                company,
                version,
                api,
                storage,
                inches,
                ram
            };
        }
    }

    public class Cp3TableAdapter : BaseTableAdapter
    {
        private readonly BaseDataSourceMapper<Customer> dataSourceMapper;

        // todo: think about how to inflate w/o access to activity
        private readonly Activity activity;
        private readonly ObservableCollection<Customer> items;


        private NexusTypes[] familys;
        private string[] headers;

        private int[] widths;
        private float density;


        public Cp3TableAdapter(BaseDataSourceMapper<Customer> dataSourceMapper, Activity activity)
        {
            this.dataSourceMapper = dataSourceMapper;
            this.activity = activity;
            items = Customer.GetCustomerList(20);

            headers = new[]
            {
                "Name",
                "Company",
                "Version",
                "API",
                "Storage",
                "Size",
                "RAM"
            };

            widths = new int[]
            {
                110,
                50,
                140,
                60,
                70,
                60,
                60
            };

            familys = new NexusTypes[]
            {
                new NexusTypes("Mobiles"),
                new NexusTypes("Tablets"),
                new NexusTypes("Others"),
            };
        }

        public override int GetRowCount()
        {
            return items.Count;
        }

        public override int GetColumnCount()
        {
            return dataSourceMapper.ColumnsNumber;
        }

        public override View GetView(int row, int column, View convertView, ViewGroup parent)
        {
            View view;
            var itemViewType = GetItemViewType(row, column);
            switch (itemViewType)
            {
                case ItemViewType.TopLeft:
                    view = getFirstHeader(row, column, convertView, parent);
                    break;

                case ItemViewType.ColumnHeader:
                    view = GetHeader(row, column, convertView, parent);
                    break;

                case ItemViewType.RowHeader:
                    view = GetFirstBody(row, column, convertView, parent);
                    break;

                case ItemViewType.Cell:
                    view = GetBody(row, column, convertView, parent);
                    break;

                case ItemViewType.SectionTitle:
                    view = GetFamilyView(row, column, convertView, parent);
                    break;

                default:
                    throw new InvalidOperationException($"Not applicable ItemViewType {itemViewType}");
            }

            return view;
        }

        public override int GetWidth(int column)
        {
            // todo: calculate depends on max value
            return 150;
        }

        public override int GetHeight(int row)
        {
            // todo: calculate depends on max value
            return 100;
        }

        public override ItemViewType GetItemViewType(int row, int column)
        {
            if (row == -1 && column == -1)
            {
                return ItemViewType.TopLeft;
            }
            else if (row == -1)
            {
                return ItemViewType.ColumnHeader;
            }
            else if (IsSeparatorRow(row))
            {
                return ItemViewType.SectionTitle;
            }
            else if (column == -1)
            {
                return ItemViewType.RowHeader;
            }
            else
            {
                return ItemViewType.Cell;
            }
        }

        public override int GetViewTypeCount()
        {
            return Enum.GetValues(typeof(ItemViewType)).Length;
        }

        private bool IsSeparatorRow(int row)
        {
            // no section headers
            return false;
        }

        private View getFirstHeader(int row, int column, View convertView, ViewGroup parent)
        {
            convertView ??= activity.LayoutInflater.Inflate(Resource.Layout.item_table_header_first, parent, false);

            convertView.FindViewById<TextView>(Resource.Id.text1).Text = headers[0];
            return convertView;
        }

        private View GetHeader(int row, int column, View convertView, ViewGroup parent)
        {
            convertView ??= activity.LayoutInflater.Inflate(Resource.Layout.item_table_header, parent, false);

            convertView.FindViewById<TextView>(Resource.Id.text1).Text = headers[column + 1];
            return convertView;
        }

        private View GetFirstBody(int row, int column, View convertView, ViewGroup parent)
        {
            convertView ??= activity.LayoutInflater.Inflate(Resource.Layout.item_table_first, parent, false);

            //convertView.SetBackgroundResource(row % 2 == 0 ? Resource.Drawable.bg_table_color1 : Resource.Drawable.bg_table_color2);

            convertView.FindViewById<TextView>(Resource.Id.text1).Text = GetDevice(row).Data[column + 1];
            return convertView;
        }

        private View GetBody(int row, int column, View convertView, ViewGroup parent)
        {
            convertView ??= activity.LayoutInflater.Inflate(Resource.Layout.item_table, parent, false);

            //convertView.setBackgroundResource(row % 2 == 0 ? R.drawable.bg_table_color1 : R.drawable.bg_table_color2);
            convertView.FindViewById<TextView>(Resource.Id.text1).Text = GetDevice(row).Data[column + 1];
            return convertView;
        }

        private View GetFamilyView(int row, int column, View convertView, ViewGroup parent)
        {
            convertView ??= activity.LayoutInflater.Inflate(Resource.Layout.item_table_family, parent, false);

            // todo: think about section headers "getFamily(row).name"
            var str = column == -1 ? "Section header" : string.Empty;

            convertView.FindViewById<TextView>(Resource.Id.text1).Text = str;
            return convertView;
        }

        private Nexus GetDevice(int row)
        {
            int family = 0;
            while (row >= 0)
            {
                row -= familys[family].size() + 1;
                family++;
            }

            family--;
            return familys[family].get(row + familys[family].size());
        }
    }
}