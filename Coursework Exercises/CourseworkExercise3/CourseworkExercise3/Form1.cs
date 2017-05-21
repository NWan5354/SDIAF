using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CourseworkExercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtToEmail.Text != string.Empty)
            {
                MailMessage mail = new MailMessage();

                NetworkCredential cred = new NetworkCredential(lblFrom.Text, "sausage4321-");

                mail.To.Add(txtToEmail.Text);
                mail.Subject = txtSubject.Text;

                mail.From = new MailAddress(lblFrom.Text);
                mail.IsBodyHtml = true;
                mail.Body = txtMessageToSend.Text;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = cred;
                smtp.Port = 587;

                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Successful, Email Sent", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtToEmail.Text = string.Empty;
                    txtSubject.Text = string.Empty;
                    txtMessageToSend.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failed to deliver to recipient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void btnAddressBook_Click(object sender, EventArgs e)
        {
            Form2 openAddressBook = new Form2();
            openAddressBook.Show();
        }
    }
}
