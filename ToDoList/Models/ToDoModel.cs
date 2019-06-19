using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [Display(Name="Is Done?")]
        public bool IsDone { get; set; }

    }
}
