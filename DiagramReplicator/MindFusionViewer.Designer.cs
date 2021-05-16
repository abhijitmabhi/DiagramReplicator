
namespace DiagramReplicator
{
    partial class MindFusionViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ruler2 = new MindFusion.Diagramming.WinForms.Ruler();
            this.diagramView2 = new MindFusion.Diagramming.WinForms.DiagramView();
            this.diagram2 = new MindFusion.Diagramming.Diagram();
            this.shapeToolBar2 = new MindFusion.Diagramming.WinForms.ShapeToolBar();
            this.ruler2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ruler2
            // 
            this.ruler2.AllowDrop = true;
            this.ruler2.Controls.Add(this.diagramView2);
            this.ruler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruler2.Location = new System.Drawing.Point(29, 118);
            this.ruler2.Name = "ruler2";
            this.ruler2.Size = new System.Drawing.Size(1721, 844);
            this.ruler2.TabIndex = 0;
            this.ruler2.Text = "ruler2";
            this.ruler2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // diagramView2
            // 
            this.diagramView2.Diagram = this.diagram2;
            this.diagramView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diagramView2.LicenseKey = null;
            this.diagramView2.Location = new System.Drawing.Point(93, 41);
            this.diagramView2.Name = "diagramView2";
            this.diagramView2.Size = new System.Drawing.Size(1628, 803);
            this.diagramView2.TabIndex = 3;
            this.diagramView2.Text = "diagramView2";
            this.diagramView2.Click += new System.EventHandler(this.diagramView2_Click);
            // 
            // diagram2
            // 
            this.diagram2.TouchThreshold = 0F;
            // 
            // shapeToolBar2
            // 
            this.shapeToolBar2.ButtonImageSize = new System.Drawing.Size(24, 24);
            this.shapeToolBar2.DropDownArrows = true;
            this.shapeToolBar2.Location = new System.Drawing.Point(0, 0);
            this.shapeToolBar2.Name = "shapeToolBar2";
            this.shapeToolBar2.ShapeFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shapeToolBar2.Shapes = null;
            this.shapeToolBar2.ShowToolTips = true;
            this.shapeToolBar2.Size = new System.Drawing.Size(1781, 96);
            this.shapeToolBar2.TabIndex = 1;
            this.shapeToolBar2.ShapeClicked += new System.EventHandler<MindFusion.Diagramming.ShapeEventArgs>(this.shapeToolBar_shapeClicked);
            this.shapeToolBar2.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.shapeToolBar2_ButtonClick);
            // 
            // MindFusionViewer
            // 
            this.ClientSize = new System.Drawing.Size(1781, 1027);
            this.Controls.Add(this.shapeToolBar2);
            this.Controls.Add(this.ruler2);
            this.Name = "MindFusionViewer";
            this.Text = "Mind Fusion Viewer";
            this.ruler2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MindFusion.Diagramming.WinForms.Ruler ruler1;
        private MindFusion.Diagramming.WinForms.DiagramView diagramView1;
        private MindFusion.Diagramming.Diagram diagram1;
        private MindFusion.Diagramming.WinForms.ShapeToolBar shapeToolBar1;
        private MindFusion.Diagramming.WinForms.Ruler ruler2;
        private MindFusion.Diagramming.WinForms.DiagramView diagramView2;
        private MindFusion.Diagramming.Diagram diagram2;
        private MindFusion.Diagramming.WinForms.ShapeToolBar shapeToolBar2;
    }
}