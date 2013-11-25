using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.inek.PeppBrowser.Data.Entities {
    public class PeppInfo {
        //kd_Pepp;kd_FaelleAnzahl;kd_FaelleAnzahlVgst1;kd_FaelleAnzahlVgst2;kd_FaelleAnzahlVgst3;kd_FaelleAnzahlVgst4;kd_FaelleAnzahlVgst5;kd_FaelleAnteilVstufe1;kd_FaelleAnteilVstufe2;kd_FaelleAnteilVstufe3;kd_FaelleAnteilVstufe4;kd_FaelleAnteilVstufe5;kd_TageAnzahlVgst1;kd_TageAnzahlVgst2;kd_TageAnzahlVgst3;kd_TageAnzahlVgst4;kd_TageAnzahlVgst5;kd_VwdSummeTage;kd_VwdMw;kd_VwdStd;kd_VwdHK;kd_VwdVonVgst1;kd_VwdBisVgst1;kd_BewertungsrelationTagVgst1;kd_VwdVonVgst2;kd_VwdBisVgst2;kd_BewertungsrelationTagVgst2;kd_VwdVonVgst3;kd_VwdBisVgst3;kd_BewertungsrelationTagVgst3;kd_VwdVonVgst4;kd_VwdBisVgst4;kd_BewertungsrelationTagVgst4;kd_VwdVonVgst5;kd_VwdBisVgst6;kd_BewertungsrelationTagVgst5;kd_GeschlechtM;kd_GeschlechtW;kd_AlterMw;kd_AlterStd;kd_AlterU28T;kd_AlterU01;kd_AlterU03;kd_AlterU06;kd_AlterU10;kd_AlterU16;kd_AlterU18;kd_AlterU30;kd_AlterU40;kd_AlterU50;kd_AlterU55;kd_AlterU60;kd_AlterU65;kd_AlterU75;kd_AlterU80;kd_AlterU99;kd_TageskostenMw;kd_TageskostenStd;kd_TageskostenHK

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


        //;kd_TageAnzahlVgst2;kd_TageAnzahlVgst3;kd_TageAnzahlVgst4;kd_TageAnzahlVgst5;kd_VwdSummeTage;kd_VwdMw;kd_VwdStd;kd_VwdHK;kd_VwdVonVgst1;kd_VwdBisVgst1;kd_BewertungsrelationTagVgst1;kd_VwdVonVgst2;kd_VwdBisVgst2;kd_BewertungsrelationTagVgst2;kd_VwdVonVgst3;kd_VwdBisVgst3;kd_BewertungsrelationTagVgst3;kd_VwdVonVgst4;kd_VwdBisVgst4;kd_BewertungsrelationTagVgst4;kd_VwdVonVgst5;kd_VwdBisVgst6;kd_BewertungsrelationTagVgst5;kd_GeschlechtM;kd_GeschlechtW;kd_AlterMw;kd_AlterStd;kd_AlterU28T;kd_AlterU01;kd_AlterU03;kd_AlterU06;kd_AlterU10;kd_AlterU16;kd_AlterU18;kd_AlterU30;kd_AlterU40;kd_AlterU50;kd_AlterU55;kd_AlterU60;kd_AlterU65;kd_AlterU75;kd_AlterU80;kd_AlterU99;kd_TageskostenMw;kd_TageskostenStd;kd_TageskostenHK
        //;2885;3340;0;;7901;90,8161;55,6836;0,6199;1;64;2,6548;65;115;2,1035;116;;1,9958;;;;;;;0,4368;0,5632;14,2414;2,7193;0,00;0,00;0,00;0,0115;0,069;0,5287;0,3908;0,00;0,00;0,00;0,00;0,00;0,00;0,00;0,00;0,00;559,0583;148,5074;0,7901

    }
}
