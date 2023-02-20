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

		public static List<EntityDers> DersListesi()
		{
			List<EntityDers> dersler = new List<EntityDers>();
			SqlCommand komut2 = new SqlCommand("Select * From TBLDERSLER", Baglanti.bgl);
			if (komut2.Connection.State != ConnectionState.Open)
			{
				komut2.Connection.Open();
			}
			SqlDataReader dr = komut2.ExecuteReader();
			while (dr.Read()) 
			{
				EntityDers ent = new EntityDers();
				ent.DersID = byte.Parse(dr["DersID"].ToString());
				ent.DersAd = dr["DersAd"].ToString();
				dersler.Add(ent);
			}
			dr.Close();
			return dersler;
		}
	}
}
