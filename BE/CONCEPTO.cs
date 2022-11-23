using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class CONCEPTO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string concepto;

		public string Concepto
		{
			get { return concepto; }
			set { concepto = value; }
		}

		private float porcentaje;

		public float Porcentaje
		{
			get { return porcentaje; }
			set { porcentaje = value; }
		}


	}
}