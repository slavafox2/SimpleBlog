﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css")
                );

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css"));

            bundles.Add(new StyleBundle("~/admin/scripts")
                .Include("~/scripts/popper.min.js")
                .Include("~/scripts/jquery-3.1.1.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/Areas/Admin/Scripts/Forms.js")
                );

            bundles.Add(new StyleBundle("~/admin/post/scripts")
                .Include("~/areas/admin/scripts/posteditor.js")
                );

            bundles.Add(new StyleBundle("~/scripts")
                .Include("~/scripts/popper.min.js")
                .Include("~/scripts/jquery.timeago.js")
                .Include("~/scripts/jquery-3.1.1.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/frontend.js")
                );
        }
    }
}