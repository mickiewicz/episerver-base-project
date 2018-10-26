using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverBase.Models.Pages
{
    [ContentType(
        GUID = "5f5a391f-6b6a-4659-8e40-67a1860c2e52",
        GroupName = Global.GroupNames.Specialized)]
    public class StartPage : SitePageData
    {
        [Display(
            Name = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }
    }
}
