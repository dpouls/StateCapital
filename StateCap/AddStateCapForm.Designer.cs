
namespace StateCap
{
    partial class AddStateCapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtBoxState = new System.Windows.Forms.TextBox();
            this.TxtBoxCapital = new System.Windows.Forms.TextBox();
            this.LstBoxStateCaps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(146, 212);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(235, 54);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "&Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtBoxState
            // 
            this.TxtBoxState.Location = new System.Drawing.Point(231, 104);
            this.TxtBoxState.Name = "TxtBoxState";
            this.TxtBoxState.Size = new System.Drawing.Size(150, 31);
            this.TxtBoxState.TabIndex = 0;
            // 
            // TxtBoxCapital
            // 
            this.TxtBoxCapital.Location = new System.Drawing.Point(231, 159);
            this.TxtBoxCapital.Name = "TxtBoxCapital";
            this.TxtBoxCapital.Size = new System.Drawing.Size(150, 31);
            this.TxtBoxCapital.TabIndex = 1;
            // 
            // LstBoxStateCaps
            // 
            this.LstBoxStateCaps.FormattingEnabled = true;
            this.LstBoxStateCaps.ItemHeight = 25;
            this.LstBoxStateCaps.Location = new System.Drawing.Point(445, 22);
            this.LstBoxStateCaps.Name = "LstBoxStateCaps";
            this.LstBoxStateCaps.Size = new System.Drawing.Size(316, 379);
            this.LstBoxStateCaps.TabIndex = 5;
            this.LstBoxStateCaps.TabStop = false;
            // 
            // AddStateCapForm
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstBoxStateCaps);
            this.Controls.Add(this.TxtBoxCapital);
            this.Controls.Add(this.TxtBoxState);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStateCapForm";
            this.Text = "Add State & Capital";
            this.Load += new System.EventHandler(this.AddStateCapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtBoxState;
        private System.Windows.Forms.TextBox TxtBoxCapital;
        private System.Windows.Forms.ListBox LstBoxStateCaps;
    }
}

