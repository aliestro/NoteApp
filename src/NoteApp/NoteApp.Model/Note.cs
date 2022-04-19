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
        private string _title = "Без названия";

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

        /// <summary>
        /// Возвращает или задает заголовок заметки
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length>50)
                {
                    throw new ArgumentException("Заголовок не должен содержать более 50 символов. Пожалуйста, повторите попытку");
                }
                _title = value;
                _lastModifiedTime = DateTime.Now;

            }
        }

        /// <summary>
        /// Возвращает или задает текст заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                _lastModifiedTime = DateTime.Now;

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
                _lastModifiedTime = DateTime.Now;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
        }
                /// <summary>
                /// Создает экземпляр <see cref="Note">
                /// </summary>
                /// <param name="title"></param>
                /// <param name="category"></param>
                /// <param name="text"></param>
                public Note(string title, Category category, string text)
        {
            _title = title;
            _category = category;
            _text = text;
            _creationTime = DateTime.Now;
            _lastModifiedTime = DateTime.Now;
        }
    }

}
