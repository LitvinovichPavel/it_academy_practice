using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture_14.Task3
{
    class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumber { get; set; }

        public Neighbor(string fullName, int flatNumber, int phoneNumber)
        {
            FullName = fullName;
            FlatNumber = flatNumber;
            PhoneNumber = phoneNumber;
        }
    }
}
