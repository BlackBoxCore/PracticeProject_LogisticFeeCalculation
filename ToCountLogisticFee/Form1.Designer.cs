namespace ToCountLogisticFee
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
            this.lblTextOnly = new System.Windows.Forms.Label();
            this.lbl_ItemType = new System.Windows.Forms.Label();
            this.lbl_ItemWeight = new System.Windows.Forms.Label();
            this.txtBox_Type = new System.Windows.Forms.TextBox();
            this.txtBox_Weight = new System.Windows.Forms.TextBox();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextOnly
            // 
            this.lblTextOnly.AutoSize = true;
            this.lblTextOnly.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOnly.Location = new System.Drawing.Point(44, 53);
            this.lblTextOnly.Name = "lblTextOnly";
            this.lblTextOnly.Size = new System.Drawing.Size(475, 29);
            this.lblTextOnly.TabIndex = 0;
            this.lblTextOnly.Text = "Check Your Logistic Fee / 檢查您的物品費用";
            // 
            // lbl_ItemType
            // 
            this.lbl_ItemType.AutoSize = true;
            this.lbl_ItemType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemType.Location = new System.Drawing.Point(44, 96);
            this.lbl_ItemType.Name = "lbl_ItemType";
            this.lbl_ItemType.Size = new System.Drawing.Size(132, 32);
            this.lbl_ItemType.TabIndex = 1;
            this.lbl_ItemType.Text = "Item Type :";
            // 
            // lbl_ItemWeight
            // 
            this.lbl_ItemWeight.AutoSize = true;
            this.lbl_ItemWeight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemWeight.Location = new System.Drawing.Point(44, 141);
            this.lbl_ItemWeight.Name = "lbl_ItemWeight";
            this.lbl_ItemWeight.Size = new System.Drawing.Size(157, 32);
            this.lbl_ItemWeight.TabIndex = 2;
            this.lbl_ItemWeight.Text = "Item Weight :";
            // 
            // txtBox_Type
            // 
            this.txtBox_Type.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Type.Location = new System.Drawing.Point(182, 93);
            this.txtBox_Type.Name = "txtBox_Type";
            this.txtBox_Type.Size = new System.Drawing.Size(120, 38);
            this.txtBox_Type.TabIndex = 3;
            this.txtBox_Type.TextChanged += new System.EventHandler(this.txtBox_Type_TextChanged);
            // 
            // txtBox_Weight
            // 
            this.txtBox_Weight.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Weight.Location = new System.Drawing.Point(214, 135);
            this.txtBox_Weight.Name = "txtBox_Weight";
            this.txtBox_Weight.Size = new System.Drawing.Size(88, 38);
            this.txtBox_Weight.TabIndex = 4;
            this.txtBox_Weight.TextChanged += new System.EventHandler(this.txtBox_Weight_TextChanged);
            // 
            // btnOK1
            // 
            this.btnOK1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnOK1.Location = new System.Drawing.Point(50, 254);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(160, 45);
            this.btnOK1.TabIndex = 5;
            this.btnOK1.Text = "Check Now";
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Exit.Location = new System.Drawing.Point(593, 421);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(95, 45);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(239, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(135, 29);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result/結果";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please type if your item is Electronic or Not!";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.txtBox_Weight);
            this.Controls.Add(this.txtBox_Type);
            this.Controls.Add(this.lbl_ItemWeight);
            this.Controls.Add(this.lbl_ItemType);
            this.Controls.Add(this.lblTextOnly);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogisticFee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextOnly;
        private System.Windows.Forms.Label lbl_ItemType;
        private System.Windows.Forms.Label lbl_ItemWeight;
        private System.Windows.Forms.TextBox txtBox_Type;
        private System.Windows.Forms.TextBox txtBox_Weight;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
    }
}

