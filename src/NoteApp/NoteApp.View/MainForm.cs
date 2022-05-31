using NoteApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Запуск главного окна
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Названия заметок для случайной генерации
        /// </summary>
        List<string> _testTitles = new List<string> { "Томск", "Работа", "Отдых",
            "Творчество", "Техника", "Фильмы" };

        /// <summary>
        /// Текст заметок для случайной генерации
        /// </summary>
        List<string> _testText = new List<string> {"Lorem ipsum dolor sit amet, " +
            "consectetur adipiscing elit, sed do",
            " eiusmod tempor incididunt ut labore et dolore magna aliqua " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco",
            "laboris nisi ut aliquip ex ea commodo consequat.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
            "dolore eu fugiat nulla pariatur. " ,
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia",
            " deserunt mollit anim id est laborum." };

        /// <summary>
        /// Закрытое поле типа Project
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Обновление элемента ListBox
        /// </summary>
        private void UpdateListBox()
        {
            TitleListBox.Items.Clear();
            for (int i = 0; i < _project.Projects.Count; ++i)
            {
                TitleListBox.Items.Add(_project.Projects[i].Title);
            }
        }

        /// <summary>
        /// Обновить выбранную заметку
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedNote(int index)
        {
            TextBox.Text = _project.Projects[index].Text;
            TitleLabel.Text = _project.Projects[index].Title;
            NoteCategoryLabel.Text = _project.Projects[index].Category.ToString();
            CreatedDateTimePicker.Value = _project.Projects[index].CreatedAt;
            ModifiedDateTimePicker.Value = _project.Projects[index].ModifiedAt;
        }       

        /// <summary>
        /// Очистить выбранную заметку
        /// </summary>
        private void ClearSelectedNote()
        {
            TextBox.Text = " ";
            TitleLabel.Text = "Note Title";
            NoteCategoryLabel.Text = "None";
        }

        /// <summary>
        /// Добавить заметку
        /// </summary>
        private void AddNote()
        {
            RandomNote();
        }
            
        private void RandomNote()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Category));
            int randomCategory = random.Next(values.Length);
            int randomTitle = random.Next(_testTitles.Count);
            int randomText = random.Next(_testText.Count);
            Note newNote = new Note(_testTitles[randomTitle], 
                (Category) randomCategory, _testText[randomText]);
            _project.Projects.Add(newNote);
        }

        /// <summary>
        /// Открытие NoteForm
        /// </summary>
        private void OpenSecondForm()
        {
            NoteForm secondForm = new NoteForm();
            secondForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OpenSecondForm();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSecondForm();
        }

        private void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TitleListBox.SelectedIndex;
            if (index == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(index);
            }
        }

        private void RemoveNote(int index)
        {
            TitleListBox.Items.RemoveAt(index);
            _project.Projects.RemoveAt(index);
        }

        /// <summary>
        /// Кнопка удаления записки
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = TitleListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            var _title = _project.Projects[index].Title;
            DialogResult result = MessageBox.Show(@"Do you really wanna remove? " + 
                _title,
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                RemoveNote(index);
                UpdateListBox();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult result = MessageBox.Show(@"Do you wanna exit? ",
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
        }
    }
}
