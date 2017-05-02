using Android.App;
using Android.Widget;
using Android.OS;
using Com.Ittianyu.Bottomnavigationviewex;
using Android.Support.Design.Internal;
using static Android.Views.View;
using System.Collections.Generic;

namespace BottomNavExtentionExample
{
    [Activity(Label = "BottomNavExtentionExample", Theme = "@style/MainTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btDifferentStyle;
        Button btViewPager;
        Button btSetUpViewPager;
        Button btBadgeView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            InitInterface();
        }

        public void InitInterface()
        {
            btDifferentStyle = (Button)FindViewById(Resource.Id.btn_style);
            btViewPager = (Button)FindViewById(Resource.Id.btn_with_view_pager);
            btSetUpViewPager = (Button)FindViewById(Resource.Id.btn_setup_with_view_pager);
            btBadgeView = (Button)FindViewById(Resource.Id.btn_badge_view);

            btDifferentStyle.Click += BtDifferentStyle_Click;
            btViewPager.Click += BtViewPager_Click;
            btSetUpViewPager.Click += BtSetUpViewPager_Click;
            btBadgeView.Click += BtBadgeView_Click;
        }

        private void BtBadgeView_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Android.Content.Intent(this, typeof(Resources.code.BadgeViewActivity)));
        }

        private void BtSetUpViewPager_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Android.Content.Intent(this, typeof(Resources.code.SetupWithViewPagerActivity)));
        }

        private void BtViewPager_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Android.Content.Intent(this, typeof(Resources.code.WithViewPagerActivity)));
        }

        private void BtDifferentStyle_Click(object sender, System.EventArgs e)
        {
            StartActivity(new Android.Content.Intent(this, typeof(Resources.code.StyleActivity)));
        }
    }
}

