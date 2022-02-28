using System.ComponentModel;
using Examine.Facets;
using Umbraco.Core.Composing;
using Umbraco.Core.Models.PublishedContent;

namespace Our.Umbraco.Extensions.Facets
{
    public static class FacetExtensions
    {
        /// <summary>
        /// Get the value for a particular facet result
        /// </summary>
        public static T GetValue<T>(this IFacetValue facet)
        {
            return ConvertValue<T>(facet.Value);
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