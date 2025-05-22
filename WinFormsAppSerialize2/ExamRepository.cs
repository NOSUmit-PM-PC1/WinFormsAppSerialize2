using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsAppSerialize2
{
    public class ExamRepository
    {
        static string fileName = "session.json";
        List<Exam> listExams = new List<Exam>();

        public void Add(Exam exam)
        { 
            listExams.Add(exam);
        }

        public void SaveToFile()
        {
            string json = JsonSerializer.Serialize(listExams);
            File.WriteAllText(fileName, json);
        }

        public void LoadFromFile()
        {
            string json = File.ReadAllText(fileName);
            listExams = JsonSerializer.Deserialize<List<Exam>>(json);
        }

        //public List<Exam> GetAllExams()
        //{
        //    return new List<Exam> (listExams);
        //}

        public IReadOnlyList<Exam> GetAllExams()
        {
            return listExams.AsReadOnly();
        }
             
    }
}
