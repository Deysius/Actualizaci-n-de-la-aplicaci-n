using Actualización_de_la_aplicación.ViewModel;
namespace Actualización_de_la_aplicación.View;

public partial class Recordatorios : ContentPage
{
    private RecordatoriosViewModel viewModel;

    public Recordatorios()
    {
        InitializeComponent();
        viewModel = new RecordatoriosViewModel();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.Cargar();
    }
}
