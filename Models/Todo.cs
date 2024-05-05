using System.ComponentModel;

namespace AspNet.TODO.Models
{
    public class Todo
    {
        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Naziv zadatka")]
        public string Title { get; set; }

        [DisplayName("Rok ili datum zadatka")]
        public DateTime Date { get; set; }
    }
}
