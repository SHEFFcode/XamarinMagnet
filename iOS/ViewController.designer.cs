// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MagnetFinder.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progressX { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progressY { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progressZ { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (progressX != null) {
                progressX.Dispose ();
                progressX = null;
            }

            if (progressY != null) {
                progressY.Dispose ();
                progressY = null;
            }

            if (progressZ != null) {
                progressZ.Dispose ();
                progressZ = null;
            }
        }
    }
}