using BrightIdeasSoftware;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace infoviewer
{    
    public partial class Form1 : Form
    {
        dbworker dbw;
        public Form1()
        {
            InitializeComponent();
            if (connectdb())
            {
                GetComps();
                TreesInit();
            }
        }

        private bool connectdb()
        {
            INIManager config = new INIManager("config.ini");
            string db_server = config.Read("server", "db");
            string db_user = config.Read("user", "db");
            string db_pass = config.Read("pass", "db");
            string db_database = config.Read("database", "db");

            dbw = new dbworker(db_server, db_user, db_pass, db_database);
            return dbw.online();
        }

        public void GetComps()
        {
            var comps = dbw.getComps();
            listComps.DataSource = comps;
            listComps.DisplayMember = "name";
            listComps.ValueMember = "id";
        }

        private void listComps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listComps.SelectedIndex != -1)
            {
                try
                {
                    int id = (int)listComps.SelectedValue;

                    var cpu = dbw.getInfo(id, "CPU");
                    var dd = dbw.getInfo(id, "DD");
                    var dev = dbw.getInfo(id, "dev");
                    var gc = dbw.getInfo(id, "GC");
                    var mb = dbw.getInfo(id, "MB");
                    var net = dbw.getInfo(id, "Net");
                    var os = dbw.getInfo(id, "OS");
                    var ram = dbw.getInfo(id, "RAM");
                    var ram2 = dbw.getInfo(id, "RAM2");
                    var soft = dbw.getInfo(id, "SOFT");

                    CPU_info.Roots = dataAdapter(cpu);
                    DD_info.Roots = dataAdapter(dd);
                    Dev_info.Roots = dataAdapter(dev);
                    GC_info.Roots = dataAdapter(gc);
                    MB_info.Roots = dataAdapter(mb);
                    Net_info.Roots = dataAdapter(net);
                    OS_info.Roots = dataAdapter(os);
                    RAM_info.Roots = dataAdapter(ram);
                    RAM2_info.Roots = dataAdapter(ram2);
                    Soft_info.Roots = dataAdapter(soft);
                    
                    CPU_info.ExpandAll();
                    DD_info.ExpandAll();
                    //Dev_info.ExpandAll();
                    GC_info.ExpandAll();
                    MB_info.ExpandAll();
                    //Net_info.ExpandAll();
                    OS_info.ExpandAll();
                    RAM_info.ExpandAll();
                    RAM2_info.ExpandAll();
                    //Soft_info.ExpandAll();

                    CPU_info.AutoResizeColumns();
                    DD_info.AutoResizeColumns();
                    Dev_info.AutoResizeColumns();
                    GC_info.AutoResizeColumns();
                    MB_info.AutoResizeColumns();
                    Net_info.AutoResizeColumns();
                    OS_info.AutoResizeColumns();
                    RAM_info.AutoResizeColumns();
                    RAM2_info.AutoResizeColumns();
                    Soft_info.AutoResizeColumns();
                }
                catch(Exception ex)
                {

                }
            }
        }

        private List<TrNode> dataAdapter(DataTable input)
        {
            List<TrNode> output = new List<TrNode>();

            foreach (DataRow row in input.Rows)
            {
                var parent = new TrNode(ParseName(row), "-");
                foreach (DataColumn column in input.Columns)
                {
                    parent.Children.Add(new TrNode(column.ColumnName, row[column].ToString()));                    
                }
                output.Add(parent);
            }

            return output;
        }

        private string ParseName(DataRow dr)
        {
            string parserow = dr.Table.Columns[1].ToString().Remove(3);//Пытаемся найти префик в заголовке столбца, ЖОСКО
            switch (parserow)
            {
                case "CPU":
                    return dr["CPU_Name"].ToString();
                case "DD_":
                    return dr["DD_Caption"].ToString();
                case "dev":
                    return dr["dev_Description"].ToString();
                case "GC_":
                    return dr["GC_Caption"].ToString();
                case "MB_":
                    return dr["MB_Name"].ToString();
                case "Net":
                    return dr["Net_Description"].ToString() + "(" + dr["Net_IPAddress"].ToString().Split(',')[0] + ")";
                case "OS_":
                    return dr["OS_Caption"].ToString();
                case "RAM":
                    if(dr.Table.Columns[1].ToString().Remove(4) == "RAM_")
                        return "Бесполезная инфа";
                    else
                        return dr["RAM2_Manufacturer"].ToString()+" ("+ dr["RAM2_PartNumber"].ToString().Trim()+")";
                case "SOF":
                    return dr["SOFT_DisplayName"].ToString();
                default:
                    return "myname";
            }
        }

        private void TreeInit(TreeListView tree)
        {
            tree.CanExpandGetter = x => (x as TrNode).Children.Count > 0;
            tree.ChildrenGetter = x => (x as TrNode).Children;

            // create the tree columns and set the delegates to print the desired object proerty
            var nameCol = new OLVColumn("Ключ", "Name");
            var col1 = new OLVColumn("Значение", "Column1");
            nameCol.AspectGetter = x => (x as TrNode).Name;
            col1.AspectGetter = x => (x as TrNode).Column1;

            // add the columns to the tree
            tree.Columns.Add(nameCol);
            tree.Columns.Add(col1);

            // set the tree roots
        }
        private void TreesInit()
        {
            TreeInit(CPU_info);
            TreeInit(DD_info);
            TreeInit(Dev_info);
            TreeInit(GC_info);
            TreeInit(MB_info);
            TreeInit(Net_info);
            TreeInit(OS_info);
            TreeInit(RAM2_info);
            TreeInit(RAM_info);
            TreeInit(Soft_info);
        }
    }
    class TrNode
    {
        public string Name { get; set; }
        public string Column1 { get; private set; }
        //public string Column2 { get; private set; }
        //public string Column3 { get; private set; }
        public List<TrNode> Children { get; private set; }
        public TrNode(string name, string col1)
        {
            this.Name = name;
            this.Column1 = col1;
            //this.Column2 = col2;
            //this.Column3 = col3;
            this.Children = new List<TrNode>();
        }
    }
}
