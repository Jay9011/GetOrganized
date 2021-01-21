using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetOrganized.Models
{
    public class Thought
    {
        public static List<Thought> thoughts = new List<Thought>{
            new Thought {Id = 1, Name = "C# 학습", Topic = Topic.Topics.Find(topic => topic.Name == "업무")},
            new Thought {Id = 2, Name = "웹 어플리케이션 구현", Topic = Topic.Topics.Find(topic => topic.Name == "일상")}
        };



        public int Id { get; set; }

        public string Name { get; set; }

        public Topic Topic { get; set; }
    }
}