using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MultiThread.ViewModel
{
  public   class TextViewModel:BaseViewModel
   {

        private List<string> allText;
        public List<string> AllText
        {
            get
            {
                return allText;
            }
            set
            {
                allText = value;
                OnPropertyChange(new PropertyChangedEventArgs(nameof(AllText)));
            }
        }

        public List<string> List;
        public TextViewModel()
        {
            List = new List<string>();
            List.Add("Salam");
            List.Add("Necesen");
            List.Add("Sagol");
            List.Add("Kele");
            List.Add("Salamlar");
        }

        public  void Process(object callback)
        {
            AllText = new List<string>();
            for (int i=0;i<List.Count;i++)
            {
              
            if( List[i].ToUpper().Contains(CurrentText.ToUpper()) && CurrentText!=string.Empty)
                {
                    AllText.Add(List[i]);
                    
                }
            }
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
                ThreadPool.QueueUserWorkItem(new WaitCallback(Process));
                
                OnPropertyChange(new PropertyChangedEventArgs(nameof(CurrentText)));
            }
        }

    }
}
