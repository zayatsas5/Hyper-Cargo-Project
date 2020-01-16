using System;
using System.IO;
using System.Windows.Forms;


namespace HyperCargoProject.Classes
{
    class Document
    {

        public static void CreateDirectory()
        {
            string MyDocumentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (Directory.Exists(MyDocumentPath + "\\Orders") == false)
            {
                Directory.CreateDirectory(MyDocumentPath + "\\Orders");
                CreateDocument();
            }
            else
            {
                CreateDocument();
            }
        }

        private static void CreateDocument()
        {

        }
    }
}
