namespace TabbedPage
{
    public partial class MainPage : TabbedPage
    {
      

        public MainPage()
        {
            InitializeComponent();
           // await Navigation.PushAsync(new UpcomingAppointmentsPage());

            // Configurar colores adicionales
        SelectedTabColor = Colors.White;
        UnselectedTabColor = Colors.LightGray;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            
        }
    }
}
