using System.ComponentModel.DataAnnotations;

namespace EF.Course.Model
{
    public class Todo
    {
        public Todo(string title)
        {
            Title = title;
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public bool Finished { get; set; }
    }
}
