namespace ContactWebApiClient.ViewModels
{
    using System;
    using System.Configuration;
    using System.Collections.ObjectModel;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Windows.Input;
    using System.Windows.Threading;
    using Command;
    using Models;
    using Newtonsoft.Json;

    public class ContactViewModel : BindableBase
    {
        private readonly HttpClient client;
        private readonly DispatcherTimer timer;
        private Contact selectedContact;
        private string email;
        private string phoneNumber;
        private string message;
        private ObservableCollection<Contact> contacts;

        [Obsolete]
        public ContactViewModel()
        {
            this.client = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationSettings.AppSettings["WebApiUrl"])
            };

            this.InitialiseContact();

            this.Contacts = new ObservableCollection<Contact>();
            this.client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            this.SaveCommand = new RelayCommand(this.CanSaveExecute, this.ExecuteSaveCommand);
            this.AddEmailCommand = new RelayCommand(this.CanAddEmailExecute, this.ExecuteAddEmailCommand);
            this.AddPhoneNumberCommand = new RelayCommand(this.CanAddPhoneNumberExecute, this.ExecuteAddPhoneNumberCommand);
            this.ClearCommand = new RelayCommand(this.CanClearExecute, this.ExecuteClearCommand);
            this.timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(3)
            };

            this.timer.Tick += this.Timer_Tick;
            this.LoadData();
        }

        public ICommand ClearCommand { get; set; }

        public ICommand SaveCommand { get; set; }

        public ICommand AddEmailCommand { get; set; }

        public ICommand AddPhoneNumberCommand { get; set; }

        public Contact SelectedContact
        {
            get => this.selectedContact;

            set
            {
                this.selectedContact = value;
                this.OnPropertyChanged();
            }
        }

        public string Message
        {
            get => this.message;

            set
            {
                this.message = value;
                this.OnPropertyChanged();
            }
        }

        public string Email
        {
            get => this.email;

            set
            {
                this.email = value;
                this.OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get => this.phoneNumber;

            set
            {
                this.phoneNumber = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<Contact> Contacts
        {
            get => this.contacts;

            set
            {
                this.contacts = value;
                this.OnPropertyChanged();
            }
        }

        private void InitialiseContact()
        {
            this.SelectedContact = new Contact
            {
                Emails = new ObservableCollection<Email>(),
                PhoneNumbers = new ObservableCollection<PhoneNumber>(),
                DateOfBirth = DateTime.Now
            };
        }

        private void ExecuteClearCommand(object obj)
        {
            this.InitialiseContact();
            this.Message = "Contact cleared successfully";
            this.timer.Start();
        }

        private bool CanClearExecute(object obj)
        {
            return this.SelectedContact != null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Message = string.Empty;
            this.timer.Stop();
        }

        private void ExecuteAddPhoneNumberCommand(object obj)
        {
            this.SelectedContact.PhoneNumbers.Add(new PhoneNumber
            {
                Number = this.PhoneNumber
            });

            this.PhoneNumber = string.Empty;
        }

        private void ExecuteAddEmailCommand(object obj)
        {
            this.SelectedContact.Emails.Add(new Email
            {
                MailAddress = this.Email
            });

            this.Email = string.Empty;
        }

        private bool CanAddPhoneNumberExecute(object obj)
        {
            return !string.IsNullOrEmpty(this.PhoneNumber);
        }

        private bool CanAddEmailExecute(object obj)
        {
            return !string.IsNullOrEmpty(this.Email);
        }

        private async void ExecuteSaveCommand(object obj)
        {
            var result = await this.client.PostAsJsonAsync("api/savecontact", this.SelectedContact);
            if (result.IsSuccessStatusCode)
            {
                this.InitialiseContact();
                this.LoadData();
                this.Message = "Contact saved successfully";
                this.timer.Start();
            }
        }

        private bool CanSaveExecute(object obj)
        {
            return !string.IsNullOrEmpty(this.SelectedContact.FirstName) &&
                !string.IsNullOrEmpty(this.SelectedContact.LastName);
        }

        private void LoadData()
        {
            var response = this.client.GetStringAsync("api/getcontacts").Result;
            {
                this.Contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(response);
            }
        }
    }
}
