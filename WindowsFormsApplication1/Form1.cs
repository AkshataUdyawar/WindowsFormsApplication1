using ASPSnippets.SmsAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SendSMS()
        {
            SMS.APIType = SMSGateway.Site2SMS;
            SMS.MashapeKey = "IxzaIGxT7zmshiJG8ewk4MeiyJolp1WRfo8jsnGUdVzGvqX1Wj";
            SMS.Username = "9773459137";
            SMS.Password = "1553442";
                //Single SMS
                SMS.SendSms("9773459137", "Hello world");
            
                //Multiple SMS
            //    List<string> numbers = txtRecipientNumber.Text.Trim().Split(',').ToList();
              //  SMS.SendSms(numbers, txtMessage.Text.Trim());
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ACCOUNT_SID = "AC32cdc569e7727c2e22e2535ec467e4f2";
            string AUTH_TOKEN = "b0822628e142879f1c0440fecec625e2";
            try
            {
                SendSMS();
                //****************uisng twilio
                //var twilio = new TwilioRestClient(ACCOUNT_SID, AUTH_TOKEN);
                //var message = twilio.SendMessage(
                //    "+19382232915", // From (Replace with your Twilio number)
                //    "+919773459137", // To (Replace with your phone number)
                //    "Hello world"
                //    );

                //if (message.RestException != null)
                //{
                //    var error = message.RestException.Message;
                //    Console.WriteLine(error);
                //    Console.Write("Press any key to continue.");
                //    Console.ReadKey();
                //}
                //******************************************************
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
