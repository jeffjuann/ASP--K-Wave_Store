using KpopZtationLab.App_Data;
using KpopZtationLab.Controllers;
using KpopZtationLab.CrystalReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtationLab.Views.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 crystalReport = new CrystalReport1();
            CrystalReportViewer1.ReportSource = crystalReport;
            var reportData = getReportData();
            crystalReport.SetDataSource(reportData);
            CrystalReportViewer1.DataBind();
            CrystalReportViewer1.SeparatePages = false;
        }
        protected DataSet1 getReportData()
        {
            var transactionHeader = TransactionController.GetAll();
            DataSet1 ds = new DataSet1();
            var reportHeader = ds.TransactionHeader;
            var reportDetail = ds.TransactionDetail;
            foreach (var th in transactionHeader)
            {
                var hrow = reportHeader.NewRow();
                hrow["transaction id"] = th.TransactionID;
                hrow["transaction date"] = th.TransactionDate;
                hrow["customer id"] = th.CustomerID;
                hrow["Grand Total value"] = TransactionController.GetTransactionHeaderTotal(th);
                foreach (var td in th.TransactionDetails)
                {
                    var drow = reportDetail.NewRow();
                    drow["transaction id"] = td.TransactionID;
                    drow["album name"] = td.Album.AlbumName;
                    drow["quantity"] = td.Qty;
                    drow["album price"] = td.Album.AlbumPrice;
                    drow["Sub Total value"] = TransactionController.GetTransactionDetailTotal(td);
                    reportDetail.Rows.Add(drow);
                }
                reportHeader.Rows.Add(hrow);

            }
            return ds;
        }

    }
}