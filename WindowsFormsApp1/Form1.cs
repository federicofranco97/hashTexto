using System;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        HashClass encript= new HashClass();
        public Form1()
        {
            InitializeComponent();
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
            outPutText.Text = resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = encript.unhashearTexto(inputText.Text);
            outPutText.Text = resultado;
        }
    }
}
