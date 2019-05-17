using System.Collections.Generic;

namespace ConstructionLine.CodingChallenge
{
    public class SearchEngine
    {
        private readonly List<Shirt> _shirts;
        private readonly List<Size> _sizes;
        private readonly List<Color> _colors;

        public SearchEngine(List<Shirt> shirts, List<Size> sizes, List<Color> colors)
        {
            _shirts = shirts;
            _sizes = sizes;
            _colors = colors;

            // TODO: data preparation and initialisation of additional data structures to improve performance goes here.
        }


        public SearchResults Search(SearchOptions options)
        {
            // TODO: search logic goes here.

            return new SearchResults
            {
            };
        }
    }
}