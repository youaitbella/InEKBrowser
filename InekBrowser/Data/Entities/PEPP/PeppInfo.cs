using System.ComponentModel.DataAnnotations.Schema;

namespace org.inek.InekBrowser.Data.Entities.PEPP {
    public class PeppInfo {

        [Column("kd_Pepp")]
        public string Code { get; set; }

        [Column("kd_FaelleAnzahl")]
        public int CaseCount { get; set; }

        [Column("kd_VwdSummeTage")]
        public int LosSumDays { get; set; }

        [Column("kd_VwdMw")]
        public decimal LosAverage{ get; set; }

        [Column("kd_VwdStd")]
        public decimal LosStandard { get; set; }

        [Column("kd_VwdHK")]
        public decimal LosHc { get; set; }  // hc = homogeneity coefficient

        [Column("kd_GeschlechtM")]
        public decimal GenderMale { get; set; }

        [Column("kd_GeschlechtW")]
        public decimal GenderFemale { get; set; }

        [Column("kd_AlterMw")]
        public decimal AgeAverage { get; set; }

        [Column("kd_AlterStd")]
        public decimal AgeStandard { get; set; }

        [Column("kd_AlterU28T")]
        public decimal AgeBelow28Days { get; set; }

        [Column("kd_AlterU01")]
        public decimal AgeBelow1Year { get; set; }

        [Column("kd_AlterU03")]
        public decimal AgeBelow3Years { get; set; }

        [Column("kd_AlterU06")]
        public decimal AgeBelow6Years { get; set; }

        [Column("kd_AlterU10")]
        public decimal AgeBelow10Years { get; set; }

        [Column("kd_AlterU16")]
        public decimal AgeBelow16Years { get; set; }

        [Column("kd_AlterU18")]
        public decimal AgeBelow18Years { get; set; }

        [Column("kd_AlterU30")]
        public decimal AgeBelow30Years { get; set; }

        [Column("kd_AlterU40")]
        public decimal AgeBelow40Years { get; set; }

        [Column("kd_AlterU50")]
        public decimal AgeBelow50Years { get; set; }

        [Column("kd_AlterU55")]
        public decimal AgeBelow55Years { get; set; }

        [Column("kd_AlterU60")]
        public decimal AgeBelow60Years { get; set; }

        [Column("kd_AlterU65")]
        public decimal AgeBelow65Years { get; set; }

        [Column("kd_AlterU75")]
        public decimal AgeBelow75Years { get; set; }

        [Column("kd_AlterU80")] 
        public decimal AgeBelow80Years { get; set; }

        [Column("kd_AlterU99")]
        public decimal AgeBelow99Years { get; set; }

        [Column("kd_TageskostenMw")]
        public decimal DayCostsAverage { get; set; }

        [Column("kd_TageskostenStd")]
        public decimal DayCostsStandard { get; set; }

        [Column("kd_TageskostenHK")]
        public decimal DayCostsHc { get; set; } // hc = homogeneity coefficient

        [Column("kd_Degressionsendpunkt")]
        public int Degression { get; set; }

        public string StruCat { get; set; }
        public string PeppTxt { get; set; }
    }
}
