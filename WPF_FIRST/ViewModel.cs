using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM;

namespace WPF_FIRST
{
    internal class ViewModel : INotifyPropertyChanged
    {
        private Model _calc;

        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand PlusCommand { get; private set; }
        public RelayCommand MinusCommand { get; private set; }
        public RelayCommand DivCommand { get; private set; }
        public RelayCommand MulCommand { get; private set; }

        public RelayCommand NumberCommand { get; private set; }



        public String Total
        {
            get
            {
                return _calc.Total;
            }
        }
        public String S1
        {
            get
            {
                return _calc.S1;
            }
        }
        public string S2
        {
            get { return _calc.S2; }
           
        }

        public string S3
        {
            get { return _calc.S3; }

        }

        public string S4
        {
            get { return _calc.S4; }

        }


        public string Sign
        {
            get { return _calc.Sign
                    ; }

        }
        public ViewModel(Model calculator)
        {
            _calc = calculator;
            PlusCommand=new RelayCommand(obj =>{_calc.add(); UpdateDisplay(); });
            MinusCommand=new RelayCommand(obj =>{_calc.sub(); UpdateDisplay(); });
            MulCommand = new RelayCommand(obj => { _calc.mul(); UpdateDisplay(); });
            DivCommand = new RelayCommand(obj => { _calc.div(); UpdateDisplay(); });
            NumberCommand = new RelayCommand(obj => { _calc.Number(Convert.ToInt32(obj)); UpdateDisplay(); });
                                     

        }

        private void UpdateDisplay()
        {
            NotifyPropertyChanged("S1");
            NotifyPropertyChanged("S2");
            NotifyPropertyChanged("S3");
            NotifyPropertyChanged("S4");
            NotifyPropertyChanged("Total");
            NotifyPropertyChanged("Sign");
            CommandManager.InvalidateRequerySuggested();
        }

    


        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

