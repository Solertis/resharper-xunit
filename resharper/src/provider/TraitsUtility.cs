using System.Collections.Generic;
using JetBrains.Util;
using Xunit;
using Xunit.Sdk;

namespace XunitContrib.Runner.ReSharper.UnitTestProvider
{
    // xunit provides MethodUtility.GetTraits, but doesn't give us anything for
    // classes. Also, it requires the trait name to be non-null or it throws.
    // That's fine if you're running tests, but no good if you're half way
    // through iterating available traits, 'cos you end up with nothing. So we'll
    // do it ourselves, with null checks
    public static class TraitsUtility
    {
        public static OneToSetMap<string, string> GetTraits(this ITypeInfo typeInfo)
        {
            var attributes = typeInfo.GetCustomAttributes(typeof(TraitAttribute));
            return GetTraitsFromAttributes(attributes);
        }

        public static OneToSetMap<string, string> GetTraits(this IMethodInfo methodInfo)
        {
            // We only need to get the traits of the method. When we update the element,
            // we merge in the traits of the parent element
            var attributes = methodInfo.GetCustomAttributes(typeof(TraitAttribute));
            return GetTraitsFromAttributes(attributes);
        }

        private static OneToSetMap<string, string> GetTraitsFromAttributes(IEnumerable<IAttributeInfo> attributes)
        {
            var traits = new OneToSetMap<string, string>();
            foreach (var attributeInfo in attributes)
            {
                var name = attributeInfo.GetPropertyValue<string>("Name");
                var value = attributeInfo.GetPropertyValue<string>("Value");
                if (name != null && value != null)
                    traits.Add(name, value);
            }

            return traits;
        }
    }
}