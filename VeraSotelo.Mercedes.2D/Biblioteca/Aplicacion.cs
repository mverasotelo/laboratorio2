using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Aplicacion
    {
        //atributos
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        /// <summary>
        /// ReadOnly
        /// </summary>
        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }

        /// <summary>
        /// ReadOnly
        /// </summary>
        public abstract int Tamanio { get; }

        /// <summary>
        /// Muestra informacion de la App
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {ToString()}");
            retorno.AppendLine($"Sistema Operativo: {sistemaOperativo}");
            retorno.AppendLine($"Tamaño ocupado: {Tamanio}");
            return retorno.ToString();
        }

        /// <summary>
        /// Sobrescribe el metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }
        /// <summary>
        /// Recibe una lista de aplicaciones y devuelve la instancia 
        /// de la aplicación que más tamaño tenga.
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {;
            Aplicacion aplicacionMasPesada = null;

            if(listaApp is not null && listaApp.Count > 0)
            {
                foreach(Aplicacion app in listaApp)
                {
                    if (aplicacionMasPesada is null)
                    {
                        aplicacionMasPesada = app;
                    }
                    else
                    {
                        if(app.Tamanio > aplicacionMasPesada.Tamanio)
                        {
                            aplicacionMasPesada = app;
                        }
                    }
                }
            }
            return aplicacionMasPesada;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator ==(List<Aplicacion>listaApp, Aplicacion app)
        {
            if(listaApp.Count > 0)
            {
                foreach (Aplicacion a in listaApp)
                {
                    if (a.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// Sobrecarga el operador +. Suma una app a la lista de apps
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static List<Aplicacion> operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            {
                if (listaApp == app)
                {
                    return listaApp;
                }
                listaApp.Add(app);
                return listaApp;
            }
        }


    }
}
