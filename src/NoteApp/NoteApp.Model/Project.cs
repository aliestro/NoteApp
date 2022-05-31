using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Представление сборника заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Сборник заметок
        /// </summary>
        private List<Note> _notes;

        /// <summary>
        /// Геттеры и сеттеры для сборника заметок
        /// </summary>
        public List<Note> Projects
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Project()
        {
            _notes = new List<Note>();
        }
    }
}
