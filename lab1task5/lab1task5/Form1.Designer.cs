namespace lab1task5
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
            this.button1_Opacity = new System.Windows.Forms.Button();
            this.button2_Color = new System.Windows.Forms.Button();
            this.button3_HelloWorld = new System.Windows.Forms.Button();
            this.button4_SuperBtn = new System.Windows.Forms.Button();
            this.checkBox1_Opacity = new System.Windows.Forms.CheckBox();
            this.checkBox2_Color = new System.Windows.Forms.CheckBox();
            this.checkBox3_HelloWorld = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1_Opacity
            // 
            this.button1_Opacity.Location = new System.Drawing.Point(12, 0);
            this.button1_Opacity.Name = "button1_Opacity";
            this.button1_Opacity.Size = new System.Drawing.Size(107, 33);
            this.button1_Opacity.TabIndex = 0;
            this.button1_Opacity.Text = "Прозорість";
            this.button1_Opacity.UseVisualStyleBackColor = true;
            this.button1_Opacity.Click += new System.EventHandler(this.button1_Opacity_Click);
            // 
            // button2_Color
            // 
            this.button2_Color.Location = new System.Drawing.Point(125, 0);
            this.button2_Color.Name = "button2_Color";
            this.button2_Color.Size = new System.Drawing.Size(110, 33);
            this.button2_Color.TabIndex = 1;
            this.button2_Color.Text = "Колір тла";
            this.button2_Color.UseVisualStyleBackColor = true;
            this.button2_Color.Click += new System.EventHandler(this.button2_Color_Click);
            // 
            // button3_HelloWorld
            // 
            this.button3_HelloWorld.Location = new System.Drawing.Point(241, 0);
            this.button3_HelloWorld.Name = "button3_HelloWorld";
            this.button3_HelloWorld.Size = new System.Drawing.Size(104, 33);
            this.button3_HelloWorld.TabIndex = 2;
            this.button3_HelloWorld.Text = "hello World";
            this.button3_HelloWorld.UseVisualStyleBackColor = true;
            this.button3_HelloWorld.Click += new System.EventHandler(this.button3_HelloWorld_Click);
            // 
            // button4_SuperBtn
            // 
            this.button4_SuperBtn.Location = new System.Drawing.Point(12, 56);
            this.button4_SuperBtn.Name = "button4_SuperBtn";
            this.button4_SuperBtn.Size = new System.Drawing.Size(330, 31);
            this.button4_SuperBtn.TabIndex = 3;
            this.button4_SuperBtn.Text = "супермегакнопка";
            this.button4_SuperBtn.UseVisualStyleBackColor = true;
            this.button4_SuperBtn.Click += new System.EventHandler(this.button4_SuperBtn_Click);
            // 
            // checkBox1_Opacity
            // 
            this.checkBox1_Opacity.AutoSize = true;
            this.checkBox1_Opacity.Location = new System.Drawing.Point(11, 111);
            this.checkBox1_Opacity.Name = "checkBox1_Opacity";
            this.checkBox1_Opacity.Size = new System.Drawing.Size(307, 20);
            this.checkBox1_Opacity.TabIndex = 4;
            this.checkBox1_Opacity.Text = "\"супермегакнопка\" поглинає \"Прозорість\"";
            this.checkBox1_Opacity.UseVisualStyleBackColor = true;
            this.checkBox1_Opacity.CheckedChanged += new System.EventHandler(this.checkBox1_Opacity_CheckedChanged);
            // 
            // checkBox2_Color
            // 
            this.checkBox2_Color.AutoSize = true;
            this.checkBox2_Color.Location = new System.Drawing.Point(11, 137);
            this.checkBox2_Color.Name = "checkBox2_Color";
            this.checkBox2_Color.Size = new System.Drawing.Size(294, 20);
            this.checkBox2_Color.TabIndex = 5;
            this.checkBox2_Color.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            this.checkBox2_Color.UseVisualStyleBackColor = true;
            this.checkBox2_Color.CheckedChanged += new System.EventHandler(this.checkBox2_Color_CheckedChanged);
            // 
            // checkBox3_HelloWorld
            // 
            this.checkBox3_HelloWorld.AutoSize = true;
            this.checkBox3_HelloWorld.Location = new System.Drawing.Point(11, 163);
            this.checkBox3_HelloWorld.Name = "checkBox3_HelloWorld";
            this.checkBox3_HelloWorld.Size = new System.Drawing.Size(304, 20);
            this.checkBox3_HelloWorld.TabIndex = 6;
            this.checkBox3_HelloWorld.Text = "\"супермегакнопка\" поглинає \"Hello World\"";
            this.checkBox3_HelloWorld.UseVisualStyleBackColor = true;
            this.checkBox3_HelloWorld.CheckedChanged += new System.EventHandler(this.checkBox3_HelloWorld_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 328);
            this.Controls.Add(this.checkBox3_HelloWorld);
            this.Controls.Add(this.checkBox2_Color);
            this.Controls.Add(this.checkBox1_Opacity);
            this.Controls.Add(this.button4_SuperBtn);
            this.Controls.Add(this.button3_HelloWorld);
            this.Controls.Add(this.button2_Color);
            this.Controls.Add(this.button1_Opacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Opacity;
        private System.Windows.Forms.Button button2_Color;
        private System.Windows.Forms.Button button3_HelloWorld;
        private System.Windows.Forms.Button button4_SuperBtn;
        private System.Windows.Forms.CheckBox checkBox1_Opacity;
        private System.Windows.Forms.CheckBox checkBox2_Color;
        private System.Windows.Forms.CheckBox checkBox3_HelloWorld;
    }
}

