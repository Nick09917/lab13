namespace lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

        }
        private TextBox textBoxX;
        private void button1_Click(object sender, EventArgs e)
        {


            Form inputForm = new Form();
            Label label = new Label();
            label.Text = "������� �������� x:";
            label.Location = new Point(10, 10);

            textBoxX = new TextBox();
            textBoxX.Location = new Point(10, 30);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new Point(10, 60);
            okButton.Click += OkButton_Click;

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBoxX);
            inputForm.Controls.Add(okButton);

            inputForm.ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            // �������� �������� x �� TextBox
            if (int.TryParse(textBoxX.Text, out int xValue))
            {
                // �������� ������� Reshen � ��������� ��������� x
                Reshen(xValue);

                // �������� ���������� � TextBox
                foreach (int result in Reshen2)
                {
                    textBox1.AppendText(result.ToString() + Environment.NewLine);
                }

                // �������� ����� �����
                ((Button)sender).FindForm().Close();
            }
            else
            {
                MessageBox.Show("������������ �������� ��� x. ������� ����� �����.");
            }
        }

        List<int> Reshen2 = new List<int>();
        int resh;
        public void Reshen(int x)
        {
            Reshen2.Clear();
            for (int i = 1; i <= 10; i++)
            {
                resh = i / x ^ i;
                Reshen2.Add(resh);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}