
namespace Password_generator
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
            this.list_password = new System.Windows.Forms.ListBox();
            this.lblPassowordCharacters = new System.Windows.Forms.Label();
            this.count_pass = new System.Windows.Forms.NumericUpDown();
            this.check_Capital = new System.Windows.Forms.CheckBox();
            this.check_numbers = new System.Windows.Forms.CheckBox();
            this.check_symbols = new System.Windows.Forms.CheckBox();
            this.btnGenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // list_password
            // 
            this.list_password.FormattingEnabled = true;
            this.list_password.Location = new System.Drawing.Point(25, 28);
            this.list_password.Name = "list_password";
            this.list_password.Size = new System.Drawing.Size(217, 277);
            this.list_password.TabIndex = 0;
            // 
            // lblPassowordCharacters
            // 
            this.lblPassowordCharacters.AutoSize = true;
            this.lblPassowordCharacters.Location = new System.Drawing.Point(256, 28);
            this.lblPassowordCharacters.Name = "lblPassowordCharacters";
            this.lblPassowordCharacters.Size = new System.Drawing.Size(109, 13);
            this.lblPassowordCharacters.TabIndex = 1;
            this.lblPassowordCharacters.Text = "Number of characters";
            // 
            // count_pass
            // 
            this.count_pass.Location = new System.Drawing.Point(259, 56);
            this.count_pass.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.count_pass.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.count_pass.Name = "count_pass";
            this.count_pass.Size = new System.Drawing.Size(120, 20);
            this.count_pass.TabIndex = 2;
            this.count_pass.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // check_Capital
            // 
            this.check_Capital.AutoSize = true;
            this.check_Capital.Location = new System.Drawing.Point(259, 110);
            this.check_Capital.Name = "check_Capital";
            this.check_Capital.Size = new System.Drawing.Size(110, 17);
            this.check_Capital.TabIndex = 3;
            this.check_Capital.Text = "Use capital letters";
            this.check_Capital.UseVisualStyleBackColor = true;
            // 
            // check_numbers
            // 
            this.check_numbers.AutoSize = true;
            this.check_numbers.Location = new System.Drawing.Point(259, 149);
            this.check_numbers.Name = "check_numbers";
            this.check_numbers.Size = new System.Drawing.Size(88, 17);
            this.check_numbers.TabIndex = 4;
            this.check_numbers.Text = "Use numbers";
            this.check_numbers.UseVisualStyleBackColor = true;
            // 
            // check_symbols
            // 
            this.check_symbols.AutoSize = true;
            this.check_symbols.Location = new System.Drawing.Point(259, 193);
            this.check_symbols.Name = "check_symbols";
            this.check_symbols.Size = new System.Drawing.Size(85, 17);
            this.check_symbols.TabIndex = 5;
            this.check_symbols.Text = "Use symbols";
            this.check_symbols.UseVisualStyleBackColor = true;
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(259, 260);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(136, 45);
            this.btnGenerator.TabIndex = 6;
            this.btnGenerator.Text = "Password Generator";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 326);
            this.Controls.Add(this.btnGenerator);
            this.Controls.Add(this.check_symbols);
            this.Controls.Add(this.check_numbers);
            this.Controls.Add(this.check_Capital);
            this.Controls.Add(this.count_pass);
            this.Controls.Add(this.lblPassowordCharacters);
            this.Controls.Add(this.list_password);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.count_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_password;
        private System.Windows.Forms.Label lblPassowordCharacters;
        private System.Windows.Forms.NumericUpDown count_pass;
        private System.Windows.Forms.CheckBox check_Capital;
        private System.Windows.Forms.CheckBox check_numbers;
        private System.Windows.Forms.CheckBox check_symbols;
        private System.Windows.Forms.Button btnGenerator;
    }
}

