using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    class Shirt : Product
    {
        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

    }
}
