using System.Diagnostics;

namespace FormConvertXmlToXlsx
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

        }

        private string passingArguments;

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openXml = new OpenFileDialog())
            {
                openXml.Filter = "Все файлы (*.*)|*.*";
                openXml.FilterIndex = 1;
                openXml.RestoreDirectory = true;

                if (openXml.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openXml.FileName;
                    passingArguments = '"'+openXml.FileName+'"'+' '+ '"' + Path.ChangeExtension(openXml.FileName, ".xlsx")+ '"';
                }
            }

            Process.Start(new ProcessStartInfo("C:/ReadyWork/ConvertXmlToXlsxUtility/ConvertXmlToXlsxUtility.exe", passingArguments));
        }
    }
}
