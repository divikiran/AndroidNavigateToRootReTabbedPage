using System;
using Xamarin.Forms;

namespace DivTestTabbed
{
	public class HomePage : TabbedPage
	{
		public HomePage()
		{
			Children.Add(new NavigationPage(new TabAPage() { Title = "A" }));
			Children.Add(new NavigationPage(new TabBPage() { Title = "B" }));
			Children.Add(new NavigationPage(new TabCPage() { Title = "C" }));
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			var navigationPage = this.CurrentPage as NavigationPage;

			if (navigationPage != null)
			{
				var currentPage = navigationPage.CurrentPage as TabPageAA;
				if (currentPage != null)
				{
					navigationPage.PopToRootAsync();
				}
			}
		}
	}
}
