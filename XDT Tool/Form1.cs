using FatAntelope;
using FatAntelope.Writers;
using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XDT_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var source = new XmlDocument();
                source.LoadXml(textBoxSource.Text);
                var target = new XmlDocument();
                target.LoadXml(textBoxTarget.Text);

                var tree1 = new XTree(source);
                var tree2 = new XTree(target);


                XDiff.Diff(tree1, tree2);
                if (tree1.Root.Match == MatchType.Match && tree2.Root.Match == MatchType.Match && tree1.Root.Matching == tree2.Root)
                {
                    Message("Warning: No difference found!\n");                    
                }

                if (tree1.Root.Match == MatchType.NoMatch || tree2.Root.Match == MatchType.NoMatch)
                {
                    Message("Error: Root nodes must have the same name!\n");                  
                }
             
                var writer = new XdtDiffWriter();
                var patch = writer.GetDiff(tree2);
                textBoxXDT.Text = PrettyXml(patch.OuterXml);
                tabControl1.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                Message(ex.ToString());                
            }
        }

        static string PrettyXml(string xml)
        {
            var stringBuilder = new StringBuilder();

            var element = XElement.Parse(xml);

            var settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }
        
        private void Message(string text)
        {
            MessageBox.Show(this, text);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = null;
            textBoxTarget.Text = null;
            textBoxXDT.Text = null;
        }
    }
}
