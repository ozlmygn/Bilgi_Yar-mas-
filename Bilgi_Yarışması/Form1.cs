namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = " Soru 1-) Cumhuriyet kaç yılında ilan edilmiştir ? ";
            BtnA.Text = "1920";
            BtnB.Text = "1921";
            BtnC.Text = "1922";
            BtnD.Text = "1923";
            label7.Text = "1923";
        }

        int soruno = 0;
        int dogru = 0, yanlis = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            button1.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



            soruno++;
            Lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
               


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Soru 2-) Hangi şehir Ege Bölgesinde bulunmaz ? ";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label7.Text = "Balıkesir";


            }

            if (soruno == 3)
            {
                richTextBox1.Text = " Soru 3 -) Son Kuşlar kitabı hangi yazara aittir ? ";
                BtnA.Text = "Sait Faik Abasıyanık";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Reşat Nuri Güntekin";
                BtnD.Text = "Atilla İlhan";
                label7.Text = "Sait Faik Abasıyanık";
                button1.Text = " Sonuçlar : ";


            }

            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                button1.Enabled = false;

                MessageBox.Show("Sonuçlar   " + " \n " + "Doğru : " + dogru + " \n " + " Yanlış : " + yanlis);



            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button1.Enabled = true;

            label8.Text = BtnA.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lblyanliş.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button1.Enabled = true;

            label8.Text = BtnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lblyanliş.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button1.Enabled = true;

            label8.Text = BtnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lblyanliş.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button1.Enabled = true;

            label8.Text = BtnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                Lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlis++;
                Lblyanliş.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}