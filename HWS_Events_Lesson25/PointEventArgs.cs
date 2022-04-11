namespace HWS_Events_Lesson25
{
    public class PointEventArgs : EventArgs
    {
        public int Points { get; set; }

        public PointEventArgs(int points)
        {
            Points = points;
        }
    }
}