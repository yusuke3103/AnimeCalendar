using System;
using System.Collections.Generic;
using AnimeCalendar.ViewModels;
using Xamarin.Forms;

namespace AnimeCalendar.Views.Base
{
	public partial class MenuPage : ContentPage
	{
		private RootPageViewModel ViewModel => this.BindingContext as RootPageViewModel;

		public MenuPage()
		{
			InitializeComponent();
		}

		private async void ListViewMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			await this.ViewModel.PageChangeAsync(e.SelectedItem as ViewModels.MenuItem);
		}
	}
}
