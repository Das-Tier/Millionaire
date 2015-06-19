using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Answer { get; set; }
    }
}