namespace udp_draw {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RHOST = new System.Windows.Forms.TextBox();
            this.TB_RPORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_LPORT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnRed = new System.Windows.Forms.RadioButton();
            this.BtnGreen = new System.Windows.Forms.RadioButton();
            this.BtnBlue = new System.Windows.Forms.RadioButton();
            this.BtnBlack = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target IP";
            // 
            // TB_RHOST
            // 
            this.TB_RHOST.Location = new System.Drawing.Point(123, 24);
            this.TB_RHOST.Name = "TB_RHOST";
            this.TB_RHOST.Size = new System.Drawing.Size(156, 26);
            this.TB_RHOST.TabIndex = 1;
            // 
            // TB_RPORT
            // 
            this.TB_RPORT.Location = new System.Drawing.Point(427, 24);
            this.TB_RPORT.Name = "TB_RPORT";
            this.TB_RPORT.Size = new System.Drawing.Size(156, 26);
            this.TB_RPORT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Port";
            // 
            // TB_LPORT
            // 
            this.TB_LPORT.Location = new System.Drawing.Point(731, 24);
            this.TB_LPORT.Name = "TB_LPORT";
            this.TB_LPORT.Size = new System.Drawing.Size(156, 26);
            this.TB_LPORT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local Port";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(916, 24);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(109, 30);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnRed
            // 
            this.BtnRed.AutoSize = true;
            this.BtnRed.Location = new System.Drawing.Point(916, 77);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(57, 24);
            this.BtnRed.TabIndex = 7;
            this.BtnRed.TabStop = true;
            this.BtnRed.Text = "Red";
            this.BtnRed.UseVisualStyleBackColor = true;
            this.BtnRed.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // BtnGreen
            // 
            this.BtnGreen.AutoSize = true;
            this.BtnGreen.Location = new System.Drawing.Point(916, 112);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(72, 24);
            this.BtnGreen.TabIndex = 8;
            this.BtnGreen.TabStop = true;
            this.BtnGreen.Text = "Green";
            this.BtnGreen.UseVisualStyleBackColor = true;
            this.BtnGreen.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // BtnBlue
            // 
            this.BtnBlue.AutoSize = true;
            this.BtnBlue.Location = new System.Drawing.Point(916, 147);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(59, 24);
            this.BtnBlue.TabIndex = 9;
            this.BtnBlue.TabStop = true;
            this.BtnBlue.Text = "Blue";
            this.BtnBlue.UseVisualStyleBackColor = true;
            this.BtnBlue.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // BtnBlack
            // 
            this.BtnBlack.AutoSize = true;
            this.BtnBlack.Checked = true;
            this.BtnBlack.Location = new System.Drawing.Point(916, 182);
            this.BtnBlack.Name = "BtnBlack";
            this.BtnBlack.Size = new System.Drawing.Size(66, 24);
            this.BtnBlack.TabIndex = 10;
            this.BtnBlack.TabStop = true;
            this.BtnBlack.Text = "Black";
            this.BtnBlack.UseVisualStyleBackColor = true;
            this.BtnBlack.CheckedChanged += new System.EventHandler(this.ColorRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 681);
            this.Controls.Add(this.BtnBlack);
            this.Controls.Add(this.BtnBlue);
            this.Controls.Add(this.BtnGreen);
            this.Controls.Add(this.BtnRed);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TB_LPORT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_RPORT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_RHOST);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "資工二甲_B11215013_徐牧遠";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TB_RHOST;
    private System.Windows.Forms.TextBox TB_RPORT;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TB_LPORT;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BtnConnect;
    private System.Windows.Forms.RadioButton BtnRed;
    private System.Windows.Forms.RadioButton BtnGreen;
    private System.Windows.Forms.RadioButton BtnBlue;
    private System.Windows.Forms.RadioButton BtnBlack;
  }
}

