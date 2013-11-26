using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.inek.PeppBrowser.Data.Entities {
    public class PeppInfo {

        [Column("kd_Pepp")]
        public string Code { get; set; }

        [Column("kd_FaelleAnzahl")]
        public int CaseCount { get; set; }

        [Column("kd_FaelleAnzahlVgst1")]
        public int CaseCountPayLevel1 { get; set; }

        [Column("kd_FaelleAnzahlVgst2")]
        public int CaseCountPayLevel2 { get; set; }

        [Column("kd_FaelleAnzahlVgst3")]
        public int CaseCountPayLevel3 { get; set; }

        [Column("kd_FaelleAnzahlVgst4")]
        public int CaseCountPayLevel4 { get; set; }

        [Column("kd_FaelleAnzahlVgst5")]
        public int CaseCountPayLevel5 { get; set; }

        [Column("kd_FaelleAnteilVstufe1")]
        public decimal CaseFractionPayLevel1 { get; set; }

        [Column("kd_FaelleAnteilVstufe2")]
        public decimal CaseFractionPayLevel2 { get; set; }

        [Column("kd_FaelleAnteilVstufe3")]
        public decimal CaseFractionPayLevel3 { get; set; }

        [Column("kd_FaelleAnteilVstufe4")]
        public decimal CaseFractionPayLevel4 { get; set; }

        [Column("kd_FaelleAnteilVstufe5")]
        public decimal CaseFractionPayLevel5 { get; set; }

        [Column("kd_TageAnzahlVgst1")]
        public int DayCountPayLevel1 { get; set; }

        [Column("kd_TageAnzahlVgst2")]
        public int DayCountPayLevel2 { get; set; }

        [Column("kd_TageAnzahlVgst3")]
        public int DayCountPayLevel3 { get; set; }

        [Column("kd_TageAnzahlVgst4")]
        public int DayCountPayLevel4 { get; set; }

        [Column("kd_TageAnzahlVgst5")]
        public int DayCountPayLevel5 { get; set; }

        [Column("kd_VwdSummeTage")]
        public int LosSumDays { get; set; }

        [Column("kd_VwdMw")]
        public decimal LosAverage{ get; set; }

        [Column("kd_VwdStd")]
        public decimal LosHours { get; set; }

        [Column("kd_VwdHK")]
        public decimal LosHc { get; set; }  // hc = homogeneity coefficient

        [Column("kd_VwdVonVgst1")]
        public int LosFromPayLevel1 { get; set; }

        [Column("kd_VwdBisVgst1")]
        public int LosToPayLevel1 { get; set; }

        [Column("kd_BewertungsrelationTagVgst1")]
        public decimal ValuationRatLevel1 { get; set; }

        [Column("kd_VwdVonVgst2")]
        public int LosFromPayLevel2 { get; set; }

        [Column("kd_VwdBisVgst2")]
        public int LosToPayLevel2 { get; set; }

        [Column("kd_BewertungsrelationTagVgst2")]
        public decimal ValuationRatLevel2 { get; set; }

        [Column("kd_VwdVonVgst3")] 
        public int LosFromPayLevel3 { get; set; }

        [Column("kd_VwdBisVgst3")]
        public int LosToPayLevel3 { get; set; }

        [Column("kd_BewertungsrelationTagVgst3")]
        public decimal ValuationRatLevel3 { get; set; }

        [Column("kd_VwdVonVgst4")]
        public int LosFromPayLevel4 { get; set; }

        [Column("kd_VwdBisVgst4")]
        public int LosToPayLevel4 { get; set; }

        [Column("kd_BewertungsrelationTagVgst4")]
        public decimal ValuationRatLevel4 { get; set; }

        [Column("kd_VwdVonVgst5")]
        public int LosFromPayLevel5 { get; set; }

        [Column("kd_VwdBisVgst5")]
        public int LosToPayLevel5 { get; set; }

        [Column("kd_BewertungsrelationTagVgst5")]
        public decimal ValuationRatLevel5 { get; set; }

        [Column("kd_GeschlechtM")]
        public decimal GenderMale { get; set; }

        [Column("kd_GeschlechtW")]
        public decimal GenderFemale { get; set; }

        [Column("kd_AlterMw")]
        public decimal AgeAverage { get; set; }

        [Column("kd_AlterStd")]
        public decimal AgeHours { get; set; }

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
        public decimal DayCostsHour { get; set; }

        [Column("kd_TageskostenHK")]
        public decimal DayCostsHc { get; set; } // hc = homogeneity coefficient

    }
}
