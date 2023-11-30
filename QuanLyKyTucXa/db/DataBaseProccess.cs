using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.Class
{
	class DataBaseProcess
	{
		//Khai báo biến toàn cục, bạn phải thay đổi chuối kết nối phù hợp
		string strConnect = "Data Source=LAPTOP-0QV26TOC;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
		SqlConnection sqlConnect = null;
		//Phương thức mở kết nối
		public void OpenConnect()
		{
			sqlConnect = new SqlConnection(strConnect);
			if (sqlConnect.State != ConnectionState.Open)
				sqlConnect.Open();
		}
		//Phương thức đóng kết nối
		public void CloseConnect()
		{
			if (sqlConnect.State != ConnectionState.Closed)
			{
				sqlConnect.Close();
				sqlConnect.Dispose();
			}
		}
		public DataTable DataReader(string sqlSelct)
		{
			DataTable tblData = new DataTable();
			OpenConnect();
			SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
			sqlData.Fill(tblData);
			CloseConnect();
			return tblData;
		}
			public void DataChange(string sql)
			{
				OpenConnect();
				SqlCommand sqlcomma = new SqlCommand();
				sqlcomma.Connection = sqlConnect;
				sqlcomma.CommandText = sql;
				sqlcomma.ExecuteNonQuery();
				CloseConnect();
			}

	}
}
