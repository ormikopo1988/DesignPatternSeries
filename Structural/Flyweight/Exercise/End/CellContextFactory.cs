using System.Collections.Generic;

namespace Flyweight.Exercise.End
{
    public class CellContextFactory
    {
        private readonly Dictionary<int, CellContext> contexts = new Dictionary<int, CellContext>();

        public CellContext Create(string fontFamily, int fontSize, bool isBold)
        {
            // Generate a unique key for the combination of fontFamily, fontSize and isBold attributes.
            var hash = fontFamily.GetHashCode() + fontSize.GetHashCode() + isBold.GetHashCode();

            if (!contexts.ContainsKey(hash))
                contexts.Add(hash, new CellContext(fontFamily, fontSize, isBold));

            return contexts[hash];
        }
    }
}
