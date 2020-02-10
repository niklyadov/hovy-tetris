namespace TetrisBool
{
    public class Teewee : IFigure
    {
        private Point _point;
        private int rotation;
        private bool[,] _data = new bool[,]
        {
            {false, true},
            {true, true},
            {false, true},
        };
        
        public Teewee(Point point)
        {
            _point = point;
        }

        #region Fields

        public bool[,] Data
        {
            get => _data;
            set => _data = value;
        }
        
        public Point Position 
        {
            get => _point;
            set => _point = value;
        }

        public int Rotate
        {
            get => rotation; 
            set => rotation = value;
        }

        #endregion
        
    }
}