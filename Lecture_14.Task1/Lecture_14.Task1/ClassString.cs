using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_14.Task1
{
    class ClassString
    {
        private string _text = "12345abdfiehfilhief";
        public void TextMethod()
        {
            _text = _text.Substring(0, 5) + "...";
            Console.WriteLine(_text);
        }
    }
}
