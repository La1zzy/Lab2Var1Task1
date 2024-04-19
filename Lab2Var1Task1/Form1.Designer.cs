namespace Lab2Var1Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MeatUpDown = new System.Windows.Forms.NumericUpDown();
            this.HawaiianUpDown = new System.Windows.Forms.NumericUpDown();
            this.PeperoniUpDown = new System.Windows.Forms.NumericUpDown();
            this.MeatPrice = new System.Windows.Forms.TextBox();
            this.HawaiianPrice = new System.Windows.Forms.TextBox();
            this.PeperoniPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CoffeeUpDown = new System.Windows.Forms.NumericUpDown();
            this.CoffeePrice = new System.Windows.Forms.TextBox();
            this.JuiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.JuicePrice = new System.Windows.Forms.TextBox();
            this.TeaUpDown = new System.Windows.Forms.NumericUpDown();
            this.TeaPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeatUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HawaiianUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeperoniUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuiceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeaUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(256, 349);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MeatUpDown);
            this.tabPage1.Controls.Add(this.HawaiianUpDown);
            this.tabPage1.Controls.Add(this.PeperoniUpDown);
            this.tabPage1.Controls.Add(this.totalPrice);
            this.tabPage1.Controls.Add(this.MeatPrice);
            this.tabPage1.Controls.Add(this.HawaiianPrice);
            this.tabPage1.Controls.Add(this.PeperoniPrice);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Піца";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MeatUpDown
            // 
            this.MeatUpDown.Location = new System.Drawing.Point(107, 67);
            this.MeatUpDown.Name = "MeatUpDown";
            this.MeatUpDown.Size = new System.Drawing.Size(30, 20);
            this.MeatUpDown.TabIndex = 1;
            // 
            // HawaiianUpDown
            // 
            this.HawaiianUpDown.Location = new System.Drawing.Point(107, 33);
            this.HawaiianUpDown.Name = "HawaiianUpDown";
            this.HawaiianUpDown.Size = new System.Drawing.Size(29, 20);
            this.HawaiianUpDown.TabIndex = 1;
            // 
            // PeperoniUpDown
            // 
            this.PeperoniUpDown.Location = new System.Drawing.Point(107, 3);
            this.PeperoniUpDown.Name = "PeperoniUpDown";
            this.PeperoniUpDown.Size = new System.Drawing.Size(29, 20);
            this.PeperoniUpDown.TabIndex = 1;
            // 
            // MeatPrice
            // 
            this.MeatPrice.Location = new System.Drawing.Point(142, 67);
            this.MeatPrice.Name = "MeatPrice";
            this.MeatPrice.Size = new System.Drawing.Size(100, 20);
            this.MeatPrice.TabIndex = 3;
            this.MeatPrice.Text = "160";
            // 
            // HawaiianPrice
            // 
            this.HawaiianPrice.Location = new System.Drawing.Point(142, 33);
            this.HawaiianPrice.Name = "HawaiianPrice";
            this.HawaiianPrice.Size = new System.Drawing.Size(100, 20);
            this.HawaiianPrice.TabIndex = 1;
            this.HawaiianPrice.Text = "150";
            // 
            // PeperoniPrice
            // 
            this.PeperoniPrice.Location = new System.Drawing.Point(142, 0);
            this.PeperoniPrice.Name = "PeperoniPrice";
            this.PeperoniPrice.Size = new System.Drawing.Size(100, 20);
            this.PeperoniPrice.TabIndex = 1;
            this.PeperoniPrice.Text = "140";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Піца М\'ясна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Піца Гавайська ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Піца Пепероні ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CoffeeUpDown);
            this.tabPage2.Controls.Add(this.CoffeePrice);
            this.tabPage2.Controls.Add(this.JuiceUpDown);
            this.tabPage2.Controls.Add(this.JuicePrice);
            this.tabPage2.Controls.Add(this.TeaUpDown);
            this.tabPage2.Controls.Add(this.TeaPrice);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Напої";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CoffeeUpDown
            // 
            this.CoffeeUpDown.Location = new System.Drawing.Point(59, 81);
            this.CoffeeUpDown.Name = "CoffeeUpDown";
            this.CoffeeUpDown.Size = new System.Drawing.Size(31, 20);
            this.CoffeeUpDown.TabIndex = 3;
            // 
            // CoffeePrice
            // 
            this.CoffeePrice.Location = new System.Drawing.Point(108, 81);
            this.CoffeePrice.Name = "CoffeePrice";
            this.CoffeePrice.Size = new System.Drawing.Size(100, 20);
            this.CoffeePrice.TabIndex = 5;
            this.CoffeePrice.Text = "30";
            // 
            // JuiceUpDown
            // 
            this.JuiceUpDown.Location = new System.Drawing.Point(59, 45);
            this.JuiceUpDown.Name = "JuiceUpDown";
            this.JuiceUpDown.Size = new System.Drawing.Size(31, 20);
            this.JuiceUpDown.TabIndex = 2;
            // 
            // JuicePrice
            // 
            this.JuicePrice.Location = new System.Drawing.Point(108, 44);
            this.JuicePrice.Name = "JuicePrice";
            this.JuicePrice.Size = new System.Drawing.Size(100, 20);
            this.JuicePrice.TabIndex = 4;
            this.JuicePrice.Text = "25";
            // 
            // TeaUpDown
            // 
            this.TeaUpDown.Location = new System.Drawing.Point(59, 10);
            this.TeaUpDown.Name = "TeaUpDown";
            this.TeaUpDown.Size = new System.Drawing.Size(31, 20);
            this.TeaUpDown.TabIndex = 1;
            // 
            // TeaPrice
            // 
            this.TeaPrice.Location = new System.Drawing.Point(108, 10);
            this.TeaPrice.Name = "TeaPrice";
            this.TeaPrice.Size = new System.Drawing.Size(100, 20);
            this.TeaPrice.TabIndex = 3;
            this.TeaPrice.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кава";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Сік";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Чай";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.orderButton);
            this.flowLayoutPanel1.Controls.Add(this.cancelButton);
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 355);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 35);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(3, 3);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Замовити";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(84, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(165, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(145, 297);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 20);
            this.totalPrice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeatUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HawaiianUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeperoniUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuiceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeaUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HawaiianPrice;
        private System.Windows.Forms.TextBox PeperoniPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MeatPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CoffeePrice;
        private System.Windows.Forms.TextBox JuicePrice;
        private System.Windows.Forms.TextBox TeaPrice;
        private System.Windows.Forms.NumericUpDown MeatUpDown;
        private System.Windows.Forms.NumericUpDown HawaiianUpDown;
        private System.Windows.Forms.NumericUpDown PeperoniUpDown;
        private System.Windows.Forms.NumericUpDown CoffeeUpDown;
        private System.Windows.Forms.NumericUpDown JuiceUpDown;
        private System.Windows.Forms.NumericUpDown TeaUpDown;
        private System.Windows.Forms.TextBox totalPrice;
    }
}

