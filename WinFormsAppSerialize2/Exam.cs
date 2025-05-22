using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppSerialize2
{
    public class Exam
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

        public Exam(string subject, DateTime date, TimeSpan time)
        {
            Subject = subject;
            Date = date;
            Time = time;
        }

        public string TimeToFormatString()
        {
            return Time.ToString(@"hh\:mm");
        }

        public string DateToFormatString()
        {
            return Date.ToShortDateString();
        }
    }
}
