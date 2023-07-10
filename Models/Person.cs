namespace EpargneRichard.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateNaissance { get; set; }

        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
