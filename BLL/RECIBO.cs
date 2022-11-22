using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class RECIBO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private EMPLEADO empleado;

		public EMPLEADO Empleado
		{
			get { return empleado; }
			set { empleado = value; }
		}

		private List<CONCEPTO> conceptos = new List<CONCEPTO>();

		public List<CONCEPTO> Conceptos
        {
            get { return conceptos; }
            set { conceptos = value; }
        }
        


	}
}