using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSiteWithBlog.Services.Contracts
{
    public interface ITagsService
    {
        int CreateTag(string name);
    }
}
