namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            MessageBox.Show($"Sending Message: {message}");
            // Later you can add Kafka or Socket logic here
        }
    }
}
