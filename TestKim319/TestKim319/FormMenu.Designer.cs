namespace TestKim319
{
    partial class FormMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label51 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUdate = new System.Windows.Forms.Label();
            this.lblIng = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblFab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColUse,
            this.ColPrice,
            this.ColVol,
            this.ColSkin});
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(476, 637);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "화장품명";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 78;
            // 
            // ColUse
            // 
            this.ColUse.HeaderText = "용도";
            this.ColUse.Name = "ColUse";
            this.ColUse.ReadOnly = true;
            this.ColUse.Width = 54;
            // 
            // ColPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColPrice.HeaderText = "가격";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 54;
            // 
            // ColVol
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColVol.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColVol.HeaderText = "용량";
            this.ColVol.Name = "ColVol";
            this.ColVol.ReadOnly = true;
            this.ColVol.Width = 54;
            // 
            // ColSkin
            // 
            this.ColSkin.HeaderText = "사용피부";
            this.ColSkin.Name = "ColSkin";
            this.ColSkin.ReadOnly = true;
            this.ColSkin.Width = 78;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label51.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label51.Location = new System.Drawing.Point(498, 72);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(374, 30);
            this.label51.TabIndex = 1;
            this.label51.Text = "성분";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(498, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "유통기한";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUdate
            // 
            this.lblUdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUdate.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUdate.Location = new System.Drawing.Point(628, 42);
            this.lblUdate.Name = "lblUdate";
            this.lblUdate.Size = new System.Drawing.Size(244, 30);
            this.lblUdate.TabIndex = 1;
            this.lblUdate.Text = "?";
            this.lblUdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIng
            // 
            this.lblIng.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIng.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIng.Location = new System.Drawing.Point(498, 102);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(374, 240);
            this.lblIng.TabIndex = 1;
            this.lblIng.Text = "?";
            this.lblIng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(498, 587);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(374, 62);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "주문확정";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblFab
            // 
            this.lblFab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFab.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFab.Location = new System.Drawing.Point(628, 12);
            this.lblFab.Name = "lblFab";
            this.lblFab.Size = new System.Drawing.Size(244, 30);
            this.lblFab.TabIndex = 1;
            this.lblFab.Text = "?";
            this.lblFab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(498, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "제 조 원";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblUdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMenu";
            this.Text = "화장품리스트";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUdate;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblFab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSkin;
    }
}