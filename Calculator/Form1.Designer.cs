namespace Calculator
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
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.lblAddition = new System.Windows.Forms.Label();
            this.lblSubtraction = new System.Windows.Forms.Label();
            this.lblMultiplication = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.Location = new System.Drawing.Point(13, 13);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(92, 82);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.Location = new System.Drawing.Point(13, 113);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(92, 79);
            this.btnSubtraction.TabIndex = 1;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(13, 212);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(92, 78);
            this.btnMultiplication.TabIndex = 2;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(13, 314);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(92, 79);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // lblAddition
            // 
            this.lblAddition.AutoSize = true;
            this.lblAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddition.Location = new System.Drawing.Point(127, 48);
            this.lblAddition.Name = "lblAddition";
            this.lblAddition.Size = new System.Drawing.Size(108, 25);
            this.lblAddition.TabIndex = 4;
            this.lblAddition.Text = "8 + 8 = 16";
            this.lblAddition.Visible = false;
            // 
            // lblSubtraction
            // 
            this.lblSubtraction.AutoSize = true;
            this.lblSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtraction.Location = new System.Drawing.Point(127, 146);
            this.lblSubtraction.Name = "lblSubtraction";
            this.lblSubtraction.Size = new System.Drawing.Size(91, 25);
            this.lblSubtraction.TabIndex = 5;
            this.lblSubtraction.Text = "8 - 8 = 0";
            this.lblSubtraction.Visible = false;
            // 
            // lblMultiplication
            // 
            this.lblMultiplication.AutoSize = true;
            this.lblMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplication.Location = new System.Drawing.Point(127, 245);
            this.lblMultiplication.Name = "lblMultiplication";
            this.lblMultiplication.Size = new System.Drawing.Size(107, 25);
            this.lblMultiplication.TabIndex = 6;
            this.lblMultiplication.Text = "8 x 8 = 64";
            this.lblMultiplication.Visible = false;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(127, 347);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(90, 25);
            this.lblDivision.TabIndex = 7;
            this.lblDivision.Text = "8 / 8 = 1";
            this.lblDivision.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplication);
            this.Controls.Add(this.lblSubtraction);
            this.Controls.Add(this.lblAddition);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label lblAddition;
        private System.Windows.Forms.Label lblSubtraction;
        private System.Windows.Forms.Label lblMultiplication;
        private System.Windows.Forms.Label lblDivision;
    }
}

