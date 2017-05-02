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

namespace BottomNavExtentionExample.Resources.code
{
    [Activity(Label = "SetupWithViewPagerActivity",Theme = "@style/AppTheme", MainLauncher = true, Icon = "@drawable/icon")]
    public class SetupWithViewPagerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frag_base);
        }
    }
}