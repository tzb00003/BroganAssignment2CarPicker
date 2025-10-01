namespace BroganAssignment2CarPicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string color;
        private string[] featureList = { "AC", "Power Windows", "Syrius Radio", "Lane Assist" };
        private string selectedFeatures = "";
        public bool hasFeatures = false;
        private enum Colors
        {
            Red,Blue,White,Black
        }
        private void getColor(Colors c)
        {
            switch (c)
            {
                case Colors.Red:
                    color = "Red";
                    break;
                case Colors.Blue:
                    color = "Blue";
                    break;
                case Colors.White:
                    color = "White";
                    break;
                case Colors.Black:
                    color = "Black";
                    break;
            }

        }
        private void getFeatures()
        {
            selectedFeatures = "";
            selectedFeatures += acCheckBox.Checked ? ", AC" : "no AC";
            selectedFeatures += powerWindowsCheckBox.Checked ? ", Power Windows" : "";
            selectedFeatures += syriusRadioCheckBox.Checked ? ", Syrius Radio" : "";
            selectedFeatures += laneAssistCheckBox.Checked ? ", Lane Assist" : "";
            selectedFeatures = selectedFeatures.Substring(2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(truckListBox.Text))
            {
                outputLabel.Text = "Please select a truck model.";
                outputLabel.BackColor = Color.Red;
            }
            else if(!int.TryParse(yearTextBox.Text, out int year))
            {
                outputLabel.Text = "Please enter a valid year.";
                outputLabel.ForeColor = Color.Red;
            }
            //else if(!blueRadioButton.Checked || !redRadioButton.Checked
            //    || !blackRadioButton.Checked || !whiteRadioButton.Checked)
            //{
            //    outputLabel.Text = "Please select a truck color.";
            //    outputLabel.ForeColor = Color.Red;
            //}
            else
            {
               // getColor(Colors.Red);
                getFeatures();
                outputLabel.Text = $"You have purchased a {yearTextBox.Text} {truckListBox.Text}";
                outputLabel.Text += hasFeatures ? $" with the following features:  \n{selectedFeatures}" : " with no features selected.";
                outputLabel.ForeColor = Color.Black;
            }
        }
    }
}
