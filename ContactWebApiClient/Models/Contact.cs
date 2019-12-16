namespace ContactWebApiClient.Models
{
    using ViewModels;
    using System;
    using System.Collections.ObjectModel;

    public class Contact : BindableBase
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        private ObservableCollection<Email> emails;

        public ObservableCollection<Email> Emails { 
            get => this.emails;
            set
            {
                this.emails = value;
                this.OnPropertyChanged();
            }
        }

        private ObservableCollection<PhoneNumber> phoneNumbers;

        public ObservableCollection<PhoneNumber> PhoneNumbers
        {
            get => this.phoneNumbers;
            set
            {
                this.phoneNumbers = value;
                this.OnPropertyChanged();
            }
        }
    }
}
