using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
	public class DalOgrenci
	{
		public static int OgrenciEkle(EntityOgrenci p)
		{
			SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (Ad,Soyad,Numara,Bolum) values (@p1,@p2,@p3,@p4)", Baglanti.bgl);

			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}
			komut1.Parameters.AddWithValue("@p1", p.Ad);
			komut1.Parameters.AddWithValue("@p2", p.Soyad);
			komut1.Parameters.AddWithValue("@p3", p.Numara);
			komut1.Parameters.AddWithValue("@p4", p.Bolum);
			return komut1.ExecuteNonQuery();
		}
	}
}
