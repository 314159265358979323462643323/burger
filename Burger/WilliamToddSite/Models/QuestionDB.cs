using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilliamToddSite.Models
{
    public static class QuestionDB
    {
        public static Question getQuestion(int qid)
        {
            Question rValue = new Question();

            if (qid == 1)
            {
                rValue.Text = "Hamburgers require meat?";
                rValue.AnswerA = "true";
                rValue.AnswerB = "false";
            }

            if (qid == 2)
            {
                rValue.Text = "is cheese good on a hamburger?";
                rValue.AnswerA = "true";
                rValue.AnswerB = "false";
            }

            if (qid > 2)
            {
                rValue.Text = "Do you love hamburgers?";
                rValue.AnswerA = "true";
                rValue.AnswerB = "false";
            }

            return rValue;
        }
    }
}
