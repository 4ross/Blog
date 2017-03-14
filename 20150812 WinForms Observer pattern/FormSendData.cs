﻿using System;
using System.Windows.Forms;
using SimpleBroker;

namespace WindowsFormsApplicationObserver
{
    public partial class FormSendData : Form
    {
        public FormSendData()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var message = new Message
            {
                Source = txtSource.Text,
                Information = txtInformation.Text
            };
            message.Publish();
        }
    }
}
