// Jared L. Abrams// CST-150// October 9, 2022// This is my own work

namespace CST_150_Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fatCalc_Click(object sender, EventArgs e)
        {
            // Check if input is a number
            double fatDouble;
            bool isDouble= double.TryParse(fatInput.Text, out fatDouble);


            if (isDouble) // If input is a number then call FatCalories()
            {
                fatOutput.Text = Convert.ToString(FatCalories(fatDouble)) + " Calories";
            }
            else // If input is not a number then prompt user with error
            { MessageBox.Show("Please Enter A Valid Number");
            }
        }

        private void carbCalc_Click(object sender, EventArgs e)
        {
            // Check if input is a number
            double carbDouble;
            bool isDouble = double.TryParse(carbInput.Text, out carbDouble);


            if (isDouble) // If input is a number then call CarbCalories()
            {
                carbOutput.Text = Convert.ToString(CarbCalories(carbDouble)) + " Calories";
            }
            else // If input is not a number then prompt user with error
            {
                MessageBox.Show("Please Enter A Valid Number");
                    }
        }

        private double FatCalories(double fat)
        {
            return fat*9; // Take input and multiply by 9. Return result.
        }
        private double CarbCalories(double carb)
        { 
            return carb*4; // Take input and multiply by 4. Return result.
        }

    }
}