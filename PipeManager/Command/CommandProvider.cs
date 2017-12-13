using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace PipeManager.Command
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    class CommandProvider : IExternalCommand
    {
        List<IExternalCommand> commandProvider = new List<IExternalCommand>();

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            

            return Result.Succeeded;
        }


        public CommandProvider() {
            commandProvider.Add(new AddPipe());
            TaskDialog.Show("ComandProvider", "run");

        }


    }
}
