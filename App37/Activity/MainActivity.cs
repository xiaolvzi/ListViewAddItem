using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using App37.Adapter;
using System.Collections.Generic;

namespace App37
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView mListView;
        List<string> mList;
        Button mButton;
        MyAdapter mMyAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            initData();
            initView();
            initListener();
        }

        private void initListener()
        {
            mButton.Click += MButton_Click;
        }

        private void MButton_Click(object sender, EventArgs e)
        {
            List<string> list=getNewContacts();
            mMyAdapter.addItem(list);
        }

        private List<string> getNewContacts()
        {
            List<string> list = new List<string>();
            list.Add("Java");
            list.Add("Java");
            list.Add("Java");
            list.Add("C#");
            list.Add("C#");
            list.Add("C#");

            return list;
        }

        private void initData()
        {
           
            mList = new List<string>();
            for (int i = 0; i < 40; i++) {
                mList.Add(i + "");
            }
            mMyAdapter = new MyAdapter(this, mList);
        }

        private void initView()
        {
            mListView = FindViewById<ListView>(Resource.Id.lv);
            mListView.Adapter = mMyAdapter;
            mButton = FindViewById<Button>(Resource.Id.bt);
        }
    }
}

