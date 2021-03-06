﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionList Qlist = new QuestionList();

            AnswerList tof = new AnswerList();
                tof.AddRange(new Answer[] { new Answer("true"), new Answer("false") });

            AnswerList ans = new AnswerList();
                ans.Add( new Answer("true"));

            Question tf = new TrueOrFalse("is that you", tof, ans, 10);
            Qlist.Add( tf);
            Qlist.Add(new TrueOrFalse("is that ", tof, ans, 30));

            Qlist.Add(new ChooseOne("who are you ", tof, ans, 50));
            Qlist.Add(new ChooseOne("how are you ", tof, ans, 5));

            Qlist.Add(new ChooseAll("who am i ", tof, ans,1));
            Qlist.Add(new ChooseAll("who ", tof, ans,6));

            
            Exam<Question>.ExamEvent += Exam<Question>.printState;

            PracticeExam<Question> x = new PracticeExam<Question>(30,6,mode.starting);
            
            x.generateExam();
            


        }

        
    }
}
