using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread.ViewModel
{
  public   class TextViewModel:BaseViewModel
   {
        public TextViewModel()
        {

            List<string> List=new List<string>();
            List.Add("Salam");
            List.Add("Necesen");
            List.Add("Sagol");
        }


        string currentext;
        public string CurrentText
        {
            get
            {
                return currentext;
            }
            set
            {

               
                currentext = value;
                OnPropertyChange(new PropertyChangedEventArgs(nameof(CurrentText)));
            }
        }

    }
}
