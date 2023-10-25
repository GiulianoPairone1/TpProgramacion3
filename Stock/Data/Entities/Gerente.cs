namespace Stock.Data.Entities
{
    public class Gerente:User
    {
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
