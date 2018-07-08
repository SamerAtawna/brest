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
            
            string constring = "Data Source=LAPTOP-4NRGSNGV\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=brest";
            SqlConnection con = new SqlConnection(constring);
              
            SqlCommand sql = new SqlCommand("select itemname from Items1", con);

            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
        
            int i = 0;
          

            foreach (DataRow dr in dt.Rows) { 

                Button btn = new Button();
                btn.Text = dr[0].ToString();
            
                btn.CssClass = "button";
                btn.ID = dr[0].ToString()+i;
                btn.Click += AddItem; 
                
                panelButtons.Controls.Add(btn);
                hf1.Value = btn.ID;

                arr[i] = dr[0].ToString();
                arr1[i] = i;
                i++;
            
         


            con.Close();
        }

        private void AddItem(object sender, EventArgs e)
        {
            string item = arr[1];
            lstitem.Items.Add(item);
     
        }
    }

}