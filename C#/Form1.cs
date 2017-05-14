using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Korelasi
{
    public partial class Form1 : Form
    {
        public DataSet dsData;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkAddValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd f = new frmAdd(this);

            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private DataSet generateDataSet()
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "dsData";

            DataTable dt = new DataTable();
            dt.TableName = "dtData";

            DataColumn dcKey = new DataColumn();
            dcKey.Caption = "Id";
            dcKey.ColumnName = "Id";
            dcKey.DataType = typeof(Int32);
            dcKey.AutoIncrement = true;
            dcKey.Unique = true;
            dt.Columns.Add(dcKey);
            
            DataColumn dcX = new DataColumn();
            dcX.Caption = "xValue";
            dcX.ColumnName = "xValue";
            dcX.DataType = typeof(Int32);
            dt.Columns.Add(dcX);

            DataColumn dcY = new DataColumn();
            dcY.Caption = "yValue";
            dcY.ColumnName = "yValue";
            dcY.DataType = typeof(Int32);
            dt.Columns.Add(dcY);

            ds.Tables.Add(dt);

            return ds;
        }

        public void insertData(int X, int Y)
        {
            DataRow dr = dsData.Tables["dtData"].NewRow();
            dr["xValue"] = X;
            dr["yValue"] = Y;

            dsData.Tables["dtData"].Rows.Add(dr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsData = generateDataSet();

            refreshDgv();
        }

        public void refreshDgv()
        {
            dgvData.DataSource = dsData;
            dgvData.DataMember = "dtData";
            dgvData.Refresh();

            dgvData.Columns[0].Visible = false;

            refreshCalculation();
        }

        private void refreshCalculation()
        {
            lblNValue.Text = nValue.ToString();
            lblX2Value.Text = sx2Value.ToString();
            lblXValue.Text = sxValue.ToString();
            lblXYValue.Text = sxyValue.ToString();
            lblY2Value.Text = sy2Value.ToString();
            lblYValue.Text = syValue.ToString();

            txtRValue.Text = rValue.ToString();
        }

        public int nValue
        {
            get 
            { 
                int outVal = dsData.Tables[0].Rows.Count;
                
                return outVal;  
            }
        }

        public int sxValue
        {
            get 
            {
                int outVal = 0;
                for (int i = 0; i < nValue; i++)
                {
                    outVal += int.Parse(dsData.Tables[0].Rows[i].ItemArray[1].ToString());
                }

                return outVal;
            }
        }

        public int sx2Value
        {
            get
            {
                int outVal = 0;
                for (int i = 0; i < nValue; i++)
                {
                    outVal += ( int.Parse(dsData.Tables[0].Rows[i].ItemArray[1].ToString()) * int.Parse(dsData.Tables[0].Rows[i].ItemArray[1].ToString()) );
                }

                return outVal;
            }
        }

        public int syValue
        {
            get
            {
                int outVal = 0;
                for (int i = 0; i < nValue; i++)
                {
                    outVal += int.Parse(dsData.Tables[0].Rows[i].ItemArray[2].ToString());
                }

                return outVal;
            }
        }

        public int sy2Value
        {
            get
            {
                int outVal = 0;
                for (int i = 0; i < nValue; i++)
                {
                    outVal += ( int.Parse(dsData.Tables[0].Rows[i].ItemArray[2].ToString()) * int.Parse(dsData.Tables[0].Rows[i].ItemArray[2].ToString()) );
                }

                return outVal;
            }
        }

        public int sxyValue
        {
            get
            {
                int outVal = 0;
                for (int i = 0; i < nValue; i++)
                {
                    outVal += ( int.Parse(dsData.Tables[0].Rows[i].ItemArray[1].ToString()) * int.Parse(dsData.Tables[0].Rows[i].ItemArray[2].ToString()) );
                }

                return outVal;
            }
        }


        public double rValue
        {
            get
            {
                return ((nValue * sxyValue) - (sxValue * syValue)) / Math.Sqrt((((nValue * sx2Value) - (sx2Value * 2)) * ((nValue * sy2Value) - (sy2Value * 2))));
            }
        }
    }
}
