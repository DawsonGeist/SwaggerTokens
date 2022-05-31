using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace SwaggerTokens
{
    public partial class SwaggerTokens : Form
    {
        private string m_amountPath;
        private string m_historyPath;
        public SwaggerTokens(string amountPath, string historyPath)
        {
            InitializeComponent();
            this.m_amountPath = amountPath;
            this.m_historyPath = historyPath;

            this.lblSwaggerTokens.Text = File.ReadAllText(this.m_amountPath);
            int sizeOfTokens = this.lblSwaggerTokens.Size.Width / 2;
            this.lblSwaggerTokens.Location = new System.Drawing.Point((this.Size.Width / 2) - sizeOfTokens, this.lblSwaggerTokens.Location.Y);
        }

        private void btnAddTokens_Click(object sender, EventArgs e)
        {
            AddTokensForm addTokensForm = new AddTokensForm(m_amountPath, m_historyPath);
            addTokensForm.ShowDialog();
            this.lblSwaggerTokens.Text = File.ReadAllText(this.m_amountPath);
            int sizeOfTokens = this.lblSwaggerTokens.Size.Width / 2;
            this.lblSwaggerTokens.Location = new System.Drawing.Point((this.Size.Width / 2) - sizeOfTokens, this.lblSwaggerTokens.Location.Y);
            this.Refresh();
        }

        private void btnTokenHistory_Click(object sender, EventArgs e)
        {
            HistoryViewForm addTokensForm = new HistoryViewForm(m_historyPath);
            addTokensForm.ShowDialog();
        }
    }
}
