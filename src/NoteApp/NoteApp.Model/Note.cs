using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Описывает блокнот.
    /// </summary>
    public class Note: ICloneable
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
        private string _text;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private DateTime _createdAt;

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private DateTime _modifiedAt;

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
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "Заголовок не должен содержать " +
                        "более 50 символов.");
                }
                _title = value;
                _modifiedAt = DateTime.Now;
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
                _modifiedAt = DateTime.Now;
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
                _modifiedAt = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает время создания заметки
        /// </summary>
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
        }

        /// <summary>
        /// Возвращает время изменения заметки
        /// </summary>
        public DateTime ModifiedAt
        {
            get
            {
                return _modifiedAt;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Note">
        /// </summary>
        /// <param name="title">Заголовок заметки.</param>
        /// <param name="category">Категория заметки.</param>
        /// <param name="text">Текст заметки.</param>
        [JsonConstructor]
        public Note(string title, string text, Category category,
            DateTime createdAt, DateTime modifiedAt) =>
            (_title, _text, _category, _createdAt, _modifiedAt)
            = (title, text, category, createdAt, modifiedAt);

        /// <summary>
        /// Конструктор заметки
        /// </summary>
        public Note()
        {
            _title = "Новая заметка";
            _text = "";
            _category = Category.Different;
            _createdAt = DateTime.Now;
            _modifiedAt = DateTime.Now;
        }

        /// <summary>
        /// Метод копирования.
        /// </summary>
        public object Clone()
        {
            return new Note(this.Title, this.Text, this.Category, this.CreatedAt, this.ModifiedAt);
        }
    }
}
