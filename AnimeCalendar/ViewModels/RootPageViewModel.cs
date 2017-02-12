using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace AnimeCalendar.ViewModels
{
	public class RootPageViewModel : BindableBase
	{
		public ObservableCollection<MenuItem> Menus { get; } = new ObservableCollection<MenuItem>
		{
			new MenuItem
			{
				Title = "Contracts",
				PageName = "ContractsPage"
			},
			new MenuItem
			{
				Title = "Leads",
				PageName = "LeadsPage"
			},
			new MenuItem
			{
				Title = "Accounts",
				PageName = "AccountsPage"
			},
			new MenuItem
			{
				Title = "Opportunities",
				PageName = "OpportunitiesPage"
			},
		};

		private INavigationService NavigationService { get; }

		private bool isPresented;

		public bool IsPresented
		{
			get { return this.isPresented; }
			set { this.SetProperty(ref this.isPresented, value); }
		}

		public RootPageViewModel(INavigationService navigationService)
		{
			this.NavigationService = navigationService;
		}

		public async Task PageChangeAsync(MenuItem menuItem)
		{
			await this.NavigationService.NavigateAsync($"NavigationPage/{menuItem.PageName}");
			this.IsPresented = false;
		}
	}
}