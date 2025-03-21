﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Maui9Issues;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        Window.AddFlags(WindowManagerFlags.Fullscreen);

        base.OnCreate(savedInstanceState);
    }
}
