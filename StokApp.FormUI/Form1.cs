using StokApp.Data.Absract;
using StokApp.Data.Concrete;
using StokApp.FormUI.Models;
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

namespace StokApp.FormUI
{
    public partial class Form1 : Form
    {
        List<StokDetay> Detays = new List<StokDetay>();
        List<UrunKod> eCodes = new List<UrunKod>();
        string baslocal = "";
        string sonlocal = "";
        private readonly IDbContext dbContext = new SqlDbContext();

        public Form1()
        {
            InitializeComponent();
            RefreshMainTable();
            RefreshCombo();
            calendarBaslangic.MinValue = new DateTime(2016, 1, 4);
            calendarBaslangic.MaxValue = new DateTime(2017, 4, 25);
            calendarBitis.MinValue = new DateTime(2016, 1, 4);
            calendarBitis.MaxValue = new DateTime(2017, 4, 25);
        }

        
        /// <summary>
        /// Comboboxdan kod seçildiğinde kod textine ürün yazması için
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBxUrunKod_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKod.Text = cBxUrunKod.Text;
        }
        /// <summary>
        /// Calender başlangIçtan başlangıç tarihi seçilmesi için
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarBaslangic_SelectionChanged(object sender, EventArgs e)
        {
            var gelenTarih = calendarBaslangic.SelectionStart.ToString();
            
            txtBaslangic.Text = DateSplit(gelenTarih).ToString();
            baslocal = txtBaslangic.Text;
        }
        /// <summary>
        /// Calender bitişten son tarihi seçilmesi için
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarBitis_SelectionChanged(object sender, EventArgs e)
        {
            var gelenTarih = calendarBitis.SelectionStart.ToString();

            txtBitis.Text = DateSplit(gelenTarih).ToString();
            sonlocal = txtBitis.Text;
        }

        /// <summary>
        /// Seçilen tarihleri saatlerden arındırıp int dönüştürmek için yapılan split
        /// </summary>
        /// <param name="date">Calenderden seçilen date.</param>
        /// <returns></returns>
        private StringBuilder DateSplit(string date)
        {
            try
            {
                var deger = date.Split('.');
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(deger[0] + "." + deger[1] + "." + deger[2].Substring(0, 4));
                return stringBuilder;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Format Hatası" + ex.Message);
            }
            finally
            {
                RefreshMainTable();
                RefreshCombo();
            }
            return null;
            
        }

        /// <summary>
        /// Form açıldığı zaman Data gride basılacak değerler
        /// </summary>
        private void RefreshMainTable()
        {
            dbContext.SqlBaglatiAc();

            SqlDataReader rdr = dbContext.SPwithoutParam();
            Detays.Clear();
            // Gelen Datalarin uzerinde tek tek geciyoruz
            while (rdr.Read())
            {
                // Gelen veriyi modelime uygun sekile ceviriyoruz
                StokDetay sd = new StokDetay();
                sd.SiraNo = Convert.ToInt32(rdr[0]);
                sd.İslemTipi = (rdr[1]).ToString();
                sd.EvrakNo = rdr[2].ToString();
                sd.Tarih = Convert.ToDateTime(rdr[3]);
                sd.Giris = Convert.ToInt32(rdr[4]);
                sd.Cikis = Convert.ToInt32(rdr[5]);

                sd.Stok = Convert.ToInt32(rdr[6]);

                Detays.Add(sd);
            }
            rdr.Close();
            var stok = 0;
            foreach (var item in Detays)
            {

                if (item.İslemTipi == "Giris")
                    stok += item.Giris;
                else
                    stok -= item.Cikis;
                item.Stok = stok;
            }
            // Listemizi datagrid'e basiyoruz
            gridControl1.DataSource = Detays.ToList();
        }

        /// <summary>
        /// Form açıldığında combobox a eklenecek veriler
        /// </summary>
        private void RefreshCombo()
        {
            cBxUrunKod.Properties.Items.Clear();
            dbContext.SqlBaglatiAc();
            SqlDataReader rdr = dbContext.ExecuteQuery("select MalKodu from STK");
            eCodes.Clear();
            while (rdr.Read())
            {
                // Gelen veriyi modelime uygun sekile ceviriyoruz
                UrunKod eCode = new UrunKod();
                eCode.EntityCodes = rdr[0].ToString();
                eCodes.Add(eCode);
            }
            rdr.Close();
            // Listemizi datagrid'e basiyoruz
            foreach (var item in eCodes)
            {
                cBxUrunKod.Properties.Items.Add(item.EntityCodes.ToString());
            }

        }

        /// <summary>
        /// Çalıştır butonuna basınca filtrelere göre sp_InOuttable prosedürünü çalıştırır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            var bas = Convert.ToDateTime(baslocal);
            var basint = Convert.ToInt32(bas.ToOADate());
            var son = Convert.ToDateTime(sonlocal);
            var sonint = Convert.ToInt32(son.ToOADate());

            SqlDataReader rdr = dbContext.SPwithParam(txtKod.Text, basint, sonint);
            Detays.Clear();
            // Gelen Datalarin uzerinde tek tek geciyoruz
            while (rdr.Read())
            {
                // Gelen veriyi modelime uygun sekile ceviriyoruz
                StokDetay sp = new StokDetay();
                sp.SiraNo = Convert.ToInt32(rdr[0]);
                sp.İslemTipi = (rdr[1]).ToString();
                sp.EvrakNo = rdr[2].ToString();
                sp.Tarih = Convert.ToDateTime(rdr[3]);
                sp.Giris = Convert.ToInt32(rdr[4]);
                sp.Cikis = Convert.ToInt32(rdr[5]);
                sp.Stok = Convert.ToInt32(rdr[6]);
                Detays.Add(sp);
            }
            rdr.Close();
            var stok = 0;
            foreach (var item in Detays)
            {

                if (item.İslemTipi == "Giris")
                    stok += item.Giris;
                else
                    stok -= item.Cikis;
                item.Stok = stok;
            }
            // Listemizi datagrid'e basiyoruz
            gridControl1.DataSource = Detays.ToList();
        }
        /// <summary>
        /// Sıfırla butonuna basınca  Textleri temizler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            RefreshCombo();
            RefreshMainTable();
            cBxUrunKod.Text = " ";
            txtKod.Text = "Mal Kodu";
            txtBaslangic.Text = "Başlangıç Tarihi";
            txtBitis.Text = "Bitiş Tarihi";
        }
    }
}
