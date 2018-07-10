using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace bRest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ip.Text = GetLocalIPAddress();
            GetButtons();

        }

        public void AddItem()
        {
       
      
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        string[] arr = new string[30];
        int[] arr1 = new int[30];

        public void GetButtons()
        {

            string constring = "Data Source='lcsmkcafe02, 3180';User ID=ad_salataox;Password=1@password;Initial Catalog=master";
            SqlConnection con = new SqlConnection(constring);

            SqlCommand sql = new SqlCommand("select * from Items", con);

            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int i = 0;


            foreach (DataRow dr in dt.Rows)
            {
         
                Button btn = new Button();
                int a = Convert.ToInt32(dr[1]);
                btn.Text = dr[0].ToString();
                
                btn.Click += (s, e) => { itemlist.Items.Add(btn.Text);
                    listprize.Items.Add(a.ToString());
                                            
                                                                        };
                btn.CssClass = "button";
                btn.ID = dr[0].ToString() + i;

                string str = btn.Text;

                panelButtons.Controls.Add(btn);
                hf1.Value = btn.ID;
                arr[i] = btn.ID;
                arr1[i] = i;
              
                i++;



                con.Close();
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
          
            object[] data = { "samer", "2" };
            DataTable dt;
          

            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Number");

            ViewState["DataTable"] = dt;

            DataRow dr = dt.NewRow();

            int i = 0;
            foreach(DataRow dr1 in dt.Rows)
            {
                dr1["Name"] = arr[i];
                dr1["Number"] = arr1[i];
                dt.Rows.Add(dr);
                i++;
            }

            DataList dm = new DataList();
      
        

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}