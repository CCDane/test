using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Helper
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine(string theme)
        {
            if (!string.IsNullOrEmpty(theme))
            {
                AreaViewLocationFormats = new[]
                {
                       //themes
                       "~/themes/"+theme+"/views/Areas/{2}/{1}/{0}.cshtml",
                      "~/themes/"+theme+"/Shared/{0}.cshtml",
                    "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{0}.cshtml"
    };
                AreaMasterLocationFormats = new[]
                {
                             //themes
              "~/themes/"+theme+"/views/Areas/{2}/{1}/{0}.cshtml",
              "~/themes/"+theme+"/views/Areas/{2}/Shared/{0}.cshtml",
              "~/themes/"+theme+"/views/Shared/{0}.cshtml",

        "~/Areas/{2}/Views/{1}/{0}.cshtml",
        "~/Areas/{2}/Views/Shared/{0}.cshtml"
    };
                AreaPartialViewLocationFormats = new[]
                {
                            //themes
         "~/themes/"+theme+"/views/Shared/{0}.cshtml",

        "~/Areas/{2}/Views/{1}/{0}.cshtml",
        "~/Areas/{2}/Views/Shared/{0}.cshtml"
    };

                ViewLocationFormats = new[]
                {
                            //themes
          "~/themes/"+theme+"/views/{1}/{0}.cshtml",

        "~/Views/{1}/{0}.cshtml",
        "~/Views/Shared/{0}.cshtml"
    };
                MasterLocationFormats = new[]
                {
                            //themes
         "~/themes/"+theme+"/views/Shared/{0}.cshtml",

        "~/Views/{1}/{0}.cshtml",
        "~/Views/Shared/{0}.cshtml"
    };
                PartialViewLocationFormats = new[]
                {
                            //themes
        "~/themes/"+theme+"/views/Shared/{0}.cshtml",

        "~/Views/{1}/{0}.cshtml",
        "~/Views/Shared/{0}.cshtml"
    };

                FileExtensions = new[] { "cshtml" };
            }

        }
    }

}