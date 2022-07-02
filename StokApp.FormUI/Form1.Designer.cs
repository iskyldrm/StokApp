namespace StokApp.FormUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.calendarBaslangic = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.calendarBitis = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.cBxUrunKod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.UrunKodulbl = new DevExpress.XtraEditors.LabelControl();
            this.btnCalistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnSifirla = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBaslangic.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBitis.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxUrunKod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 355);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1148, 413);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // calendarBaslangic
            // 
            this.calendarBaslangic.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarBaslangic.Location = new System.Drawing.Point(486, 12);
            this.calendarBaslangic.Name = "calendarBaslangic";
            this.calendarBaslangic.Size = new System.Drawing.Size(294, 282);
            this.calendarBaslangic.TabIndex = 1;
            this.calendarBaslangic.SelectionChanged += new System.EventHandler(this.calendarBaslangic_SelectionChanged);
            // 
            // calendarBitis
            // 
            this.calendarBitis.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarBitis.Location = new System.Drawing.Point(828, 12);
            this.calendarBitis.Name = "calendarBitis";
            this.calendarBitis.Size = new System.Drawing.Size(294, 282);
            this.calendarBitis.TabIndex = 2;
            this.calendarBitis.SelectionChanged += new System.EventHandler(this.calendarBitis_SelectionChanged);
            // 
            // cBxUrunKod
            // 
            this.cBxUrunKod.Location = new System.Drawing.Point(12, 36);
            this.cBxUrunKod.Name = "cBxUrunKod";
            this.cBxUrunKod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cBxUrunKod.Size = new System.Drawing.Size(279, 22);
            this.cBxUrunKod.TabIndex = 3;
            this.cBxUrunKod.SelectedIndexChanged += new System.EventHandler(this.cBxUrunKod_SelectedIndexChanged);
            // 
            // UrunKodulbl
            // 
            this.UrunKodulbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunKodulbl.Appearance.Options.UseFont = true;
            this.UrunKodulbl.Location = new System.Drawing.Point(12, 12);
            this.UrunKodulbl.Name = "UrunKodulbl";
            this.UrunKodulbl.Size = new System.Drawing.Size(116, 18);
            this.UrunKodulbl.TabIndex = 4;
            this.UrunKodulbl.Text = "Ürün Kodu Seçiniz";
            // 
            // btnCalistir
            // 
            this.btnCalistir.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalistir.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCalistir.Appearance.Options.UseFont = true;
            this.btnCalistir.Appearance.Options.UseForeColor = true;
            this.btnCalistir.Location = new System.Drawing.Point(12, 107);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(279, 47);
            this.btnCalistir.TabIndex = 5;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Appearance.Options.UseFont = true;
            this.btnSifirla.Location = new System.Drawing.Point(12, 187);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(279, 29);
            this.btnSifirla.TabIndex = 6;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(214, 328);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Filtreler : ";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(297, 327);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(182, 22);
            this.txtKod.TabIndex = 8;
            this.txtKod.Text = "Ürün Kodu";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(486, 327);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(294, 22);
            this.txtBaslangic.TabIndex = 9;
            this.txtBaslangic.Text = "Başlangıç Tarihi";
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(828, 327);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(294, 22);
            this.txtBitis.TabIndex = 10;
            this.txtBitis.Text = "Bitiş Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(486, 303);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Başlangıç Tarihi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(828, 303);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 18);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Bitiş Tarihi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(297, 303);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Ürün Kodu ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 780);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnCalistir);
            this.Controls.Add(this.UrunKodulbl);
            this.Controls.Add(this.cBxUrunKod);
            this.Controls.Add(this.calendarBitis);
            this.Controls.Add(this.calendarBaslangic);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBaslangic.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBitis.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBxUrunKod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarBaslangic;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarBitis;
        private DevExpress.XtraEditors.ComboBoxEdit cBxUrunKod;
        private DevExpress.XtraEditors.LabelControl UrunKodulbl;
        private DevExpress.XtraEditors.SimpleButton btnCalistir;
        private DevExpress.XtraEditors.SimpleButton btnSifirla;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

