// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SortRack.Models;
using System.Linq;

Console.WriteLine("Hello, World!");

var stringRackObj = "[{'ActualPickingQuantity':0.0,'DetailNo':1.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'DIAL PLATE (SP&FU)-K58M','PartNo':'050206865900102','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'A8','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':7.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'P-LENS (NEUTRAL)-K58M','PartNo':'052505639900000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B2.2','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':8.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'P-LENS (HIGHT BEAM)','PartNo':'052505640900000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B2.2','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':9.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'P-LENS (FI)','PartNo':'052505655900000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B2.2','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':13.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':5.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':5200.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'SZ0523001 PACKING (2)','PartNo':'057501140900000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B2.3','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':14.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':3.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':3120.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'PACKING','PartNo':'0575015089R0001','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B3.1','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':2.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'POINTER ASSY-KWWG','PartNo':'0503055069RA102','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B8.2','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':3.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'POINTER ASSY SP-KZVA','PartNo':'0503065729RA100','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'B8.3','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':12.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':3.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':3120.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'WATER PROOF SEAL ','PartNo':'0552044189R0000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'C1.1','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':5.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'GLASS-K58M','PartNo':'051202157900004','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'D10','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':11.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'LAMP CORD ASSY','PartNo':'0551139569MA000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'F11','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':16.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'MOVEMENT ASSY','PartNo':'M032000019M0000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'F12','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':6.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'LOWER CASE','PartNo':'051409238900003','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'F2','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':15.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'MG-26 FUEL MOVEMENT COMP-KWWY','PartNo':'15700619890A002','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'L12','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':4.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'REFLECTOR-K58M','PartNo':'050702560900001','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'L8','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0},{'ActualPickingQuantity':0.0,'DetailNo':10.0,'ErrorCode':null,'ErrorMessage':null,'FormulaTotal':1.00,'GroupCode':'','GroupName':null,'InstructPickingQuantity':1040.0000000,'IsuueDate':'2022-09-22T00:00:00','LineProduction':'000M3','LotNo':'2390','LotID':0,'PartName':'EMBLEM WING MARK','PartNo':'0531019179R0000','PickingDate':'2022-09-22T00:00:00','PlanPartName':'COMBINATION METER-K2JH 012','PlanPartNo':'HP1191012A0CO01EX','PlanQuantity':1040.00,'ProductionDate':'2022-09-26T00:00:00','Result':true,'SlipNo':'22090001535','RackNo':'M1','Status':0,'id':0,'full_barcode':null,'CurrentPickingQuantity':0.0,'PickResults':null,'Supplier':null,'IIT_ID':0}]";
List<RackModel> list = new List<RackModel>();
//var test = JsonConvert.SerializeObject(stringRackObj);
list = JsonConvert.DeserializeObject<List<RackModel>>(stringRackObj);

var alpha = new AlphanumericSortedPickListParts();
list.Sort(alpha);
var lstHc = list.Where(s => s.RackNo.Contains("HC")).ToList();
list.RemoveAll(s => s.RackNo.Contains("HC"));
list.AddRange(lstHc);
foreach (var item in list)
{
    Console.WriteLine(item.RackNo+"-"+item.PartNo);
}

public class AlphanumericSortedPickListParts : List<RackModel>, IComparer<RackModel>
{
    public int Compare(RackModel? x, RackModel? y)
    {
        int a, b;
        int C, i, j;
        string Xtemp = x.RackNo.Replace(".", "");
        string Ytemp = y.RackNo.Replace(".", "");
        for (i = 0; i < x.RackNo.Length - 1; i++)
        {
            string S = Xtemp.Substring(i);
            if (int.TryParse(S, out a)) break;
        }
        for (j = 0; j < y.RackNo.Length - 1; j++)
        {
            string S = Ytemp.Substring(j);
            if (int.TryParse(S, out b)) break;
        }
        C = string.Compare(x.RackNo.Substring(0, i), y.RackNo.Substring(0, j));
        if (C == 0)
        {
            List<int> lstX  = x.RackNo.Substring(i, x.RackNo.Length - i).Split(".").Where(s => !string.IsNullOrEmpty(s)).Select(s => int.Parse(s)).ToList();
            List<int> lstY  = y.RackNo.Substring(j, y.RackNo.Length - j).Split(".").Where(s => !string.IsNullOrEmpty(s)).Select(s => int.Parse(s)).ToList();
            int lengthLstX = lstX.Count;
            int lengthLstY = lstY.Count;
            var minLength = Math.Min(lstX.Count, lstY.Count);
            for (int t = 0; t < minLength; t++)
            {
                C = compareNumber(lstX[t], lstY[t]);
                if (C == 0)
                {
                    if (t == minLength - 1)
                    {
                        C = compareNumber(lengthLstX, lengthLstY);
                        if (C == 0)
                        {
                            return string.Compare(x.PartNo,y.PartNo);
                        }
                    } else continue;
                };
                return C;
            }
        }
        return C;
    }

    private int compareNumber (int a, int b)
    {
        if (a == b) return 0;
        else if (a < b) return -1;
        else return 1;
    }
}