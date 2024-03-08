using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class EmailSender
    {
        private static string[] sampleEmailBodyText =
        {
            "Nhập mã xác thực sau để tạo tài khoản quản lý tài chính: ",
            "Nhập mã xác thực sau để đổi mật khẩu: "
        };


        /// <summary>
        /// Tu dong tao ma xac thuc 6 so va gui email den dia chi toAddress
        /// Cac mau email tuong ung voi gia tri sampleIndex:<br />
        /// - 0: xac thuc lap tai khoan<br />
        /// - 1: xac thuc doi mat khau<br />
        /// </summary>
        public static string SendAuthenticationEmail(string toAddress, int sampleIndex)
        {
            string fromAddress = "trungdzlhp@gmail.com";
            string password = "eqnb amki ojds dbvp";
            MailAddress to = new MailAddress(toAddress);
            MailAddress from = new MailAddress(fromAddress);
            MailMessage email = new MailMessage(from, to);
            Random random = new Random();
            string code = random.Next(0, 1000000).ToString("D6");
            email.Subject = "Xác thực";
            email.Body = sampleEmailBodyText[sampleIndex] + code;
            SendEmail(email, fromAddress, password);
            return code;
        }

        /// <summary>
        /// Gui 1 email bat ky thong qua MailMessage
        /// </summary>
        public static void SendEmail(MailMessage email, string fromAddress, string password)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential(fromAddress, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(email);
                MessageBox.Show("Successfully");
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
