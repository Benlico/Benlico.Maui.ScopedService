using Benlico.Maui.ScopedService.ViewModels;

namespace Benlico.Maui.ScopedService.Views;

public partial class FirstView : ContentPage
{
	public FirstView(FirstViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
    }
}