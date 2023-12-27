namespace lab4
{
    public partial class Form1 : Form
    {
        caffe coffee;
        public Form1()
        {
            InitializeComponent();
            coffee = new caffe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //กาแฟดำ 
            bool canMake = coffee.makeBlackCoffee();
            if (canMake)
            {
                picture.Image = Properties.Resources.BlackC;
            }
            else
            {
                picture.Image = Properties.Resources.BlackC;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //มอลค่า
            bool canMake = coffee.makeMocha();
            if (canMake)
            {
                picture.Image = Properties.Resources.Mocla;
            }
            else
            {
                picture.Image = Properties.Resources.Mocla;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ลาเต้
            bool canMake = coffee.makeLatte();
            if (canMake)
            {
                picture.Image = Properties.Resources.Latte;
            }
            else
            {
                picture.Image = Properties.Resources.Latte;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ช๊อตโกแลต
            bool canMake = coffee.makechoclate();
            if (canMake)
            {
                picture.Image = Properties.Resources.choclate;
            }
            else
            {
                picture.Image = Properties.Resources.choclate;
            }
        }
    }
}
