using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoGUI 
{
    public partial class frmAlumno : Form
        {
        double c,cl,cr,cp; //Declarámos el contador
        double acuMP, mayorPromedio; //VARIABLE MAYOR PROMEDIO
        string mayorNombre;
        double acu; //Los acumuladores son double. Declarámos el acumulador
        public frmAlumno() { //Constructor, método
            InitializeComponent();
            c = 0; //Inicializamos el contador
            acu = 0; //Inicializamos el acumulador
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void frmAlumno_Load(object sender, EventArgs e) {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e) 
        {
           //if (this.validar() == true) 
            if (txtLegajo.Text == "")
            {
                MessageBox.Show("Está mal...");
                txtLegajo.Focus();
                return;

            }

            if (txtNombre.Text == "")//o string.Empty
            {
                MessageBox.Show("El nombre no puede estar vacio...");
                txtLegajo.Focus();
                return;

            }

            Alumno a; //Alumno creado
            a = new Alumno();
            a.pLegajo =Convert.ToInt32(txtLegajo.Text);
            a.pNombre = txtNombre.Text;
            a.pNota1 = Convert.ToDouble(txtNota1.Text);
            a.pNota2 = Convert.ToDouble(txtNota2.Text);
            a.pNota3 = Convert.ToDouble(txtNota3.Text);

            txtPromedio.Text =Convert.ToString(a.calcularPromedio());
            acu = acu + a.calcularPromedio();
            c = c + 1; //Acá se dice que el contador va a ser igual al mismo +1, por lo tanto va a contar de a 1 en el Form los promedios en este caso ya calculados.
            lblContador.Text = c.ToString(); // Se muestra el valor que tiene el contador
            txtPromGral.Text = Convert.ToString(acu / c);

            lblMayorNombre.Text = a.mostrarCondicion();

            if (a.calcularCondicion() == 1) //"==" Significa o representa igualdad de contenido. Ósea que en vez de asignar compara un valor con otro
                cl ++; //Es igual a contador de libres + 1  cl= cl + 1
            else
                if (a.calcularCondicion() == 2) //Es igual a contador de regulares + 1  cr= cr + 1
                cr ++;
            else
                cp ++; //Es igual a contador de promocionados + 1  cp= cp + 1

            lblContadorLibres.Text = cl.ToString();
            lblContadorRegulares.Text = cr.ToString();
            lblContadorPromocionados.Text = cp.ToString();

            lblPorcLibres.Text = Math.Round((cl / c * 100),2).ToString();
            lblPorcReg.Text = Math.Round((cr / c * 100),2).ToString();
            lblPorcPromocionados.Text = Math.Round((cp / c * 100),2).ToString();

            if (c == 1)
            { 
                mayorPromedio = a.calcularPromedio();
                mayorNombre = a.pNombre;
            }
        else
            if (a.calcularPromedio() > mayorPromedio)
            {
                mayorPromedio = a.calcularPromedio();
                mayorNombre = a.pNombre;
            }
            txtMayorProm.Text = mayorPromedio.ToString();
            lblMayorNombre.Text = mayorNombre;

        }

        private void txtPromedio_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }
    }
}
