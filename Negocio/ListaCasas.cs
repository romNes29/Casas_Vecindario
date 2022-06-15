using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.IO;
using System.Windows.Forms;

namespace Negocio
{
    public class ListaCasas
    {
        private List<Casa> lista_casas;

        public ListaCasas()
        {
            this.lista_casas = new List<Casa>();
        }

        public void Registrar_casa(Casa casa)
        {
            this.lista_casas.Add(casa);
        }

        public void Eliminar_casa(int numero_casa)
        {
            foreach (Casa casa in lista_casas)
            {
                if (numero_casa == casa.Numero_casa)
                {
                    lista_casas.Remove(casa);
                }
            }
        }
        public Casa Mostrar_casa(int numero_casa)
        {
            Casa hogar = new Casa();
            foreach (Casa _casa in lista_casas)
            {
                if (_casa.Numero_casa == numero_casa)
                {
                    hogar = _casa;
                }
            }
            return hogar;
        }
        public void Modificar_casa(Casa casa_modificada)
        {
            foreach (Casa casa in lista_casas)
            {
                if (casa.Numero_casa == casa_modificada.Numero_casa)
                {
                    lista_casas.Remove(casa);
                    lista_casas.Add(casa_modificada);
                }
            }
        }

        public void almacenar_informacion()
        {
            TextWriter archivo = new StreamWriter("Vecindario.txt");
            foreach (Casa casa in lista_casas)
            {
                string casa_informacion = "";
                casa_informacion += casa.Numero_casa+",";
                casa_informacion += casa.Propietario + ",";
                casa_informacion += casa.Cantidad_pisos + ",";
                casa_informacion += casa.Cantidad_bannos + ",";
                casa_informacion += casa.Posee_balcon + ",";
                casa_informacion += casa.Total_habitaciones + ",";
                casa_informacion += casa.Amueblado + ",";
                casa_informacion += casa.Piscina;
                archivo.WriteLine(casa_informacion);
            }
            archivo.Close();
        }

        public void cargar_lista_inicio()
        {
            String path = "Vecindario.txt";
            
            if (File.Exists(path))
            {
                TextReader archivo = new StreamReader("Vecindario.txt");
                string linea = archivo.ReadLine();

                if (linea != "")
                {
                    while (linea != null)
                    {
                        string[] datos = linea.Split(',');
                        lista_casas.Add(new Casa(int.Parse(datos[0]), datos[1], int.Parse(datos[2]), int.Parse(datos[3]), 
                            datos[4], int.Parse(datos[5]),datos[6], datos[7]));

                        linea = archivo.ReadLine();
                    }
                } //Cirra if
                else
                {
                    MessageBox.Show("NO EXISTEN DATOS EN EL ARCHIVO");
                }
                archivo.Close();
            }
            else
            {
                MessageBox.Show("EL ARCHIVO NO EXISTE.");
            }
        }

        public List<Casa> ListaCasa
        {
            get { return lista_casas; }
        }



    } //Cierra la clase principal
} //Cierra nameSpace
