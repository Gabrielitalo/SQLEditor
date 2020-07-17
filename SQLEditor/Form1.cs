using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLEditor.Classes;

namespace SQLEditor
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void BtnBuscaProcedure_Click(object sender, EventArgs e)
    {
      //string Conn = Properties.Settings.Default.DbCon;
      ConectDB Conn = new ConectDB();
      SqlCommand cmd;
      SqlDataAdapter da;
      DataSet ds;

      SqlConnection sqlconn = new SqlConnection(Conn.connectionString);
      //cmd = new SqlCommand("PcRetornaPCs", sqlconn);
      cmd = new SqlCommand("sp_helptext", sqlconn);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.CommandTimeout = 0;
      cmd.Parameters.AddWithValue("@objname", txtNomePc.Text);

      da = new SqlDataAdapter(cmd);
      ds = new DataSet();
      da.Fill(ds);

      int ContResult = ds.Tables[0].Rows.Count;
      int i;
      string Resultado = "";

      if (ContResult > 0)
      {
        for (i = 0; i < ContResult; i++)
        {
          // Resultado += ds.Tables[0].Rows[i]["Texto"].ToString();
          Resultado += ds.Tables[0].Rows[i]["Text"].ToString();
        }

        // Convertendo de UnixLF para WindowsCRLF
        //Resultado = Resultado.Replace("\n", "\r\n");
       // Resultado = Resultado.Replace("\u0020", " ");
        Resultado = Resultado.Replace("\t", "");
        Resultado = Resultado.Replace("CREATE PROCEDURE", "ALTER PROCEDURE");
      }

      if (Resultado != "")

      txtEditor.Text = Resultado;
      ContResult = 0;
      sqlconn.Close();

    }

    private void BtnLimpar_Click(object sender, EventArgs e)
    {
      txtEditor.Text = "";
    }

    private void Button1_Click(object sender, EventArgs e)
    {
    }
  }
}
