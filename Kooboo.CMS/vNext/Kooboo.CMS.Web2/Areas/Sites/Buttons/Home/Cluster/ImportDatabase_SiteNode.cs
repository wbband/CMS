﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kooboo.CMS.Web2.Areas.Sites.Buttons.Home.Cluster
{
    public class ImportDatabase_SiteNode : Kooboo.Common.Web.Button.IButtonPlugin
    {

        public System.Web.Mvc.ActionResult Execute(Kooboo.Common.Web.Button.ButtonPluginContext context)
        {
            throw new NotImplementedException();
        }

        public Kooboo.Common.Web.MvcRoute GetMvcRoute(System.Web.Mvc.ControllerContext controllerContext)
        {
            return new Kooboo.Common.Web.MvcRoute()
            {
                Area = "Sites",
                Controller = "Site",
                Action = "ImportRepository"
            };
        }

        public string GroupName
        {
            get { return null; }
        }

        public Type OptionModelType
        {
            get { throw new NotImplementedException(); }
        }

        public string DisplayText
        {
            get { return "Import database"; }
        }

        public IDictionary<string, object> HtmlAttributes(System.Web.Mvc.ControllerContext controllerContext)
        {
            return new Dictionary<string, object>();
        }

        public string IconClass
        {
            get { return null; }
        }

        public bool IsVisibleFor(object dataItem)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return "Import_Database"; }
        }

        public int Order
        {
            get { return 5; }
        }

        public IEnumerable<Kooboo.Common.Web.MvcRoute> ApplyTo
        {
            get { return new[] { Kooboo.CMS.SiteKernel.Extension.Site.SiteExtensionPoints.SiteCluster }; }
        }

        public string Position
        {
            get { return Kooboo.CMS.SiteKernel.Extension.Site.SiteExtensionPoints.SiteNodeButton; }
        }
    }
}