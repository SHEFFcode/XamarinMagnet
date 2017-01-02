using System;
using DeviceMotion.Plugin;
using DeviceMotion.Plugin.Abstractions;
using UIKit;

namespace MagnetFinder.iOS
{
    public partial class ViewController : UIViewController
    {
        double maxX = 0;
        double maxY = 0;
        double maxZ = 0;

        double minX = 0;
        double minY = 0;
        double minZ = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();



            CrossDeviceMotion.Current.Start(MotionSensorType.Magnetometer);
            CrossDeviceMotion.Current.SensorValueChanged += (sendor, arg) =>
            {
                switch (arg.SensorType)
                {
                    case MotionSensorType.Magnetometer:
                        var values = (MotionVector)arg.Value;
                        LimitsTestFunction(values);

                        progressX.Progress = (float)values.X / 300;
                        progressY.Progress = (float)values.Y / 200;
                        progressZ.Progress = (float)values.Z / -1100;
                        break;
                    default:
                        break;
                        
                }
            };

        }

        void LimitsTestFunction(MotionVector vector)
        {
            var xVal = vector.X;
            var yVal = vector.Y;
            var zVal = vector.Z;

            if (xVal > maxX)
            {
                maxX = xVal;
                Console.WriteLine($"Max X is {maxX}.");
            }

            if (yVal > maxY)
            {
                maxY = yVal;
                Console.WriteLine($"Max X is {yVal}.");
            }

            if (zVal > maxZ)
            {
                maxZ = zVal;
                Console.WriteLine($"Max X is {zVal}.");
            }


            if (xVal > minX)
            {
                minX = xVal;
                Console.WriteLine($"Min X is {minX}.");
            }

            if (yVal > minY)
            {
                minY = yVal;
                Console.WriteLine($"Min X is {yVal}.");
            }

            if (zVal > minZ)
            {
                minZ = zVal;
                Console.WriteLine($"Min X is {zVal}.");
            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
