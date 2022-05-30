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
    public partial class NoteForm : Form
    {
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            UpdateForm();
        }

        private Note _note = new Note("Ушёл за пивом", Category.Different, "Пошёл в АЯН за джоем");
        private string _titleError;

        private void UpdateForm()
        {
            TitleTextBox.Text = _note.Title;
            CategoryComboBox.SelectedItem = _note.Category;
            CreatedDateTimePicker.Value = _note.CreatedAt;
            ModifiedDateTimePicker.Value = _note.ModifiedAt;
            MainRichTextBox.Text = _note.Text;
        }

        private void UpdateNote()
        {
            _note.Title = TitleTextBox.Text;
            _note.Category = (Category)Enum.Parse(typeof(Category), 
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
            _note.Text = MainRichTextBox.Text;  
        }

        
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
        private void MainGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _note.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.White;
                _titleError = null;
            }
            catch (Exception exception)
            {
                _titleError = TitleTextBox.Text;
                TitleTextBox.BackColor = Color.LightPink;
                MessageBox.Show(exception.Message, "Ошибка ввода");
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _note.Category = (Category)Enum.Parse(typeof(Category), 
                CategoryComboBox.GetItemText(CategoryComboBox.SelectedItem));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {

        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            _note.Text = MainRichTextBox.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFormOnErrors();
                UpdateNote();     
                Close();
            }   
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка ввода");
            }
        }
    }
}
