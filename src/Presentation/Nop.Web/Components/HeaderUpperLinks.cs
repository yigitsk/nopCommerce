using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class HeaderUpperLinksViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public HeaderUpperLinksViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareHeaderLinksModel();
            return View(model);
        }
    }
}
