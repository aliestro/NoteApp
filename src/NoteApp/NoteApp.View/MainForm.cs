using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
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
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
        }
    }
}
