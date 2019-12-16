using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitecoreDev.Data.Items;

namespace SitecoreDev.Feature.Media.Repositories
{
    public interface IMediaRepository
    {
        Item GetItem(string contentGuid);
    }
}

