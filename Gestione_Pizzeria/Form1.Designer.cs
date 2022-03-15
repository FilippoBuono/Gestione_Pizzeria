
namespace Gestione_Pizzeria
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnMargherite = new System.Windows.Forms.Label();
            this.lblnStagioni = new System.Windows.Forms.Label();
            this.lblnVerdure = new System.Windows.Forms.Label();
            this.cmbTipoPizze = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtquantità = new System.Windows.Forms.TextBox();
            this.lstriepilogo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantità";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Riepilogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Pizza Margerita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Pizza 4 Stagioni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo Pizza Verdure:";
            // 
            // lblnMargherite
            // 
            this.lblnMargherite.AutoSize = true;
            this.lblnMargherite.Location = new System.Drawing.Point(699, 226);
            this.lblnMargherite.Name = "lblnMargherite";
            this.lblnMargherite.Size = new System.Drawing.Size(13, 15);
            this.lblnMargherite.TabIndex = 6;
            this.lblnMargherite.Text = "0";
            // 
            // lblnStagioni
            // 
            this.lblnStagioni.AutoSize = true;
            this.lblnStagioni.Location = new System.Drawing.Point(699, 258);
            this.lblnStagioni.Name = "lblnStagioni";
            this.lblnStagioni.Size = new System.Drawing.Size(13, 15);
            this.lblnStagioni.TabIndex = 7;
            this.lblnStagioni.Text = "0";
            // 
            // lblnVerdure
            // 
            this.lblnVerdure.AutoSize = true;
            this.lblnVerdure.Location = new System.Drawing.Point(699, 288);
            this.lblnVerdure.Name = "lblnVerdure";
            this.lblnVerdure.Size = new System.Drawing.Size(13, 15);
            this.lblnVerdure.TabIndex = 8;
            this.lblnVerdure.Text = "0";
            // 
            // cmbTipoPizze
            // 
            this.cmbTipoPizze.FormattingEnabled = true;
            this.cmbTipoPizze.Items.AddRange(new object[] {
            "Margherita",
            "4 Stagioni",
            "Vedure"});
            this.cmbTipoPizze.Location = new System.Drawing.Point(153, 45);
            this.cmbTipoPizze.Name = "cmbTipoPizze";
            this.cmbTipoPizze.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoPizze.TabIndex = 9;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(334, 45);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 10;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // txtquantità
            // 
            this.txtquantità.Location = new System.Drawing.Point(153, 119);
            this.txtquantità.Name = "txtquantità";
            this.txtquantità.Size = new System.Drawing.Size(49, 23);
            this.txtquantità.TabIndex = 11;
            // 
            // lstriepilogo
            // 
            this.lstriepilogo.FormattingEnabled = true;
            this.lstriepilogo.ItemHeight = 15;
            this.lstriepilogo.Location = new System.Drawing.Point(489, 74);
            this.lstriepilogo.Name = "lstriepilogo";
            this.lstriepilogo.Size = new System.Drawing.Size(155, 124);
            this.lstriepilogo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstriepilogo);
            this.Controls.Add(this.txtquantità);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cmbTipoPizze);
            this.Controls.Add(this.lblnVerdure);
            this.Controls.Add(this.lblnStagioni);
            this.Controls.Add(this.lblnMargherite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnMargherite;
        private System.Windows.Forms.Label lblnStagioni;
        private System.Windows.Forms.Label lblnVerdure;
        private System.Windows.Forms.ComboBox cmbTipoPizze;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.TextBox txtquantità;
        private System.Windows.Forms.ListBox lstriepilogo;
    }
}

