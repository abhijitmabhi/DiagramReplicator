using System;
using System.Windows.Forms;

namespace DiagramReplicator
{
    public class DiagramReplicatorMain
    {
        public void EA_Connect(EA.Repository Rep)
        {

        }
        public object EA_GetMenuItems(EA.Repository Repository, string Location, string MenuName)
        {
            if (MenuName == "")
                return "-&diagramReplicator";
            else
            {
                String[] ret = { "Show in Mindfusion", "About" };
                return ret; 
            }
        }   
        public void EA_MenuClick(EA.Repository Rep, string Location, string MenuName, string ItemName)
        {
            if (ItemName == "Show in Mindfusion")
            {
                EA.Package pack;
                EA.Diagram diag;
                EA.Element ele;

                // TO_DO Why diag null?

                MindFusionViewer form = new MindFusionViewer();
                form.Show();
           
                Rep.ShowAddinWindow("Mind Fusion Viewer");
            }
            else if (ItemName == "About")
            {
                Rep.ShowAddinWindow("Mind Fusion Viewer");
            }
        }
        public void EA_Disconnect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
     
    }
}
