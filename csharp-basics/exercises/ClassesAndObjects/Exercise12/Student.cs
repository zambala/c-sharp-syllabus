﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Student : IStudent
    {
        private string[] _testsTaken;
        private int _testIndex = 0;
        public Student()
        {
            _testsTaken = new string[] { "No tests taken" };
        }

        public string[] TestsTaken => _testsTaken;

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            var score = TestScore(paper, answers);
            var testResults = $"{paper.Subject}: {IsTestPassed(paper, score)} ({score})";
            _testsTaken[_testIndex] = testResults;
            _testIndex++;
            Array.Resize(ref _testsTaken, _testsTaken.Length + 1);
        }
        private string IsTestPassed(ITestpaper paper, string score)
        {
            return ConvertToNumber(score) >= ConvertToNumber(paper.PassMark) ? "Passed!" : "Failed!";
        }

        private string TestScore(ITestpaper paper, string[] answers)
        {
            var totalQuestions = 0;
            var correctAnswers = 0;

            for (var i = 0; i < answers.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    correctAnswers++;
                }

                totalQuestions++;
            }

            return Math.Round((decimal)correctAnswers / totalQuestions * 100) + "%";
        }

        private int ConvertToNumber(string input)
        {
            return int.Parse(input.Replace("%", ""));
        }
    }
}
