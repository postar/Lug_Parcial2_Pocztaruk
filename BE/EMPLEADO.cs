using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class EMPLEADO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private float sueldoBruto;

		public float SueldoBruto
		{
			get { return sueldoBruto; }
			set { sueldoBruto = value; }
		}

	}
}