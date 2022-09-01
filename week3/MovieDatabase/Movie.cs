namespace MovieDatabase
{
    public class Movie
    {
        // class members
        private string Title;
        private string Category;

        // default constructor
        public Movie(string _Title, string _Category)
        {
            Title = _Title;
            Category = _Category;
        }

        // return title
        public string GetTitle() => Title;
        // return category
        public string GetCategory() => Category;
        // default string to print when printing object
        public override string ToString() => $"{Title} ({Category})";
    }
}
