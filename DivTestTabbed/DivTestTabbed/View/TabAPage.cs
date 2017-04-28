using System;
using Xamarin.Forms;

namespace DivTestTabbed
{
	public class TabAPage : ContentPage
	{
		Label label = new Label() { Text = "Page A" };
		Button button = new Button() { Text = "Click me" };
		public TabAPage()
		{
			Title = "Tab A";

			label.HorizontalOptions = LayoutOptions.Center;
			label.VerticalOptions = LayoutOptions.Center;

			button.Clicked += (sender, e) =>
			{
				Navigation.PushAsync(new TabPageAA());
			};

			var stack = new StackLayout();
			stack.Children.Add(label);
			stack.Children.Add(button);
			Content = stack;
		}
	}
}
