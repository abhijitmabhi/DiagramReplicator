using MindFusion.Diagramming;
using MindFusion.Diagramming.Layout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace DiagramReplicator
{
    public partial class MindFusionViewer : Form
    {
        private XmlDocument xmlDiagram;
        public MindFusionViewer()
        {
            InitializeComponent();
            diagramView2.AllowInplaceEdit = true;
            diagram2.DiagramStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(192, 255, 255));
        }

        private void MindFusionViewer_Load(object sender, EventArgs e)
        {
            this.diagram2.DefaultShape = MindFusion.Diagramming.Shapes.Rectangle;
        }

        private void diagramView2_Click(object sender, EventArgs e)
        {
            //ShapeNode b = diagram2.Factory.CreateShapeNode(10, 10, 40, 20);
            //b.Text = "This is a node";
            //b.Font = new Font("Times New Roman", 6, GraphicsUnit.World);
        }

        private void shapeToolBar_shapeClicked(object sender, MindFusion.Diagramming.ShapeEventArgs e)
        {
            diagram2.DefaultShape = e.Shape;
        }

        private void shapeToolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }

        public void setJsonContent(string content)
        {
            xmlDiagram = new XmlDocument();
            xmlDiagram.LoadXml(content);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //this.diagram1.DefaultShape = Shapes.Rectangle;
            Dictionary<string, DiagramNode> nodeMap = new Dictionary<string, DiagramNode>();
            var bounds = new RectangleF(0, 0, 30, 20);

            XmlNodeList nodes = xmlDiagram.SelectNodes("/ArrayOfDiagramElements/DiagramElements/elementName");
            foreach (XmlElement node in nodes)
            {
                ShapeNode diagramNode = diagram2.Factory.CreateShapeNode(bounds);
                nodeMap[node.GetAttribute("id")] = diagramNode;
                diagramNode.Text = node.InnerText;
            }

            // Arrange the graph
            LayeredLayout layout = new LayeredLayout();
            layout.LayerDistance = 12;
            layout.Arrange(diagram2);
        }
    }
}
