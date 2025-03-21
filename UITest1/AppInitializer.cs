using System;
using System.IO;
using System.Runtime.InteropServices;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}