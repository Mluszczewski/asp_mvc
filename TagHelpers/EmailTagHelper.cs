using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_dot_net_Mluszczewski.TagHelpers
{
    [HtmlTargetElement("email")] 
    public class CustomTagHelper : TagHelper
    {
        private const string EmailDomain = "o2.pl";

        public string MailTo { get; set; }
        public string MailDesc { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address);
            output.Content.SetContent(MailDesc);
        }
    }
}  
