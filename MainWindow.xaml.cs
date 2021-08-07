using EasyNote.Model;
using System.ComponentModel;
using System.Windows;
namespace EasyNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<NoteModel> _notes;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _notes = new BindingList<NoteModel>()
            {
                new NoteModel(){ Text ="test"},
                new NoteModel(){ Text ="jusie"}
            };
            Note.ItemsSource = _notes;
            _notes.ListChanged += (object sender, ListChangedEventArgs e) => 
            {
                if (e.ListChangedType == ListChangedType.ItemAdded || 
                e.ListChangedType == ListChangedType.ItemAdded)
                    MessageBox.Show("action");
            };
        }

        private void Note_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
