namespace TrainingDiary
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewTraining = new System.Windows.Forms.DataGridView();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.btnTrainingSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(791, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewTraining
            // 
            this.dataGridViewTraining.AllowUserToAddRows = false;
            this.dataGridViewTraining.AllowUserToDeleteRows = false;
            this.dataGridViewTraining.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraining.Location = new System.Drawing.Point(13, 94);
            this.dataGridViewTraining.Name = "dataGridViewTraining";
            this.dataGridViewTraining.ReadOnly = true;
            this.dataGridViewTraining.RowTemplate.Height = 24;
            this.dataGridViewTraining.Size = new System.Drawing.Size(864, 344);
            this.dataGridViewTraining.TabIndex = 1;
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Location = new System.Drawing.Point(13, 38);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSearch.TabIndex = 2;
            // 
            // btnTrainingSearch
            // 
            this.btnTrainingSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTrainingSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainingSearch.Image")));
            this.btnTrainingSearch.Location = new System.Drawing.Point(232, 27);
            this.btnTrainingSearch.Name = "btnTrainingSearch";
            this.btnTrainingSearch.Size = new System.Drawing.Size(75, 48);
            this.btnTrainingSearch.TabIndex = 3;
            this.btnTrainingSearch.UseVisualStyleBackColor = false;
            this.btnTrainingSearch.Click += new System.EventHandler(this.btnTrainingSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(363, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 48);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTrainingSearch);
            this.Controls.Add(this.dateTimePickerSearch);
            this.Controls.Add(this.dataGridViewTraining);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewTraining;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Button btnTrainingSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}

