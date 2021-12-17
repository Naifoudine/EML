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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.eml)|*.eml|All files (*.*)|*.*";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\sources");
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileInfo = new FileInfo(openFileDialog.FileName);
                var eml = MsgReader.Mime.Message.Load(fileInfo);
                txt_chemin.Text = openFileDialog.FileName;

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

                        if (attachment.ContentType.ToString().Contains("image"))
                        {
                            var isImage = piece_j;
                            txt_Img.Text = isImage;

                        }
                        else if (attachment.ContentType.ToString().Contains("audio"))
                        {
                            var isAudio = piece_j;
                            txt_Audio.Text = isAudio;
                        }
                        else if (attachment.ContentType.ToString().Contains("application"))
                        {
                            var isAudio = piece_j;
                            txt_Application.Text = isAudio;
                        }
                        else
                        {
                            txt_Img.Text = "Il n'y a rien à voir ici !";
                            txt_Audio.Text = "Il n'y a rien à voir ici !";
                            txt_Application.Text = "Il n'y a rien à voir ici !";
                        }
                    }
                }
            }

            if (eml.HtmlBody != null)
            {
                var htmlBody = System.Text.Encoding.UTF8.GetString(eml.HtmlBody.Body);
            }

            }
        }

    }
}
