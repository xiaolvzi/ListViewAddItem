using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace App37.Adapter
{
   public class MyAdapter : BaseAdapter
    {
        Context mContext;
        List<string> mList;
        LayoutInflater mInflater;
        public MyAdapter(Context context, List<string> list) {
            this.mContext = context;
            this.mList = list;
            mInflater = (LayoutInflater)mContext.GetSystemService(Context.LayoutInflaterService);
        }
        public override int Count => mList.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return mList[position];
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = null;
            ViewHolder viewHolder = null;
            if (convertView == null)
            {
               
                view = mInflater.Inflate(Resource.Layout.item_layout, parent, false);
                viewHolder = new ViewHolder();
                viewHolder.mtv = (TextView)view.FindViewById(Resource.Id.item_tv);
                view.Tag=viewHolder;
            

            } else {
                view = convertView;
                viewHolder = (ViewHolder)view.Tag;
            }


            viewHolder.mtv.Text = mList[position];
 
            return view;
        }

        public void addItem(List<string> list)
        {
            mList.AddRange(list);
            NotifyDataSetChanged();
        }
    }

    public class ViewHolder:Java.Lang.Object {
        public TextView mtv;
        
    }
}