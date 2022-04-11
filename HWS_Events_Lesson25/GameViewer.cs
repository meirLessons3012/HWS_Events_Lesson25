using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Events_Lesson25
{
    internal class GameViewer
    {

        public void GoodSpaceShipHpChangedEventHandler(object sender, PointEventArgs pointEventArgs)
        {
            Console.WriteLine($"your points: {pointEventArgs.Points}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs locationEventArgs)
        {
            Console.WriteLine($"new location: x: {locationEventArgs.X}. y: {locationEventArgs.Y}.");
        }
    }

    internal class NewGameViewer
    {

        public void GoodSpaceShipHpChangedEventHandler(object sender, PointEventArgs pointEventArgs)
        {
            Console.WriteLine($"your points: {pointEventArgs.Points}!!!!!");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object sender, LocationEventArgs locationEventArgs)
        {
            Console.WriteLine($"new location: x: {locationEventArgs.X}. y: {locationEventArgs.Y}!!!!");
        }
    }
}
