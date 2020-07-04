using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerPlate.ViewModels.Base
{
    public class BaseViewModel : ExtendedBindableObject
    {



        bool _isBusy = false;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }


        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;

                RaisePropertyChanged(() => Title);
            }
        }


    }
}
