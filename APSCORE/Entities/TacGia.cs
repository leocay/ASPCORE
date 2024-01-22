using System.ComponentModel.DataAnnotations.Schema;

namespace APSCORE.Entities
{   
    //Tao ten bang
    [Table("TacGia")]
    public class TacGia
    {
        private string name;
        private string que;
        private int id;

        public TacGia(string name, string que, int id)
        {
            Name = name;
            Que = que;
            Id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Que { get => que; set => que = value; }
        public int Id { get => id; set => id = value; }
    }
}
