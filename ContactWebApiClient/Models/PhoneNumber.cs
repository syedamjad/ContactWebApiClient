namespace ContactWebApiClient.Models
{
    using ViewModels;

    public class PhoneNumber : BindableBase
    {
        public int Id { get; set; }
        
        private string number;

        public string Number
        {
            get => this.number;
            set
            {
                this.number = value;
                this.OnPropertyChanged();
            }
        }

        public Contact Contact { get; set; }

        public override string ToString()
        {
            return this.Number;
        }
    }
}
