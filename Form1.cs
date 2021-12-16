using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var fileInfo = new FileInfo("C:\\Users\\wazer\\source\\repos\\EML\\sources\\Mail avec pièce jointe.eml");
            var eml = MsgReader.Mime.Message.Load(fileInfo);
            

            if (eml.Headers != null)
            {
                if (eml.Headers.To != null)
                {
                    txt_chemin.Text = fileInfo.FullName;
                    foreach (var recipient in eml.Headers.To)
                    {
                        var to = recipient.Address;
                        txt_To.Text = to;
                        
                    }
                }
                if (eml.Headers.From != null)
                {
                    var from = eml.Headers.From;
                    txt_from.Text = from.Address;

                }
            }

            var subject = eml.Headers.Subject;
            txt_objet.Text = subject;

            if (eml.TextBody != null)
            {
                var textBody = System.Text.Encoding.UTF8.GetString(eml.TextBody.Body);
                txt_msg.Text = textBody;

                if (eml.Attachments != null)
                {
                    var Attachments = eml.Attachments.ToArray();

                    //var filtre = Attachments.Find(Attachments.ContentType.ToString().Contains("image"));

                    //var subset = from theattachment in Attachments where theattachment.FileName = "11";

                    //eml.Attachments.ToArray().;
                    foreach (var attachment in Attachments)
                    {
                        var piece_j = "FileName : " + attachment.FileName + " \r\n";
                        piece_j += "ContentId : " + attachment.ContentId + " \r\n";
                        piece_j += "ContentDescription : " + attachment.ContentDescription + " \r\n";
                        piece_j += "ContentDisposition : " + attachment.ContentDisposition + " \r\n";
                        piece_j += "ContentTransferEncoding : " + attachment.ContentTransferEncoding + " \r\n";
                        piece_j += "ContentType : " + attachment.ContentType + " \r\n";
                        piece_j += "Body : " + attachment.Body + " \r\n";
                        piece_j += "BodyEncoding : " + attachment.BodyEncoding + " \r\n";
                        piece_j += "IsAttachment : " + attachment.IsAttachment + " \r\n";
                        piece_j += "IsInline : " + attachment.IsInline + " \r\n";
                        piece_j += "IsMultiPart : " + attachment.IsMultiPart + " \r\n";
                        piece_j += "IsText : " + attachment.IsText + " \r\n";
                        piece_j += "MessageParts : " + attachment.MessageParts + " \r\n";
                        piece_j += "\r\n";
                        //txt_Img.Text += piece_j;

                        if (attachment.ContentType.ToString().Contains("image"))
                        {
                            txt_Application.Text += piece_j;
                        }
                        else
                        {
                            txt_Img.Text = "Y'a rien à voir ici.";
                        }

                        if (attachment.ContentType.ToString().Contains("audio"))
                        {
                            txt_Application.Text += piece_j;
                        }
                        else
                        {
                            txt_Audio.Text = "Y'a rien à voir ici.";
                        }

                        if (attachment.ContentType.ToString().Contains("application"))
                        {
                            txt_Application.Text += piece_j;
                        }
                        else
                        {
                            txt_Application.Text = "Y'a rien à voir ici.";
                        }

                    }



                }
            }

            if (eml.HtmlBody != null)
            {
                var htmlBody = System.Text.Encoding.UTF8.GetString(eml.HtmlBody.Body);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
