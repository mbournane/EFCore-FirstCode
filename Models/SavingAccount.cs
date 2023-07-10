namespace EpargneRichard.Models
{
    public class SavingAccount
    {
        public Guid ID { get; set; }
        public string RIB { get; set; }
        public string Name { get; set; }
        public Double Amount { get; set; }  
        public Double SavingRate { get; set; }


    }
}
