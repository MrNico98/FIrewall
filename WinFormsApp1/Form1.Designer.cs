namespace WinFormsApp1
{
    partial class Firewall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firewall));
            btnselezionaexe = new Button();
            exeselect = new Label();
            btnapplicafirewall = new Button();
            SuspendLayout();
            // 
            // btnselezionaexe
            // 
            btnselezionaexe.Location = new Point(12, 83);
            btnselezionaexe.Name = "btnselezionaexe";
            btnselezionaexe.Size = new Size(94, 51);
            btnselezionaexe.TabIndex = 0;
            btnselezionaexe.Text = "Seleziona EXE";
            btnselezionaexe.UseVisualStyleBackColor = true;
            btnselezionaexe.Click += btnselezionaexe_Click;
            // 
            // exeselect
            // 
            exeselect.AutoSize = true;
            exeselect.Location = new Point(12, 25);
            exeselect.Name = "exeselect";
            exeselect.Size = new Size(92, 20);
            exeselect.TabIndex = 1;
            exeselect.Text = "Percorso exe";
            // 
            // btnapplicafirewall
            // 
            btnapplicafirewall.Location = new Point(187, 83);
            btnapplicafirewall.Name = "btnapplicafirewall";
            btnapplicafirewall.Size = new Size(94, 51);
            btnapplicafirewall.TabIndex = 2;
            btnapplicafirewall.Text = "Aggiungi al Firewall";
            btnapplicafirewall.UseVisualStyleBackColor = true;
            btnapplicafirewall.Click += btnapplicafirewall_Click;
            // 
            // Firewall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 164);
            Controls.Add(btnapplicafirewall);
            Controls.Add(exeselect);
            Controls.Add(btnselezionaexe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Firewall";
            Text = "Firewall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnselezionaexe;
        private Label exeselect;
        private Button btnapplicafirewall;
    }
}
