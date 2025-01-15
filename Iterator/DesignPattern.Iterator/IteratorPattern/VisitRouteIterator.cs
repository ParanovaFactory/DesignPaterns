namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitorRoute>
    {
        private VisitRouteMover _mover;

        public VisitRouteIterator(VisitRouteMover mover)
        {
            _mover = mover;
        }

        private int currentIndex = 0;

        public VisitorRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < _mover.VisitRouteCount)
            {
                CurrentItem = _mover.visitorRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
