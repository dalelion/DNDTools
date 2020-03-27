namespace DNDTools
{
    partial class characterInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStrVar = new System.Windows.Forms.Label();
            this.lblStrConst = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStrUp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonStrDown_Click);
            // 
            // lblStrVar
            // 
            this.lblStrVar.AutoSize = true;
            this.lblStrVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrVar.Location = new System.Drawing.Point(101, 12);
            this.lblStrVar.Name = "lblStrVar";
            this.lblStrVar.Size = new System.Drawing.Size(36, 20);
            this.lblStrVar.TabIndex = 2;
            this.lblStrVar.Text = "( 0 )";
            // 
            // lblStrConst
            // 
            this.lblStrConst.AutoSize = true;
            this.lblStrConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrConst.Location = new System.Drawing.Point(68, 15);
            this.lblStrConst.Name = "lblStrConst";
            this.lblStrConst.Size = new System.Drawing.Size(27, 20);
            this.lblStrConst.TabIndex = 3;
            this.lblStrConst.Text = "15";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.Location = new System.Drawing.Point(143, 15);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(71, 20);
            this.lblStr.TabIndex = 4;
            this.lblStr.Text = "Strength";
            // 
            // characterInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 647);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.lblStrConst);
            this.Controls.Add(this.lblStrVar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "characterInfo";
            this.Text = "Character Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblStrVar;
        private System.Windows.Forms.Label lblStrConst;
        private System.Windows.Forms.Label lblStr;
    }
}