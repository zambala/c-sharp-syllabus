using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class TestPaper : ITestpaper
    {
        public string Subject
        {
            get; set;
        }

        public string[] MarkScheme
        {
            get; set;
        }

        public string PassMark
        {
            get; set;
        }

        public TestPaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}
