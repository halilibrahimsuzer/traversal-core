using System;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _SliderPartial:ViewComponent
	{
		public _SliderPartial()
		{
		}
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}