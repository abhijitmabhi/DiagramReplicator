using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramReplicator
{
    public partial class MindFusionViewer : Form
    {
        public MindFusionViewer()
        {
            InitializeComponent();
            diagramView2.AllowInplaceEdit = true;
            diagram2.DiagramStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(192, 255, 255));
        }

        private void MindFusionViewer_Load(object sender, EventArgs e)
        {
            this.diagram1.DefaultShape = MindFusion.Diagramming.Shapes.Rectangle;
        }

        private void diagramView2_Click(object sender, EventArgs e)
        {
            ShapeNode b = diagram1.Factory.CreateShapeNode(10, 10, 40, 20);
            b.Text = "This is a node";
            //b.TextColor = Color.Red;
            b.Font = new Font("Times New Roman", 6, GraphicsUnit.World);
        }

        private void shapeToolBar_shapeClicked(object sender, MindFusion.Diagramming.ShapeEventArgs e)
        {
            diagram2.DefaultShape = e.Shape;
        }

        private void shapeToolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }
    }
}
