using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVM;

namespace WPF_FIRST
{
    internal class Model: INotifyPropertyChanged
    {
        public string s1="0";
        public string s2="0";
        public string total;
        public string sign="**";
        public string s3;
        public string s4;
        public Model() { 
          
        
        }

        public string S1
        {
            get { return s1; }
            set
            {
                s1 = value;
                OnPropertyChanged("S1");
            }

        }
        public string S2
        {
            get { return s2; }
            set
            {
                s2 = value;
                OnPropertyChanged("S2");
            }
        }


        public string S3
        {
            get { return s3; }
            set
            {
                s3 = value;
                OnPropertyChanged("S3");
            }
        }


        public string S4
        {
            get { return s4; }
            set
            {
                s4 = value;
                OnPropertyChanged("S4");
            }
        }


        public string Total
        {
            get { return total; }
            set
            {
               total = value;
                OnPropertyChanged("Total");
            }
        }
        public string Sign
        {
            get { return sign; }
            set
            {
                sign = value;
                OnPropertyChanged("Sign");
            }
        }



        #region ModelMethods
        public string enter_pointer(  string s) 
        {
            if (s.Contains(",") != true)
            {
                s = s + ","; 
            }
            return s;
         
         }
        public void add() {
            Sign = "+";
        }
        public void sub()
        {
            Sign = "-";
        }

        public void mul()
        {
            Sign = "*";
            //Total = (float.Parse(S1) * float.Parse(S2)).ToString();
        }

        public void div()
        {
            Sign = "/";
            //Total = (float.Parse(S1) / float.Parse(S2)).ToString();
        }

        public void Number(int num)
        {
            if (Sign == "**")
            {
                s3 = s3 + num.ToString();
            }
            else s4= s4+num.ToString();
        }
 



        #endregion





        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }

}
