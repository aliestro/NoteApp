using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает блокнот.
    /// </summary>
    public class Note
    {


        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title;
        /// <summary>
        /// Категория заметки.
        /// </summary>
        private Category _category;
        /// <summary>
        /// Возвращает или задает текст заголовка.
        /// </summary>
        /// 
        private string _text;
        /// <summary>
        /// Время создания заметки.
        /// </summary>
        /// 
        private DateTime _creationTime;
        /// <summary>
        /// Время последнего измения заметки.
        /// </summary>
        /// 
        private DateTime _lastModifiedTime;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        /// <summary>
        /// Возвращает или задает категорию заметки
        /// </summary>
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public Note(string title, Category category, string text)
        {
            _title = title;
            _category = category;
            _text = text;
        }

        /// <summary> 
    }

}
