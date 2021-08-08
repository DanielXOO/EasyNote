using EasyNote.Model;
using EasyNote.Service;
using System;
using System.Windows;
namespace EasyNote
{
    public partial class NewNoteWindow : Window
    {
        private JsonData _provider = new JsonData();
        
        public NewNoteWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = new NoteModel() { Text = Note.Text };
            _provider.InputData(res.ToString());
            Close();
        }
    }
}
