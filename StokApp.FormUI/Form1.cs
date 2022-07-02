using StokApp.Data.Absract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokApp.FormUI
{
    public partial class Form1 : Form
    {
        private readonly IDbContext dbContext;

        public Form1(IDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }
        
        
    }
}
