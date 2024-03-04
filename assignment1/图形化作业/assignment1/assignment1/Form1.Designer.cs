
namespace assignment1
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
            this.calculate = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calOpcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.calculate.Location = new System.Drawing.Point(529, 342);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(196, 57);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add.Location = new System.Drawing.Point(529, 121);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 80);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sub.Location = new System.Drawing.Point(645, 121);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(80, 80);
            this.sub.TabIndex = 2;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multi
            // 
            this.multi.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.multi.Location = new System.Drawing.Point(529, 227);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(80, 80);
            this.multi.TabIndex = 3;
            this.multi.Text = "×";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divide.Location = new System.Drawing.Point(645, 227);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 80);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(89, 110);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(266, 25);
            this.number1.TabIndex = 5;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(509, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "请选择运算符并点击计算";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F);
            this.label2.Location = new System.Drawing.Point(85, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "请输入第一个参与计算的数字：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F);
            this.label3.Location = new System.Drawing.Point(85, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "请输入第二个参与计算的数字：";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(89, 194);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(266, 25);
            this.number2.TabIndex = 9;
            this.number2.TextChanged += new System.EventHandler(this.number2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F);
            this.label4.Location = new System.Drawing.Point(85, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "最终计算结果为：";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(89, 364);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(266, 25);
            this.result.TabIndex = 11;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 12F);
            this.label5.Location = new System.Drawing.Point(87, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "此时选择的运算符为：";
            // 
            // calOpcode
            // 
            this.calOpcode.Location = new System.Drawing.Point(91, 282);
            this.calOpcode.Name = "calOpcode";
            this.calOpcode.Size = new System.Drawing.Size(266, 25);
            this.calOpcode.TabIndex = 13;
            this.calOpcode.TextChanged += new System.EventHandler(this.calOpcode_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 523);
            this.Controls.Add(this.calOpcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox calOpcode;
    }
}

