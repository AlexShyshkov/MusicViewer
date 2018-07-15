namespace MusicViewer
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.musicViewerListBox = new System.Windows.Forms.ListBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelReleased = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.albumTextLabel = new System.Windows.Forms.Label();
            this.releaserTextLabel = new System.Windows.Forms.Label();
            this.lengthTextlabel = new System.Windows.Forms.Label();
            this.genresTextLabel = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.textBoxReleased = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxGenres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 21);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(109, 21);
            this.comboBoxSelect.MaxDropDownItems = 15;
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(351, 21);
            this.comboBoxSelect.TabIndex = 1;
            this.comboBoxSelect.SelectedValueChanged += new System.EventHandler(this.comboBoxSelect_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(68, 56);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerFrom.TabIndex = 3;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(259, 56);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(31, 20);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(296, 56);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerTo.TabIndex = 5;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // musicViewerListBox
            // 
            this.musicViewerListBox.FormattingEnabled = true;
            this.musicViewerListBox.Location = new System.Drawing.Point(16, 92);
            this.musicViewerListBox.Name = "musicViewerListBox";
            this.musicViewerListBox.Size = new System.Drawing.Size(212, 238);
            this.musicViewerListBox.TabIndex = 6;
            this.musicViewerListBox.SelectedIndexChanged += new System.EventHandler(this.musicViewerListBox_SelectedIndexChanged);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlbum.Location = new System.Drawing.Point(257, 92);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(58, 20);
            this.labelAlbum.TabIndex = 7;
            this.labelAlbum.Text = "Album:";
            // 
            // labelReleased
            // 
            this.labelReleased.AutoSize = true;
            this.labelReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReleased.Location = new System.Drawing.Point(234, 127);
            this.labelReleased.Name = "labelReleased";
            this.labelReleased.Size = new System.Drawing.Size(81, 20);
            this.labelReleased.TabIndex = 8;
            this.labelReleased.Text = "Released:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(252, 164);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(63, 20);
            this.labelLength.TabIndex = 9;
            this.labelLength.Text = "Length:";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenres.Location = new System.Drawing.Point(249, 199);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(66, 20);
            this.labelGenres.TabIndex = 10;
            this.labelGenres.Text = "Genres:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // albumTextLabel
            // 
            this.albumTextLabel.AutoSize = true;
            this.albumTextLabel.Location = new System.Drawing.Point(321, 97);
            this.albumTextLabel.Name = "albumTextLabel";
            this.albumTextLabel.Size = new System.Drawing.Size(0, 13);
            this.albumTextLabel.TabIndex = 11;
            // 
            // releaserTextLabel
            // 
            this.releaserTextLabel.AutoSize = true;
            this.releaserTextLabel.Location = new System.Drawing.Point(321, 132);
            this.releaserTextLabel.Name = "releaserTextLabel";
            this.releaserTextLabel.Size = new System.Drawing.Size(0, 13);
            this.releaserTextLabel.TabIndex = 12;
            // 
            // lengthTextlabel
            // 
            this.lengthTextlabel.AutoSize = true;
            this.lengthTextlabel.Location = new System.Drawing.Point(321, 169);
            this.lengthTextlabel.Name = "lengthTextlabel";
            this.lengthTextlabel.Size = new System.Drawing.Size(0, 13);
            this.lengthTextlabel.TabIndex = 13;
            // 
            // genresTextLabel
            // 
            this.genresTextLabel.AutoSize = true;
            this.genresTextLabel.Location = new System.Drawing.Point(321, 204);
            this.genresTextLabel.Name = "genresTextLabel";
            this.genresTextLabel.Size = new System.Drawing.Size(0, 13);
            this.genresTextLabel.TabIndex = 14;
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlbum.Location = new System.Drawing.Point(315, 97);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.ReadOnly = true;
            this.textBoxAlbum.Size = new System.Drawing.Size(145, 13);
            this.textBoxAlbum.TabIndex = 15;
            // 
            // textBoxReleased
            // 
            this.textBoxReleased.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReleased.Location = new System.Drawing.Point(314, 132);
            this.textBoxReleased.Name = "textBoxReleased";
            this.textBoxReleased.ReadOnly = true;
            this.textBoxReleased.Size = new System.Drawing.Size(145, 13);
            this.textBoxReleased.TabIndex = 16;
            // 
            // textBoxLength
            // 
            this.textBoxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLength.Location = new System.Drawing.Point(314, 169);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.ReadOnly = true;
            this.textBoxLength.Size = new System.Drawing.Size(145, 13);
            this.textBoxLength.TabIndex = 17;
            // 
            // textBoxGenres
            // 
            this.textBoxGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenres.Location = new System.Drawing.Point(315, 204);
            this.textBoxGenres.Name = "textBoxGenres";
            this.textBoxGenres.ReadOnly = true;
            this.textBoxGenres.Size = new System.Drawing.Size(145, 13);
            this.textBoxGenres.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 350);
            this.Controls.Add(this.textBoxGenres);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxReleased);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.genresTextLabel);
            this.Controls.Add(this.lengthTextlabel);
            this.Controls.Add(this.releaserTextLabel);
            this.Controls.Add(this.albumTextLabel);
            this.Controls.Add(this.labelGenres);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelReleased);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.musicViewerListBox);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.buttonLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ListBox musicViewerListBox;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelReleased;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label albumTextLabel;
        private System.Windows.Forms.Label releaserTextLabel;
        private System.Windows.Forms.Label lengthTextlabel;
        private System.Windows.Forms.Label genresTextLabel;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.TextBox textBoxReleased;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxGenres;
    }
}

