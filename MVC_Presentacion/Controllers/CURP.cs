using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Presentacion.Controllers
{
    public class CURP
    {


        string curp = "GAPB980523HHGRRR02";
        string nombre = "brayan";
        string pApellido = "garcia";
        string sApellido = "perez";
        string fechaN = "1998-05-23";
        string estado = "HG";
        public void CoCURP()
        {


            string[] ar = new string[17]; 
             ar[0] = pApellido.Substring(1,1);
            

            //ar[1] = pApellido.Split("A","E","I","O","U");

            System.Console.WriteLine(ar);
          System.Console.ReadKey();
        }

    }
}