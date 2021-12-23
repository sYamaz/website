using System;
using Skclusive.Core.Component;
using Skclusive.Material.Theme;
namespace website.Shared
{
	public class DocsViewStyleProvider: StyleTypeProvider
	{
		public DocsViewStyleProvider():base(priority:default, typeof(AppStyle))
		{
		}
	}

    public class DocsViewStyleProducer : IStyleProducer
    {
        public IDictionary<string, string> Variables(ThemeValue theme)
        {
            var isDatk = theme.IsDark();
            return new Dictionary<string, string>
            {
                [ "--theme-docs-palette-border-color"] = (isDatk ? "rgba(255, 255, 255, 0.12)" : "rgba(0,0,0, 0.12)"),
            };
        }
    }
}

