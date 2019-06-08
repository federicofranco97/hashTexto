using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        HashClass encript= new HashClass();
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        void mostrarMensaje(String mensaje)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.ContentText = mensaje;
            popup.Popup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           
        }

        private void btnHashear_Click(object sender, EventArgs e)
        {
            String resultado=encript.hashearTexto(inputText.Text);
            String resultado2 = encript.hashearTexto(resultado);
            String resultado3 = encript.hashearTexto(resultado2);
            outPutText.Text = resultado3;
            mostrarMensaje("Has hasheado un texto!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = encript.unhashearTexto(inputText.Text);
            String resultado2 = encript.unhashearTexto(resultado);
            String resultado3 = encript.unhashearTexto(resultado2);
            outPutText.Text = resultado3;
            mostrarMensaje("Desencriptaste un texto!");
        }

        public void guardarData()
        {
            string conStr = ConfigurationManager.ConnectionStrings["hashDB"].ToString();
            int id;
            try
            {
                id=Convert.ToInt16(numdb.Text);
            }
            catch (Exception e)
            {
                mostrarMensaje("El valor ingresado no es valido!");
                return;
            }
            string query = "Select contenido From TextoHasheado where id="+id;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        String cont= (String)(reader["contenido"]);
                        if (cont == null || cont.Equals("") || cont.Equals(" "))
                        {
                            mostrarMensaje("No existe la entrada");
                        }
                        else
                        {
                            inputText.Text = cont;
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            guardarData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
            outPutText.Text = "";
            numdb.Text = "";
        }
    }
}
