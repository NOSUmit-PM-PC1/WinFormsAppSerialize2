namespace WinFormsAppSerialize2
{
    partial class FormAddExam
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddSubject = new Button();
            textBoxSubject = new TextBox();
            monthCalendar = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            listViewExams = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(65, 273);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(250, 29);
            buttonAddSubject.TabIndex = 0;
            buttonAddSubject.Text = "Добавить экзамен";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(65, 89);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(250, 27);
            textBoxSubject.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.CustomFormat = "dd.MM.yyyy HH:mm";
            monthCalendar.Format = DateTimePickerFormat.Short;
            monthCalendar.Location = new Point(65, 146);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.Size = new Size(250, 27);
            monthCalendar.TabIndex = 2;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerTime.Location = new Point(65, 204);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.Size = new Size(250, 27);
            dateTimePickerTime.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 53);
            label1.Name = "label1";
            label1.Size = new Size(385, 20);
            label1.TabIndex = 4;
            label1.Text = "Введите название предмета и выберите дату и время";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 53);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 5;
            label2.Text = "Список всех экзаменов";
            // 
            // listViewExams
            // 
            listViewExams.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewExams.Location = new Point(455, 104);
            listViewExams.Name = "listViewExams";
            listViewExams.Size = new Size(306, 296);
            listViewExams.TabIndex = 6;
            listViewExams.UseCompatibleStateImageBehavior = false;
            listViewExams.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Предмет";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Дата";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Время";
            // 
            // FormAddExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewExams);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerTime);
            Controls.Add(monthCalendar);
            Controls.Add(textBoxSubject);
            Controls.Add(buttonAddSubject);
            Name = "FormAddExam";
            Text = "Добавить экзамен";
            FormClosing += FormAddExam_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddSubject;
        private TextBox textBoxSubject;
        private DateTimePicker monthCalendar;
        private DateTimePicker dateTimePickerTime;
        private Label label1;
        private Label label2;
        private ListView listViewExams;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
