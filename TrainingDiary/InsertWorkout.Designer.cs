namespace TrainingDiary
{
    partial class InsertWorkout
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblNoOfSeries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.tbLenght = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmb3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
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
            "Running",
            " "});
            this.cmb1.Location = new System.Drawing.Point(12, 111);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(200, 24);
            this.cmb1.TabIndex = 1;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // cmb2
            // 
            this.cmb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
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
            this.cmb2.Location = new System.Drawing.Point(12, 173);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(200, 24);
            this.cmb2.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 81);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(149, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Choose exercise";
            // 
            // lblNoOfSeries
            // 
            this.lblNoOfSeries.AutoSize = true;
            this.lblNoOfSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeries.Location = new System.Drawing.Point(12, 150);
            this.lblNoOfSeries.Name = "lblNoOfSeries";
            this.lblNoOfSeries.Size = new System.Drawing.Size(154, 20);
            this.lblNoOfSeries.TabIndex = 5;
            this.lblNoOfSeries.Text = "Number of series";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of repetitions";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenght.Location = new System.Drawing.Point(12, 269);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(161, 20);
            this.lblLenght.TabIndex = 7;
            this.lblLenght.Text = "Duration(minutes)";
            // 
            // tbLenght
            // 
            this.tbLenght.Location = new System.Drawing.Point(12, 292);
            this.tbLenght.Name = "tbLenght";
            this.tbLenght.Size = new System.Drawing.Size(100, 22);
            this.tbLenght.TabIndex = 8;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(12, 329);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(156, 20);
            this.lblDistance.TabIndex = 9;
            this.lblDistance.Text = "Distance(meters)";
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(12, 352);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 22);
            this.tbDistance.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 40);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 398);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cmb3
            // 
            this.cmb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb3.FormattingEnabled = true;
            this.cmb3.Location = new System.Drawing.Point(12, 242);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(196, 24);
            this.cmb3.TabIndex = 13;
            // 
            // InsertWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.cmb3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.tbLenght);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoOfSeries);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "InsertWorkout";
            this.Text = "InsertWorkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNoOfSeries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.TextBox tbLenght;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmb3;
    }
}