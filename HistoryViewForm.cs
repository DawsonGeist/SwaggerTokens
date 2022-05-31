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
    public partial class HistoryViewForm : Form
    {
        public HistoryViewForm(string historyPath)
        {
            InitializeComponent();
            this.textBox1.Lines = File.ReadLines(historyPath).ToArray();
            this.Refresh();
        }
    }
}