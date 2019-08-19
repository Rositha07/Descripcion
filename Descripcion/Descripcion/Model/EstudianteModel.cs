using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Descripcion.Model
{
    public class EstudianteModel : INotifyPropertyChanged
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { ID = value; }
        }

        private string _NombredelEstudiante;

        public string NombredelEstudiante
        {
            get { return _NombredelEstudiante; }
            set { NombredelEstudiante = value; }
        }

        private string _ApellidodelEstudiante;

        public string ApellidodelEstudiante
        {
            get { return _ApellidodelEstudiante; }
            set { ApellidodelEstudiante = value; }
        }

        private int _Curso;

        public int Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }

        private string _Edad;

        public string Edad
        {
            get { return _Edad; }
            set { Edad = value; }
        }

        private string _Direccion;

        public string Direccion
        {
            get { return  _Direccion; }
            set { Direccion = value; }
        }

        private string _Responsabledelestudiante;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Responsabledelestudiante
        {
            get { return _Responsabledelestudiante; }
            set { Responsabledelestudiante = value; }
        }


    }
}
