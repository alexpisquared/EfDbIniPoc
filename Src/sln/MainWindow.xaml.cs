using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace xDbIni
{
	public partial class MainWindow : Window
	{
		public MainWindow() { InitializeComponent(); KeyDown += new KeyEventHandler((s, e) => { if (e.Key == Key.Escape) { Close(); Application.Current.Shutdown(); } }); }

		async void onSetDbInitialr(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); DBInitializer.SetDbInitializer(); Title = "Done!"; }
		async void onTbxNameDbName(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); ((CollectionViewSource)(FindResource("lkuGenreViewSource"))).Source = new DbIniPoc_DbContext(dbName.Text).Genres.ToList(); Title = "Done!"; }
		async void onDefaultDbName(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); ((CollectionViewSource)(FindResource("lkuGenreViewSource"))).Source = new DbIniPoc_DbContext().Genres.ToList(); Title = "Done!"; }
    async void onConnStringExp(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); ((CollectionViewSource)(FindResource("lkuGenreViewSource"))).Source = new DbIniPoc_DbContext(@"Data Source=.\AC-201704-LW;Initial Catalog=xDbIni_4;Integrated Security=True;MultipleActiveResultSets=True").Genres.ToList(); Title = "Done!"; }
    async void onLocalConnStr1(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); ((CollectionViewSource)(FindResource("lkuGenreViewSource"))).Source = new DbIniPoc_DbContext($@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\temp\{dbName.Text}.mdf;Integrated Security=True;Connect Timeout=5;User Instance=True").Genres.ToList(); Title = "Done!"; }
    async void onLocalConnStr2(object sender, RoutedEventArgs e) { Title = "Wait ..."; await Task.Delay(9); ((CollectionViewSource)(FindResource("lkuGenreViewSource"))).Source = new DbIniPoc_DbContext($@"Data Source=.\SQLEXPRESS;AttachDbFilename={dbName.Text}.mdf;Integrated Security=True;Connect Timeout=5;User Instance=True").Genres.ToList(); Title = "Done!"; }

    void Window_Loaded(object sender, RoutedEventArgs e)
    {
      tbx1.Text = Environment.CurrentDirectory;

      //OK: worked:
      //init_Click(sender, e);
      //load_Click(sender, e);
    }
  }
}
