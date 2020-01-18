using System;
using tech_dot_net_Mluszczewski.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace tech_dot_net_Mluszczewski.TagHelpers{
    public class WebsiteInformationTagHelper : TagHelper{
        public WebsiteContext Info {get; set;}

        public override void Process(TagHelperContext context, TagHelperOutput output){
            output.TagName = "section";
            output.Content.SetHtmlContent(
                $@"<ul><li><strong>Version:</strong> {Info.Version}</li>
                <li><strong>Copyright Year:</strong> {Info.CopyrightYear}</li>
                <li><strong>Approved:</strong> {Info.Approved}</li>");
                output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}