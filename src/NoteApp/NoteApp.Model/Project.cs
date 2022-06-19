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
        public List<Note> Notes
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
            Notes = new List<Note>();
        }

        /// <summary>
		/// Функция сортировки всех заметок по убыванию
		/// </summary>
		/// <param name="notes">Передаваемый список заметок</param>
		/// <returns></returns>
        public List<Note> SortByModificationTime(List<Note> notes)
        {
            notes = notes.OrderByDescending(note =>
                note.ModifiedAt).ToList();
            return notes;
        }

        /// <summary>
		/// Функция выборки всех заметок по передаваемой категории
		/// </summary>
		/// <param name="notes">Передаваемый список заметок</param>
		/// <param name="noteCategory">Передаваемая категория заметки</param>
		/// <returns></returns>
		public List<Note> SearchByCategory(List<Note> notes, Category noteCategory)
        {
            notes = Notes.Where(note =>
                note.Category == noteCategory).ToList();
            return notes;
        }
    }
}
