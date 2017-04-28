using System;
using Xamarin.Forms;

namespace DivTestTabbed
{
	public class TabCPage : ContentPage
	{
		Label label = new Label() { Text = "Page C" };
		public TabCPage()
		{
			label.HorizontalOptions = LayoutOptions.Center;
			label.VerticalOptions = LayoutOptions.Center;
			Title = "Tab C";
			Content = label;
		}
	}
}
