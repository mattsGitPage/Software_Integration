using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//The wcf service needs to be running in the browser
//for the windows form application to work
namespace numWinForm
{
    public partial class Form1 : Form
    {
        // this is used for RESTful commented out for assignment
        //myService.ImyServiceClient client;
        public Form1()
        {
            InitializeComponent();

            // this is global instance of the self hosting variable
            //client = new myService.ImyServiceClient();
        }

        //global variable to hold the secret number
        int secret = 0;
        //global variable to keep number of attempts
        int attempts = 1;

        //generate secret number button
        private void button1_Click(object sender, EventArgs e)
        {
            // generate a new instance of our game service
            //this is for the local host service reference
            SolutionRef.Service1Client game = new SolutionRef.Service1Client();

            //check to make sure bounds are specified
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                //two variables to take the upper and lower limits
                int low = Convert.ToInt32(textBox1.Text);
                int upper = Convert.ToInt32(textBox2.Text);

                //make sure secret has been zeroed out first
                secret = 0;

                //this method is for the local host and generates the secret number
                secret = game.SecretNumber(low, upper);

                //this method is for the self hosting service
                //secret = client.SecretNumber(low, upper);

                //the secret number has been generated now we assume the
                //player starts guessing after so we will set the attempts to 0
                textBox4.Text = Convert.ToString(0);
                MessageBox.Show("secret number created please enter a guess");

            }

            //catch the user not entering data
            else
            {
                MessageBox.Show("please enter a lower and upper bound");
            }

        }

        //play button
        private void button2_Click(object sender, EventArgs e)
        {

            //varible to check to users guess set to nothing at first to check against
            String choice = "nothing";

            if (textBox3.Text == "")
            {
                MessageBox.Show("please enter your guess");
            }

            else
            {
                //call the service to see if the guess is correct
                //this method is for the local host reference
                SolutionRef.Service1Client guess = new SolutionRef.Service1Client();
                choice = guess.checkNumber(Convert.ToInt32(textBox3.Text), secret);

                //this method is for the self hosting reference
                // it assigns the string of the result to choice and compares against it
               // choice = client.checkNumber(Convert.ToInt32(textBox3.Text), secret);


                //check if the user enterd the correct number
                // if so display that to the screen and update attempts
                if (String.Compare(choice, "correct") == 0)
                {
                    textBox5.Text = "correct guess";
                    textBox4.Text = Convert.ToString(attempts++);
                }

                //check if the entered guess is to high
                // if so update the amount of attempts as well as inform the user
                //reset the input area for the user as well
                else if (String.Compare(choice, "too big") == 0)
                {
                    textBox5.Text = "too big";
                    textBox4.Text = Convert.ToString(attempts++);
                    textBox3.Text = "";
                }

                //check if the entered guess is to low
                // if so update the amount of attempts as well as inform the user
                //reset the input area for the user as well
                else if (String.Compare(choice, "too small") == 0)
                {
                    textBox5.Text = "too small";
                    textBox4.Text = Convert.ToString(attempts++);
                    textBox3.Text = "";
                }
            }

        }
        
    }
}
