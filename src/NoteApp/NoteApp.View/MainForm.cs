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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNote addEditNote = new AddEditNote();
            addEditNote.Show();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
