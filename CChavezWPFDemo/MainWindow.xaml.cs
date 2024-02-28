using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDemo;
using static System.Formats.Asn1.AsnWriter;

namespace CChavezWPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //////  4.6.	Add the following code:
            //////Instantiate a class object
            ////Student st = new Student();

            //////Set the values from our controls into the class
            ////st.FirstName = txbFirstName.Text;
            ////st.LastName = txbLastName.Text;
            ////st.StudentNumber = txbStudentNum.Text;
            ////st.Major = txbMajor.Text;

            //////Set the results from the class into a control on the form
            ////txbResults.Text = st.ToString();
            ///
            //Instantiate a class object
            Student st = new Student();

            //  5.9.	Add the following code to the btnSubmit_Click method:
            //Set the values from our controls into the class
            st.FirstName = txbFirstName.Text;
            st.LastName = txbLastName.Text;
            st.StudentNumber = txbStudentNum.Text;
            st.Major = txbMajor.Text;

            //////  5.15.	Fix the code by changing it to the following:
            ////List<int> scores = new List<int>();
            ////foreach (int score in lbScores.Items)
            ////{
            ////    scores.Add(score);
            ////}
            ////st.Scores = scores;

            //  6.8.	In the btnSubmit_Click event change the code that sets the contents of the list box to:
            List<Assignment> scores = new List<Assignment>();
            foreach (Assignment score in lbScores.Items)
            {
                scores.Add(score);
            }
            st.Scores = scores;

            //Set the results from the class into a control on the form
            txbResults.Text = st.ToString();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //////  5.3.	Double click on the button to add an event handler for it:
            ////lbScores.Items.Add(int.Parse(txbScore.Text));
            ///
            //  6.7.Change the add button click event to:
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            lbScores.Items.Add(assign);

        }
    }
}