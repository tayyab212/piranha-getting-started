using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace piranha_getting_started.Models
{
    [SiteType(Title = "Hansen site")]
    public class HansenRacingSite : SiteContent<HansenRacingSite>
    {
        [Region(Title = "General", Display = RegionDisplayMode.Content)]
        public SiteSettings Settings { get; set; }

    }

    public class SiteSettings
    {
        [Field(Title = "SiteId")]
        public NumberField SiteId { get; set; }

        [Field(Title = "LayoutName")]
        public NumberField LayoutName { get; set; }

        [Field(Title = "HomePage")]
        public NumberField HomePageName { get; set; }
    }
}
