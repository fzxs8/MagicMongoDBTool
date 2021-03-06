﻿using MagicMongoDBTool.Module;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Windows.Forms;

namespace MagicMongoDBTool.UnitTest
{
    public partial class frmUnitTest : Form
    {
        public frmUnitTest()
        {
            InitializeComponent();
        }

        private void frmUnitTest_Load(object sender, EventArgs e)
        {

        }
        private void btnFillDataForUser_Click(object sender, EventArgs e)
        {
            if (SystemManager.GetCurrentServer() != null)
            {
                InitTestData.FillDataForUser(SystemManager.GetCurrentServer());
                MessageBox.Show("Complete");
            }
            else {
                MessageBox.Show("Please select a server");
            }
        }

        private void btnFillDataForTTL_Click(object sender, EventArgs e)
        {
            if (SystemManager.GetCurrentServer() != null)
            {
                InitTestData.FillDataForTTL(SystemManager.GetCurrentServer());
                MessageBox.Show("Complete");
            }
            else
            {
                MessageBox.Show("Please select a server");
            }
        }

        private void btnFillDataForGeoObject_Click(object sender, EventArgs e)
        {
            if (SystemManager.GetCurrentServer() != null)
            {
                InitTestData.FillDataForGeoObject(SystemManager.GetCurrentServer());
                MessageBox.Show("Complete");
            }
            else
            {
                MessageBox.Show("Please select a server");
            }
        }
    }
}
