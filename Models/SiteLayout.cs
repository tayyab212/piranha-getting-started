using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Blocks;
using Piranha.Extend.Fields;
using Piranha.Models;


namespace piranha_getting_started.Models
{
    [PageType(Title = "Site Layout")]
    public class SiteLayout : Page<SiteLayout>
    {
        [Region(Title = "HeaderArea")]
        public SiteHeader Header { get; set; }

        [Region(Title = "FooterArea")]
        public Footer FooterContent { get; set; }
    }


    public class SiteHeader
    {
        [Field(Title = "TopBanner")]
        public HtmlField TopBanner { get; set; }

        [Field(Title = "MainHtml")]
        public HtmlField MainHtml { get; set; }

        [Field(Title = "LeftMenu")]
        public HtmlField LeftMenu { get; set; }

        [Field(Title = "TopCountryDropdown")]
        public HtmlField TopCountryDropdown { get; set; }
    }

    public class Footer
    {
        [Field(Title = "Footer text")]
        public HtmlField Text { get; set; }
    }
}
