using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Allenliu.Badgeview;
using Android.Graphics;
using Com.Ittianyu.Bottomnavigationviewex;
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace BottomNavExtentionExample
{
    [Activity(Label = "Activity1", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class BadgeViewActivity : AppCompatActivity
    {
        BottomNavigationViewEx bnve;
        private BadgeView badgeView1;
        private BadgeView badgeView2;
        private BadgeView badgeView3;
        private BadgeView badgeView4;
        private BadgeView badgeView5;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_badge_view);

            InitInterface();
        }

        public void InitInterface()
        {
            bnve = FindViewById<BottomNavigationViewEx>(Resource.Id.bnve);
            // disable all animation
            bnve.EnableAnimation(false);
            bnve.EnableShiftingMode(false);
            bnve.EnableItemShiftingMode(false);


            bnve.Post(() =>
            {
                //add badgeview at second icon
                badgeView1 = AddBadgeViewAt(0, "20", BadgeView.ShapeOval);
                badgeView2 = AddBadgeViewAt(1, "99", BadgeView.ShapeOval);
                badgeView3 = AddBadgeViewAt(2, "20", BadgeView.ShapeOval);
                badgeView4 = AddBadgeViewAt(3, "2", BadgeView.ShapeOval);
                badgeView5 = AddBadgeViewAt(4, "2", BadgeView.ShapeOval);
            });
            
            bnve.NavigationItemReselected += Bnve_NavigationItemReselected;
        }

        private void Bnve_NavigationItemReselected(object sender, BottomNavigationView.NavigationItemReselectedEventArgs e)
        {
            int position = bnve.GetMenuItemPosition(e.Item);
            switch (position)
            {
                case 0: ToggleBadgeView(badgeView1);
                    break;
                case 1: ToggleBadgeView(badgeView2);
                    break;
                case 2: ToggleBadgeView(badgeView3);
                    break;
                case 3: ToggleBadgeView(badgeView4);
                    break;
                case 4: ToggleBadgeView(badgeView5);
                    break;
            }
        }


        private void ToggleBadgeView(BadgeView badgeView)
        {
            badgeView.Visibility = (badgeView.Visibility == ViewStates.Visible ? ViewStates.Invisible : ViewStates.Visible);
        }

        private BadgeView AddBadgeViewAt(int position, String text, int shape)
        {
            // get position
            ImageView icon = bnve.GetIconAt(position);
            int[] pos = new int[2];
            icon.GetLocationInWindow(pos);

            var actionBar = SupportActionBar;
            // action bar height
            int actionBarHeight = 0;
            if (actionBar != null)
            {
                actionBarHeight = actionBar.Height;
            }

            float x = (pos[0] + icon.MeasuredWidth * 0.7f);
            float y = (pos[1] - actionBarHeight - icon.MeasuredHeight * 1.25f);

            // calculate width
            int width = 16 + 4 * (text.Length - 1);
            int height = 16;

            BadgeView badgeView = BadgeFactory.Create(this)
                .SetTextColor(Color.White)
                .SetWidthAndHeight(width, height)
                .SetBadgeBackground(Color.Red)
                .SetTextSize(10)
                .SetBadgeGravity((int)(GravityFlags.Left | GravityFlags.Top))
                .SetBadgeCount(text)
                .SetShape(shape)
                .Bind(FindViewById(Resource.Id.rl_root));
            badgeView.SetX(x);
            badgeView.SetY(y);
            badgeView.Visibility = ViewStates.Visible;
            return badgeView;
        }
    }
}