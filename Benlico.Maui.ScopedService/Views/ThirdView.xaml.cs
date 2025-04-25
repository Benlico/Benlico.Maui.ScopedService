using Benlico.Maui.ScopedService.ViewModels;

namespace Benlico.Maui.ScopedService.Views;

public partial class ThirdView : ContentPage
{
	public ThirdView(ThirdViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}