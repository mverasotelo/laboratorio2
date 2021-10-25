using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;


        private Competencia()
        {
            competidores =  new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo)
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public short CantidadVueltas
        {
            get
            {
                return cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad competidores {cantidadCompetidores}");
            sb.AppendLine($"Cantidad vueltas: {cantidadVueltas}");
            sb.AppendLine($"Competidores:");
            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {

            if ((v is MotoCross && c.tipo == TipoCompetencia.MotoCross) || (v is AutoF1 && c.tipo == TipoCompetencia.F1))
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    Random r = new Random();
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    v.CantidadCombustible = (short)r.Next(15, 100);
                    c.competidores.Add(v);
                    return true;
                }
            }
            throw new Exception("Competencia incorrecta");
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            foreach (VehiculoDeCarrera vehiculo in c.competidores)
            {
                if (vehiculo == v)
                {
                    return true;
                }
            }
            throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "==");
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

    }
}
