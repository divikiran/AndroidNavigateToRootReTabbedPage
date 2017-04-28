using System;
using Android.App;
using DivTestTabbed.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: Xamarin.Forms.ExportRenderer(typeof(TabbedPage), typeof(MyTabbedPageRenderer))]
namespace DivTestTabbed.Droid
{
	public class MyTabbedPageRenderer : TabbedRenderer
	{
		private ActionBar.Tab currentTab;
		private FormsApplicationActivity activity;
		private ActionBar actionBar;

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEvent)
		{
			base.OnElementPropertyChanged(sender, propertyChangedEvent);

			if (propertyChangedEvent.PropertyName != "SelectedItem")
			{
				return;
			}

			this.activity = this.activity ?? this.Context as FormsApplicationActivity;
			this.actionBar = this.actionBar ?? this.activity?.ActionBar;

			if (this.activity == null || this.actionBar == null)
			{
				return;
			}

			if (this.currentTab != null)
			{
				this.currentTab.TabReselected -= this.OnCurrentTabReselected;
			}

			this.actionBar.SelectedTab.TabReselected += this.OnCurrentTabReselected;
			this.currentTab = this.actionBar.SelectedTab;
		}

		void OnCurrentTabReselected(object sender, ActionBar.TabEventArgs e)
		{
			//throw new NotImplementedException();
		}
	}
}
