using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.TagHelpers
{
    [HtmlTargetElement("message")]
    public class MessageTagHelper : TagHelper
    {
        [HtmlAttributeName("class")]
        public string Type { get; set; } = "info";

        [HtmlAttributeName("text")]
        public string Content { get; set; } = string.Empty;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();
            string newContent = this.Content + childContent.GetContent();

            string template = $@"<div class='alert alert-{Type} alert-dismissible fade show'>
                                    {newContent}
                                    <button type='button' class='close' data-dismiss='alert'>
                                        <span aria-hidden='true'>&times;</span>
                                    </button>
                                </div>";

            output.TagName = string.Empty;
            output.Content.SetHtmlContent(template);
        }
    }
}
