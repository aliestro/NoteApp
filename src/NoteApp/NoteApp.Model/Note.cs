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
                if (value.Length>50)
                {
                    throw new ArgumentException(
                        "Заголовок не должен содержать " +
                        "более 50 символов. Пожалуйста, повторите попытку");
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
                var _categorys = Enum.GetValues(typeof(Category));
                bool _categoryEror = true;
                foreach (Category item in _categorys)
                {
                    value = item;
                    _categoryEror = false;
                    break;
                }
                if (_categoryEror)
                {
                    throw new ArgumentException(
                        "Некорректно выбрана категория " +
                        "пожалуйста, выберите необходимую из имеющегося списка");
                }
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
        public Note(string title, Category category = Category.Different, string text = "Без названия")
        {
            _title = title;
            _category = category;
            _text = text;
            _createdAt = DateTime.Now;
            _modifiedAt = DateTime.Now;
        }

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
    }
}
