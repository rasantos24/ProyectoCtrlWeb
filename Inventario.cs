using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace CtrlWebT
{
    public class Inventario
    {
        private int nuid;

        public int NuId
        {
            get { return nuid; }
            set { nuid = value; }
        }

        private int noinven;

        public int NoInventario
        {
            get { return noinven; }
            set { noinven = value; }
        }

        private string idbin;

        public string IdBin
        {
            get { return idbin; }
            set { idbin = value; }
        }

        private string idprod;

        public string IdProd
        {
            get { return idprod; }
            set { idprod = value; }
        }

        private double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private double conteo;

        public double Conteo
        {
            get { return conteo; }
            set { conteo = value; }
        }

        private double diferencia;

        public double Diferencia
        {
            get { return diferencia; }
            set { diferencia = value; }
        }

        private double totalCant;

        public double TotalCantidad
        {
            get { return totalCant; }
            set { totalCant = value; }
        }

        private double totalConteo;

        public double TotalConteo
        {
            get { return totalConteo; }
            set { totalConteo = value; }
        }

        private double totaldiferencia;

        public double totalDiferencia
        {
            get { return totalDiferencia; }
            set { totalDiferencia = value; }
        }

        public Inventario(int ni, int noiv, string ib, string ip, double cos, double cant, double dife, double tocant, double tocon,
            double todif)
        {
            nuid = ni;
            noinven = noiv;
            idbin = ib;
            idprod = ip;
            costo = cos;
            totalCant = cant;
            diferencia = dife;
            totalConteo = tocant;
            totaldiferencia = todif;
        }

        public Inventario()
        {
            nuid = 0;
            noinven = 0;
            idbin = "";
            idprod = "";
            costo = 0;
            totalCant = 0;
            diferencia = 0;
            totalConteo = 0;
            totaldiferencia = 0;
        }
    }
}