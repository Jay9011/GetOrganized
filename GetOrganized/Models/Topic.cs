using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace GetOrganized.Models
{
    public class Topic
    {
        public static List<Topic> Topics = new List<Topic>{
            new Topic {Id = 1, Color = Color.Red, Name = "업무"},
            new Topic {Id = 2, Color = Color.Blue, Name = "가사"}
        };

        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Topic;
            return other.Id == Id && other.Color.Equals(Color) && Equals(other.Name, Name);
        }

        public string ColorInWebHex()
        {
            return ColorTranslator.ToHtml(Color);
        }
    }
}