using DevExpress.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T263441 {
    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid)
            : base(grid) {

        }
        protected override string ViewName { get { return "MyGridView"; } }
        protected override BaseGridController CreateDataController() { return new MyDataController(); }
    }
}
