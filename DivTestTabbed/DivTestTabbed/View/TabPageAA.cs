using System;

using Xamarin.Forms;

namespace DivTestTabbed
{
	public class TabPageAA : ContentPage
	{
		public TabPageAA()
		{
			//NavigationPage.SetHasNavigationBar(this, false);
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

