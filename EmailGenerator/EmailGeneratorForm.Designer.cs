
namespace EmailGenerator
{
  partial class EmailGeneratorForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateNextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.SeparatorBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CreateNextAndCopyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateNextButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IndexBox);
            this.groupBox1.Controls.Add(this.SeparatorBox);
            this.groupBox1.Controls.Add(this.EmailBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // CreateNextButton
            // 
            this.CreateNextButton.Location = new System.Drawing.Point(7, 113);
            this.CreateNextButton.Name = "CreateNextButton";
            this.CreateNextButton.Size = new System.Drawing.Size(368, 23);
            this.CreateNextButton.TabIndex = 6;
            this.CreateNextButton.Text = "Создать следующий";
            this.CreateNextButton.UseVisualStyleBackColor = true;
            this.CreateNextButton.Click += new System.EventHandler(this.CreateNextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текущий индекс*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Разделитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email*";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(124, 54);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(251, 23);
            this.IndexBox.TabIndex = 2;
            this.IndexBox.TextChanged += new System.EventHandler(this.IndexBox_TextChanged);
            this.IndexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndexBox_KeyPress);
            // 
            // SeparatorBox
            // 
            this.SeparatorBox.Location = new System.Drawing.Point(124, 83);
            this.SeparatorBox.Name = "SeparatorBox";
            this.SeparatorBox.Size = new System.Drawing.Size(251, 23);
            this.SeparatorBox.TabIndex = 1;
            this.SeparatorBox.TextChanged += new System.EventHandler(this.SeparatorBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(124, 25);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(251, 23);
            this.EmailBox.TabIndex = 0;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CopyButton);
            this.groupBox2.Controls.Add(this.ResultBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(7, 54);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(369, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Копировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(7, 25);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(369, 23);
            this.ResultBox.TabIndex = 1;
            // 
            // CreateNextAndCopyButton
            // 
            this.CreateNextAndCopyButton.Location = new System.Drawing.Point(12, 256);
            this.CreateNextAndCopyButton.Name = "CreateNextAndCopyButton";
            this.CreateNextAndCopyButton.Size = new System.Drawing.Size(382, 23);
            this.CreateNextAndCopyButton.TabIndex = 2;
            this.CreateNextAndCopyButton.Text = "Создать следующий и копировать";
            this.CreateNextAndCopyButton.UseVisualStyleBackColor = true;
            this.CreateNextAndCopyButton.Click += new System.EventHandler(this.CreateNextAndCopyButton_Click);
            // 
            // EmailGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 286);
            this.Controls.Add(this.CreateNextAndCopyButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 325);
            this.MinimumSize = new System.Drawing.Size(415, 325);
            this.Name = "EmailGeneratorForm";
            this.Text = "Генератор email адресов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailGeneratorForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button CreateNextButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox IndexBox;
    private System.Windows.Forms.TextBox SeparatorBox;
    private System.Windows.Forms.TextBox EmailBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button CopyButton;
    private System.Windows.Forms.TextBox ResultBox;
    private System.Windows.Forms.Button CreateNextAndCopyButton;
  }
}

