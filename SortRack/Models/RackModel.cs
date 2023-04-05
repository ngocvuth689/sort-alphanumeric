using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortRack.Models
{
    public class TestModel
    {
        public bool HAS_ACCESS { get; set; }
        public bool HAS_ERROR { get; set; }
        public string ERROR_MESSAGE { get; set; }
        public List<RackModel> RESULT { get; set; }
    }
    public class RackModel
    {
        public decimal ActualPickingQuantity { get; set; }
        public decimal DetailNo { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public decimal FormulaTotal { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public decimal InstructPickingQuantity { get; set; }
        public DateTime? IsuueDate { get; set; }
        public string LineProduction { get; set; }
        public string LotNo { get; set; }
        public int LotID { get; set; }
        public string PartName { get; set; }
        public string PartNo { get; set; }
        public DateTime PickingDate { get; set; }
        public string PlanPartName { get; set; }
        public string PlanPartNo { get; set; }
        public decimal PlanQuantity { get; set; }
        public DateTime? ProductionDate { get; set; }
        public bool Result { get; set; }
        public string SlipNo { get; set; }
        public string RackNo { get; set; }
        public int Status { get; set; } = 0;
        public int id { get; set; }
        public List<string> full_barcode { get; set; }
        public decimal CurrentPickingQuantity { get; set; } = 0;
        public List<PickResultModel> PickResults { get; set; }
        public string Supplier { get; set; }
        public int IIT_ID { get; set; }

    }

    public class PickResultModel
    {
        public string FULL_BARCODE { get; set; }
        public decimal PICK_QUANTITY { get; set; }
    }
}
