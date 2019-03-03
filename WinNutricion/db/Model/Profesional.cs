using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class Profesional
    {
        #region variables locales
        private int _dni;
        private string _matricula;
		private string _nombre;
		private string _apellido;
        private string _domicilio;        
		private string _telefono;
		private DateTime _fechaAlta;
		private int _esMedico;
		private int _esNutricionista;
        #endregion

        //cambie el tipo de dato booleano de es_med y es_nutri porque en la base son enteros. la base era para C que no tiene booleanos.

        #region propiedades publicas
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }     
		
		public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
		
		public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
		
		public int EsMedico
        {
            get { return _esMedico; }
            set { _esMedico = value; }
        }
		
		
		public int EsNutricionista
        {
            get { return _esNutricionista; }
            set { _esNutricionista = value; }
        }
        #endregion



    }
}
