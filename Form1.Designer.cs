
namespace Payments
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirmLbl = new System.Windows.Forms.Label();
            this.RepLbl = new System.Windows.Forms.Label();
            this.FirmTmTxBox = new System.Windows.Forms.TextBox();
            this.RepTmTxBox = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.OutChBox = new System.Windows.Forms.CheckBox();
            this.PrcLbl = new System.Windows.Forms.Label();
            this.PrcValLbl = new System.Windows.Forms.Label();
            this.EmbLbl = new System.Windows.Forms.Label();
            this.EmbTmTxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirmLbl
            // 
            this.FirmLbl.AutoSize = true;
            this.FirmLbl.Location = new System.Drawing.Point(76, 63);
            this.FirmLbl.Name = "FirmLbl";
            this.FirmLbl.Size = new System.Drawing.Size(118, 17);
            this.FirmLbl.TabIndex = 4;
            this.FirmLbl.Text = "Firmware flashing";
            // 
            // RepLbl
            // 
            this.RepLbl.AutoSize = true;
            this.RepLbl.Location = new System.Drawing.Point(76, 103);
            this.RepLbl.Name = "RepLbl";
            this.RepLbl.Size = new System.Drawing.Size(116, 17);
            this.RepLbl.TabIndex = 5;
            this.RepLbl.Text = "Part replacement";
            // 
            // FirmTmTxBox
            // 
            this.FirmTmTxBox.Location = new System.Drawing.Point(236, 60);
            this.FirmTmTxBox.Name = "FirmTmTxBox";
            this.FirmTmTxBox.Size = new System.Drawing.Size(50, 22);
            this.FirmTmTxBox.TabIndex = 6;
            // 
            // RepTmTxBox
            // 
            this.RepTmTxBox.Location = new System.Drawing.Point(236, 100);
            this.RepTmTxBox.Name = "RepTmTxBox";
            this.RepTmTxBox.Size = new System.Drawing.Size(50, 22);
            this.RepTmTxBox.TabIndex = 7;
            this.RepTmTxBox.TextChanged += new System.EventHandler(this.RepTmTxBox_TextChanged);
            // 
            // CalBtn
            // 
            this.CalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CalBtn.Location = new System.Drawing.Point(79, 315);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(100, 35);
            this.CalBtn.TabIndex = 8;
            this.CalBtn.Text = "Calculate";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // OutChBox
            // 
            this.OutChBox.AutoSize = true;
            this.OutChBox.Location = new System.Drawing.Point(432, 57);
            this.OutChBox.Name = "OutChBox";
            this.OutChBox.Size = new System.Drawing.Size(93, 21);
            this.OutChBox.TabIndex = 9;
            this.OutChBox.Text = "Outdoors ";
            this.OutChBox.UseVisualStyleBackColor = true;
            // 
            // PrcLbl
            // 
            this.PrcLbl.AutoSize = true;
            this.PrcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PrcLbl.Location = new System.Drawing.Point(427, 325);
            this.PrcLbl.Name = "PrcLbl";
            this.PrcLbl.Size = new System.Drawing.Size(62, 25);
            this.PrcLbl.TabIndex = 10;
            this.PrcLbl.Text = "Price:";
            // 
            // PrcValLbl
            // 
            this.PrcValLbl.AutoSize = true;
            this.PrcValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PrcValLbl.Location = new System.Drawing.Point(494, 325);
            this.PrcValLbl.Name = "PrcValLbl";
            this.PrcValLbl.Size = new System.Drawing.Size(39, 25);
            this.PrcValLbl.TabIndex = 11;
            this.PrcValLbl.Text = "0 €";
            // 
            // EmbLbl
            // 
            this.EmbLbl.AutoSize = true;
            this.EmbLbl.Location = new System.Drawing.Point(76, 143);
            this.EmbLbl.Name = "EmbLbl";
            this.EmbLbl.Size = new System.Drawing.Size(159, 17);
            this.EmbLbl.TabIndex = 12;
            this.EmbLbl.Text = "Mothertboard embeding";
            this.EmbLbl.Click += new System.EventHandler(this.EmbLbl_Click);
            // 
            // EmbTmTxBox
            // 
            this.EmbTmTxBox.Location = new System.Drawing.Point(236, 140);
            this.EmbTmTxBox.Name = "EmbTmTxBox";
            this.EmbTmTxBox.Size = new System.Drawing.Size(50, 22);
            this.EmbTmTxBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time (Hours)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmbTmTxBox);
            this.Controls.Add(this.EmbLbl);
            this.Controls.Add(this.PrcValLbl);
            this.Controls.Add(this.PrcLbl);
            this.Controls.Add(this.OutChBox);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.RepTmTxBox);
            this.Controls.Add(this.FirmTmTxBox);
            this.Controls.Add(this.RepLbl);
            this.Controls.Add(this.FirmLbl);
            this.Name = "Form1";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirmLbl;
        private System.Windows.Forms.Label RepLbl;
        private System.Windows.Forms.TextBox FirmTmTxBox;
        private System.Windows.Forms.TextBox RepTmTxBox;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.CheckBox OutChBox;
        private System.Windows.Forms.Label PrcLbl;
        private System.Windows.Forms.Label PrcValLbl;
        private System.Windows.Forms.Label EmbLbl;
        private System.Windows.Forms.TextBox EmbTmTxBox;
        private System.Windows.Forms.Label label2;
    }
}

