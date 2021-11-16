using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaConsultorioMedico.Modelos;
using System.Data.SqlClient;
using SistemaConsultorioMedico.Controladores;
using System.Windows.Forms;

namespace SistemaConsultorioMedico.Controladores
{
    class InformacionMedicaController
    {

        public static void altaInformacionMedica(Modelos.InformacionMedica im1, Modelos.InformacionMedica im2)
        {
            String query = "INSERT INTO INFORMACIONMEDICA VALUES (@idPaciente, @dato1, @dato2, @dato3, @dato4, @dato4Opc, @dato5, @dato5Opc, @dato6, @dato6Opc, " +
                            "@dato7, @dato7Opc, @dato8, @dato8Opc, @dato9, @dato9Opc, @dato10, @dato10Opc, @dato11, @dato11Opc, @dato12, @dato13, @dato13Opc," +
                            "@dato13Opc2, @dato14, @dato14Opc, @dato14Opc2, @dato15, @dato15Opc, @dato15Opc2, @dato15Opc3, @dato15Opc4, @dato16, @dato17, @dato18, @fecha)";
            try
            {
                using (SqlCommand comando = new SqlCommand(query, ConexionController.Conectar()))
                {
                    comando.Parameters.AddWithValue("@idPaciente", im1.getIdPaciente());
                    comando.Parameters.AddWithValue("@dato1", im1.getDato1());
                    comando.Parameters.AddWithValue("@dato2", im1.getDato2());
                    comando.Parameters.AddWithValue("@dato3", im1.getDato3());
                    comando.Parameters.AddWithValue("@dato4", im1.getDato4());
                    comando.Parameters.AddWithValue("@dato4Opc", im1.getDato4Opc());
                    comando.Parameters.AddWithValue("@dato5", im1.getDato5());
                    comando.Parameters.AddWithValue("@dato5Opc", im1.getDato5Opc());
                    comando.Parameters.AddWithValue("@dato6", im1.getDato6());
                    comando.Parameters.AddWithValue("@dato6Opc", im1.getDato6Opc());
                    comando.Parameters.AddWithValue("@dato7", im1.getDato7());
                    comando.Parameters.AddWithValue("@dato7Opc", im1.getDato7Opc());
                    comando.Parameters.AddWithValue("@dato8", im1.getDato8());
                    comando.Parameters.AddWithValue("@dato8Opc", im1.getDato8Opc());
                    comando.Parameters.AddWithValue("@dato9", im1.getDato9());
                    comando.Parameters.AddWithValue("@dato9Opc", im1.getDato9Opc());
                    comando.Parameters.AddWithValue("@dato10", im2.getDato10());
                    comando.Parameters.AddWithValue("@dato10Opc", im2.getDato10Opc());
                    comando.Parameters.AddWithValue("@dato11", im2.getDato11());
                    comando.Parameters.AddWithValue("@dato11Opc", im2.getDato11Opc());
                    comando.Parameters.AddWithValue("@dato12", im2.getDato12());
                    comando.Parameters.AddWithValue("@dato13", im2.getDato13());
                    comando.Parameters.AddWithValue("@dato13Opc", im2.getDato13Opc());
                    comando.Parameters.AddWithValue("@dato13Opc2", im2.getDato13Opc2());
                    comando.Parameters.AddWithValue("@dato14", im2.getDato14());
                    comando.Parameters.AddWithValue("@dato14Opc", im2.getDato14Opc());
                    comando.Parameters.AddWithValue("@dato14Opc2", im2.getDato14Opc2());
                    comando.Parameters.AddWithValue("@dato15", im2.getDato15());
                    comando.Parameters.AddWithValue("@dato15Opc", im2.getDato15Opc());
                    comando.Parameters.AddWithValue("@dato15Opc2", im2.getDato15Opc2());
                    comando.Parameters.AddWithValue("@dato15Opc3", im2.getDato15Opc3());
                    comando.Parameters.AddWithValue("@dato15Opc4", im2.getDato15Opc4());
                    comando.Parameters.AddWithValue("@dato16", im2.getDato16());
                    comando.Parameters.AddWithValue("@dato17", im2.getDato17());
                    comando.Parameters.AddWithValue("@dato18", im2.getDato18());
                    comando.Parameters.AddWithValue("@fecha", im2.getFecha());
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado < 0)
                    {
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Información Médica agregada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

    }
}
