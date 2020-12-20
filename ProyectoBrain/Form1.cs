using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBrain
{
    // Form:
        // MaximizeBox      --> False
        // FormBorderStyle  --> FixedDialog (impide redimensionar borde)

    // Timer:
        // Interval         --> 1000 (milisegundos)

    // NumericUpDown:
        // ReadOnly         --> True
        // Minimun          --> 1
        // Maximun          --> 3

    public partial class FormBrain : Form
    {
        const int SEGUNDOS = 10;
        static int puntuacion;
        static int segundos;
        static int resultado;
        Random aleatorio = new Random();
        MySqlConnection conexion = new MySqlConnection(); 

        public FormBrain()
        {
            InitializeComponent();
            setTime(SEGUNDOS);
        }

        private void FormBrain_Load(object sender, EventArgs e)
        {
            // Cadena de conexión con servidor
            conexion.ConnectionString = "server=db4free.net; database=dam2020; uid=camachin2020; pwd=pruden2020; old guids=true"; // 'old guids=true' evita FormatException en MySql.Data.dll v4.5.2: Guid debe contener 32 dígitos con 4 guiones (xxxxxxxx - xxxx - xxxx - xxxx - xxxxxxxxxxxx)
        }

        private void setScore(int p)
        {
            puntuacion = p;
            labPuntuacion.Text = Convert.ToString(puntuacion);
        }

        private void setTime(int s)
        {
            segundos = s;
            labTiempo.Text = Convert.ToString(segundos);
        }

        private void Reset()
        {
            timer.Enabled = true;
            nivelNum.Enabled = false;
            setScore(0);
            setTime(SEGUNDOS);
            tbResult.Enabled = true;
            tbResult.Focus();
            GenerarOperacion();
        }

        private void Stop()
        {
            timer.Enabled = false;
            labOperand1.Text = "";
            labOperator.Text = "";
            labOperand2.Text = "";
            labPuntuacion.ForeColor = new System.Drawing.Color();
            tbResult.Enabled = false;
            tbUsername.Enabled = true;
            nivelNum.Enabled = true;
            tbUsername.Focus();
            MessageBox.Show("¡Se acabó el tiempo! Escribe tu nombre en el campo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos--;
            labTiempo.Text = Convert.ToString(segundos);
            if (segundos == 0)
            {
                Stop();
            }
        }

        private int GetRandomInt(int min, int max)
        {
            return aleatorio.Next(min, max + 1);
        }

        private String GetOperator()
        {
            String oper = "+-×÷";
            int random = GetRandomInt(0, 3);
            return Char.ToString(oper[random]);
        }

        private void GenerarOperacion()
        {
            //int operand1 = GetRandomInt(1, Convert.ToInt16(nivelNum.Value) * 10);
            //labOperand1.Text = Convert.ToString(operand1);
            //int operand2 = GetRandomInt(1, Convert.ToInt16(nivelNum.Value) * 10);
            //labOperand2.Text = Convert.ToString(operand2);
            //int oper = GetRandomInt(0, 3);

            //switch (oper)
            //{
            //    case 0:
            //        labOperator.Text = "\u002B"; // +
            //        resultado = operand1 + operand2;
            //        break;
            //    case 1:
            //        labOperator.Text = "\u2212"; // −
            //        resultado = operand1 - operand2;
            //        break;
            //    case 2:
            //        labOperator.Text = "\u00D7"; // ×
            //        resultado = operand1 * operand2;
            //        break;
            //    case 3:
            //        labOperator.Text = "\u00F7"; // ÷
            //        resultado = operand1 / operand2;
            //        break;
            //}

            labOperand1.Text = Convert.ToString(GetRandomInt(1, Convert.ToInt16(nivelNum.Value) * 10));
            labOperator.Text = GetOperator();
            labOperand2.Text = Convert.ToString(GetRandomInt(1, Convert.ToInt16(nivelNum.Value) * 10));
        }

        private int Eval(String expression)
        {

            int number = (int)Convert.ToDouble(new System.Data.DataTable().Compute(expression, String.Empty));
            //return ((number == Int32.MinValue) ? 0 : number); // Int32.MinValue (-2^31) es valor de resultado en división por cero
            return number;
        }

        private void ComprobarResultado()
        {
            String cadena = (labOperand1.Text + labOperator.Text + labOperand2.Text).Replace("×", "*").Replace("÷", "/");
            resultado = Eval(cadena);

            if (Convert.ToInt16(tbResult.Text) == resultado)
            {
                puntuacion++;
                segundos = segundos + 2;
                setTime(segundos);
                labPuntuacion.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                puntuacion--;
                //segundos = segundos - 2;
                labPuntuacion.ForeColor = System.Drawing.Color.Red;
            }
            setScore(puntuacion);
        }

        private void tbResult_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && timer.Enabled)
            {
                if (tbResult.Text != "")
                {
                    ComprobarResultado();

                    /*
                        Esta lógica solo tiene sentido si se establece una sustracción de segundos 
                        en caso de fallo porque cabría la posibilidad de salir de ComprobarResultado() 
                        con tiempo negativo, en cuyo caso habría que detener temporizador y no ejecutar 
                        GenerarOperacion().
                    */

                    //if (segundos <= 0)
                    //{
                    //    setTime(0);
                    //    StopTimer();
                    //}
                    //else
                    //{
                    //    setTime(segundos);
                    //    GenerarOperacion();
                    //}

                    GenerarOperacion();
                    tbResult.Clear();
                }
            }
            else if (e.KeyCode == Keys.Space && !timer.Enabled)
            {
                Reset();
            } else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FormBrain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Reset();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-' || tb.Text.Length != 0)))
            //{
            //    e.Handled = true;
            //}
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-' || (sender as TextBox).Text.Length != 0);
        }

        /*
            Conexión con Base de Datos MySQL:

            Primero es necesario tener teer fichero MySQL.Data.dll, el cual viene incluido en el
            paquete Connector/NET 8.0.21 (para descargarlo hay que seleccionar '.NET & Mono' en la
            pestaña Select Operating System'). Después hay que hacer clic con el botón derecho en
            el nombre del proyecto desde el Explorador de Soluciones (ProyectoBrain), elegir Agregar
            y después Referencia. Desde la sección Examinar podemos subir el mencionado archivo
            MySQL.Data.dll (dependiendo de la versión .NET Framework de nuestro proyecto habrá que buscar
            en la carpeta v4.5.2 o v4.8). Una vez subido y activada su casilla de verificación, tenemos
            que añadir la importación using MySql.Data.MySqlClient a la cabecera.
            
            El fichero queda registrado en el directorio bin/Debug para asegurar la persistencia de la
            referencia en caso de que su fuente original sea inaccesible (borrada).
        */

        private void RegistrarPartidaDB() 
        {
            try
            {
                conexion.Open(); // una vez abierta la puerta al servidor es posible lanzar consultas SQL

                /*
                    A dynamic parameter is a parameter to an SQL statement for which the value is not specified 
                    when the statement is created; instead, the statement has a question mark (?) as a placeholder 
                    for each dynamic parameter. 
                    
                        https://docs.oracle.com/javadb/10.6.2.1/ref/crefsqlj29911.html#crefsqlj29911
                */
                String cadenaSQL = "INSERT INTO ranking VALUES (?nombre, ?puntos, ?fecha)"; // se podrían especificar parámetros aquí y no añadirlos individualmente con comando, pero NO es recomendable (construir cadena concatenando tipos de datos distintos es más complicado que usar única cadena)
                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion); // comando permite efectuar instrucción SQL (selección, inserción, modificación, borrado) (hay que especificar conexión sobre la que se va a efectuar instrucción)
                
                comando.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = tbUsername.Text; // necesario especificar MISMO tipo de dato especificado (definido) en Base de Datos (varchar en este caso)
                comando.Parameters.Add("?puntos", MySqlDbType.Int16).Value = puntuacion;
                comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;

                comando.ExecuteNonQuery(); // ejecución de comando (hay que lanzarlo después de especificar parámetros dinámicos)
                
                MessageBox.Show("Datos subidos correctamente al servidor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se han podido subir los datos al servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RegistrarPartidaDB();
                tbUsername.Enabled = false;
                tbUsername.Clear();
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            List<Ranking> listaRanking = new List<Ranking>(); // hay que crear clase propia Ranking

            try
            {
                conexion.Open();

                String cadenaSQL = "SELECT * FROM ranking ORDER BY puntos DESC";
                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion);
                MySqlDataReader resultadoLista = comando.ExecuteReader(); // objeto MySqlDataReader tiene que ser convertido en List para poder añadirlo a Data Grid View 

                /*
                    ExecuteNonQuery()   operation which executes any arbitrary SQL statements 
                                        in SQL Server without returning any result 
                                        (INSERT, UPDATE, DELETE).

                    ExecuteReader()     operation which executes any arbitrary SQL statements 
                                        in SQL Server and also returns the result, if any, as 
                                        an array of DataSet (SELECT).
                */

                while (resultadoLista.Read()) // mientras haya otra tupla en objeto MySqlDataReader (read() en este contexto es similar a next() en Java)
                {
                    listaRanking.Add( new Ranking( (string)resultadoLista[0], (int)resultadoLista[1], (DateTime)resultadoLista[2] ) ); // int es entero de 32 bits (casting a int equivale a Convert.ToInt32)
                }

                dgvRanking.DataSource = listaRanking; // Data Grid View recoge contenido de lista

                conexion.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    }

}
