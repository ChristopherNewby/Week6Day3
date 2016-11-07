using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TasksApp
{
    [MetadataType(typeof(TaskTableMetadata))]

    public partial class TaskTable
    {
    }
    public partial class TaskTableMetadata
    {
        [DisplayName("Task Id")]
        public int TaskID { get; set; }

        [DisplayName("Task Title")]
        [Required(ErrorMessage = "You must enter a Title!")]
        [MaxLength(50, ErrorMessage = "Title must be 50 characters or less")]
        public string TaskTitle { get; set; }

        [DisplayName("Task Description")]
        [Required(ErrorMessage = "You must enter a Description!")]
        [MaxLength(50, ErrorMessage = "Description must be 50 characters or less")]

        public string TaskDescription { get; set; }
        [DisplayName("Due Date")]
        [Required(ErrorMessage = "You must enter a due date!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime TaskDueDate { get; set; }

        [DisplayName("Completion  Date")]
        [Required(ErrorMessage = "You must enter a completion date!")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> TaskCompletionDate { get; set; }
    }
}