using System.Collections.Generic;
using System.Linq;
using Examine;
using Examine.Facets;

namespace Our.Umbraco.Extensions.Facets
{
    public static class SearchResultExtensions
    {
        /// <summary>
        /// Get the values for a particular facet in the results
        /// </summary>
        public static IEnumerable<T> GetFacet<T>(this ISearchResults searchResults, string field)
        {
            var facetResults = searchResults.GetFacet(field);

            if (facetResults == null)
            {
                return Enumerable.Empty<T>();
            }

            return facetResults
                .Select(x => x.GetValue<T>())
                .Where(x => x != null);
        }

        /// <summary>
        /// Gets the hits and values for a particular facet in the results
        /// </summary>
        public static IDictionary<T, int> GetFacetHits<T>(this ISearchResults searchResults, string field)
        {
            var facetResults = searchResults.GetFacet(field);

            return facetResults
                .Where(x => x.GetValue<T>() != null)
                .ToDictionary(x => x.GetValue<T>(), x => x.Hits);
        }
    }
}