
namespace WindowsFormsApp22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Rendszam = new System.Windows.Forms.TextBox();
            this.comboBox_Gyartmany = new System.Windows.Forms.ComboBox();
            this.textBox_Tipus = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Uzembehelyezés = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Szin = new System.Windows.Forms.ComboBox();
            this.checkBox_Muszaki = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renszám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyártmány";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üzembehyezve";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "szín";
            // 
            // textBox_Rendszam
            // 
            this.textBox_Rendszam.Location = new System.Drawing.Point(209, 36);
            this.textBox_Rendszam.Name = "textBox_Rendszam";
            this.textBox_Rendszam.Size = new System.Drawing.Size(200, 26);
            this.textBox_Rendszam.TabIndex = 6;
            // 
            // comboBox_Gyartmany
            // 
            this.comboBox_Gyartmany.FormattingEnabled = true;
            this.comboBox_Gyartmany.Location = new System.Drawing.Point(209, 74);
            this.comboBox_Gyartmany.Name = "comboBox_Gyartmany";
            this.comboBox_Gyartmany.Size = new System.Drawing.Size(200, 28);
            this.comboBox_Gyartmany.TabIndex = 7;
            // 
            // textBox_Tipus
            // 
            this.textBox_Tipus.Location = new System.Drawing.Point(209, 112);
            this.textBox_Tipus.Name = "textBox_Tipus";
            this.textBox_Tipus.Size = new System.Drawing.Size(200, 26);
            this.textBox_Tipus.TabIndex = 8;
            // 
            // dateTimePicker_Uzembehelyezés
            // 
            this.dateTimePicker_Uzembehelyezés.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Uzembehelyezés.Location = new System.Drawing.Point(209, 143);
            this.dateTimePicker_Uzembehelyezés.Name = "dateTimePicker_Uzembehelyezés";
            this.dateTimePicker_Uzembehelyezés.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_Uzembehelyezés.TabIndex = 9;
            // 
            // comboBox_Szin
            // 
            this.comboBox_Szin.FormattingEnabled = true;
            this.comboBox_Szin.Location = new System.Drawing.Point(209, 180);
            this.comboBox_Szin.Name = "comboBox_Szin";
            this.comboBox_Szin.Size = new System.Drawing.Size(200, 28);
            this.comboBox_Szin.TabIndex = 10;
            // 
            // checkBox_Muszaki
            // 
            this.checkBox_Muszaki.AutoSize = true;
            this.checkBox_Muszaki.Location = new System.Drawing.Point(209, 222);
            this.checkBox_Muszaki.Name = "checkBox_Muszaki";
            this.checkBox_Muszaki.Size = new System.Drawing.Size(153, 24);
            this.checkBox_Muszaki.TabIndex = 11;
            this.checkBox_Muszaki.Text = "műszaki érvényes";
            this.checkBox_Muszaki.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(295, 299);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(114, 36);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Mentes";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(71, 299);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(114, 36);
            this.button_Read.TabIndex = 12;
            this.button_Read.Text = "Visszatöltés";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 362);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_Muszaki);
            this.Controls.Add(this.comboBox_Szin);
            this.Controls.Add(this.dateTimePicker_Uzembehelyezés);
            this.Controls.Add(this.textBox_Tipus);
            this.Controls.Add(this.comboBox_Gyartmany);
            this.Controls.Add(this.textBox_Rendszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Autókölcsönzés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Rendszam;
        private System.Windows.Forms.ComboBox comboBox_Gyartmany;
        private System.Windows.Forms.TextBox textBox_Tipus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Uzembehelyezés;
        private System.Windows.Forms.ComboBox comboBox_Szin;
        private System.Windows.Forms.CheckBox checkBox_Muszaki;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Read;
    }
}

