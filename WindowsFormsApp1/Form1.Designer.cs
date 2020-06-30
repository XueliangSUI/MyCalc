namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEquip = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxOP2 = new System.Windows.Forms.TextBox();
            this.textBoxOP1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelResult);
            this.panel4.Location = new System.Drawing.Point(91, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 74);
            this.panel4.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("宋体", 18F);
            this.labelResult.Location = new System.Drawing.Point(52, 22);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(82, 24);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Result";
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonEquip);
            this.panel3.Controls.Add(this.buttonDiv);
            this.panel3.Controls.Add(this.buttonMul);
            this.panel3.Controls.Add(this.buttonSub);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Location = new System.Drawing.Point(402, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 373);
            this.panel3.TabIndex = 1;
            // 
            // buttonEquip
            // 
            this.buttonEquip.Location = new System.Drawing.Point(45, 213);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(75, 23);
            this.buttonEquip.TabIndex = 4;
            this.buttonEquip.Text = "=";
            this.buttonEquip.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(45, 168);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 3;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(45, 139);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 23);
            this.buttonMul.TabIndex = 2;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(45, 93);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "－";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 64);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "＋";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxOP2);
            this.panel2.Controls.Add(this.textBoxOP1);
            this.panel2.Location = new System.Drawing.Point(18, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 150);
            this.panel2.TabIndex = 0;
            // 
            // textBoxOP2
            // 
            this.textBoxOP2.Font = new System.Drawing.Font("宋体", 18F);
            this.textBoxOP2.Location = new System.Drawing.Point(37, 78);
            this.textBoxOP2.Name = "textBoxOP2";
            this.textBoxOP2.Size = new System.Drawing.Size(238, 35);
            this.textBoxOP2.TabIndex = 1;
            // 
            // textBoxOP1
            // 
            this.textBoxOP1.Font = new System.Drawing.Font("宋体", 18F);
            this.textBoxOP1.Location = new System.Drawing.Point(37, 36);
            this.textBoxOP1.Name = "textBoxOP1";
            this.textBoxOP1.Size = new System.Drawing.Size(238, 35);
            this.textBoxOP1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxOP2;
        private System.Windows.Forms.TextBox textBoxOP1;
    }
}

