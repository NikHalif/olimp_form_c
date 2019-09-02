namespace Olimp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView1 = new EO.WebBrowser.WebView();
            this.tab_menu = new System.Windows.Forms.TabControl();
            this.main_setting = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Open_debag = new System.Windows.Forms.Button();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.value_pay = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.min_money = new System.Windows.Forms.NumericUpDown();
            this.size_pay = new System.Windows.Forms.NumericUpDown();
            this.timer_pay = new System.Windows.Forms.NumericUpDown();
            this.timer_pp_pay = new System.Windows.Forms.NumericUpDown();
            this.procent_money = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inject_button = new System.Windows.Forms.Button();
            this.Log_setting = new System.Windows.Forms.TabPage();
            this.log_text = new System.Windows.Forms.ListView();
            this.log_file = new System.Windows.Forms.CheckBox();
            this.text_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tab_menu.SuspendLayout();
            this.main_setting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.setting_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_pp_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procent_money)).BeginInit();
            this.Log_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.webControl1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.MinimumSize = new System.Drawing.Size(783, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 545);
            this.panel1.TabIndex = 0;
            // 
            // webControl1
            // 
            this.webControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(796, 545);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView1;
            // 
            // webView1
            // 
            this.webView1.InputMsgFilter = null;
            this.webView1.ObjectForScripting = null;
            this.webView1.Title = null;
            // 
            // tab_menu
            // 
            this.tab_menu.Controls.Add(this.main_setting);
            this.tab_menu.Controls.Add(this.Log_setting);
            this.tab_menu.Location = new System.Drawing.Point(801, 2);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.SelectedIndex = 0;
            this.tab_menu.Size = new System.Drawing.Size(304, 542);
            this.tab_menu.TabIndex = 1;
            // 
            // main_setting
            // 
            this.main_setting.Controls.Add(this.panel2);
            this.main_setting.Location = new System.Drawing.Point(4, 22);
            this.main_setting.Name = "main_setting";
            this.main_setting.Padding = new System.Windows.Forms.Padding(3);
            this.main_setting.Size = new System.Drawing.Size(296, 516);
            this.main_setting.TabIndex = 0;
            this.main_setting.Text = "Основновные настройки";
            this.main_setting.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Open_debag);
            this.panel2.Controls.Add(this.setting_panel);
            this.panel2.Controls.Add(this.inject_button);
            this.panel2.Location = new System.Drawing.Point(1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 522);
            this.panel2.TabIndex = 2;
            // 
            // Open_debag
            // 
            this.Open_debag.Location = new System.Drawing.Point(210, 3);
            this.Open_debag.Name = "Open_debag";
            this.Open_debag.Size = new System.Drawing.Size(81, 25);
            this.Open_debag.TabIndex = 2;
            this.Open_debag.Text = "DeBug";
            this.Open_debag.UseVisualStyleBackColor = true;
            this.Open_debag.Click += new System.EventHandler(this.Open_debag_Click);
            // 
            // setting_panel
            // 
            this.setting_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_panel.Controls.Add(this.text_info);
            this.setting_panel.Controls.Add(this.value_pay);
            this.setting_panel.Controls.Add(this.cena);
            this.setting_panel.Controls.Add(this.label7);
            this.setting_panel.Controls.Add(this.label6);
            this.setting_panel.Controls.Add(this.min_money);
            this.setting_panel.Controls.Add(this.size_pay);
            this.setting_panel.Controls.Add(this.timer_pay);
            this.setting_panel.Controls.Add(this.timer_pp_pay);
            this.setting_panel.Controls.Add(this.procent_money);
            this.setting_panel.Controls.Add(this.label5);
            this.setting_panel.Controls.Add(this.label4);
            this.setting_panel.Controls.Add(this.label3);
            this.setting_panel.Controls.Add(this.label2);
            this.setting_panel.Controls.Add(this.button_start);
            this.setting_panel.Controls.Add(this.label1);
            this.setting_panel.Enabled = false;
            this.setting_panel.Location = new System.Drawing.Point(4, 34);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(287, 485);
            this.setting_panel.TabIndex = 1;
            // 
            // value_pay
            // 
            this.value_pay.AutoSize = true;
            this.value_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value_pay.Location = new System.Drawing.Point(135, 387);
            this.value_pay.Name = "value_pay";
            this.value_pay.Size = new System.Drawing.Size(18, 20);
            this.value_pay.TabIndex = 8;
            this.value_pay.Text = "0";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cena.Location = new System.Drawing.Point(135, 339);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(18, 20);
            this.cena.TabIndex = 8;
            this.cena.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Оъем";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Цена";
            // 
            // min_money
            // 
            this.min_money.DecimalPlaces = 2;
            this.min_money.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.min_money.Location = new System.Drawing.Point(165, 277);
            this.min_money.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.min_money.Name = "min_money";
            this.min_money.Size = new System.Drawing.Size(119, 20);
            this.min_money.TabIndex = 6;
            this.min_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // size_pay
            // 
            this.size_pay.DecimalPlaces = 6;
            this.size_pay.Location = new System.Drawing.Point(165, 100);
            this.size_pay.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.size_pay.Name = "size_pay";
            this.size_pay.Size = new System.Drawing.Size(119, 20);
            this.size_pay.TabIndex = 6;
            this.size_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer_pay
            // 
            this.timer_pay.DecimalPlaces = 1;
            this.timer_pay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timer_pay.Location = new System.Drawing.Point(210, 226);
            this.timer_pay.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.timer_pay.Name = "timer_pay";
            this.timer_pay.Size = new System.Drawing.Size(74, 20);
            this.timer_pay.TabIndex = 5;
            this.timer_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer_pp_pay
            // 
            this.timer_pp_pay.DecimalPlaces = 1;
            this.timer_pp_pay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timer_pp_pay.Location = new System.Drawing.Point(210, 164);
            this.timer_pp_pay.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.timer_pp_pay.Name = "timer_pp_pay";
            this.timer_pp_pay.Size = new System.Drawing.Size(74, 20);
            this.timer_pp_pay.TabIndex = 5;
            this.timer_pp_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timer_pp_pay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // procent_money
            // 
            this.procent_money.DecimalPlaces = 2;
            this.procent_money.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.procent_money.Location = new System.Drawing.Point(210, 39);
            this.procent_money.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.procent_money.Name = "procent_money";
            this.procent_money.Size = new System.Drawing.Size(74, 20);
            this.procent_money.TabIndex = 5;
            this.procent_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.procent_money.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Минимум денег на счету:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минимальное время между \r\nселками(сек):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Минимальное время между \r\nпротивоположными селками(сек):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Минимальный объем \r\n         сделки автореакции:";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 450);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Запустить";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальный допустимый\r\n процент дохода:";
            // 
            // inject_button
            // 
            this.inject_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inject_button.Location = new System.Drawing.Point(4, 3);
            this.inject_button.Name = "inject_button";
            this.inject_button.Size = new System.Drawing.Size(200, 25);
            this.inject_button.TabIndex = 0;
            this.inject_button.Text = "Внедрить код";
            this.inject_button.UseVisualStyleBackColor = true;
            this.inject_button.Click += new System.EventHandler(this.Inject_button_Click);
            // 
            // Log_setting
            // 
            this.Log_setting.Controls.Add(this.log_text);
            this.Log_setting.Controls.Add(this.log_file);
            this.Log_setting.Location = new System.Drawing.Point(4, 22);
            this.Log_setting.Name = "Log_setting";
            this.Log_setting.Padding = new System.Windows.Forms.Padding(3);
            this.Log_setting.Size = new System.Drawing.Size(296, 516);
            this.Log_setting.TabIndex = 1;
            this.Log_setting.Text = "Log";
            this.Log_setting.UseVisualStyleBackColor = true;
            // 
            // log_text
            // 
            this.log_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_text.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.log_text.HideSelection = false;
            this.log_text.LabelWrap = false;
            this.log_text.Location = new System.Drawing.Point(0, 0);
            this.log_text.MultiSelect = false;
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(293, 485);
            this.log_text.TabIndex = 9;
            this.log_text.TabStop = false;
            this.log_text.UseCompatibleStateImageBehavior = false;
            this.log_text.View = System.Windows.Forms.View.List;
            // 
            // log_file
            // 
            this.log_file.AutoSize = true;
            this.log_file.Location = new System.Drawing.Point(6, 491);
            this.log_file.Name = "log_file";
            this.log_file.Size = new System.Drawing.Size(107, 17);
            this.log_file.TabIndex = 8;
            this.log_file.Text = "Отладка в файл";
            this.log_file.UseVisualStyleBackColor = true;
            // 
            // text_info
            // 
            this.text_info.AutoSize = true;
            this.text_info.Location = new System.Drawing.Point(93, 455);
            this.text_info.Name = "text_info";
            this.text_info.Size = new System.Drawing.Size(0, 13);
            this.text_info.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 546);
            this.Controls.Add(this.tab_menu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1123, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olimp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tab_menu.ResumeLayout(false);
            this.main_setting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_pp_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procent_money)).EndInit();
            this.Log_setting.ResumeLayout(false);
            this.Log_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView1;
        private System.Windows.Forms.TabControl tab_menu;
        private System.Windows.Forms.TabPage main_setting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Open_debag;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.NumericUpDown min_money;
        private System.Windows.Forms.NumericUpDown size_pay;
        private System.Windows.Forms.NumericUpDown timer_pay;
        private System.Windows.Forms.NumericUpDown timer_pp_pay;
        private System.Windows.Forms.NumericUpDown procent_money;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inject_button;
        private System.Windows.Forms.TabPage Log_setting;
        private System.Windows.Forms.ListView log_text;
        private System.Windows.Forms.CheckBox log_file;
        private System.Windows.Forms.Label value_pay;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label text_info;
    }
}

