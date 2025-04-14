using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_equipe_final
{
    public class Calculateur
    {
        public Calculateur() { }


        public  double Multiplication(double nb1, double nb2)
        {

            return nb1 * nb2;
        }

        public int Division(int nombre1, int nombre2) //jai laisser les types en double ici cest a cause de sa que sa marchait pas
        {
            return nombre1 / nombre2;
        }
    }
}
