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

using Android.Support.V4;
using Android.Support.V7;
using Com.Ittianyu.Bottomnavigationviewex;

namespace BottomNavExtentionExample
{
    [Activity(Label = "WithViewPagerActivity",Theme = "@style/AppTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class WithViewPagerActivity : Activity
    {

        BottomNavigationViewEx bnve;
        List<Fragment> fragment;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_with_view_pager);

            InitInterface();
        }

        public void InitInterface()
        {
            bnve = (BottomNavigationViewEx)FindViewById(Resource.Id.activity_with_view_pager);
            bnve.EnableAnimation(false);
            bnve.EnableItemShiftingMode(false);
            //bnve.Click += Bnve_Click;
        }

        private void Bnve_Click(object sender, EventArgs e)
        {
            int index = bnve.SelectedItemId;
            int x = 0;
        }

        public void InitData()
        {
            fragment = new List<Fragment>(3);

            Fragment musicfragment = new Fragment();
            Bundle bundle1 = new Bundle();
            bundle1.PutString("title","Music");
            musicfragment.Arguments = bundle1;

            Fragment backupfragment = new Fragment();
            Bundle bundle2 = new Bundle();
            bundle2.PutString("title", "Backup");
            backupfragment.Arguments = bundle2;

            Fragment friendsfragment = new Fragment();
            Bundle bundle3 = new Bundle();
            bundle3.PutString("title", "Friends");
            friendsfragment.Arguments = bundle3;

            fragment.Add(musicfragment);
            fragment.Add(backupfragment);
            fragment.Add(friendsfragment);

            
        }
        public void InitEvent()
        {

        }
    }
}