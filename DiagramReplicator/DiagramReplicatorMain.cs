using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DiagramReplicator
{
    public class DiagramReplicatorMain
    {
        private List<DiagramElements> diagramElementsList;
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
                EA.Diagram diag;

                switch (Rep.GetContextItemType())
                {
                    case EA.ObjectType.otPackage:
                        {
                            MessageBox.Show("Please select the entire diagram");
                            break;
                        }
                    case EA.ObjectType.otElement:
                        {
                            MessageBox.Show("Please select the entire diagram");
                            break;
                        }

                    case EA.ObjectType.otDiagram:
                        {
                            diag = Rep.GetContextObject();
                            diagramElementsList = new List<DiagramElements>();
                            foreach (EA.DiagramObject diagramObj in diag.DiagramObjects)
                            {
                                int diagramId = diagramObj.DiagramID;
                                EA.Diagram diagram = Rep.GetDiagramByID(diagramId);

                                int elementId = diagramObj.ElementID;
                                EA.Element element = Rep.GetElementByID(elementId);

                                DiagramElements diagramElement = new DiagramElements();
                                diagramElement.elementName = element.Name;
                                diagramElement.elementType = element.MetaType;
                                diagramElement.elementShape = element.ElementID.ToString();

                                diagramElementsList.Add(diagramElement);
                            }
                            break;
                        }
                    
                }

                StringWriter sw = new StringWriter();
                XmlSerializer s = new XmlSerializer(diagramElementsList.GetType());
                s.Serialize(sw, diagramElementsList);
                string xmlString = sw.ToString();

                MindFusionViewer form = new MindFusionViewer();
                form.setJsonContent(xmlString);
                form.Show();
           
            }
            else if (ItemName == "About")
            {
                
            }
        }

        public void EA_Disconnect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
     
    }
}
