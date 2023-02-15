using System.Collections.Generic;

namespace TodoList.Models
{
    public class SearchModel
    {
        public string q { get; set; }
        public int p { get; set; }
        public int nrOfPages { get; set; }
        public List<TodoModel> Todos { get; set; }
    }
}
