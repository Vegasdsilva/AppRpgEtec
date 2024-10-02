using AppRpgEtec.ViewModels.Personagens;


namespace AppRpgEtec.Views.Personagens;

public partial class ListagemView : ContentPage
{
	ListagempersonagemViewModel viewModel;
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_ = viewModel.ObterPersonagens();
    }

    public ListagemView()
	{
		InitializeComponent();

		viewModel = new ListagempersonagemViewModel();
		BindingContext = viewModel;
		Title = "Personagens - App Rpg Etec";

		
	}
}