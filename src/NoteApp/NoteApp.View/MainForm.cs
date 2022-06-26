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
            CategoryComboBox.SelectedIndex = 0;
            _project = _projectSerializer.LoadFromFile();
            UpdateListBox();
        }
        private const string _allCategory = "All";

        /// <summary>
        /// Названия заметок для случайной генерации
        /// </summary>
        private List<string> _testTitles = new List<string> { "Томск", "Работа", "Отдых",
            "Творчество", "Техника", "Фильмы" };

        /// <summary>
        /// Текст заметок для случайной генерации
        /// </summary>
        private List<string> _testText = new List<string> {"Lorem ipsum dolor sit amet, " +
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
        private Project _project;

        /// <summary>
        /// Список отображаемых заметок на экране
        /// </summary>
        private List<Note> _currentNotes;

        /// <summary>
        /// Экземпляр класс ProjectSerializer для сереализации.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary>
        /// Обновление элемента ListBox
        /// </summary>
        private void UpdateListBox()
        {
            TitleListBox.Items.Clear();
            if (_project != null)
            {
                OutputByCategory();
                for (int i = 0; i < _currentNotes.Count; ++i)
                {
                    TitleListBox.Items.Add(_currentNotes[i].Title);
                }
            }
        }

        /// <summary>
        /// Обновить выбранную заметку
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0) || (_currentNotes.Count <= index))
            {
                ClearSelectedNote();
                return;
            }
            TextBox.Text = _currentNotes[index].Text;
            TitleLabel.Text = _currentNotes[index].Title;
            NoteCategoryLabel.Text = _currentNotes[index].Category.ToString();
            CreatedDateTimePicker.Value = _currentNotes[index].CreatedAt;
            ModifiedDateTimePicker.Value = _currentNotes[index].ModifiedAt;
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
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                TitleListBox.SelectedIndex = -1;
                _projectSerializer.SaveToFile(_project);
            }
        }

        private void RandomNote()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Category));
            int randomCategory = random.Next(values.Length);
            int randomTitle = random.Next(_testTitles.Count);
            int randomText = random.Next(_testText.Count);
            Note newNote = new Note(_testTitles[randomTitle],
                 _testText[randomText], (Category)randomCategory, DateTime.Now,DateTime.Now);
            _project.Notes.Add(newNote);
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории
        /// </summary>
        private int FindNoteIndex(int index)
        {
            int resultIndex = 0;
            for (int i = 0; i < _project.Notes.Count; i++)
            {
                if (_project.Notes[i] == _currentNotes[index])
                {
                    resultIndex = i;
                    break;
                }
            }
            return resultIndex;
        }

        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                Category noteCategory = (Category)Enum.Parse(typeof(Category),
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }


        /// <summary>
        /// Редактирование существующей заметки.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            index = FindNoteIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
                OutputByCategory();
                UpdateSelectedNote(TitleListBox.SelectedIndex);
                _projectSerializer.SaveToFile(_project);
            }
            if ((TitleListBox.Items.Count != 0) && (currentIndex < TitleListBox.Items.Count))
            {
                TitleListBox.SelectedIndex = currentIndex;
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote(TitleListBox.SelectedIndex);
            UpdateListBox();
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
            EditNote(TitleListBox.SelectedIndex);
            UpdateListBox();
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
            _project.Notes.RemoveAt(index);
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// Кнопка удаления записки
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int currentIndex = TitleListBox.SelectedIndex;
            if (currentIndex == -1)
            {
                return;
            }
            int index = FindNoteIndex(currentIndex);
            var _title = _project.Notes[index].Title;
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

        private void RandomNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNote();
            UpdateListBox();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            if (_project != null)
            {
                OutputByCategory();
            }
            UpdateListBox();
        }
    }
}
