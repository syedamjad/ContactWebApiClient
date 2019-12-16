namespace ContactWebApiClient.Models
{
    using ViewModels;

    public class Email : BindableBase
    {
        public int Id { get; set; }

        private string mailAddress;

        public string MailAddress
        {
            get => this.mailAddress;
            set
            {
                this.mailAddress = value;
                this.OnPropertyChanged();
            }
        }

        public Contact Contact { get; set; }

        public override string ToString()
        {
            return this.MailAddress;
        }
    }
}
