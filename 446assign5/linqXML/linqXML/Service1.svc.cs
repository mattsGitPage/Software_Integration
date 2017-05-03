using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace linqXML
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //send a message to a particular user
        public void sendMessage(string message, string from, string to)
        {

            //create a new xml document object to load the xml file
            XmlDocument doc1 = new XmlDocument();
            //relative path so i dont lose points

            doc1.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\linqXML\WebApplication1\xml\database.xml"));


            //create thedatabase node with its sub elements
            XmlElement user = doc1.CreateElement("user");
            XmlElement sender = doc1.CreateElement("senderID");
            XmlElement sen = doc1.CreateElement("sendName");

            XmlElement reciever = doc1.CreateElement("recieverID");
            XmlElement rec = doc1.CreateElement("recieveName");

            XmlElement timeStamp = doc1.CreateElement("timeStamp");
            XmlElement time = doc1.CreateElement("time");

            XmlElement mess = doc1.CreateElement("message");
            XmlElement text = doc1.CreateElement("text");


            //add the name node as a child to person and set the elements of the name to the parameters that were passed
            user.AppendChild(sender);
            sender.AppendChild(sen);
            sen.InnerText = from;


            //add the credentials as node to person and set the values passed from parameter to the password and id
            user.AppendChild(reciever);
            reciever.AppendChild(rec);
            rec.InnerText = to;

            //append the timestamp node
            user.AppendChild(timeStamp);
            timeStamp.AppendChild(time);
            time.InnerText = Convert.ToString(DateTime.Now);

            //append thhe message
            user.AppendChild(mess);
            mess.AppendChild(text);
            text.InnerText = message;



            //append the entire person node to the xml file
            doc1.DocumentElement.AppendChild(user);
            //relative path so i dont lose points
            doc1.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\linqXML\WebApplication1\xml\database.xml"));

        }

        //get the message based on user id
        public string[] recieveMessage(string recieverID)
        {
            XmlDocument doc = new XmlDocument();
            //relative path!!!!
            doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\linqXML\WebApplication1\xml\database.xml"));

            //get user enter name and password
            string user = recieverID;

            //get to the child of the root node to traverse
            XmlNodeList xnList = doc.SelectNodes("database/user");

            //could get the root node and use the length feature of the entire xml doc but i dont think youll be pushing this passed 100 trials 
            string[] reply = new string[100];


            int i = 0;
            //go through all the person nodes to locate name
            foreach (XmlNode xn in xnList)
            {
                //get the name from the nodes in xml doc
                string sendy = xn["senderID"]["sendName"].InnerText;
                string userName = xn["recieverID"]["recieveName"].InnerText;
                string timeStam = xn["timeStamp"]["time"].InnerText;
                string message = xn["message"]["text"].InnerText;
                //check if the names meet the name that was passed
                if (user == userName)
                {
                    //assign all the the information attached with the message
                    reply[i] = "\n sender: " + sendy + "\n message: " + message + "\n time: " + timeStam; 
                   
                    i++;
                }
               
            }

            return reply;
        }


    }
}
