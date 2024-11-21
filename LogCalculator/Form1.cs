namespace LogCalculator
{
    public partial class Form1 : Form
    {
        private double result_mem = 0;
        private double A = 0;
        private double B = 0;
        private double C = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lowDec;
            if (lower_fraction.Text == "")
            {
                lowDec = 1;
            }
            else
            {
                lowDec = lowDec = Convert.ToDouble(lower_fraction.Text);
            }
            double frac = (Convert.ToDouble(upper_fraction.Text) / lowDec);
            resultFraction.Text = frac.ToString();
            result_mem = Math.Log(
                frac
                , Convert.ToDouble(base_log.Text));
            result.Text = result_mem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = result_mem;
            showA.Text = A.ToString();
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            B = result_mem;
            showB.Text = B.ToString();
        }

        private void saveC_Click(object sender, EventArgs e)
        {
            C = result_mem;
            showC.Text = C.ToString();
        }
    }
}
