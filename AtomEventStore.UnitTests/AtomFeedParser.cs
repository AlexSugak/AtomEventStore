using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grean.AtomEventStore.UnitTests
{
    public class AtomFeedParser<T> where T : IContentSerializer
    {
        private readonly T serializer;
        private readonly IIriParser iriParser;

        public AtomFeedParser(T serializer, IIriParser iriParser)
        {
            this.serializer = serializer;
            this.iriParser = iriParser;
        }

        public AtomFeed Parse(string xml)
        {
            return AtomFeed.Parse(xml, this.serializer, this.iriParser);
        }
    }
}
