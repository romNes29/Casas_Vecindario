using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Casa
    {
        private int numero_casa;
        private string propietario;
        private int cantidad_pisos;
        private int cantidad_bannos;
        private string posee_balcon;
        private int total_habitaciones;
        private string amueblado;
        private string piscina;

        public Casa()
        {

        }
        public Casa(int numero_casa, string propietario , int cantidad_pisos, int cantidad_bannos, string posee_balcon, int total_habitaciones, string amueblado, string piscina)
        {
            this.numero_casa = numero_casa;
            this.propietario = propietario;
            this.cantidad_pisos = cantidad_pisos;
            this.cantidad_bannos = cantidad_bannos;
            this.posee_balcon = posee_balcon;
            this.total_habitaciones = total_habitaciones;
            this.amueblado = amueblado;
            this.piscina = piscina;
        }

        public int Numero_casa
        {
            set { this.numero_casa = value; }
            get { return this.numero_casa; }
        }
        public string Propietario
        {
            set { this.propietario = value; }   
            get { return this.propietario; }
        }
        public int Cantidad_pisos
        {
            set { this.cantidad_pisos = value; }
            get { return this.cantidad_pisos; }
        }
        public int Cantidad_bannos
        {
            set { this.cantidad_bannos = value; }
            get { return this.cantidad_bannos; }
        }
        public string Posee_balcon
        {
            set { this.posee_balcon = value; }
            get { return this.posee_balcon; }
        }
        public int Total_habitaciones{
            set { this.total_habitaciones = value; }
            get { return this.total_habitaciones;}  
        }
        public string Amueblado
        {
            set { this.amueblado = value; }
            get { return this.amueblado; }
        }
        public string Piscina
        {
            set { this.piscina = value; }
            get { return this.piscina; }
        }

        public string toSttring()
        {
            string cadena = "";
            cadena += "Numero de casa       : " + this.Numero_casa+"\n";
            cadena += "Nombre de propietario: " + this.Propietario + "\n";
            cadena += "Cantidad de pisos    : " + this.cantidad_pisos + "\n";
            cadena += "Cantidad de baños    : " + this.Cantidad_bannos + "\n";
            cadena += "¿Posee balcón?       : " + this.Posee_balcon + "\n";
            cadena += "Habitaciones         : " + this.Total_habitaciones + "\n";
            cadena += "¿Amueblado?          : " + this.Amueblado + "\n";
            cadena += "¿Posee Piscina?      : " + this.Piscina + "\n";
            return cadena;
        }


    }

}
