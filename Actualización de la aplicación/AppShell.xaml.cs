namespace Actualización_de_la_aplicación
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.NotePage), typeof(Views.NotePage));

        }
    }
}
