using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Catalog
{
    public partial class SelectedAddOnModel : BaseNopEntityModel
    {
        public string ThumbImageUrl { get; set; }
        public int SlotId { get; set; }
    }
}