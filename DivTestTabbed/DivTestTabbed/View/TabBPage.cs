using System;
using Xamarin.Forms;

namespace DivTestTabbed
{
	public class TabBPage : ContentPage
	{
		Label label = new Label() { Text = "Page B" };
		public TabBPage()
		{
			label.HorizontalOptions = LayoutOptions.Center;
			label.VerticalOptions = LayoutOptions.Center;
			Title = "Tab B";
			Content = label;
		}
	}
}
