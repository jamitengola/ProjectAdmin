using System.Web;
using System.Web.Optimization;

namespace ProjectAdmin
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/js/jquery-3.2.1.js",
                "~/js/jquery.appear.js",
                "~/js/jquery.mousewheel.js",
                "~/js/perfect-scrollbar.js",
                "~/js/jquery.matchHeight.js",
                "~/js/svgxuse.js",
                "~/js/imagesloaded.pkgd.js",
                "~/js/Headroom.js",
                "~/js/velocity.js",
                "~/js/ScrollMagic.js",
                "~/js/jquery.waypoints.js",
                "~/js/jquery.countTo.js",
                "~/js/popper.min.js",
                "~/js/material.min.js",
                "~/js/bootstrap-select.js",
                "~/js/smooth-scroll.js",
                "~/js/selectize.js",
                "~/js/swiper.jquery.js",
                "~/js/moment.js",
                "~/js/daterangepicker.js",
                "~/js/simplecalendar.js",
                "~/js/fullcalendar.js",
                "~/js/isotope.pkgd.js",
                "~/js/ajax-pagination.js",
                "~/js/Chart.js",
                "~/js/chartjs-plugin-deferred.js",
                "~/js/circle-progress.js",
                "~/js/loader.js",
                "~/js/run-chart.js",
                "~/js/jquery.magnific-popup.js",
                "~/js/jquery.gifplayer.js",
                "~/js/mediaelement-and-player.js",
                "~/js/mediaelement-playlist-plugin.min.js",
                "~/js/base-init.js",
                "~/fonts/fontawesome-all.js",
                "~/Bootstrap/dist/js/bootstrap.bundle.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Bootstrap/dist/css/bootstrap-reboot.css",
                "~/Bootstrap/dist/css/bootstrap.css",
                "~/Bootstrap/dist/css/bootstrap-grid.css",
                "~/css/main.min.css",
                "~/css/fonts.min.css"
                ));
        }
    }
}
