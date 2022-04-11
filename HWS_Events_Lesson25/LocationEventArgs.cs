namespace HWS_Events_Lesson25
{
    public class LocationEventArgs : EventArgs
    {
        public LocationEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}