using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModernWPFDesign.Core
{
    //INotifyPropertyChanged allows object to notify other objects(listeners) that its state has changed
    class ObservableObjects : INotifyPropertyChanged //ObservableObjects inheritfrom the INotifyPropertyChanged class
    {
        //PropertyChangedEventHandler is a delegate has object & PropertyChangedEventArgs
        public event PropertyChangedEventHandler PropertyChanged;

        //method to change property
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            //if property is not null, change to new string being passed through
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
        }
    }
}
