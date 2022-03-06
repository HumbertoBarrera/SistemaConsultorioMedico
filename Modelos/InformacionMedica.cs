using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConsultorioMedico.Modelos
{
    public class InformacionMedica
    {
        int idPaciente;
        String dato1, dato2, dato3, dato4, dato4Opc, dato5, dato5Opc, dato6, dato6Opc, dato7, dato7Opc, dato8, dato8Opc, dato9, dato9Opc,
                dato10, dato10Opc, dato11, dato11Opc, dato12, dato13, dato13Opc, dato13Opc2, dato14, dato14Opc, dato14Opc2,
                dato15, dato15Opc, dato15Opc2, dato15Opc3, dato15Opc4, dato16, dato17, dato18;
        DateTime fecha;

        // Estructura de los modelos de Información Médica

        /// <summary>
        /// Primer método constructor del objeto para el registro de Información Médica.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="dato1"></param>
        /// <param name="dato2"></param>
        /// <param name="dato3"></param>
        /// <param name="dato4"></param>
        /// <param name="dato4Opc"></param>
        /// <param name="dato5"></param>
        /// <param name="dato5Opc"></param>
        /// <param name="dato6"></param>
        /// <param name="dato6Opc"></param>
        /// <param name="dato7"></param>
        /// <param name="dato7Opc"></param>
        /// <param name="dato8"></param>
        /// <param name="dato8Opc"></param>
        /// <param name="dato9"></param>
        /// <param name="dato9Opc"></param>
        /// <param name="dato10"></param>
        /// <param name="dato10Opc"></param>
        /// <param name="dato11"></param>
        /// <param name="dato11Opc"></param>
        /// <param name="dato12"></param>
        /// <param name="dato13"></param>
        /// <param name="dato13Opc"></param>
        /// <param name="dato13Opc2"></param>
        /// <param name="dato14"></param>
        /// <param name="dato14Opc"></param>
        /// <param name="dato14Opc2"></param>
        /// <param name="dato15"></param>
        /// <param name="dato15Opc"></param>
        /// <param name="dato15Opc2"></param>
        /// <param name="dato15Opc3"></param>
        /// <param name="dato15Opc4"></param>
        /// <param name="dato16"></param>
        /// <param name="dato17"></param>
        /// <param name="dato18"></param>
        /// <param name="fecha"></param>
        public InformacionMedica(int idPaciente, String dato1, String dato2, String dato3, String dato4, String dato4Opc, String dato5, String dato5Opc,
                                String dato6, String dato6Opc, String dato7, String dato7Opc, String dato8, String dato8Opc, String dato9, String dato9Opc,
                                String dato10, String dato10Opc, String dato11, String dato11Opc, String dato12, String dato13, String dato13Opc,
                                String dato13Opc2, String dato14, String dato14Opc, String dato14Opc2, String dato15, String dato15Opc, String dato15Opc2, 
                                String dato15Opc3, String dato15Opc4, String dato16, String dato17, String dato18, DateTime fecha)
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
            this.dato9Opc = dato9Opc;
            this.dato10 = dato10;
            this.dato10Opc = dato10Opc;
            this.dato11 = dato11;
            this.dato11Opc = dato11Opc;
            this.dato12 = dato12;
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
            this.fecha = fecha;
        }
        
        /// <summary>
        /// Segundo método constructor para el registro de Información Médica. Se tuvo que partir en dos partes
        /// debido a necesidad en el sistema. Esta es la primera parte de información.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="dato1"></param>
        /// <param name="dato2"></param>
        /// <param name="dato3"></param>
        /// <param name="dato4"></param>
        /// <param name="dato4Opc"></param>
        /// <param name="dato5"></param>
        /// <param name="dato5Opc"></param>
        /// <param name="dato6"></param>
        /// <param name="dato6Opc"></param>
        /// <param name="dato7"></param>
        /// <param name="dato7Opc"></param>
        /// <param name="dato8"></param>
        /// <param name="dato8Opc"></param>
        /// <param name="dato9"></param>
        /// <param name="dato9Opc"></param>
        public InformacionMedica(int idPaciente, String dato1, String dato2, String dato3, String dato4, String dato4Opc, String dato5, String dato5Opc,
                                String dato6, String dato6Opc, String dato7, String dato7Opc, String dato8, String dato8Opc, String dato9, String dato9Opc)
        {
            this.idPaciente = idPaciente;
            this.dato1 = dato1;
            this.dato2 = dato2;
            this.dato3 = dato3;
            this.dato4 = dato4;
            this.dato4Opc = dato4Opc;
            this.dato5 = dato5;
            this.dato5Opc = dato5Opc;
            this.dato6 = dato6;
            this.dato6Opc = dato6Opc;
            this.dato7 = dato7;
            this.dato7Opc = dato7Opc;
            this.dato8 = dato8;
            this.dato8Opc = dato8Opc;
            this.dato9 = dato9;
            this.dato9Opc = dato9Opc;
        }

        /// <summary>
        /// Tercer método constructor para el registro de Información Médica. Se tuvo que partir en dos partes
        /// debido a necesidad en el sistema. Esta es la segunda parte de información.
        /// </summary>
        /// <param name="dato10"></param>
        /// <param name="dato10Opc"></param>
        /// <param name="dato11"></param>
        /// <param name="dato11Opc"></param>
        /// <param name="dato12"></param>
        /// <param name="dato13"></param>
        /// <param name="dato13Opc"></param>
        /// <param name="dato13Opc2"></param>
        /// <param name="dato14"></param>
        /// <param name="dato14Opc"></param>
        /// <param name="dato14Opc2"></param>
        /// <param name="dato15"></param>
        /// <param name="dato15Opc"></param>
        /// <param name="dato15Opc2"></param>
        /// <param name="dato15Opc3"></param>
        /// <param name="dato15Opc4"></param>
        /// <param name="dato16"></param>
        /// <param name="dato17"></param>
        /// <param name="dato18"></param>
        /// <param name="fecha"></param>
        public InformacionMedica(String dato10, String dato10Opc, String dato11, String dato11Opc, String dato12, String dato13, String dato13Opc,
                                String dato13Opc2, String dato14, String dato14Opc, String dato14Opc2, String dato15, String dato15Opc, String dato15Opc2, 
                                String dato15Opc3, String dato15Opc4, String dato16, String dato17, String dato18, DateTime fecha)
        {
            this.dato10 = dato10;
            this.dato10Opc = dato10Opc;
            this.dato11 = dato11;
            this.dato11Opc = dato11Opc;
            this.dato12 = dato12;
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
            this.fecha = fecha;
        }

        // Métodos setters del modelo de Información Médica

        /// <summary>
        /// Método para settear el identificador del paciente en el registro de Información Médica.
        /// </summary>
        /// <param name="idPaciente"></param>
        public void setIdPaciente(int idPaciente)
        {
            this.idPaciente = idPaciente;
        }

        /// <summary>
        /// Método para settear el dato 1 de la Información Médica.
        /// El dato 1 es saber quién recomendó a la paciente sobre la doctora.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato1(String dato)
        {
            this.dato1 = dato;
        }

        /// <summary>
        /// Método para settear el dato 2 de la Información Médica.
        /// El dato 2 es conocer qué ginecólogo se consultaba anteriormente.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato2(String dato)
        {
            this.dato2 = dato;
        }

        /// <summary>
        /// Método para settear el dato 3 de la Información Médica.
        /// El dato 3 es conocer el motivo de la primera consulta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato3(String dato)
        {
            this.dato3 = dato;
        }

        /// <summary>
        /// Método para settear el dato 4 de la Información Médica.
        /// El dato 4 es conocer si se padece de alguna enfermedad crónica.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato4(String dato)
        {
            this.dato4 = dato;
        }

        /// <summary>
        /// Método para settear el dato 4 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica qué enfermedad padece.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato4Opc(String dato)
        {
            this.dato4Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 5 de la Información Médica.
        /// El dato 5 es conocer si la paciente cuenta con animales domésticos.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato5(String dato)
        {
            this.dato5 = dato;
        }

        /// <summary>
        /// Método para settear el dato 5 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica qué animales domésticos tiene
        /// </summary>
        /// <param name="dato"></param>
        public void setDato5Opc(String dato)
        {
            this.dato5Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 6 de la Información Médica.
        /// El dato 6 es para conocer si se toma algún medicamento con regularidad.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato6(String dato)
        {
            this.dato6 = dato;
        }

        /// <summary>
        /// Método para settear el dato 6 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica qué medicamento se consume.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato6Opc(String dato)
        {
            this.dato6Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 7 de la Información Médica.
        /// El dato 7 es para saber si la paciente es alérgica a algún medicamento.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato7(String dato)
        {
            this.dato7 = dato;
        }

        /// <summary>
        /// Método para settear el dato 7 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica a qué medicamento se es alérgica.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato7Opc(String dato)
        {
            this.dato7Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 8 de la Información Médica.
        /// El dato 8 es para conocer si la paciente se ha sometido a alguna cirugía con anterioridad.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato8(String dato)
        {
            this.dato8 = dato;
        }

        /// <summary>
        /// Método para settear el dato 8 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica a qué cirugía fue sometida.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato8Opc(String dato)
        {
            this.dato8Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 9 de la Información Médica.
        /// El dato 9 es para conocer si hubo alguna complicación en la cirugía.
        /// Si la respuesta al dato 8 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato9(String dato)
        {
            this.dato9 = dato;
        }

        /// <summary>
        /// Método para settear el dato 9 opcional de la Información Médica.
        /// Si la respuesta al dato anterior fue SÍ se especifica qué complicación hubo.
        /// Si la respuesta al dato 8 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato9Opc(String dato)
        {
            this.dato9Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 10 de la Información Médica.
        /// El dato 10 es para conocer si algún familiar padece alguna de las enfermedades mostradas.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato10(String dato)
        {
            this.dato10 = dato;
        }

        /// <summary>
        /// Método para settear el dato 10 opcional de la Información Médica.
        /// El dato 10 opcional es para conocer qué familiar padece dicha enfermadad.
        /// Si la respuesta al dato anterior fue OMITIR, se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato10Opc(String dato)
        {
            this.dato10Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 11 de la Información Médica.
        /// El dato 11 es para conocer si la paciente tiene algún pariente infertil.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato11(String dato)
        {
            this.dato11 = dato;
        }

        /// <summary>
        /// Método para settear el dato 11 de la Información Médica.
        /// Este dato es para conocer qué familiar es infértil.
        /// Si se respondió NO al dato anterior se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato11Opc(String dato)
        {
            this.dato11Opc = dato;
        }

        /// <summary>
        /// Método para settear el dato 12 de la Información Médica.
        /// El dato 12 es para conocer cuántas parejas sexuales ha tenidod la paciente.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato12(String dato)
        {
            this.dato12 = dato;
        }

        /// <summary>
        /// Método para settear el dato 13 de la Información Médica.
        /// El dato 13 es para conocer si la paciente consume tabaco.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato13(String dato)
        {
            this.dato13 = dato;
        }

        /// <summary>
        /// Método para settear el primer dato 13 opcional de la Información Médica.
        /// Este dato es para saber desde cuándo consume tabaco la paciente.
        /// Si la respuesta al dato 13 fue NO se omite esta pregunta
        /// </summary>
        /// <param name="dato"></param>
        public void setDato13Opc(String dato)
        {
            this.dato13Opc = dato;
        }

        /// <summary>
        /// Método para settear el segundo dato 13 opcional de la Información Médica.
        /// Este dato es para saber qué tanto diario consume tabaco la paciente.
        /// Si la respuesta al dato 13 fue NO se omite esta pregunta
        /// </summary>
        /// <param name="dato"></param>
        public void setDato13Opc2(String dato)
        {
            this.dato13Opc2 = dato;
        }

        /// <summary>
        /// Método para settear el dato 14 de la Información Médica.
        /// El dato 14 es para saber si la paciente consume alcohol.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato14(String dato)
        {
            this.dato14 = dato;
        }

        /// <summary>
        /// Método para settear el primer dato 13 opcional de la Información Médica.
        /// Este dato es para saber desde cuándo consume alcohol la paciente.
        /// Si la respuesta al dato 14 fue NO se omite esta pregunta
        /// </summary>
        /// <param name="dato"></param>
        public void setDato14Opc(String dato)
        {
            this.dato14Opc = dato;
        }

        /// <summary>
        /// Método para settear el segundo dato 13 opcional de la Información Médica.
        /// Este dato es para saber qué tanto diario consume alcohol la paciente.
        /// Si la respuesta al dato 14 fue NO se omite esta pregunta
        /// </summary>
        /// <param name="dato"></param>
        public void setDato14Opc2(String dato)
        {
            this.dato14Opc2 = dato;
        }

        /// <summary>
        /// Método para settear el dato 15 de la Información Médica.
        /// El dato 15 es para conocer si la paciente consume drogas.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato15(String dato)
        {
            this.dato15 = dato;
        }

        /// <summary>
        /// Método para settear el primer dato 15 opcional de la Información Médica.
        /// Este dato es para conocer qué drogas consume la paciente.
        /// Si la respuesta al dato 15 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato15Opc(String dato)
        {
            this.dato15Opc = dato;
        }

        /// <summary>
        /// Método para settear el segundo dato 15 opcional de la Información Médica.
        /// Este dato es para conocer desde cuándo consume drogas la paciente.
        /// Si la respuesta al dato 15 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato15Opc2(String dato)
        {
            this.dato15Opc2 = dato;
        }

        /// <summary>
        /// Método para settear el tercer dato 15 opcional de la Información Médica.
        /// Este dato es para conocer qué tanto diario consume drogas la paciente.
        /// Si la respuesta al dato 15 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato15Opc3(String dato)
        {
            this.dato15Opc3 = dato;
        }

        /// <summary>
        /// Método para settear el cuarto dato 15 opcional de la Información Médica.
        /// Este dato es para conocer qué tanto mensualmente consume drogas la paciente.
        /// Si la respuesta al dato 15 fue NO se omite esta pregunta.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato15Opc4(String dato)
        {
            this.dato15Opc4 = dato;
        }

        /// <summary>
        /// Método para settear el dato 16 de la Información Médica.
        /// El dato 16 es para conocer cuántas personas duermen en el cuarto de la paciente.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato16(String dato)
        {
            this.dato16 = dato;
        }

        /// <summary>
        /// Método para settear el dato 17 de la Información Médica.
        /// El dato 17 es para conocer si la paciente considera que se alimenta bien.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato17(String dato)
        {
            this.dato17 = dato;
        }

        /// <summary>
        /// Método para settear el dato 18 de la Información Médica.
        /// El dato 18 es para conocer algún comentario que tenga la paciente.
        /// Se puede omitir este dato.
        /// </summary>
        /// <param name="dato"></param>
        public void setDato18(String dato)
        {
            this.dato18 = dato;
        }

        /// <summary>
        /// Método para settear la fecha de registro de de la Información Médica.
        /// </summary>
        /// <param name="fecha"></param>
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        // Métodos getter del modelo de Información Médica

        /// <summary>
        /// Obtiene el ID del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public int getIdPaciente()
        {
            return idPaciente;
        }

        /// <summary>
        /// Obtiene el dato 1 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato1()
        {
            return dato1;
        }

        /// <summary>
        /// Obtiene el dato 2 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato2()
        {
            return dato2;
        }

        /// <summary>
        /// Obtiene el dato 3 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato3()
        {
            return dato3;
        }

        /// <summary>
        /// Obtiene el dato 4 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato4()
        {
            return dato4;
        }

        /// <summary>
        /// Obtiene el dato 4 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato4Opc()
        {
            return dato4Opc;
        }

        /// <summary>
        /// Obtiene el dato 5 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato5()
        {
            return dato5;
        }

        /// <summary>
        /// Obtiene el dato 5 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato5Opc()
        {
            return dato5Opc;
        }

        /// <summary>
        /// Obtiene el dato 6 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato6()
        {
            return dato6;
        }

        /// <summary>
        /// Obtiene el dato 6 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato6Opc()
        {
            return dato6Opc;
        }

        /// <summary>
        /// Obtiene el dato 7 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato7()
        {
            return dato7;
        }

        /// <summary>
        /// Obtiene el dato 7 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato7Opc()
        {
            return dato7Opc;
        }

        /// <summary>
        /// Obtiene el dato 8 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato8()
        {
            return dato8;
        }

        /// <summary>
        /// Obtiene el dato 8 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato8Opc()
        {
            return dato8Opc;
        }

        /// <summary>
        /// Obtiene el dato 9 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato9()
        {
            return dato9;
        }

        /// <summary>
        /// Obtiene el dato 9 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato9Opc()
        {
            return dato9Opc;
        }

        /// <summary>
        /// Obtiene el dato 10 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato10()
        {
            return dato10;
        }

        /// <summary>
        /// Obtiene el dato 10 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato10Opc()
        {
            return dato10Opc;
        }

        /// <summary>
        /// Obtiene el dato 11 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato11()
        {
            return dato11;
        }

        /// <summary>
        /// Obtiene el dato 11 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato11Opc()
        {
            return dato11Opc;
        }

        /// <summary>
        /// Obtiene el dato 12 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato12()
        {
            return dato12;
        }

        /// <summary>
        /// Obtiene el dato 13 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato13()
        {
            return dato13;
        }

        /// <summary>
        /// Obtiene el primer dato 13 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato13Opc()
        {
            return dato13Opc;
        }

        /// <summary>
        /// Obtiene el segundo dato 13 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato13Opc2()
        {
            return dato13Opc2;
        }

        /// <summary>
        /// Obtiene el dato 14 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato14()
        {
            return dato14;
        }

        /// <summary>
        /// Obtiene el primer dato 14 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato14Opc()
        {
            return dato14Opc;
        }

        /// <summary>
        /// Obtiene el segundo dato 14 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato14Opc2()
        {
            return dato14Opc2;
        }

        /// <summary>
        /// Obtiene el dato 15 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato15()
        {
            return dato15;
        }

        /// <summary>
        /// Obtiene el primer dato 15 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato15Opc()
        {
            return dato15Opc;
        }

        /// <summary>
        /// Obtiene el segundo dato 15 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato15Opc2()
        {
            return dato15Opc2;
        }

        /// <summary>
        /// Obtiene el tercer dato 15 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato15Opc3()
        {
            return dato15Opc3;
        }

        /// <summary>
        /// Obtiene el cuarto dato 15 opcional del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato15Opc4()
        {
            return dato15Opc4;
        }

        /// <summary>
        /// Obtiene el dato 16 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato16()
        {
            return dato16;
        }

        /// <summary>
        /// Obtiene el dato 17 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato17()
        {
            return dato17;
        }

        /// <summary>
        /// Obtiene el dato 18 del paciente de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public String getDato18()
        {
            return dato18;
        }

        /// <summary>
        /// Obtiene la fecha de registro de la Información Médica.
        /// </summary>
        /// <returns></returns>
        public DateTime getFecha()
        {
            return fecha;
        }

    }
}
