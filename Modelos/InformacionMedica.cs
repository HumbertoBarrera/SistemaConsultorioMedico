using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    class InformacionMedica
    {
        int idPaciente;
        String dato1, dato2, dato3, dato4, dato4Opc, dato5, dato5Opc, dato6, dato6Opc, dato7, dato7Opc, dato8, dato8Opc, dato9, dato9Opc,
                dato10, dato10Opc, dato11, dato11Opc, dato12, dato12Opc, dato13, dato13Opc, dato13Opc2, dato14, dato14Opc, dato14Opc2,
                dato15, dato15Opc, dato15Opc2, dato15Opc3, dato15Opc4, dato16, dato17, dato18;
        DateTime fecha;

        public InformacionMedica(int idPaciente, String dato1, String dato2, String dato3, String dato4, String dato4Opc, String dato5, String dato5Opc,
                                String dato6, String dato6Opc, String dato7, String dato7Opc, String dato8, String dato8Opc, String dato9, String dato9Opc,
                                String dato10, String dato10Opc, String dato11, String dato11Opc, String dato12, String dato12Opc, String dato13, String dato13Opc,
                                String dato13Opc2, String dato14, String dato14Opc, String dato14Opc2, String dato15, String dato15Opc, String dato15Opc2, String dato15Opc3,
                                String dato15Opc4, String dato16, String dato17, String dato18, DateTime fecha)
        {
            this.idPaciente = idPaciente;
            this.dato1 = dato1;
            this.dato2 = dato2;
            this.dato3 = dato3;
            this.dato4 = dato4;
            this.dato4Opc = dato4Opc;
            this.dato5 = dato5;
            this.dato5Opc = dato5;
            this.dato6 = dato6;
            this.dato6 = dato6Opc;
            this.dato7 = dato7;
            this.dato7Opc = dato7Opc;
            this.dato8 = dato8;
            this.dato8Opc = dato8Opc;
            this.dato9 = dato9;
            this.dato10 = dato10;
            this.dato10Opc = dato10Opc;
            this.dato11 = dato11;
            this.dato11Opc = dato11Opc;
            this.dato12 = dato12;
            this.dato12Opc = dato12Opc;
            this.dato13 = dato13;
            this.dato13Opc = dato13Opc;
            this.dato13Opc2 = dato13Opc2;
            this.dato14 = dato14;
            this.dato14Opc = dato14Opc;
            this.dato14Opc2 = dato14Opc2;
            this.dato15 = dato15;
            this.dato15Opc = dato13Opc;
            this.dato15Opc2 = dato15Opc2;
            this.dato15Opc3 = dato15Opc3;
            this.dato15Opc4 = dato15Opc4;
            this.dato16 = dato16;
            this.dato17 = dato17;
            this.dato18 = dato18;
        }

        public void setDato1(String dato)
        {
            this.dato1 = dato;
        }

        public void setDato2(String dato)
        {
            this.dato2 = dato;
        }

        public void setDato3(String dato)
        {
            this.dato3 = dato;
        }

        public void setDato4(String dato)
        {
            this.dato4 = dato;
        }

        public void setDato4Opc(String dato)
        {
            this.dato4Opc = dato;
        }

        public void setDato5(String dato)
        {
            this.dato5 = dato;
        }

        public void setDato5Opc(String dato)
        {
            this.dato5Opc = dato;
        }

        public void setDato6(String dato)
        {
            this.dato6 = dato;
        }

        public void setDato6Opc(String dato)
        {
            this.dato6Opc = dato;
        }

        public void setDato7(String dato)
        {
            this.dato7 = dato;
        }

        public void setDato7Opc(String dato)
        {
            this.dato7Opc = dato;
        }

        public void setDato8(String dato)
        {
            this.dato8 = dato;
        }

        public void setDato8Opc(String dato)
        {
            this.dato8Opc = dato;
        }

        public void setDato9(String dato)
        {
            this.dato9 = dato;
        }

        public void setDato9Opc(String dato)
        {
            this.dato9Opc = dato;
        }

        public void setDato10(String dato)
        {
            this.dato10 = dato;
        }

        public void setDato10Opc(String dato)
        {
            this.dato10Opc = dato;
        }

        public void setDato11(String dato)
        {
            this.dato11 = dato;
        }

        public void setDato11Opc(String dato)
        {
            this.dato11Opc = dato;
        }

        public void setDato12(String dato)
        {
            this.dato12 = dato;
        }

        public void setDato12Opc(String dato)
        {
            this.dato12Opc = dato;
        }

        public void setDato13(String dato)
        {
            this.dato13 = dato;
        }

        public void setDato13Opc(String dato)
        {
            this.dato13Opc = dato;
        }

        public void setDato13Opc2(String dato)
        {
            this.dato13Opc2 = dato;
        }

        public void setDato14(String dato)
        {
            this.dato14 = dato;
        }

        public void setDato14Opc(String dato)
        {
            this.dato14Opc = dato;
        }

        public void setDato14Opc2(String dato)
        {
            this.dato14Opc2 = dato;
        }

        public void setDato15(String dato)
        {
            this.dato15 = dato;
        }

        public void setDato15Opc(String dato)
        {
            this.dato15Opc = dato;
        }

        public void setDato15Opc2(String dato)
        {
            this.dato15Opc2 = dato;
        }

        public void setDato15Opc3(String dato)
        {
            this.dato15Opc3 = dato;
        }

        public void setDato15Opc4(String dato)
        {
            this.dato15Opc4 = dato;
        }

        public void setDato16(String dato)
        {
            this.dato16 = dato;
        }

        public void setDato17(String dato)
        {
            this.dato17 = dato;
        }

        public void setDato18(String dato)
        {
            this.dato18 = dato;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public String getDato1()
        {
            return dato1;
        }

        public String getDato2()
        {
            return dato2;
        }

        public String getDato3()
        {
            return dato3;
        }

        public String getDato4()
        {
            return dato4;
        }

        public String getDato4Opc()
        {
            return dato4Opc;
        }

        public String getDato5()
        {
            return dato5;
        }

        public String getDato5Opc()
        {
            return dato5Opc;
        }

        public String getDato6()
        {
            return dato6;
        }

        public String getDato6Opc()
        {
            return dato6Opc;
        }

        public String getDato7()
        {
            return dato7;
        }

        public String getDato7Opc()
        {
            return dato7Opc;
        }

        public String getDato8()
        {
            return dato8;
        }

        public String getDato8Opc()
        {
            return dato8Opc;
        }

        public String getDato9()
        {
            return dato9;
        }

        public String getDato9Opc()
        {
            return dato9Opc;
        }

        public String getDato10()
        {
            return dato10;
        }

        public String getDato10Opc()
        {
            return dato10Opc;
        }

        public String getDato11()
        {
            return dato11;
        }

        public String getDato11Opc()
        {
            return dato11Opc;
        }

        public String getDato12()
        {
            return dato12;
        }

        public String getDato12Opc()
        {
            return dato12Opc;
        }

        public String getDato13()
        {
            return dato13;
        }

        public String getDato13Opc()
        {
            return dato13Opc;
        }

        public String getDato13Opc2()
        {
            return dato13Opc2;
        }

        public String getDato14()
        {
            return dato14;
        }

        public String getDato14Opc()
        {
            return dato14Opc;
        }

        public String getDato14Opc2()
        {
            return dato14Opc2;
        }

        public String getDato15()
        {
            return dato15;
        }

        public String getDato15Opc()
        {
            return dato15Opc;
        }

        public String getDato15Opc2()
        {
            return dato15Opc2;
        }

        public String getDato15Opc3()
        {
            return dato15Opc3;
        }

        public String getDato15Opc4()
        {
            return dato15Opc4;
        }

        public String getDato16()
        {
            return dato16;
        }

        public String getDato17()
        {
            return dato17;
        }

        public String getDato18()
        {
            return dato18;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

    }
}
