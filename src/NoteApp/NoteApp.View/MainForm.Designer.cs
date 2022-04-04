
namespace NoteApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitВыйтиИзПриложенияAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowComboBox = new System.Windows.Forms.ComboBox();
            this.ShowLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.WorkLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.Created = new System.Windows.Forms.ComboBox();
            this.MoifiedComboBox = new System.Windows.Forms.ComboBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.TitalLabel = new System.Windows.Forms.Label();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "FileMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitВыйтиИзПриложенияAltF4ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitВыйтиИзПриложенияAltF4ToolStripMenuItem
            // 
            this.exitВыйтиИзПриложенияAltF4ToolStripMenuItem.Name = "exitВыйтиИзПриложенияAltF4ToolStripMenuItem";
            this.exitВыйтиИзПриложенияAltF4ToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.exitВыйтиИзПриложенияAltF4ToolStripMenuItem.Text = "Exit (Выйти из приложения – Alt+F4) ";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNoteToolStripMenuItem.Text = "Add Note ";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editNoteToolStripMenuItem.Text = "Edit Note ";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ShowComboBox
            // 
            this.ShowComboBox.FormattingEnabled = true;
            this.ShowComboBox.Location = new System.Drawing.Point(134, 35);
            this.ShowComboBox.Name = "ShowComboBox";
            this.ShowComboBox.Size = new System.Drawing.Size(154, 24);
            this.ShowComboBox.TabIndex = 3;
            this.ShowComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowLabel
            // 
            this.ShowLabel.AutoSize = true;
            this.ShowLabel.Location = new System.Drawing.Point(17, 38);
            this.ShowLabel.Name = "ShowLabel";
            this.ShowLabel.Size = new System.Drawing.Size(101, 16);
            this.ShowLabel.TabIndex = 4;
            this.ShowLabel.Text = "Show Category:";
            this.ShowLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 386);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(308, 69);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category:";
            // 
            // WorkLabel
            // 
            this.WorkLabel.AutoSize = true;
            this.WorkLabel.Location = new System.Drawing.Point(370, 69);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new System.Drawing.Size(39, 16);
            this.WorkLabel.TabIndex = 8;
            this.WorkLabel.Text = "Work";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(308, 97);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(58, 16);
            this.CreatedLabel.TabIndex = 9;
            this.CreatedLabel.Text = "Created:";
            // 
            // Created
            // 
            this.Created.FormattingEnabled = true;
            this.Created.Location = new System.Drawing.Point(372, 94);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(121, 24);
            this.Created.TabIndex = 10;
            // 
            // MoifiedComboBox
            // 
            this.MoifiedComboBox.FormattingEnabled = true;
            this.MoifiedComboBox.Location = new System.Drawing.Point(584, 94);
            this.MoifiedComboBox.Name = "MoifiedComboBox";
            this.MoifiedComboBox.Size = new System.Drawing.Size(120, 24);
            this.MoifiedComboBox.TabIndex = 11;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(516, 97);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(62, 16);
            this.ModifiedLabel.TabIndex = 12;
            this.ModifiedLabel.Text = "Modified:";
            this.ModifiedLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TitalLabel
            // 
            this.TitalLabel.AutoSize = true;
            this.TitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitalLabel.Location = new System.Drawing.Point(308, 33);
            this.TitalLabel.Name = "TitalLabel";
            this.TitalLabel.Size = new System.Drawing.Size(346, 25);
            this.TitalLabel.TabIndex = 13;
            this.TitalLabel.Text = "Требование к оформлению кода";
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(308, 133);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(577, 365);
            this.MainRichTextBox.TabIndex = 14;
            this.MainRichTextBox.Text = resources.GetString("MainRichTextBox.Text");
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddButton.Location = new System.Drawing.Point(20, 468);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(30, 30);
            this.AddButton.TabIndex = 15;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.Location = new System.Drawing.Point(56, 468);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 16;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Location = new System.Drawing.Point(92, 468);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 503);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.TitalLabel);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.MoifiedComboBox);
            this.Controls.Add(this.Created);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.WorkLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ShowLabel);
            this.Controls.Add(this.ShowComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitВыйтиИзПриложенияAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox ShowComboBox;
        private System.Windows.Forms.Label ShowLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label WorkLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.ComboBox Created;
        private System.Windows.Forms.ComboBox MoifiedComboBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label TitalLabel;
        private System.Windows.Forms.RichTextBox MainRichTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

