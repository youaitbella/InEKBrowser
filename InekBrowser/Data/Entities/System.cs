
namespace org.inek.InekBrowser.Data.Entities {
    public class System {
        
        public string Category { get; set; }
        public int Partition { get; set; } // DRG only
        public string Code { get; set; }
        public string Text { get; set; }
        public int Calculated { get; set; } // DRG only
    }
}
