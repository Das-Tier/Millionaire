using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebForms
{
    public static class QuizTable
    {
        public static int index = 0;
        public static int Score = 0;
        public static int [] scoreArray = { 0, 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 125000, 250000, 500000, 1000000 };
    }
    public partial class Game : System.Web.UI.Page
    {
        
        List<Question> questions;
        public Game()
        {
            CreateQuestions();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            //CreateQuestions();
            if (rblst_anwer.SelectedValue==questions[QuizTable.index].Answer)
            {
                QuizTable.Score = QuizTable.scoreArray[QuizTable.index++];
                lbl_score.Text = QuizTable.Score.ToString();
                lbl_question.Text = questions[QuizTable.index++].Text;
            }
        }

        protected void btn_newGame_Click(object sender, EventArgs e)
        {
            QuizTable.index = 0;
            QuizTable.Score = 0;
            lbl_question.Text = questions[QuizTable.index].Text;
        }
        private void CreateQuestions()
        {
            questions = new List<Question>();
            QuizTable.Score = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Server.MapPath("/App_Data/Data.xml"));
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Question quiz = new Question();
                XmlNode attr = xnode.Attributes.GetNamedItem("id");
                if (attr != null)
                    quiz.ID = Int32.Parse(attr.Value);

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "text")
                        quiz.Text = childnode.InnerText;

                    if (childnode.Name == "a")
                        quiz.A = childnode.InnerText;

                    if (childnode.Name == "b")
                        quiz.B = childnode.InnerText;

                    if (childnode.Name == "c")
                        quiz.C = childnode.InnerText;

                    if (childnode.Name == "d")
                        quiz.D = childnode.InnerText;

                    if (childnode.Name == "answer")
                        quiz.Answer = childnode.InnerText;
                }
                questions.Add(quiz);
            }
        }
    }
}