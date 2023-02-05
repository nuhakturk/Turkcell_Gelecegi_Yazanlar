using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using EntityLayer;

namespace DataAccessLayer
{
	public class DalDers
	{
		//Crud Metotları
		//Ekle Silme Güncelleme Listeleme
		public static int DersEkle(EntityDers p)
		{
			SqlCommand komut1 = new SqlCommand("insert into TBLDERSLER (DersAd) values (@p1)", Baglanti.bgl);
			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}
			komut1.Parameters.AddWithValue("@p1", p.DersAd);
			return komut1.ExecuteNonQuery();
		}
	}
}
