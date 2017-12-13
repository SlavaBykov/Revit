using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using PipeManager.Service;
using PipeManager.Entity;
using PipeManager.ExcelLogic;

namespace PipeManager.Controller
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class Controller : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application application = uiapp.Application;
            Document doc = uidoc.Document;

            AddData addData = new AddData();

            List<Pipe> listPipe = addData.AddPipe(doc);
            IEnumerable<Izolation> listIzolation = addData.AddIzolation(doc);


           double amountCoverPipe =  Vedomostlogic.AmountAreaOfPaint_Coat(listPipe);
           double amountDontCoverPipe = Vedomostlogic.AmountAreaOfPaint_DontCoat(listPipe);

           // RunExcel a = new RunExcel();

            //TaskDialog.Show("test", "count cover: " + amountCoverPipe + "; cont don't cover: " + amountDontCoverPipe);

            //foreach (Pipe pipeData in listPipe)
            //{
            //    TaskDialog.Show("Test", "" + pipeData.Diametr + ", " + pipeData.Length + ", " + pipeData.TypeIzol + "; " + pipeData.Area);
            //}

            

            foreach (Izolation iz in listIzolation)
            {
                TaskDialog.Show("Test", "" + iz.Type + "; " + iz.Tube + "; " + iz.Layer1 + "; " + iz.Layer2 + "; " + iz.Layer3);
            }


            //TaskDialog.Show("Test","Hello");
            return Result.Succeeded;
        }
    }
}
