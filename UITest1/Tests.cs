using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class Tests
    {
        [Test]
        public void MAUI8()
        {
            var apkPath = @"..\..\..\Maui8App\bin\Release\net8.0-android\android-arm64\publish\com.companyname.maui8app-Signed.apk";
            var app = ConfigureApp
                .Android
                .ApkFile(apkPath)
                .StartApp();
        }

        [Test]
        public void MAUI9()
        {
            var apkPath = @"..\..\..\Maui9App\bin\Release\net9.0-android\android-arm64\publish\com.companyname.maui9app-Signed.apk";
            var app = ConfigureApp
                .Android
                .ApkFile(apkPath)
                .StartApp();
        }
    }
}
