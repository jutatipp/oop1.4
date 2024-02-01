namespace GPACalcuator
{
    public partial class Form1 : Form
    {
        private GPACalcuator gPAcaluator = new GPACalcuator();
        public Form1()
        {
            InitializeComponent();
        }
        private GPACalcuator gpacalculator = new GPACalcuator();
        private void button1_Click(object sender, EventArgs e)
        {
            string studentName =this. nameBox1.Text;
            double gpa = double.Parse(gpaBox2.Text);

            Student newStudent = new Student(studentName, dGPA);
            gPAcaluator.SetStudent(newStudent);

            double highName = gPAcaluator.higna();
            double lowName = gPAcaluator.lowna();
            double getHightScore = gPAcaluator.getihghSc();
            string GetLowScore = gPAcaluator.getlowSc();
            string avScore = gPAcaluator.getlowName();
            double getGpa = gPAcaluator.getGPAx(gpa);


            Name1high.Text = highName.ToString();
            Name2low.Text = lowName.ToString();
            HighBox2.Text = getHightScore.ToString();
            lowBox4.Text = GetLowScore.ToString();
            avBox5.Text = avScore.ToString();
            gpaBox3.Text = getGpa.ToString();
        }
    }
}
