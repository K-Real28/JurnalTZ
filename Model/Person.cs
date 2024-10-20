using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalTZ.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string id;
        private string lastName;
        private string name;
        private string surname;
        private string birthday;
        private string email;
        private string phone;

        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Поле должно содержать только цифры.")]
        [StringLength(20)]
        public string Id
        {
            get => id;
            set { id = value; OnPropertyChanged(nameof(Id)); }
        }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Поле должно содержать только буквы кириллицы.")]
        public string LastName
        {
            get => lastName;
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Поле должно содержать только буквы кириллицы.")]
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Поле должно содержать только буквы кириллицы.")]
        public string Surname
        {
            get => surname;
            set { surname = value; OnPropertyChanged(nameof(Surname)); }
        }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$", ErrorMessage = "Введите дату в формате дд.ММ.гггг.")]
        public string Birthday
        {
            get => birthday;
            set { birthday = value; OnPropertyChanged(nameof(Birthday)); }
        }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Введите адрес в формате пользователь@доменная зона.")]
        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^\+\d{1,3}\d{1,4}\d{6,10}$", ErrorMessage = "Введите номер в формате +[код страны][код оператора][номер абонента].")]
        public string Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
