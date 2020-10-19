using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Cider : Product
    {
        private string _alcohol;

        public string Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }

    }
}
