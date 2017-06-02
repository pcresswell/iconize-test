using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace iconizetest.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.MaterialModule());

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
