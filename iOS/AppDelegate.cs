﻿using System;
using System.Collections.Generic;
using System.Linq;
using ChewsYes.iOS.InputPrompt;
using ChewsYes;
using Foundation;
using UIKit;
using FFImageLoading.Forms;
using FFImageLoading.Forms.Touch;

namespace ChewsYes.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsMaps.Init();
            //Xamarin.Forms.DependencyService.Register<Prompt>();
            CachedImageRenderer.Init();
            ZXing.Net.Mobile.Forms.iOS.Platform.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
