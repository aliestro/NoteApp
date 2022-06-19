using NoteApp.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.SelectedIndex = 6;
            _note = new Note("Название", Category.Different, "Текст...");
            UpdateForm();
        }

        /// <summary>
        /// Объект заметки 
        /// </summary>
        private Note _note = new Note();

        /// <summary>
        /// Объект заметки
        /// </summary>
        private Note _noteCopy = new Note();

        /// <summary>
        /// Неверный заголовок 
        /// </summary>
        private string _titleError;

        /// <summary>
        /// Задает и возвращает объект заметки
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    _noteCopy = (Note)_note.Clone();
                }
                else
                {
                    _noteCopy = new Note();
                }
                UpdateForm();
            }
        }

        /// <summary>
        /// Обновление формы
        /// </summary>
        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Title;
            CategoryComboBox.SelectedItem = Enum.GetName(typeof(Category),_note.Category);
            CreatedDateTimePicker.Value = _note.CreatedAt;
            ModifiedDateTimePicker.Value = _note.ModifiedAt;
            TextBox.Text = _note.Text;
        }

        /// <summary>
        /// Обновление заметки
        /// </summary>
        private void UpdateNote()
        {
            _noteCopy.Title = TitleTextBox.Text;
            Category selectedCategory = (Category)Enum.Parse(typeof(Category), CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
            _noteCopy.Category = selectedCategory;
            _noteCopy.Text = TextBox.Text;
        }

        /// <summary>
        /// Проверка формы на ошибку
        /// </summary>
        /// <returns></returns>
        bool CheckFormOnErrors()
        {
            if ((_titleError == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
                _titleError = null;
                TitleToolTip.SetToolTip(TitleTextBox, string.Empty);
            }
            catch (Exception exception)
            {
                _titleError = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.LightPink;
                TitleToolTip.SetToolTip(TitleTextBox, exception.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _noteCopy.Category = (Category)Enum.Parse(typeof(Category),
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormOnErrors();
                UpdateNote();
                _note = _noteCopy;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка ввода");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            _noteCopy.Text = TextBox.Text;
        }
    }
}
