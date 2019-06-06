using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HashClass
    {
        String abc = "abcdefghijklmnñopqrstuvwxyz0123456789!#$%&/()=?¡¿/*-+.";
        String ota = "b*+1j#[ñ=4r9hvue¡wsid/m$n&3.87y?fc26)0t!px¿kz(go-%5qal";
        public HashClass()
        {
        }

        public String hashearTexto(String text2)
        {
            String text = text2.ToLower();
            String nuevaCadena = "";
            foreach (var item in text)
            {
                if(item != ' ')
                {
                    int posicion = abc.IndexOf(item);
                    char aux= ota[posicion];
                    nuevaCadena += aux;
                }
                else
                {
                    nuevaCadena += ' ';
                }
                
            }
            return nuevaCadena;
        }

        public String unhashearTexto(String text2)
        {
            String text = text2.ToLower();
            String nuevaCadena = "";
            foreach (var item in text)
            {
                if (item != ' ')
                {
                    int posicion = ota.IndexOf(item);
                    char aux = abc[posicion];
                    nuevaCadena += aux;
                }
                else
                {
                    nuevaCadena += ' ';
                }

            }
            return nuevaCadena;
        }

    }
}
