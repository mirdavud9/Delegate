using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Function
{
    internal class Exam
    {
        public string _subject { get; set; }
        public TimeSpan _examDuration { get; set; }
        public DateTime _startDate { get; set; }
        public DateTime EndDate { get; set; }
        public Exam(string subject, TimeSpan examDuration, DateTime startDate)
        {
            _subject = subject;
            _examDuration = examDuration;
            _startDate = startDate;
            EndDate = _startDate + _examDuration;
        }
    }
}