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
            get;
        }

        public string[] MarkScheme
        {
            get;
        }

        public string PassMark
        {
            get;
        }
        public TestPaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}
