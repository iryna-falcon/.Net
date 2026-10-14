namespace lab_5.Toys
{
    public class ToyNameComparer : IComparer<Toy>
    {
        public int Compare(Toy? x, Toy? y)
        {
            if (x == null || y == null) return 0;
            return string.Compare(x.Title, y.Title, System.StringComparison.OrdinalIgnoreCase);
        }
    }
}