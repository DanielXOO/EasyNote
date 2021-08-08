using EasyNote.Service;
using System;
using System.Windows;
namespace EasyNote
{
    public partial class MainWindow : Window
    {
        private JsonData _provider = new JsonData();

        public MainWindow()
        {
            InitializeComponent();
            Note.ItemsSource = _provider.OutputData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Note.ItemsSource = _provider.OutputData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addNote = new NewNoteWindow();
            addNote.Show();
            addNote.Closed += (s, e) => Note.ItemsSource = _provider.OutputData();
        }

    }
}
