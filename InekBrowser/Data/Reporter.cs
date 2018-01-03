using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using combit.ListLabel22;
using combit.ListLabel22.DataProviders;

namespace org.inek.InekBrowser.Data {
    public enum OutputType {
        Preview,
        PDF,
        Print,
        Design
    }

    public class Reporter {
        private ListLabel _ll;

        public Reporter() {
            InitLL();
        }


        private void InitLL() {
            _ll = new ListLabel();
            //_ll.LicensingInfo = "XwdqEQ";   //tx5vDg
            _ll.LicensingInfo = "tx5vDg";
            _ll.MaxRTFVersion = 65280;
            _ll.PreviewControl = null;
            _ll.Unit = LlUnits.Millimeter_1_100;
        }

        public void AddVar(string varName, object varValue) {
            _ll.Variables.Add(varName, varValue);
        }

        private void Object2Vars(Object obj) {
            if (obj == null) { return; }
            string prefix = "@" + obj.GetType().Name + ".";
            foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties()) {
                AddVar(prefix + propertyInfo.Name, propertyInfo.GetValue(obj, null));
            }
        }

        public void Perform<T>(LlProject projectType, LlAutoMasterMode mastermode, OutputType outputType, string layoutFile, IEnumerable<T> proposals, string dataMember, string fileName = "", string outputPath = "") {
            ObjectDataProvider provider = new ObjectDataProvider(proposals, 2);
            provider.RootTableName = dataMember;
            Perform(projectType, mastermode, outputType, layoutFile, provider, dataMember, fileName, outputPath);
        }

        public void Perform(LlProject projectType, LlAutoMasterMode mastermode, OutputType outputType, string layoutFile, object data, string dataMember, string fileName = "", string outputPath = "") {
            ObjectDataProvider provider = new ObjectDataProvider(data, 2);
            provider.RootTableName = data.GetType().Name;
            Perform(projectType, mastermode, outputType, layoutFile, provider, dataMember, fileName, outputPath);
        }

        public void Perform(LlProject projectType, LlAutoMasterMode mastermode, OutputType outputType, string layoutFile, DataSet dataSet, string dataMember, string fileName = "", string outputPath = "") {
            AdoDataProvider provider = new AdoDataProvider(dataSet);
            Perform(projectType, mastermode, outputType, layoutFile, provider, dataMember, fileName, outputPath);
        }

        public void Perform(LlProject projectType, LlAutoMasterMode mastermode, OutputType outputType, string layoutFile, IDataProvider provider, string dataMember, string fileName = "", string outputPath = "") {

            _ll.AutoProjectType = projectType;

            //SqlConnection connection = new SqlConnection(Properties.Settings.Default.PeppVV);
            //SqlConnectionDataProvider provider = new SqlConnectionDataProvider(connection);


            _ll.DataSource = provider;
            _ll.DataMember = dataMember;
            _ll.AutoMasterMode = mastermode;


            _ll.AutoShowSelectFile = false;
            _ll.AutoProjectFile = layoutFile;
            _ll.AutoShowPrintOptions = false;
            _ll.NoParameterCheck = true;

            try {
                if (outputType == OutputType.Design || !File.Exists(layoutFile)) {
                    _ll.AutoFileAlsoNew = true;
                    _ll.Design();
                } else if (outputType == OutputType.PDF) {
                    _ll.AutoShowSelectFile = false;
                    _ll.ExportOptions.Clear();
                    _ll.ExportOptions.Add(LlExportOption.ExportTarget, "PDF");
                    _ll.ExportOptions.Add(LlExportOption.ExportFile, fileName);
                    _ll.ExportOptions.Add(LlExportOption.ExportPath, outputPath);
                    _ll.ExportOptions.Add(LlExportOption.ExportQuiet, "1");
                    _ll.ExportOptions.Add(LlExportOption.ExportShowResult, "1");
                    //_ll.ExportOptions.Add(LlExportOption.PdfFontMode, "3");
                    _ll.Print(LlProject.List, layoutFile, false, LlPrintMode.Export);
                } else {
                    _ll.AutoDestination = outputType == OutputType.Preview
                                             ? LlPrintMode.Preview
                                             : LlPrintMode.Normal;
                    _ll.Print();
                }
            } catch (LL_NoData_Exception e) {
                MessageBox.Show("Keine Daten für den Druck vorhanden!\r\n" + e.Message,
                                "Berichtsdruck",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            } catch (LL_User_Aborted_Exception) {

            } catch (Exception e) {
                throw e;
            } finally {
                _ll.Dispose();
            }
        }

    }
}
