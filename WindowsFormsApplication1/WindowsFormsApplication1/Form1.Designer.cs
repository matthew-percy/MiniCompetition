namespace WindowsFormsApplication1
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
            this.creditCardTxt = new System.Windows.Forms.TextBox();
            this.issuerLabel = new System.Windows.Forms.Label();
            this.validateBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditCardTxt
            // 
            this.creditCardTxt.Location = new System.Drawing.Point(12, 45);
            this.creditCardTxt.Name = "creditCardTxt";
            this.creditCardTxt.Size = new System.Drawing.Size(260, 20);
            this.creditCardTxt.TabIndex = 0;
            this.creditCardTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.creditCardTxt_KeyDown);
            // 
            // issuerLabel
            // 
            this.issuerLabel.AutoSize = true;
            this.issuerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.issuerLabel.Location = new System.Drawing.Point(12, 80);
            this.issuerLabel.Name = "issuerLabel";
            this.issuerLabel.Size = new System.Drawing.Size(41, 13);
            this.issuerLabel.TabIndex = 1;
            this.issuerLabel.Text = "Issuer: ";
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(12, 109);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(260, 23);
            this.validateBtn.TabIndex = 2;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(12, 138);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(260, 23);
            this.copyBtn.TabIndex = 3;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 167);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(260, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.issuerLabel);
            this.Controls.Add(this.creditCardTxt);
            this.Name = "Form1";
            this.Text = "Credit card validator Flowers 4 U";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditCardTxt;
        private System.Windows.Forms.Label issuerLabel;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

