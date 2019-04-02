using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConsructor
{
    class Mahasiswa
    {
        // constructor default
        public Mahasiswa()
        {

        }

        //constructor dengan 2 parameter
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;

        }

        public string Nim{get; set;}
        public string Nama { get; set; }
        
    }
}
