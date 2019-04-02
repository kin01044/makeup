namespace TestKim319
{
    partial class FormCosmetic
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSerch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CmbGroup = new System.Windows.Forms.ComboBox();
            this.CmbUse = new System.Windows.Forms.ComboBox();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.ColName,
            this.ColUse,
            this.ColPrice,
            this.ColVolume,
            this.ColMaking});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(643, 610);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(582, 12);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(73, 21);
            this.btnSerch.TabIndex = 3;
            this.btnSerch.Text = "검색";
            this.btnSerch.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 21);
            this.txtName.TabIndex = 4;
            // 
            // CmbGroup
            // 
            this.CmbGroup.FormattingEnabled = true;
            this.CmbGroup.Items.AddRange(new object[] {
            "전체"});
            this.CmbGroup.Location = new System.Drawing.Point(12, 12);
            this.CmbGroup.Name = "CmbGroup";
            this.CmbGroup.Size = new System.Drawing.Size(142, 20);
            this.CmbGroup.TabIndex = 5;
            this.CmbGroup.Text = "전체";
            // 
            // CmbUse
            // 
            this.CmbUse.FormattingEnabled = true;
            this.CmbUse.Location = new System.Drawing.Point(160, 12);
            this.CmbUse.Name = "CmbUse";
            this.CmbUse.Size = new System.Drawing.Size(78, 20);
            this.CmbUse.TabIndex = 5;
            // 
            // ColNum
            // 
            this.ColNum.HeaderText = "분류";
            this.ColNum.Name = "ColNum";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "화장품명";
            this.ColName.Name = "ColName";
            // 
            // ColUse
            // 
            this.ColUse.HeaderText = "용도";
            this.ColUse.Name = "ColUse";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "가격";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColVolume
            // 
            this.ColVolume.HeaderText = "용량";
            this.ColVolume.Name = "ColVolume";
            // 
            // ColMaking
            // 
            this.ColMaking.HeaderText = "제조자";
            this.ColMaking.Name = "ColMaking";
            // 
            // FormCosmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.CmbUse);
            this.Controls.Add(this.CmbGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCosmetic";
            this.Text = "FormCosmetic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CmbGroup;
        private System.Windows.Forms.ComboBox CmbUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaking;
    }
}