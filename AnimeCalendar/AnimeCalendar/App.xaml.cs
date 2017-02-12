using AnimeCalendar.Views;
using AnimeCalendar.Views.Base;
using Prism.Unity;
using Xamarin.Forms;

namespace AnimeCalendar
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer)
		{
		}

		protected override async void OnInitialized()
		{
			InitializeComponent();
			await this.NavigationService.NavigateAsync("/RootPage/NavigationPage/ContractsPage");
		}

		protected override void RegisterTypes()
		{
			this.Container.RegisterTypeForNavigation<RootPage>();
			this.Container.RegisterTypeForNavigation<NavigationPage>();
			this.Container.RegisterTypeForNavigation<ContractsPage>();
			this.Container.RegisterTypeForNavigation<LeadsPage>();
			this.Container.RegisterTypeForNavigation<AccountsPage>();
			this.Container.RegisterTypeForNavigation<OpportunitiesPage>();
		}
	}
}
