
namespace WebApplication1.Models
{
    public enum Gender
    {
        kadın=1,
        erkek=2,
        none=3
    }
    public class Personel
    {
        public Personel()
        {
            
        }
        public Personel(int ıd, string name, string address, string cv, Gender gender)
        {
            Id = ıd;
            Name = name;
            Address = address;
            Cv = cv;
            Gender = gender;
        }

        public int Id { get; set; }

        public string    Name { get; set; }
        public string Address { get; set; }
        public string Cv { get; set; }
        public Gender Gender { get; set; } 

    }
}
