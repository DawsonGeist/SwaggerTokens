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
    public partial class AddTokensForm : Form
    {
        private string m_amountPath;
        private string m_historyPath;

        public AddTokensForm(string amountPath, string historyPath)
        {
            InitializeComponent();
            this.m_amountPath = amountPath;
            this.m_historyPath = historyPath;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Fix the amount
            string temp_amount = File.ReadAllText(m_amountPath);
            int amount = 0;

            if (int.TryParse(temp_amount, out amount))
            {
                amount += this.trackBarTokenAmount.Value;
                var amtFile = File.CreateText(m_amountPath);
                amtFile.Write($"{amount}");
                amtFile.Close();
            }

            //Add to the Log
            File.AppendAllText(m_historyPath, $"{System.DateTime.Now} \n+{trackBarTokenAmount.Value} Tokens, Description: {textBox1.Text}\n\n");
            this.Close();
        }

        private void trackBarTokenAmount_ValueChanged(object sender, EventArgs e)
        {
            this.lblTokenAmount.Text = $"{trackBarTokenAmount.Value}";
            int sizeOfTokens = this.lblTokenAmount.Size.Width / 2;
            this.lblTokenAmount.Location = new System.Drawing.Point((this.Size.Width / 2) - sizeOfTokens, this.lblTokenAmount.Location.Y);
            this.Refresh();
        }
    }
}
