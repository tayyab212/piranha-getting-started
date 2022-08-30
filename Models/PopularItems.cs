using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace piranha_getting_started.Models
{
    [PageType(Title = "Popular Items")]
    public class PopularItems : Page<PopularItems>
    {
        [Region(Title = "Categories")]
        public IList<NumberField> PopularCategories { get; set; }

        [Region(Title = "Hot Articles")]
        public IList<NumberField> HotArticles { get; set; }

        [Region(Title = "Hot Spare parts")]
        public IList<NumberField> SpareParts { get; set; }
    }
}
