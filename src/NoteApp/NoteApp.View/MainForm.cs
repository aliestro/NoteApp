using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        string testText = "It is a long established fact that a reader will be distracted" +
            " by the readable content of a page when looking at its layout. " +
            "The point of using Lorem Ipsum is that it has a more-or-less normal";
        public MainForm()
        {
            InitializeComponent();
        }

        //static Note defaultNote = new Note();
        static List<Note> defaultList = new List<Note> { };
        private Project _project = new Project(defaultList);

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateListView()
        {
            TitleListBox.Items.Clear();
            for (int i = 0; i < _project.Projects.Count; ++i)
            {
                TitleListBox.Items.Add(_project.Projects[i].Title);
            }
        }

        private void UpdateSelectedObject(int index)
        {
            MainRichTextBox.Text = _project.Projects[index].Text;
            TitleLabel.Text = _project.Projects[index].Title;
            NoteCategoryLabel.Text = _project.Projects[index].Category.ToString();
            CreatedDateTimePicker.Value = _project.Projects[index].CreatedAt;
            ModifiedDateTimePicker.Value = _project.Projects[index].ModifiedAt;
        }       

        private void ClearSelectedObject()
        {
            MainRichTextBox.Text = " ";
            TitleLabel.Text = "Note Title";
            NoteCategoryLabel.Text = "None";
        }
        private void UpdatedIndex(object sender, EventArgs e)
        {
            int selected = TitleListBox.SelectedIndex;
            if (selected == -1)
            {
                ClearSelectedObject();
            }
            else
            {
                UpdateSelectedObject(selected);
            }
        }

        private void AddNote()
        {
            //Note newNote = new Note("Новая заметка", Category.Different,testText);
            //_project.Projects.Add(newNote);
            RandomNote();
        }

        private void RandomNote()
        {
            Random random = new Random();
            Category randomCategory = (Category) random.Next(0,6);
            string randomTitle = System.IO.Path.GetRandomFileName();
            var randomText = System.IO.Path.GetRandomFileName();
            Note newNote = new Note(randomTitle, randomCategory, randomText);
            _project.Projects.Add(newNote);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListView();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void CreatedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListView();
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
        }

        private void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = TitleListBox.SelectedIndex;
            if (selected == -1)
            {
                ClearSelectedObject();
            }
            else
            {
                UpdateSelectedObject(selected);
            }
        }

        private void RemoveObject(int selected)
        {
            TitleListBox.Items.RemoveAt(selected);
            _project.Projects.RemoveAt(selected);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selected = TitleListBox.SelectedIndex;
            if (selected == -1)
            {
                return;
            }
            DialogResult result = MessageBox.Show(@"Do you really wanna remove " + _project.Projects[TitleListBox.SelectedIndex].Title,
                "Message",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.ServiceNotification);
            if (result == DialogResult.OK)
            {
                RemoveObject(selected);
                UpdateListView();
            }
        }
    }
}
