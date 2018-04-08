namespace BCH_code
{
    partial class MainForm
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
            this.btn_code = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tb_poll = new System.Windows.Forms.TextBox();
            this.tb_numOfInfoCombinations = new System.Windows.Forms.TextBox();
            this.lb_codedCombinations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_codeParams = new System.Windows.Forms.ComboBox();
            this.cb_poll = new System.Windows.Forms.ComboBox();
            this.numericUpDown_n = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_k = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_k)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_code
            // 
            this.btn_code.Location = new System.Drawing.Point(20, 261);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(77, 32);
            this.btn_code.TabIndex = 0;
            this.btn_code.Text = "Кодировать";
            this.btn_code.UseVisualStyleBackColor = true;
            this.btn_code.Click += new System.EventHandler(this.btn_code_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(103, 262);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(47, 31);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Выход";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // tb_poll
            // 
            this.tb_poll.Enabled = false;
            this.tb_poll.Location = new System.Drawing.Point(20, 228);
            this.tb_poll.Name = "tb_poll";
            this.tb_poll.Size = new System.Drawing.Size(101, 20);
            this.tb_poll.TabIndex = 2;
            this.tb_poll.Text = "1011";
            // 
            // tb_numOfInfoCombinations
            // 
            this.tb_numOfInfoCombinations.Location = new System.Drawing.Point(187, 69);
            this.tb_numOfInfoCombinations.Name = "tb_numOfInfoCombinations";
            this.tb_numOfInfoCombinations.Size = new System.Drawing.Size(273, 20);
            this.tb_numOfInfoCombinations.TabIndex = 3;
            // 
            // lb_codedCombinations
            // 
            this.lb_codedCombinations.FormattingEnabled = true;
            this.lb_codedCombinations.Location = new System.Drawing.Point(187, 108);
            this.lb_codedCombinations.Name = "lb_codedCombinations";
            this.lb_codedCombinations.Size = new System.Drawing.Size(273, 186);
            this.lb_codedCombinations.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите последовательность \r\nk-разрядных информационных комбинаций\r\nв десятичном " +
    "виде через пробел\r\nПример: 1 3 7 15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Образующий полином";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Параметры кода";
            // 
            // cb_codeParams
            // 
            this.cb_codeParams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_codeParams.FormattingEnabled = true;
            this.cb_codeParams.Location = new System.Drawing.Point(20, 68);
            this.cb_codeParams.Name = "cb_codeParams";
            this.cb_codeParams.Size = new System.Drawing.Size(101, 21);
            this.cb_codeParams.TabIndex = 8;
            this.cb_codeParams.SelectedIndexChanged += new System.EventHandler(this.cb_codeParams_SelectedIndexChanged);
            // 
            // cb_poll
            // 
            this.cb_poll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_poll.FormattingEnabled = true;
            this.cb_poll.Location = new System.Drawing.Point(20, 178);
            this.cb_poll.Name = "cb_poll";
            this.cb_poll.Size = new System.Drawing.Size(101, 21);
            this.cb_poll.TabIndex = 9;
            this.cb_poll.SelectedIndexChanged += new System.EventHandler(this.cb_poll_SelectedIndexChanged);
            // 
            // numericUpDown_n
            // 
            this.numericUpDown_n.Enabled = false;
            this.numericUpDown_n.Location = new System.Drawing.Point(20, 108);
            this.numericUpDown_n.Name = "numericUpDown_n";
            this.numericUpDown_n.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_n.TabIndex = 10;
            // 
            // numericUpDown_k
            // 
            this.numericUpDown_k.Enabled = false;
            this.numericUpDown_k.Location = new System.Drawing.Point(78, 108);
            this.numericUpDown_k.Name = "numericUpDown_k";
            this.numericUpDown_k.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_k.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 325);
            this.Controls.Add(this.numericUpDown_k);
            this.Controls.Add(this.numericUpDown_n);
            this.Controls.Add(this.cb_poll);
            this.Controls.Add(this.cb_codeParams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_codedCombinations);
            this.Controls.Add(this.tb_numOfInfoCombinations);
            this.Controls.Add(this.tb_poll);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_code);
            this.Name = "MainForm";
            this.Text = "БЧХ коды";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_k)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_code;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox tb_poll;
        private System.Windows.Forms.TextBox tb_numOfInfoCombinations;
        private System.Windows.Forms.ListBox lb_codedCombinations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_codeParams;
        private System.Windows.Forms.ComboBox cb_poll;
        private System.Windows.Forms.NumericUpDown numericUpDown_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_k;
    }
}

