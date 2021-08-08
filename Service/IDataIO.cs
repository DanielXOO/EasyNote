using EasyNote.Model;
using System.ComponentModel;

namespace EasyNote.Service
{
    interface IDataIO
    {
        void InputData(string note);
        BindingList<NoteModel> OutputData();
    }
}
