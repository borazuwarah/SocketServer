namespace ServiceSocket
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtDataRecibed = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btChangeServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.Label();
            this.lbLegend = new System.Windows.Forms.Label();
            this.lbHaveCapitalLetter = new System.Windows.Forms.Label();
            this.lbSecondCharter = new System.Windows.Forms.Label();
            this.lbSortNumber = new System.Windows.Forms.Label();
            this.lbHaveNumber = new System.Windows.Forms.Label();
            this.lbTotalCapitalLetter = new System.Windows.Forms.Label();
            this.lbrListSortNumber = new System.Windows.Forms.Label();
            this.lbrTotalNumbers = new System.Windows.Forms.Label();
            this.lbrTotalCapitalLetter = new System.Windows.Forms.Label();
            this.lbrHaveCapitalLetter = new System.Windows.Forms.Label();
            this.lbrSecondChar = new System.Windows.Forms.Label();
            this.lbrLength = new System.Windows.Forms.Label();
            this.lbrTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbTitle.Location = new System.Drawing.Point(367, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(160, 46);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Service";
            // 
            // txtDataRecibed
            // 
            this.txtDataRecibed.Location = new System.Drawing.Point(12, 121);
            this.txtDataRecibed.Multiline = true;
            this.txtDataRecibed.Name = "txtDataRecibed";
            this.txtDataRecibed.Size = new System.Drawing.Size(400, 81);
            this.txtDataRecibed.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(501, 121);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(400, 362);
            this.txtLog.TabIndex = 3;
            // 
            // btChangeServer
            // 
            this.btChangeServer.Location = new System.Drawing.Point(741, 19);
            this.btChangeServer.Name = "btChangeServer";
            this.btChangeServer.Size = new System.Drawing.Size(160, 45);
            this.btChangeServer.TabIndex = 4;
            this.btChangeServer.Text = "Start / Stop Service";
            this.btChangeServer.UseVisualStyleBackColor = true;
            this.btChangeServer.Click += new System.EventHandler(this.btChangeServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last message recibed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Logs";
            // 
            // dtTime
            // 
            this.dtTime.AutoSize = true;
            this.dtTime.Location = new System.Drawing.Point(12, 226);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(43, 17);
            this.dtTime.TabIndex = 7;
            this.dtTime.Text = "Time:";
            // 
            // lbLegend
            // 
            this.lbLegend.AutoSize = true;
            this.lbLegend.Location = new System.Drawing.Point(12, 263);
            this.lbLegend.Name = "lbLegend";
            this.lbLegend.Size = new System.Drawing.Size(56, 17);
            this.lbLegend.TabIndex = 8;
            this.lbLegend.Text = "Length:";
            // 
            // lbHaveCapitalLetter
            // 
            this.lbHaveCapitalLetter.AutoSize = true;
            this.lbHaveCapitalLetter.Location = new System.Drawing.Point(12, 332);
            this.lbHaveCapitalLetter.Name = "lbHaveCapitalLetter";
            this.lbHaveCapitalLetter.Size = new System.Drawing.Size(132, 17);
            this.lbHaveCapitalLetter.TabIndex = 10;
            this.lbHaveCapitalLetter.Text = "Have Capital letter: ";
            // 
            // lbSecondCharter
            // 
            this.lbSecondCharter.AutoSize = true;
            this.lbSecondCharter.Location = new System.Drawing.Point(12, 295);
            this.lbSecondCharter.Name = "lbSecondCharter";
            this.lbSecondCharter.Size = new System.Drawing.Size(96, 17);
            this.lbSecondCharter.TabIndex = 9;
            this.lbSecondCharter.Text = "Second chart:";
            // 
            // lbSortNumber
            // 
            this.lbSortNumber.AutoSize = true;
            this.lbSortNumber.Location = new System.Drawing.Point(9, 437);
            this.lbSortNumber.Name = "lbSortNumber";
            this.lbSortNumber.Size = new System.Drawing.Size(99, 17);
            this.lbSortNumber.TabIndex = 13;
            this.lbSortNumber.Text = "Sort Numbers:";
            // 
            // lbHaveNumber
            // 
            this.lbHaveNumber.AutoSize = true;
            this.lbHaveNumber.Location = new System.Drawing.Point(9, 405);
            this.lbHaveNumber.Name = "lbHaveNumber";
            this.lbHaveNumber.Size = new System.Drawing.Size(103, 17);
            this.lbHaveNumber.TabIndex = 12;
            this.lbHaveNumber.Text = "Total numbers:";
            // 
            // lbTotalCapitalLetter
            // 
            this.lbTotalCapitalLetter.AutoSize = true;
            this.lbTotalCapitalLetter.Location = new System.Drawing.Point(9, 368);
            this.lbTotalCapitalLetter.Name = "lbTotalCapitalLetter";
            this.lbTotalCapitalLetter.Size = new System.Drawing.Size(132, 17);
            this.lbTotalCapitalLetter.TabIndex = 11;
            this.lbTotalCapitalLetter.Text = "Total Capital Letter:";
            // 
            // lbrListSortNumber
            // 
            this.lbrListSortNumber.AutoSize = true;
            this.lbrListSortNumber.Location = new System.Drawing.Point(183, 437);
            this.lbrListSortNumber.Name = "lbrListSortNumber";
            this.lbrListSortNumber.Size = new System.Drawing.Size(48, 17);
            this.lbrListSortNumber.TabIndex = 20;
            this.lbrListSortNumber.Text = "98730";
            this.lbrListSortNumber.Visible = false;
            // 
            // lbrTotalNumbers
            // 
            this.lbrTotalNumbers.AutoSize = true;
            this.lbrTotalNumbers.Location = new System.Drawing.Point(183, 405);
            this.lbrTotalNumbers.Name = "lbrTotalNumbers";
            this.lbrTotalNumbers.Size = new System.Drawing.Size(24, 17);
            this.lbrTotalNumbers.TabIndex = 19;
            this.lbrTotalNumbers.Text = "15";
            this.lbrTotalNumbers.Visible = false;
            // 
            // lbrTotalCapitalLetter
            // 
            this.lbrTotalCapitalLetter.AutoSize = true;
            this.lbrTotalCapitalLetter.Location = new System.Drawing.Point(183, 368);
            this.lbrTotalCapitalLetter.Name = "lbrTotalCapitalLetter";
            this.lbrTotalCapitalLetter.Size = new System.Drawing.Size(24, 17);
            this.lbrTotalCapitalLetter.TabIndex = 18;
            this.lbrTotalCapitalLetter.Text = "25";
            this.lbrTotalCapitalLetter.Visible = false;
            // 
            // lbrHaveCapitalLetter
            // 
            this.lbrHaveCapitalLetter.AutoSize = true;
            this.lbrHaveCapitalLetter.Location = new System.Drawing.Point(186, 332);
            this.lbrHaveCapitalLetter.Name = "lbrHaveCapitalLetter";
            this.lbrHaveCapitalLetter.Size = new System.Drawing.Size(38, 17);
            this.lbrHaveCapitalLetter.TabIndex = 17;
            this.lbrHaveCapitalLetter.Text = "True";
            this.lbrHaveCapitalLetter.Visible = false;
            // 
            // lbrSecondChar
            // 
            this.lbrSecondChar.AutoSize = true;
            this.lbrSecondChar.Location = new System.Drawing.Point(186, 295);
            this.lbrSecondChar.Name = "lbrSecondChar";
            this.lbrSecondChar.Size = new System.Drawing.Size(11, 17);
            this.lbrSecondChar.TabIndex = 16;
            this.lbrSecondChar.Text = "i";
            this.lbrSecondChar.Visible = false;
            // 
            // lbrLength
            // 
            this.lbrLength.AutoSize = true;
            this.lbrLength.Location = new System.Drawing.Point(186, 263);
            this.lbrLength.Name = "lbrLength";
            this.lbrLength.Size = new System.Drawing.Size(24, 17);
            this.lbrLength.TabIndex = 15;
            this.lbrLength.Text = "25";
            this.lbrLength.Visible = false;
            // 
            // lbrTime
            // 
            this.lbrTime.AutoSize = true;
            this.lbrTime.Location = new System.Drawing.Point(186, 226);
            this.lbrTime.Name = "lbrTime";
            this.lbrTime.Size = new System.Drawing.Size(44, 17);
            this.lbrTime.TabIndex = 14;
            this.lbrTime.Text = "10:25";
            this.lbrTime.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 495);
            this.Controls.Add(this.lbrListSortNumber);
            this.Controls.Add(this.lbrTotalNumbers);
            this.Controls.Add(this.lbrTotalCapitalLetter);
            this.Controls.Add(this.lbrHaveCapitalLetter);
            this.Controls.Add(this.lbrSecondChar);
            this.Controls.Add(this.lbrLength);
            this.Controls.Add(this.lbrTime);
            this.Controls.Add(this.lbSortNumber);
            this.Controls.Add(this.lbHaveNumber);
            this.Controls.Add(this.lbTotalCapitalLetter);
            this.Controls.Add(this.lbHaveCapitalLetter);
            this.Controls.Add(this.lbSecondCharter);
            this.Controls.Add(this.lbLegend);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btChangeServer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtDataRecibed);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Service Socket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtDataRecibed;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btChangeServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dtTime;
        private System.Windows.Forms.Label lbLegend;
        private System.Windows.Forms.Label lbHaveCapitalLetter;
        private System.Windows.Forms.Label lbSecondCharter;
        private System.Windows.Forms.Label lbSortNumber;
        private System.Windows.Forms.Label lbHaveNumber;
        private System.Windows.Forms.Label lbTotalCapitalLetter;
        private System.Windows.Forms.Label lbrListSortNumber;
        private System.Windows.Forms.Label lbrTotalNumbers;
        private System.Windows.Forms.Label lbrTotalCapitalLetter;
        private System.Windows.Forms.Label lbrHaveCapitalLetter;
        private System.Windows.Forms.Label lbrSecondChar;
        private System.Windows.Forms.Label lbrLength;
        private System.Windows.Forms.Label lbrTime;
    }
}

