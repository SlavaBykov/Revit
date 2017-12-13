using Autodesk.Revit.DB;
using PipeManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Service
{
    class AddData
    {
        public List<Pipe> AddPipe(Document doc)
        {
            //коллектор на трубы
            FilteredElementCollector collectorPipe = new FilteredElementCollector(doc);
            //список труб
            List<Element> pipes = collectorPipe.OfCategory(BuiltInCategory.OST_PipeCurves).WhereElementIsNotElementType().ToList();
            List<Pipe> listPipe = new List<Pipe>();




            foreach (Element p in pipes)
            {
                double length = Converter.FutInMillimetr(p.LookupParameter("Длина").AsDouble());
                double diametr = Converter.FutInMillimetr(p.LookupParameter("Внешний диаметр").AsDouble());
                double area = Converter.SQ_FutIN_SQ_Metr(p.LookupParameter("Площадь").AsDouble());
                string typeIzol = p.LookupParameter("Тип изоляции").AsString();
                Pipe pipe = new Pipe(diametr, length, area, typeIzol);
                listPipe.Add(pipe);
            }
            return listPipe;
        }



        public IEnumerable<Izolation> AddIzolation(Document doc) {
            //коллектор на изоляцию
            FilteredElementCollector collectorIzolation = new FilteredElementCollector(doc);
            //список изоляции
            List<Element> pipesIzolations = collectorIzolation.OfCategory(BuiltInCategory.OST_PipeInsulations).WhereElementIsNotElementType().ToList();

            List<Izolation> izolTmp = new List<Izolation>();

            foreach (Element pipesIzolation in pipesIzolations)
            {
                ElementType type = doc.GetElement(pipesIzolation.GetTypeId()) as ElementType;
                //Получение Id типа семейства
                ElementId typeId = pipesIzolation.GetTypeId();
                //Получение типа семейства
                Element typeIzol = doc.GetElement(typeId);
                //Получаем имя типа

                string nameType = typeIzol.Name;
                double v = pipesIzolation.LookupParameter("Объем").AsDouble();
                double tube = (type.LookupParameter("Трубка")).AsDouble();
                double layer1 = (type.LookupParameter("Слой1")).AsDouble();
                double layer2 = (type.LookupParameter("Слой2")).AsDouble();
                double layer3 = (type.LookupParameter("Слой3")).AsDouble();
                Izolation izolation = new Izolation(nameType, tube, layer1, layer2, layer3);
                izolTmp.Add(izolation);
            }
            //Список уникальнх типов изоляции
            IEnumerable<Izolation> uniqIzolation = izolTmp.Distinct();
            return uniqIzolation;
        }

    }
}
