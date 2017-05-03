using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{ 

    
    public partial class _Default : Page
    {

        /// <summary>
        /// global variables to set the whosender and a newmessage notification
        /// </summary>
        public static class GlobalVariables
        {
            public static string newMess { get; set; }
            public static string who { get; set; }
        }

        /// <summary>
        /// default page load
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="e">default</param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      /// <summary>
      /// send a message to someone and store it in an xml file
      /// </summary>
      /// <param name="sender">default</param>
      /// <param name="e">defualt</param>
        //
        protected void Button1_Click(object sender, EventArgs e)
        {
            //create the wcf service client to send a message to the xml file
            messages.Service1Client mess = new messages.Service1Client();

            //assign the variables
            string toWho = TextBox1.Text;
            string text = TextBox2.Text;
            string from = TextBox5.Text;

            //invoke the method
            mess.sendMessage(text, from, toWho);
            
            //assign the global variables of who sent the message and the message 
            GlobalVariables.newMess = "you've got mail";
            GlobalVariables.who = toWho;
        }

        /// <summary>
        /// button click to recieve a message based on your id
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="e">default</param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            //make sure the text box is not empty
            if (TextBox3.Text != "")
            {
                //call the wcf service to recieve a message
                messages.Service1Client mess = new messages.Service1Client();

                //get the name of the user who wants to see their message
                string name = TextBox3.Text;

                //call the wcf recieve message service and assign the values to the array
                string[] stuff = mess.recieveMessage(name);

                //iterate through the array and add the elements to the text box
                for (int i = 0; i < stuff.Length; i++)
                {
                    TextBox4.Text += stuff[i];

                }
            }
            else { TextBox3.Text = "enter some id"; }
        }

        //just practice
        protected void Timer1_Tick(object sender, EventArgs e)
        {
             Label1.Text = "UpdatePanel1 refreshed at: " +
             DateTime.Now.ToLongTimeString();
              Label2.Text = "UpdatePanel2 refreshed at: " +
              DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// update event based on a one second timer code edited in the source of the default
        /// as soon as a message is sent it updates the update box letting the user know they recieved a message
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="e">default</param>
        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            //keep track of time of running event for checking message activity
            Label1.Text = "checking for messages " +
             DateTime.Now.ToLongTimeString();

            //if a new message was sent set the label to the user who recieved the message and let them know that they can read it
            if (GlobalVariables.newMess == "you've got mail")
            {
                Label2.Text = GlobalVariables.who + " you've got mail please enter your id tag to read your messages";
            }
            else
            {
                Label2.Text = "waiting for an alert";
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            
        }

        protected void Timer2_Tick1(object sender, EventArgs e)
        {
            
        }

        protected void Timer2_Tick2(object sender, EventArgs e)
        {
           
        }

        protected void Timer2_Tick3(object sender, EventArgs e)
        {
            //TextBox4.Text = "looking for new messages when a sender sends one it will be updated";
        }
    }
}