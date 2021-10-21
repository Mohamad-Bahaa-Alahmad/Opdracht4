namespace OPDRACHT4
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
            this.label1 = new System.Windows.Forms.Label();
            this.toevogen = new System.Windows.Forms.Button();
            this.volgende = new System.Windows.Forms.Button();
            this.achteraan = new System.Windows.Forms.Button();
            this.toonmbox = new System.Windows.Forms.Button();
            this.toonform = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.verwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel/Omschrijving";
            // 
            // toevogen
            // 
            this.toevogen.Location = new System.Drawing.Point(663, 25);
            this.toevogen.Name = "toevogen";
            this.toevogen.Size = new System.Drawing.Size(107, 43);
            this.toevogen.TabIndex = 1;
            this.toevogen.Text = "Taak Toevogen";
            this.toevogen.UseVisualStyleBackColor = true;
            this.toevogen.Click += new System.EventHandler(this.toevogen_Click);
            // 
            // volgende
            // 
            this.volgende.Location = new System.Drawing.Point(663, 85);
            this.volgende.Name = "volgende";
            this.volgende.Size = new System.Drawing.Size(107, 53);
            this.volgende.TabIndex = 2;
            this.volgende.Text = "Volgende";
            this.volgende.UseVisualStyleBackColor = true;
            this.volgende.Click += new System.EventHandler(this.volgende_Click);
            // 
            // achteraan
            // 
            this.achteraan.Location = new System.Drawing.Point(663, 153);
            this.achteraan.Name = "achteraan";
            this.achteraan.Size = new System.Drawing.Size(107, 57);
            this.achteraan.TabIndex = 3;
            this.achteraan.Text = "Zet achteraan";
            this.achteraan.UseVisualStyleBackColor = true;
            this.achteraan.Click += new System.EventHandler(this.achteraan_Click);
            // 
            // toonmbox
            // 
            this.toonmbox.BackColor = System.Drawing.Color.Red;
            this.toonmbox.Location = new System.Drawing.Point(663, 307);
            this.toonmbox.Name = "toonmbox";
            this.toonmbox.Size = new System.Drawing.Size(107, 58);
            this.toonmbox.TabIndex = 4;
            this.toonmbox.Text = "Toon in messageBox";
            this.toonmbox.UseVisualStyleBackColor = false;
            this.toonmbox.Click += new System.EventHandler(this.toonmbox_Click);
            // 
            // toonform
            // 
            this.toonform.BackColor = System.Drawing.Color.Red;
            this.toonform.Location = new System.Drawing.Point(663, 371);
            this.toonform.Name = "toonform";
            this.toonform.Size = new System.Drawing.Size(107, 55);
            this.toonform.TabIndex = 5;
            this.toonform.Text = "Toon in form";
            this.toonform.UseVisualStyleBackColor = false;
            this.toonform.Click += new System.EventHandler(this.toonform_Click);
            // 
            // titel
            // 
            this.titel.Location = new System.Drawing.Point(147, 64);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(437, 22);
            this.titel.TabIndex = 6;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(147, 194);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(437, 189);
            this.info.TabIndex = 7;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(15, 139);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(148, 20);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "Met geddan worden";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            // 
            // verwijder
            // 
            this.verwijder.Location = new System.Drawing.Point(663, 226);
            this.verwijder.Name = "verwijder";
            this.verwijder.Size = new System.Drawing.Size(107, 44);
            this.verwijder.TabIndex = 10;
            this.verwijder.Text = "Taak Verwijder";
            this.verwijder.UseVisualStyleBackColor = true;
            this.verwijder.Click += new System.EventHandler(this.verwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verwijder);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.info);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.toonform);
            this.Controls.Add(this.toonmbox);
            this.Controls.Add(this.achteraan);
            this.Controls.Add(this.volgende);
            this.Controls.Add(this.toevogen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toevogen;
        private System.Windows.Forms.Button volgende;
        private System.Windows.Forms.Button achteraan;
        private System.Windows.Forms.Button toonmbox;
        private System.Windows.Forms.Button toonform;
        private System.Windows.Forms.TextBox titel;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button verwijder;
    }
}

