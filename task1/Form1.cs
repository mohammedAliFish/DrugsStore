using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using task1.Forms.Company;

namespace task1
{
    public partial class Form1 : CenterForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CompanyForm companyForm = new CompanyForm();
            companyForm.Show();
        }
    }
}
