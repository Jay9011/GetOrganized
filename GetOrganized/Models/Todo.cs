using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetOrganized.Models
{
    public class Todo
    {
        public static List<Todo> ThingsToBeDone = new List<Todo>{
            new Todo {Title = "일어나기", Completed = false},
            new Todo {Title = "잠자기", Completed = false}
        };

        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}