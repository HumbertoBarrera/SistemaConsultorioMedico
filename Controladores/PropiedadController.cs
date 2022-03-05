using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConsultorioMedico.Controladores
{
    class PropiedadController
    {
        //Limitar longitud de caracteres en string
        public static void BunifuMaterial(Bunifu.Framework.UI.BunifuMaterialTextbox materialTextbox, int longitud)

        {
            foreach (var ctl in materialTextbox.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))

                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = longitud;
                    // set other properties & events here
                }

            }

        }
    }
}
