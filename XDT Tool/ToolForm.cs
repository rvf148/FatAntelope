using FatAntelope;
using FatAntelope.Writers;
using Microsoft.Web.XmlTransform;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XDT_Tool
{
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var source = new XmlDocument();
                source.LoadXml(fastColoredTextBoxSource.Text);
                var target = new XmlDocument();
                target.LoadXml(fastColoredTextBoxTarget.Text);

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
                fastColoredTextBoxXDT.Text = PrettyXml(patch.OuterXml);
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
            settings.NewLineOnAttributes = false;

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                element.Save(xmlWriter);
            }

            return stringBuilder.ToString().Replace("utf-16","utf-8");
        }
        
        private void Message(string text)
        {
            MessageBox.Show(this, text);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to clear all tabs ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                fastColoredTextBoxSource.Clear();
                fastColoredTextBoxTarget.Clear();
                fastColoredTextBoxXDT.Clear();
                fastColoredTextBoxTransformed.Clear();              
                tabControl1.SelectedIndex = 0;
            }
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var xmlDoc = new XmlTransformableDocument())
                {
                    xmlDoc.PreserveWhitespace = true;
                    xmlDoc.Load(new MemoryStream(Encoding.ASCII.GetBytes(fastColoredTextBoxSource.Text)));
                    var logger = new TransformationLogger();
                    using (var xmlTrans = new XmlTransformation(new MemoryStream(Encoding.ASCII.GetBytes(fastColoredTextBoxXDT.Text)), logger))
                    {
                        if (xmlTrans.Apply(xmlDoc))
                        {
                            fastColoredTextBoxTransformed.Text = xmlDoc.OuterXml;                           
                        }
                        if (!string.IsNullOrEmpty(logger.Content))
                            Message(logger.Content);
                    }
                    tabControl1.SelectedIndex = 3;
                }
            }
            catch (Exception ex)
            {
                Message(ex.ToString());
            }
        }
    }
}
