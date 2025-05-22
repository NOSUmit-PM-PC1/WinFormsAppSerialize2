using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsAppSerialize2
{
    public partial class FormAddExam : Form
    {
        ExamRepository examRepository = new ExamRepository();

        public FormAddExam()
        {
            InitializeComponent();
            examRepository.LoadFromFile();
            ShowAllExams();
        }

        public void ShowAllExams()
        {
            listViewExams.Items.Clear();
            foreach (var exam in examRepository.GetAllExams())
            {
                var item = new ListViewItem(exam.Subject);
                item.SubItems.Add(exam.DateToFormatString());
                item.SubItems.Add(exam.TimeToFormatString());
                listViewExams.Items.Add(item);
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam(textBoxSubject.Text, monthCalendar.Value, dateTimePickerTime.Value.TimeOfDay);
            examRepository.Add(exam);
            ShowAllExams();

            //var options = new JsonSerializerOptions
            //{
            //    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            //};

            //string json = JsonSerializer.Serialize(exam, options);

            //MessageBox.Show(json);
            ////StreamWriter file = new StreamWriter("exam.json", true);
            ////file.Write(json);
            ////file.Close();

            //File.WriteAllText("person.json", json, Encoding.UTF8);

        }

        private void FormAddExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            examRepository.SaveToFile();
        }
    }
}
