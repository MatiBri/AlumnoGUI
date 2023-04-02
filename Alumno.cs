using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoGUI
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private double nota1, nota2, nota3;
        
    
    public int pLegajo
    {
      set { legajo = value;}
      get { return legajo; }
    }
    public string pNombre
    {
     set { nombre = value; }
     get { return nombre; }
    }
    public double pNota1
    {
      set{ nota1 = value; }
      get { return nota1;}
    }
    public double pNota2 
    {
        set { nota2 = value; }
        get { return nota2; }
    }
    public double pNota3 
    {
        set { nota3 = value; }
        get { return nota3; }
    }

    public double calcularPromedio()
    {   
       return (nota1 + nota2 + nota3) / 3;
    }
        public Alumno(int leg, string nom, double not1, double not2, double not3) //Constructor con parámetros
      {
        legajo=leg;
        nombre=nom;
        nota1 = not1;
        nota2 = not2;
        nota3 = not3;
      }

      public Alumno() //Constructor y método es lo mismo
      {
            legajo = 0;
            nombre = ""; //Los string son con "" comillas
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;

      }
      public string toString()
      {
            return "nota1" + Convert.ToString(nota1) + "\n" +
            "nota2" + Convert.ToString(nota2) + "\n" +
            "nota3" + Convert.ToString(nota3) + "\n" +
            "legajo" + Convert.ToString(legajo) + "\n" +
            "nombre" + nombre;
      }

      public int calcularCondicion() //Metodo calcular Condicion del lblCondicion
      {
         if(this.calcularPromedio()<6)
         {
                return 1; //Condicion libre
         }
         else
         {
          if(this.calcularPromedio()<8)
          {
                return 2; //Condicion Regular
          }
          else
          {
                return 3; //Condicion Promocionado
          }
         }
         
      }
    public string mostrarCondicion()
      {
            string condicion = "";
            switch(this.calcularCondicion())
            {
                case 1:
                {
                        condicion = "libre";
                        break;
                }
                case 2:
                    {
                        condicion = "Regular";
                        break;
                    }
                case 3:
                    {
                        condicion = "Promocionado";
                        break;
                    }
            default:
                break;
            }
        return condicion;
     }

}
}


