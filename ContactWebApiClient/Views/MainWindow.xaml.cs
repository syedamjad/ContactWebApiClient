namespace ContactWebApiClient.Views
{
    using System.Windows;
    using ViewModels;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ContactViewModel();
        }
    }
}
