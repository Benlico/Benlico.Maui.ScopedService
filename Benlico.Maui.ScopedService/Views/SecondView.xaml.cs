using Benlico.Maui.ScopedService.ViewModels;

namespace Benlico.Maui.ScopedService.Views;

public partial class SecondView : ContentPage
{
	public SecondView(SecondViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}