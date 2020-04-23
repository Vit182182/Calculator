namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.NumericSpecial = new System.Windows.Forms.NumericUpDown();
            this.B2 = new System.Windows.Forms.Button();
            this.BRound = new System.Windows.Forms.Button();
            this.BDel = new System.Windows.Forms.Button();
            this.BResult = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.BDot = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.BBackSpace = new System.Windows.Forms.Button();
            this.BPlus = new System.Windows.Forms.Button();
            this.BMinus = new System.Windows.Forms.Button();
            this.BMultiply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(32, 12);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(178, 26);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B1
            // 
            this.B1.AutoEllipsis = true;
            this.B1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B1.FlatAppearance.BorderSize = 3;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B1.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(32, 107);
            this.B1.Name = "B1";
            this.B1.Padding = new System.Windows.Forms.Padding(2);
            this.B1.Size = new System.Drawing.Size(40, 40);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // NumericSpecial
            // 
            this.NumericSpecial.AutoSize = true;
            this.NumericSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericSpecial.Hexadecimal = true;
            this.NumericSpecial.Location = new System.Drawing.Point(124, 291);
            this.NumericSpecial.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericSpecial.Name = "NumericSpecial";
            this.NumericSpecial.Size = new System.Drawing.Size(86, 26);
            this.NumericSpecial.TabIndex = 40;
            this.NumericSpecial.ThousandsSeparator = true;
            // 
            // B2
            // 
            this.B2.AutoEllipsis = true;
            this.B2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B2.FlatAppearance.BorderSize = 3;
            this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B2.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(78, 107);
            this.B2.Name = "B2";
            this.B2.Padding = new System.Windows.Forms.Padding(2);
            this.B2.Size = new System.Drawing.Size(40, 40);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // BRound
            // 
            this.BRound.AutoEllipsis = true;
            this.BRound.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BRound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BRound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BRound.FlatAppearance.BorderSize = 3;
            this.BRound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BRound.Font = new System.Drawing.Font("Segoe Script", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRound.Location = new System.Drawing.Point(32, 289);
            this.BRound.Name = "BRound";
            this.BRound.Size = new System.Drawing.Size(86, 28);
            this.BRound.TabIndex = 24;
            this.BRound.Text = "~";
            this.BRound.UseVisualStyleBackColor = false;
            this.BRound.Click += new System.EventHandler(this.BRound_Click);
            // 
            // BDel
            // 
            this.BDel.AutoEllipsis = true;
            this.BDel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BDel.FlatAppearance.BorderSize = 3;
            this.BDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BDel.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDel.Location = new System.Drawing.Point(170, 61);
            this.BDel.Name = "BDel";
            this.BDel.Padding = new System.Windows.Forms.Padding(2);
            this.BDel.Size = new System.Drawing.Size(40, 40);
            this.BDel.TabIndex = 31;
            this.BDel.Text = "/";
            this.BDel.UseVisualStyleBackColor = false;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // BResult
            // 
            this.BResult.AutoEllipsis = true;
            this.BResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BResult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BResult.FlatAppearance.BorderSize = 3;
            this.BResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BResult.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BResult.Location = new System.Drawing.Point(124, 245);
            this.BResult.Name = "BResult";
            this.BResult.Padding = new System.Windows.Forms.Padding(2);
            this.BResult.Size = new System.Drawing.Size(86, 40);
            this.BResult.TabIndex = 35;
            this.BResult.Text = "=";
            this.BResult.UseVisualStyleBackColor = false;
            this.BResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // B3
            // 
            this.B3.AutoEllipsis = true;
            this.B3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B3.FlatAppearance.BorderSize = 3;
            this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B3.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(124, 107);
            this.B3.Name = "B3";
            this.B3.Padding = new System.Windows.Forms.Padding(2);
            this.B3.Size = new System.Drawing.Size(40, 40);
            this.B3.TabIndex = 3;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B6
            // 
            this.B6.AutoEllipsis = true;
            this.B6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B6.FlatAppearance.BorderSize = 3;
            this.B6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B6.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B6.Location = new System.Drawing.Point(124, 153);
            this.B6.Name = "B6";
            this.B6.Padding = new System.Windows.Forms.Padding(2);
            this.B6.Size = new System.Drawing.Size(40, 40);
            this.B6.TabIndex = 6;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B5
            // 
            this.B5.AutoEllipsis = true;
            this.B5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B5.FlatAppearance.BorderSize = 3;
            this.B5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B5.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B5.Location = new System.Drawing.Point(78, 153);
            this.B5.Name = "B5";
            this.B5.Padding = new System.Windows.Forms.Padding(2);
            this.B5.Size = new System.Drawing.Size(40, 40);
            this.B5.TabIndex = 5;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.AutoEllipsis = true;
            this.B4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B4.FlatAppearance.BorderSize = 3;
            this.B4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B4.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B4.Location = new System.Drawing.Point(32, 153);
            this.B4.Name = "B4";
            this.B4.Padding = new System.Windows.Forms.Padding(2);
            this.B4.Size = new System.Drawing.Size(40, 40);
            this.B4.TabIndex = 4;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B9
            // 
            this.B9.AutoEllipsis = true;
            this.B9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B9.FlatAppearance.BorderSize = 3;
            this.B9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B9.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B9.Location = new System.Drawing.Point(124, 199);
            this.B9.Name = "B9";
            this.B9.Padding = new System.Windows.Forms.Padding(2);
            this.B9.Size = new System.Drawing.Size(40, 40);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B8
            // 
            this.B8.AutoEllipsis = true;
            this.B8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B8.FlatAppearance.BorderSize = 3;
            this.B8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B8.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B8.Location = new System.Drawing.Point(78, 199);
            this.B8.Name = "B8";
            this.B8.Padding = new System.Windows.Forms.Padding(2);
            this.B8.Size = new System.Drawing.Size(40, 40);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B7
            // 
            this.B7.AutoEllipsis = true;
            this.B7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B7.FlatAppearance.BorderSize = 3;
            this.B7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B7.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B7.Location = new System.Drawing.Point(32, 199);
            this.B7.Name = "B7";
            this.B7.Padding = new System.Windows.Forms.Padding(2);
            this.B7.Size = new System.Drawing.Size(40, 40);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // BDot
            // 
            this.BDot.AutoEllipsis = true;
            this.BDot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BDot.FlatAppearance.BorderSize = 3;
            this.BDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BDot.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDot.Location = new System.Drawing.Point(78, 245);
            this.BDot.Name = "BDot";
            this.BDot.Padding = new System.Windows.Forms.Padding(2);
            this.BDot.Size = new System.Drawing.Size(40, 40);
            this.BDot.TabIndex = 23;
            this.BDot.Text = ",";
            this.BDot.UseVisualStyleBackColor = false;
            this.BDot.Click += new System.EventHandler(this.BDot_Click);
            // 
            // B0
            // 
            this.B0.AutoEllipsis = true;
            this.B0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.B0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.B0.FlatAppearance.BorderSize = 3;
            this.B0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.B0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.B0.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B0.Location = new System.Drawing.Point(32, 245);
            this.B0.Name = "B0";
            this.B0.Padding = new System.Windows.Forms.Padding(2);
            this.B0.Size = new System.Drawing.Size(40, 40);
            this.B0.TabIndex = 10;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // BC
            // 
            this.BC.AutoEllipsis = true;
            this.BC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BC.FlatAppearance.BorderSize = 3;
            this.BC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BC.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BC.Location = new System.Drawing.Point(32, 61);
            this.BC.Name = "BC";
            this.BC.Padding = new System.Windows.Forms.Padding(2);
            this.BC.Size = new System.Drawing.Size(40, 40);
            this.BC.TabIndex = 21;
            this.BC.Text = "C";
            this.BC.UseVisualStyleBackColor = false;
            this.BC.Click += new System.EventHandler(this.BC_Click);
            // 
            // BBackSpace
            // 
            this.BBackSpace.AutoEllipsis = true;
            this.BBackSpace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BBackSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BBackSpace.FlatAppearance.BorderSize = 3;
            this.BBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BBackSpace.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBackSpace.Location = new System.Drawing.Point(78, 61);
            this.BBackSpace.Name = "BBackSpace";
            this.BBackSpace.Padding = new System.Windows.Forms.Padding(2);
            this.BBackSpace.Size = new System.Drawing.Size(86, 40);
            this.BBackSpace.TabIndex = 22;
            this.BBackSpace.Text = "<-";
            this.BBackSpace.UseVisualStyleBackColor = false;
            // 
            // BPlus
            // 
            this.BPlus.AutoEllipsis = true;
            this.BPlus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BPlus.FlatAppearance.BorderSize = 3;
            this.BPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BPlus.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BPlus.Location = new System.Drawing.Point(170, 199);
            this.BPlus.Name = "BPlus";
            this.BPlus.Padding = new System.Windows.Forms.Padding(2);
            this.BPlus.Size = new System.Drawing.Size(40, 40);
            this.BPlus.TabIndex = 34;
            this.BPlus.Text = "+";
            this.BPlus.UseVisualStyleBackColor = false;
            this.BPlus.Click += new System.EventHandler(this.BPlus_Click);
            // 
            // BMinus
            // 
            this.BMinus.AutoEllipsis = true;
            this.BMinus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BMinus.FlatAppearance.BorderSize = 3;
            this.BMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BMinus.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMinus.Location = new System.Drawing.Point(170, 153);
            this.BMinus.Name = "BMinus";
            this.BMinus.Padding = new System.Windows.Forms.Padding(2);
            this.BMinus.Size = new System.Drawing.Size(40, 40);
            this.BMinus.TabIndex = 33;
            this.BMinus.Text = "-";
            this.BMinus.UseVisualStyleBackColor = false;
            this.BMinus.Click += new System.EventHandler(this.BMinus_Click);
            // 
            // BMultiply
            // 
            this.BMultiply.AutoEllipsis = true;
            this.BMultiply.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BMultiply.FlatAppearance.BorderSize = 3;
            this.BMultiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.BMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.BMultiply.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMultiply.Location = new System.Drawing.Point(170, 107);
            this.BMultiply.Name = "BMultiply";
            this.BMultiply.Padding = new System.Windows.Forms.Padding(2);
            this.BMultiply.Size = new System.Drawing.Size(40, 40);
            this.BMultiply.TabIndex = 32;
            this.BMultiply.Text = "*";
            this.BMultiply.UseVisualStyleBackColor = false;
            this.BMultiply.Click += new System.EventHandler(this.BMultiply_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(242, 364);
            this.Controls.Add(this.BBackSpace);
            this.Controls.Add(this.BPlus);
            this.Controls.Add(this.BMinus);
            this.Controls.Add(this.BMultiply);
            this.Controls.Add(this.BDot);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.BResult);
            this.Controls.Add(this.BDel);
            this.Controls.Add(this.BRound);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.NumericSpecial);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Простой калькулятор(C#)";
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.NumericUpDown NumericSpecial;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button BRound;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button BDot;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button BC;
        private System.Windows.Forms.Button BBackSpace;
        private System.Windows.Forms.Button BPlus;
        private System.Windows.Forms.Button BMinus;
        private System.Windows.Forms.Button BMultiply;
    }
}

