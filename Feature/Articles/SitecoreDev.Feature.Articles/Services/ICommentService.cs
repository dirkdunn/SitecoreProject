using SitecoreDev.Feature.Articles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Feature.Articles.Services
{
    public interface ICommentService
    {
        IEnumerable<IComment> GetComments(string blogId);
    }
}