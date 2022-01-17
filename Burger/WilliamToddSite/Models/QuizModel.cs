using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WilliamToddSite.Models
{
    public class QuizModel
    {   
        public int qid { get; set; }
        public string Answer { get; set; }
        public int rScore { get; set; }

        public string checkAnswer()
        {
            int score = 0;
            string result = " ";
            if(rScore > score)
            {
                result = "True";
            }
            else
            {
                result = "False";
            }
            score = rScore;
            return result;
        }
    }
}