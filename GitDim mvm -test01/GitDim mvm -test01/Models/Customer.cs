using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDim_mvm__test01.Models
{
    public class Customer : INotifyPropertyChanged
    {

        /// <summary>
        /// Initializes a new instance of the Customer class;
        /// </summary>
        public Customer(string customerName)
        {
            Name = customerName;
        }


        private string _Name;
        /// <summary>
        /// Gets or sets the Customer's name.
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                value = _Name;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// test comment from laptop;

    }
}
