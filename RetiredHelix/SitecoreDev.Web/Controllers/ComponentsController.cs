using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace SitecoreDev.Web.Controllers
{
    public class ComponentsController : SitecoreController
    {
        // Grabs reference to the database, then passes the actions rendering ID to the GetItem method
        // to get the sitecore item.
        public ViewResult HeroSlider()
        {
            Item contentItem = null;
            var database = Context.Database;

            if (database != null)
            {
                if (!String.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
                {
                    contentItem = database.GetItem(
                        new Sitecore.Data.ID(RenderingContext.Current.Rendering.DataSource)
                    );
                }
            }

            return View(contentItem);
        }
    }
}