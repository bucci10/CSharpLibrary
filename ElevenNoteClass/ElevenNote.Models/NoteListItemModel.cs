using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItemModel
    {
        public NoteListItemModel(
           int noteId,
           string title,
           DateTime createdUtc,
           DateTime? modifiedUtc
        )
        {
            NoteId = noteId;
            Title = title;
            CreatedUtc = createdUtc;
            ModifiedUtc = modifiedUtc;
        }    

        public int NoteId { get; }

        public string Title { get; }

        public DateTime CreatedUtc { get; }

        public DateTime? ModifiedUtc { get; }
    }
}
