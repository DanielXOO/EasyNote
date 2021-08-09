using EasyNote.Model;
using System.Text.Json;
using System.ComponentModel;
using System.IO;

namespace EasyNote.Service
{
    class JsonData : IDataIO
    {
        private const string _configPath = "config.json";
        
        public JsonData()
        {
            if (!File.Exists(_configPath))
                File.Create(_configPath).Dispose();
        }
        public void InputData(string note)
        {
            using(var stream = new StreamWriter(_configPath, true))
            {
                stream.WriteLine(note);
            }
        }

        public BindingList<NoteModel> OutputData()
        {
            var notes = new BindingList<NoteModel>();
            using (var stream = new StreamReader(_configPath))
            {
                while(!stream.EndOfStream)
                {
                    string obj = stream.ReadLine();
                    notes.Add(JsonSerializer.Deserialize<NoteModel>(obj));
                }
            }
            return notes;
        }
    }
}
