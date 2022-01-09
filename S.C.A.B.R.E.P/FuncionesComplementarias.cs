using System;
using System.Linq;

namespace S.C.A.B.R.E.P
{
    class FuncionesComplementarias
    {
        public bool resCedula;
        public bool resTelefonoCelular;
        public bool resRuc;
        public bool resMail;
        public string num_Cedula;
        public string num_TelefonoCelular;
        public string num_Ruc;
        public string cadena_Mail;

        public FuncionesComplementarias(string numCedula,string numTelefonoCelular,string numRuc,string cadenaMail)
        {
            num_Cedula = numCedula;
            num_TelefonoCelular = numTelefonoCelular;
            num_Ruc = numRuc;
            cadena_Mail = cadenaMail;
            
        }
        public bool comprobarMail()
        {
            if (cadena_Mail.Contains('@') || cadena_Mail=="")
            {
                resMail = true;
            }
            else 
            {
                resMail = false;
            }
            return resMail;
        }
        
        public bool comprobarRuc()
        {

            if (num_Ruc.Length == 13 || num_Ruc=="" )
            {
                resRuc = true;
            }
            else 
            {
                resRuc = false;    
            }
            return resRuc;
        }

        public bool comprobarTelefonoCelular()
        {

            if (num_TelefonoCelular.Length <= 10)
            {
                resTelefonoCelular = true;
            }
            else
            {
                resTelefonoCelular = false;
            }
            return resTelefonoCelular;
        }


        public bool comprobarCedula()
        {
            int suma = 0;
            int j = 0;
            bool a = true;
            int x = 0;
            if (num_Cedula.Length == 10 && num_Cedula!="")
            {
                for (int i = 0; i < 9; i++)
                {
                    j = Convert.ToInt16(this.num_Cedula[i].ToString());
                    if (a == true)
                    {
                        x = j * 2;
                        if (x > 9)
                        {
                            x = 1 + (x % 10);
                        }
                        a = false;
                    }
                    else
                    {
                        x = j * 1;
                        a = true;
                    }
                    suma += x;

                }
                x = suma % 10;
                j = Convert.ToInt32(this.num_Cedula[9].ToString());

                if (x == 0)
                {
                    if (x == j)
                    {
                        resCedula = true;
                    }
                }
                else
                {
                    x = (suma - x) + 10;
                    if (j == (x - suma))
                    {
                        resCedula = true;

                    }
                    else
                    {
                        resCedula = false;

                    }
                }
                return resCedula;
            }
            else if (num_Cedula == "")
            {

                resCedula = true;
            }
            else
            {
                resCedula = false;
            }
            return resCedula;
        }
    }
}
