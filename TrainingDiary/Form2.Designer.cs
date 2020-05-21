namespace TrainingDiary
{
    partial class WorkoutViewer
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
            this.cmb6 = new System.Windows.Forms.ComboBox();
            this.tbDistance2 = new System.Windows.Forms.TextBox();
            this.tbLenght2 = new System.Windows.Forms.TextBox();
            this.cmb5 = new System.Windows.Forms.ComboBox();
            this.cmb4 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb6
            // 
            this.cmb6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb6.FormattingEnabled = true;
            this.cmb6.Location = new System.Drawing.Point(26, 231);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(196, 24);
            this.cmb6.TabIndex = 19;
            // 
            // tbDistance2
            // 
            this.tbDistance2.Location = new System.Drawing.Point(26, 359);
            this.tbDistance2.Name = "tbDistance2";
            this.tbDistance2.Size = new System.Drawing.Size(100, 22);
            this.tbDistance2.TabIndex = 18;
            // 
            // tbLenght2
            // 
            this.tbLenght2.Location = new System.Drawing.Point(26, 299);
            this.tbLenght2.Name = "tbLenght2";
            this.tbLenght2.Size = new System.Drawing.Size(100, 22);
            this.tbLenght2.TabIndex = 17;
            // 
            // cmb5
            // 
            this.cmb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb5.FormattingEnabled = true;
            this.cmb5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb5.Location = new System.Drawing.Point(26, 165);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(200, 24);
            this.cmb5.TabIndex = 16;
            // 
            // cmb4
            // 
            this.cmb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb4.FormattingEnabled = true;
            this.cmb4.Items.AddRange(new object[] {
            "Pushups",
            "Jumping jacks",
            "Squats",
            "Climbers",
            "Plank jump-ins",
            "High knees",
            "Knee pull-ups",
            "Cross crunches",
            "Leg raises",
            "Triceps dip on chair",
            "Bench press",
            "Deadlift",
            "Biceps curls",
            "Rope triceps pushdown",
            "Running"});
            this.cmb4.Location = new System.Drawing.Point(26, 103);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(200, 24);
            this.cmb4.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Workout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Series";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Repetitions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Distance";
            // 
            // WorkoutViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb6);
            this.Controls.Add(this.tbDistance2);
            this.Controls.Add(this.tbLenght2);
            this.Controls.Add(this.cmb5);
            this.Controls.Add(this.cmb4);
            this.Controls.Add(this.dateTimePicker2);
            this.Name = "WorkoutViewer";
            this.Text = "WorkoutViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb6;
        private System.Windows.Forms.TextBox tbDistance2;
        private System.Windows.Forms.TextBox tbLenght2;
        private System.Windows.Forms.ComboBox cmb5;
        private System.Windows.Forms.ComboBox cmb4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}