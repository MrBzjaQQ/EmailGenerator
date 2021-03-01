using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailGenerator
{
    public partial class EmailGeneratorForm : Form
    {
        public EmailGeneratorForm()
        {
            InitializeComponent();

            _generator = new Generator();

            EmailBox.Text = _generator.Email;
            SeparatorBox.Text = _generator.Separator;
            IndexBox.Text = _generator.Index.ToString();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            _generator.Email = EmailBox.Text;
            CheckIfButtonsActive();
        }

        private void SeparatorBox_TextChanged(object sender, EventArgs e)
        {
            _generator.Separator = SeparatorBox.Text;
        }

        private void IndexBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(IndexBox.Text, out var index))
            {
                _generator.Index = index;
                CheckIfButtonsActive();
            }
        }

        private void CreateNextButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = _generator.GenerateNew();
            IndexBox.Text = _generator.Index.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultBox.Text);
        }

        private void IndexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void CreateNextAndCopyButton_Click(object sender, EventArgs e)
        {
            CreateNextButton_Click(sender, e);
            CopyButton_Click(sender, e);
        }
        private void EmailGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _generator.SaveSettings();
        }

        private void CheckIfButtonsActive()
        {
            bool canGenerate = EmailBox.Text.Contains('@') && int.TryParse(IndexBox.Text, out _);
            bool canCopy = !string.IsNullOrEmpty(ResultBox.Text);

            CreateNextButton.Enabled = canGenerate;
            CreateNextAndCopyButton.Enabled = canGenerate;
            CopyButton.Enabled = canCopy;
        }

        private readonly Generator _generator;
    }
}
