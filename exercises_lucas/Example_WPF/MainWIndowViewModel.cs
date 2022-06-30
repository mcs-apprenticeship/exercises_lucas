using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Example_WPF
{
    internal class MainWIndowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string counter = string.Empty;

        public MainWIndowViewModel()
        {
            IncrementCommand = new RelayCommand(IncrementExecute);
        }


        private string count = "0";

        public string Counter {
            get => count;
            set
            {
                if (counter != value)
                {
                    counter = value;
                    NotifyPropertyChanged();
                    Console.WriteLine()
                }
            } 
        }

       public ICommand IncrementCommand { get; }

        private void IncrementExecute(object? parameter)
        {

            Counter = "123";        }
        }
    }

