using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Examine;
using Examine.Facets;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Composing;

namespace Our.Umbraco.Extensions.Facets
{
    public static class SearchResultExtensions
    {
        /// <summary>
        /// Get the values for a particular facet in the results
        /// </summary>
        public static IEnumerable<T> GetFacet<T>(this ISearchResults searchResults, string field)
        {
            var facet = searchResults.GetFacet(field);

            if (facet == null)
            {
                return Enumerable.Empty<T>();
            }

            return facet
                .Select(x => ConvertValue<T>(x.Value))
                .Where(x => x != null);
        }

        private static T ConvertValue<T>(object value)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter.CanConvertFrom(value.GetType()) == true)
            {
                return (T)converter.ConvertFrom(value);
            }

            if (typeof(IPublishedContent).IsAssignableFrom(typeof(T)) == true)
            {
                return (T)Current.Mapper.Map<IPublishedContent>(value);
            }

            return Current.Mapper.Map<T>(value);
        }
    }
}