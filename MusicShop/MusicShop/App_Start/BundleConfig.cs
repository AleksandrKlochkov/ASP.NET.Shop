using System.Web;
using System.Web.Optimization;

namespace MusicShop
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/pluginsjs").Include(
                        "~/Content/Scripts/plugins/accordions-menu/accordionmenu.js", "~/Content/Scripts/function/function.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/Site.css"));

            bundles.Add(new StyleBundle("~/Fonts/fontssite").Include(
                    "~/Content/Fonts/Roboto/roboto-font.css",
                    "~/Content/Fonts/font-awesome/css/font-awesome.min.css"));
        }
    }
}
