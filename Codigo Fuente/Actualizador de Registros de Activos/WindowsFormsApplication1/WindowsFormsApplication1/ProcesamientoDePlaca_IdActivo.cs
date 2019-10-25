using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrosActas
{
    class ProcesamientoDePlaca_IdActivo
    {
        String id_Activo;

        public string procesarPlaca(String placa)
        {
            id_Activo = "";
            for (int i = 0; i < placa.Length; i++)
            {
                if (placa[i] != '0')
                {
                    for (int j = i; j < placa.Length; j++)
                    {
                        if (placa[j] != '-')
                        {
                            id_Activo += placa[j];
                           // MessageBox.Show(id_Activo+"ID"+i);
                            i++;
                        }
                        else { i++; }

                    }
                }
            }

            return id_Activo;
        }


    }
}
