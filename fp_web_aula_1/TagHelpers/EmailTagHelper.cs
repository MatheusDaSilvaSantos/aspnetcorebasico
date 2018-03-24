using Microsoft.AspNetCore.Razor.TagHelpers;

namespace fp_web_aula_1.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string emailDomain = "fiap.com.br";
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var endereco = $"{MailTo}@{emailDomain}";

            output.Attributes.SetAttribute("href", $"mailto:{endereco}");
            output.Content.SetContent(endereco);
        }
    }
}
