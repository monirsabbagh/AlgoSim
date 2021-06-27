
namespace AlgoSim
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_speed = new System.Windows.Forms.TrackBar();
            this.btn_rand = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_step = new System.Windows.Forms.Button();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.ckb_showRanks = new System.Windows.Forms.CheckBox();
            this.pb_board = new System.Windows.Forms.PictureBox();
            this.cb_numItems = new System.Windows.Forms.ComboBox();
            this.timer_sort = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_board)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_speed);
            this.panel1.Controls.Add(this.btn_rand);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.btn_run);
            this.panel1.Controls.Add(this.btn_step);
            this.panel1.Controls.Add(this.cb_sort);
            this.panel1.Controls.Add(this.ckb_showRanks);
            this.panel1.Controls.Add(this.pb_board);
            this.panel1.Controls.Add(this.cb_numItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 499);
            this.panel1.TabIndex = 1;
            // 
            // tb_speed
            // 
            this.tb_speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_speed.Location = new System.Drawing.Point(911, 463);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(118, 56);
            this.tb_speed.TabIndex = 11;
            this.tb_speed.ValueChanged += new System.EventHandler(this.tb_speed_ValueChanged);
            // 
            // btn_rand
            // 
            this.btn_rand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rand.Location = new System.Drawing.Point(179, 461);
            this.btn_rand.Name = "btn_rand";
            this.btn_rand.Size = new System.Drawing.Size(30, 25);
            this.btn_rand.TabIndex = 10;
            this.btn_rand.Text = "#";
            this.btn_rand.UseVisualStyleBackColor = true;
            this.btn_rand.Click += new System.EventHandler(this.btn_rand_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pause.Location = new System.Drawing.Point(598, 458);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(70, 30);
            this.btn_pause.TabIndex = 8;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_run.Location = new System.Drawing.Point(452, 458);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(70, 30);
            this.btn_run.TabIndex = 7;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_step
            // 
            this.btn_step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_step.Location = new System.Drawing.Point(525, 458);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(70, 30);
            this.btn_step.TabIndex = 6;
            this.btn_step.Text = "Step";
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // cb_sort
            // 
            this.cb_sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort (N/A)",
            "Selection Sort (N/A)",
            "Insertion Sort (N/A)"});
            this.cb_sort.Location = new System.Drawing.Point(323, 461);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(121, 24);
            this.cb_sort.TabIndex = 5;
            this.cb_sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // ckb_showRanks
            // 
            this.ckb_showRanks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckb_showRanks.AutoSize = true;
            this.ckb_showRanks.Checked = true;
            this.ckb_showRanks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_showRanks.Location = new System.Drawing.Point(216, 463);
            this.ckb_showRanks.Name = "ckb_showRanks";
            this.ckb_showRanks.Size = new System.Drawing.Size(105, 21);
            this.ckb_showRanks.TabIndex = 3;
            this.ckb_showRanks.Text = "Show Ranks";
            this.ckb_showRanks.UseVisualStyleBackColor = true;
            this.ckb_showRanks.CheckStateChanged += new System.EventHandler(this.ckb_showRanks_CheckStateChanged);
            // 
            // pb_board
            // 
            this.pb_board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_board.Location = new System.Drawing.Point(3, 3);
            this.pb_board.Name = "pb_board";
            this.pb_board.Size = new System.Drawing.Size(1053, 440);
            this.pb_board.TabIndex = 2;
            this.pb_board.TabStop = false;
            this.pb_board.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_board_Paint);
            this.pb_board.Resize += new System.EventHandler(this.pb_board_Resize);
            // 
            // cb_numItems
            // 
            this.cb_numItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_numItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numItems.FormattingEnabled = true;
            this.cb_numItems.Items.AddRange(new object[] {
            "5   Random Numbers",
            "15 Random Numbers",
            "35 Random Numbers",
            "50 Random Numbers"});
            this.cb_numItems.Location = new System.Drawing.Point(12, 461);
            this.cb_numItems.Name = "cb_numItems";
            this.cb_numItems.Size = new System.Drawing.Size(161, 24);
            this.cb_numItems.TabIndex = 0;
            this.cb_numItems.SelectedIndexChanged += new System.EventHandler(this.cb_numItems_SelectedIndexChanged);
            // 
            // timer_sort
            // 
            this.timer_sort.Interval = 1;
            this.timer_sort.Tick += new System.EventHandler(this.timer_sort_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fast";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1023, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Slow";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 499);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(810, 47);
            this.Name = "MainForm";
            this.Text = "Sorting Algorithms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_numItems;
        private System.Windows.Forms.PictureBox pb_board;
        private System.Windows.Forms.CheckBox ckb_showRanks;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_rand;
        private System.Windows.Forms.Timer timer_sort;
        private System.Windows.Forms.TrackBar tb_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

