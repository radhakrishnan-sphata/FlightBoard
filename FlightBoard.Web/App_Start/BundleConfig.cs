// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.BundleConfig
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System.Web.Optimization;

namespace FlightBoard.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(((Bundle)new ScriptBundle("~/bundles/jquery")).Include("~/Scripts/jquery-{version}.js", new IItemTransform[0]));
            bundles.Add(((Bundle)new ScriptBundle("~/bundles/jqueryval")).Include("~/Scripts/jquery.validate*", new IItemTransform[0]));
            bundles.Add(((Bundle)new ScriptBundle("~/bundles/jqueryval")).Include("~/Scripts/jquery.nicescroll.min.js*", new IItemTransform[0]));
            bundles.Add(((Bundle)new StyleBundle("~/bundles/inputmask")).Include(new string[4]
      {
        "~/Scripts/jquery.inputmask/jquery.inputmask.js",
        "~/Scripts/jquery.inputmask/jquery.inputmask.extensions.js",
        "~/Scripts/jquery.inputmask/jquery.inputmask.numeric.extensions.js",
        "~/Scripts/jquery.inputmask/jquery.inputmask.date.extensions.js"
      }));
            bundles.Add(((Bundle)new ScriptBundle("~/bundles/modernizr")).Include("~/Scripts/modernizr-*", new IItemTransform[0]));
            bundles.Add(((Bundle)new ScriptBundle("~/bundles/bootstrap")).Include(new string[2]
      {
        "~/Scripts/bootstrap.js",
        "~/Scripts/respond.js"
      }));
            bundles.Add(((Bundle)new StyleBundle("~/Content/css")).Include(new string[2]
      {
        "~/Content/bootstrap.css",
        "~/Content/site.css"
      }));
        }
    }
}
