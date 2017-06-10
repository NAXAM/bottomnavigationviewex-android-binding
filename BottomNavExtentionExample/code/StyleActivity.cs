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
using Com.Ittianyu.Bottomnavigationviewex;

namespace BottomNavExtentionExample
{
    [Activity(Label = "StyleActivity", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class StyleActivity : Activity
    {
        BottomNavigationViewEx bnve_normal;
        BottomNavigationViewEx bnve_no_animation;
        BottomNavigationViewEx bnve_no_shifting_mode;
        BottomNavigationViewEx bnve_no_item_shifting_mode;
        BottomNavigationViewEx bnve_no_text;
        BottomNavigationViewEx bnve_no_icon;
        BottomNavigationViewEx bnve_no_animation_shifting_mode;
        BottomNavigationViewEx bnve_no_animation_item_shifting_mode;
        BottomNavigationViewEx bnve_no_animation_shifting_mode_item_shifting_mode;
        BottomNavigationViewEx bnve_no_shifting_mode_item_shifting_mode_text;
        BottomNavigationViewEx bnve_no_animation_shifting_mode_item_shifting_mode_text;
        BottomNavigationViewEx bnve_no_shifting_mode_item_shifting_mode_and_icon;
        BottomNavigationViewEx bnve_no_item_shifting_mode_icon;
        BottomNavigationViewEx bnve_no_animation_shifting_mode_item_shifting_mode_icon;
        BottomNavigationViewEx bnve_with_padding;
        BottomNavigationViewEx bnve_center_icon_only;
        BottomNavigationViewEx bnve_smaller_text;
        BottomNavigationViewEx bnve_bigger_icon;
        BottomNavigationViewEx bnve_custom_typeface;
        BottomNavigationViewEx bnve_icon_selector;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_style);

            initInterface();
        }

        public void initInterface()
        {
            bnve_normal = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_normal);
            bnve_no_animation = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation);
            bnve_no_shifting_mode = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_shifting_mode);
            bnve_no_item_shifting_mode = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_item_shifting_mode);
            bnve_no_text = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_text);
            bnve_no_icon = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_icon);
            bnve_no_animation_shifting_mode = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation_shifting_mode);
            bnve_no_animation_item_shifting_mode = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation_item_shifting_mode);
            bnve_no_animation_shifting_mode_item_shifting_mode = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation_shifting_mode_item_shifting_mode);
            bnve_no_shifting_mode_item_shifting_mode_text = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_shifting_mode_item_shifting_mode_text);
            bnve_no_animation_shifting_mode_item_shifting_mode_text = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation_shifting_mode_item_shifting_mode_text);
            bnve_no_shifting_mode_item_shifting_mode_and_icon = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_shifting_mode_item_shifting_mode_and_icon);
            bnve_no_item_shifting_mode_icon = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_item_shifting_mode_icon);
            bnve_no_animation_shifting_mode_item_shifting_mode_icon = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_no_animation_shifting_mode_item_shifting_mode_icon);
            bnve_with_padding = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_with_padding);
            bnve_center_icon_only = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_center_icon_only);
            bnve_smaller_text = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_smaller_text);
            bnve_bigger_icon = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_bigger_icon);
            bnve_custom_typeface = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_custom_typeface);
            bnve_icon_selector = (BottomNavigationViewEx)FindViewById(Resource.Id.bnve_icon_selector);

            //no animation
            bnve_no_animation.EnableAnimation(false);

            //no shifting mode
            bnve_no_shifting_mode.EnableShiftingMode(false);

            //no item shifting mode
            bnve_no_item_shifting_mode.EnableItemShiftingMode(false);

            //bnve no text
            bnve_no_text.SetTextVisibility(false);

            //bnve no icon
            bnve_no_icon.SetIconVisibility(false);

            //bnve no animation shifting mode
            bnve_no_animation_shifting_mode.EnableAnimation(false);
            bnve_no_animation_shifting_mode.EnableShiftingMode(false);

            //bnve_no_animation_item_shifting_mode
            bnve_no_animation_shifting_mode_item_shifting_mode.EnableAnimation(false);
            bnve_no_animation_shifting_mode_item_shifting_mode.EnableItemShiftingMode(false);

            //bnve_no_animation_shifting_mode_item_shifting_mode
            bnve_no_animation_shifting_mode_item_shifting_mode.EnableAnimation(false);
            bnve_no_animation_shifting_mode_item_shifting_mode.EnableShiftingMode(false);
            bnve_no_animation_shifting_mode_item_shifting_mode.EnableItemShiftingMode(false);

            //bnve_no_shifting_mode_item_shifting_mode_text
            bnve_no_shifting_mode_item_shifting_mode_text.EnableItemShiftingMode(false);
            bnve_no_shifting_mode_item_shifting_mode_text.EnableShiftingMode(false);
            bnve_no_shifting_mode_item_shifting_mode_text.SetTextVisibility(false);

            //bnve_no_animation_shifting_mode_item_shifting_mode_text
            bnve_no_animation_shifting_mode_item_shifting_mode_text.EnableAnimation(false);
            bnve_no_animation_shifting_mode_item_shifting_mode_text.EnableShiftingMode(false);
            bnve_no_animation_shifting_mode_item_shifting_mode_text.EnableItemShiftingMode(false);

            //bnve_no_shifting_mode_item_shifting_mode_and_icon
            bnve_no_shifting_mode_item_shifting_mode_and_icon.EnableItemShiftingMode(false);
            bnve_no_shifting_mode_item_shifting_mode_and_icon.EnableShiftingMode(false);
            bnve_no_shifting_mode_item_shifting_mode_and_icon.SetIconVisibility(false);

            //bnve_no_item_shifting_mode_icon
            bnve_no_item_shifting_mode_icon.EnableItemShiftingMode(false);
            bnve_no_item_shifting_mode_icon.SetIconVisibility(false);

            //bnve_no_animation_shifting_mode_item_shifting_mode_icon
            bnve_no_animation_shifting_mode_item_shifting_mode_icon.EnableAnimation(false);
            bnve_no_animation_shifting_mode_item_shifting_mode_icon.EnableItemShiftingMode(false);
            bnve_no_animation_shifting_mode_item_shifting_mode_icon.EnableShiftingMode(false);
            bnve_no_animation_shifting_mode_item_shifting_mode_icon.SetIconVisibility(false);

            //bnve_with_padding
            bnve_with_padding.SetPadding(8,8,8,8);

            //bnve_center_icon_only

            //bnve_smaller_text
            bnve_smaller_text.SetTextSize(10);

            //bnve_bigger_icon
            bnve_bigger_icon.SetIconSize(48, 48);
            bnve_bigger_icon.SetTextVisibility(false);

            //bnve_custom_typeface
            Android.Graphics.Typeface typeface = Android.Graphics.Typeface.CreateFromAsset(this.Assets, "fonts/JOKERMAN.TTF");
            bnve_custom_typeface.SetTypeface(typeface);

            //bnve_icon_selector

        }
    }
}