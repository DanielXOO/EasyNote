using System;
using System.Text.Json;

namespace EasyNote.Model
{
    class NoteModel
    {
  
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string Text { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
