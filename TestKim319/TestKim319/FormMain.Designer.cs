namespace TestKim319
{
    partial class FormMain
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
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Regist = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_regist_Regist = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_regist_Revision = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_regist_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_data_Today = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_data_Monthly = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_data_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_search_Cosmetic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKind1 = new System.Windows.Forms.Button();
            this.btnKind2 = new System.Windows.Forms.Button();
            this.btnKind3 = new System.Windows.Forms.Button();
            this.btnKind4 = new System.Windows.Forms.Button();
            this.btnKind5 = new System.Windows.Forms.Button();
            this.btnKind6 = new System.Windows.Forms.Button();
            this.btnKind9 = new System.Windows.Forms.Button();
            this.btnKind8 = new System.Windows.Forms.Button();
            this.btnKind7 = new System.Windows.Forms.Button();
            this.btnKind10 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.Menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Main
            // 
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Regist,
            this.Menu_Data,
            this.Menu_Search});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu_Main.Size = new System.Drawing.Size(462, 24);
            this.Menu_Main.TabIndex = 0;
            this.Menu_Main.Text = "Menu_Main";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_file_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(43, 20);
            this.Menu_File.Text = "파일";
            // 
            // Menu_file_Exit
            // 
            this.Menu_file_Exit.Name = "Menu_file_Exit";
            this.Menu_file_Exit.Size = new System.Drawing.Size(180, 22);
            this.Menu_file_Exit.Text = "종료";
            this.Menu_file_Exit.Click += new System.EventHandler(this.Menu_file_Exit_Click);
            // 
            // Menu_Regist
            // 
            this.Menu_Regist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_regist_Regist,
            this.Menu_regist_Revision,
            this.Menu_regist_Delete});
            this.Menu_Regist.Name = "Menu_Regist";
            this.Menu_Regist.Size = new System.Drawing.Size(72, 20);
            this.Menu_Regist.Text = "등록/수정";
            // 
            // Menu_regist_Regist
            // 
            this.Menu_regist_Regist.Name = "Menu_regist_Regist";
            this.Menu_regist_Regist.Size = new System.Drawing.Size(180, 22);
            this.Menu_regist_Regist.Text = "화장품 등록";
            this.Menu_regist_Regist.Click += new System.EventHandler(this.Menu_regist_Regist_Click);
            // 
            // Menu_regist_Revision
            // 
            this.Menu_regist_Revision.Name = "Menu_regist_Revision";
            this.Menu_regist_Revision.Size = new System.Drawing.Size(180, 22);
            this.Menu_regist_Revision.Text = "화장품 수정";
            this.Menu_regist_Revision.Click += new System.EventHandler(this.Menu_regist_Revision_Click);
            // 
            // Menu_regist_Delete
            // 
            this.Menu_regist_Delete.Name = "Menu_regist_Delete";
            this.Menu_regist_Delete.Size = new System.Drawing.Size(180, 22);
            this.Menu_regist_Delete.Text = "화장품 삭제";
            this.Menu_regist_Delete.Click += new System.EventHandler(this.Menu_regist_Delete_Click);
            // 
            // Menu_Data
            // 
            this.Menu_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_data_Today,
            this.Menu_data_Monthly,
            this.Menu_data_Year});
            this.Menu_Data.Name = "Menu_Data";
            this.Menu_Data.Size = new System.Drawing.Size(43, 20);
            this.Menu_Data.Text = "통계";
            // 
            // Menu_data_Today
            // 
            this.Menu_data_Today.Name = "Menu_data_Today";
            this.Menu_data_Today.Size = new System.Drawing.Size(180, 22);
            this.Menu_data_Today.Text = "금일";
            this.Menu_data_Today.Click += new System.EventHandler(this.Menu_data_Today_Click);
            // 
            // Menu_data_Monthly
            // 
            this.Menu_data_Monthly.Name = "Menu_data_Monthly";
            this.Menu_data_Monthly.Size = new System.Drawing.Size(180, 22);
            this.Menu_data_Monthly.Text = "월간";
            this.Menu_data_Monthly.Click += new System.EventHandler(this.Menu_data_Monthly_Click);
            // 
            // Menu_data_Year
            // 
            this.Menu_data_Year.Name = "Menu_data_Year";
            this.Menu_data_Year.Size = new System.Drawing.Size(180, 22);
            this.Menu_data_Year.Text = "연간";
            this.Menu_data_Year.Click += new System.EventHandler(this.Menu_data_Year_Click);
            // 
            // Menu_Search
            // 
            this.Menu_Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_search_Cosmetic});
            this.Menu_Search.Name = "Menu_Search";
            this.Menu_Search.Size = new System.Drawing.Size(43, 20);
            this.Menu_Search.Text = "검색";
            // 
            // Menu_search_Cosmetic
            // 
            this.Menu_search_Cosmetic.Name = "Menu_search_Cosmetic";
            this.Menu_search_Cosmetic.Size = new System.Drawing.Size(180, 22);
            this.Menu_search_Cosmetic.Text = "화장품 검색";
            this.Menu_search_Cosmetic.Click += new System.EventHandler(this.Menu_search_Cosmetic_Click);
            // 
            // btnKind1
            // 
            this.btnKind1.Location = new System.Drawing.Point(10, 25);
            this.btnKind1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind1.Name = "btnKind1";
            this.btnKind1.Size = new System.Drawing.Size(144, 94);
            this.btnKind1.TabIndex = 1;
            this.btnKind1.Text = "스킨";
            this.btnKind1.UseVisualStyleBackColor = true;
            this.btnKind1.Click += new System.EventHandler(this.btnKind1_Click);
            // 
            // btnKind2
            // 
            this.btnKind2.Location = new System.Drawing.Point(159, 25);
            this.btnKind2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind2.Name = "btnKind2";
            this.btnKind2.Size = new System.Drawing.Size(144, 94);
            this.btnKind2.TabIndex = 1;
            this.btnKind2.Text = "에센스/크림";
            this.btnKind2.UseVisualStyleBackColor = true;
            this.btnKind2.Click += new System.EventHandler(this.btnKind2_Click);
            // 
            // btnKind3
            // 
            this.btnKind3.Location = new System.Drawing.Point(308, 25);
            this.btnKind3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind3.Name = "btnKind3";
            this.btnKind3.Size = new System.Drawing.Size(144, 94);
            this.btnKind3.TabIndex = 1;
            this.btnKind3.Text = "로션";
            this.btnKind3.UseVisualStyleBackColor = true;
            this.btnKind3.Click += new System.EventHandler(this.btnKind3_Click);
            // 
            // btnKind4
            // 
            this.btnKind4.Location = new System.Drawing.Point(10, 124);
            this.btnKind4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind4.Name = "btnKind4";
            this.btnKind4.Size = new System.Drawing.Size(144, 94);
            this.btnKind4.TabIndex = 1;
            this.btnKind4.Text = "팩/마스크";
            this.btnKind4.UseVisualStyleBackColor = true;
            this.btnKind4.Click += new System.EventHandler(this.btnKind4_Click);
            // 
            // btnKind5
            // 
            this.btnKind5.Location = new System.Drawing.Point(159, 124);
            this.btnKind5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind5.Name = "btnKind5";
            this.btnKind5.Size = new System.Drawing.Size(144, 94);
            this.btnKind5.TabIndex = 1;
            this.btnKind5.Text = "선케어/BB";
            this.btnKind5.UseVisualStyleBackColor = true;
            this.btnKind5.Click += new System.EventHandler(this.btnKind5_Click);
            // 
            // btnKind6
            // 
            this.btnKind6.Location = new System.Drawing.Point(308, 124);
            this.btnKind6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind6.Name = "btnKind6";
            this.btnKind6.Size = new System.Drawing.Size(144, 94);
            this.btnKind6.TabIndex = 1;
            this.btnKind6.Text = "쉐이빙/클렌징 폼";
            this.btnKind6.UseVisualStyleBackColor = true;
            this.btnKind6.Click += new System.EventHandler(this.btnKind6_Click);
            // 
            // btnKind9
            // 
            this.btnKind9.Location = new System.Drawing.Point(308, 223);
            this.btnKind9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind9.Name = "btnKind9";
            this.btnKind9.Size = new System.Drawing.Size(144, 94);
            this.btnKind9.TabIndex = 1;
            this.btnKind9.Text = "퍼퓸";
            this.btnKind9.UseVisualStyleBackColor = true;
            this.btnKind9.Click += new System.EventHandler(this.btnKind9_Click);
            // 
            // btnKind8
            // 
            this.btnKind8.Location = new System.Drawing.Point(159, 223);
            this.btnKind8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind8.Name = "btnKind8";
            this.btnKind8.Size = new System.Drawing.Size(144, 94);
            this.btnKind8.TabIndex = 1;
            this.btnKind8.Text = "기획 세트";
            this.btnKind8.UseVisualStyleBackColor = true;
            this.btnKind8.Click += new System.EventHandler(this.btnKind8_Click);
            // 
            // btnKind7
            // 
            this.btnKind7.Location = new System.Drawing.Point(10, 223);
            this.btnKind7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind7.Name = "btnKind7";
            this.btnKind7.Size = new System.Drawing.Size(144, 94);
            this.btnKind7.TabIndex = 1;
            this.btnKind7.Text = "헤어스타일링";
            this.btnKind7.UseVisualStyleBackColor = true;
            this.btnKind7.Click += new System.EventHandler(this.btnKind7_Click);
            // 
            // btnKind10
            // 
            this.btnKind10.Location = new System.Drawing.Point(12, 321);
            this.btnKind10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKind10.Name = "btnKind10";
            this.btnKind10.Size = new System.Drawing.Size(142, 94);
            this.btnKind10.TabIndex = 1;
            this.btnKind10.Text = "기타";
            this.btnKind10.UseVisualStyleBackColor = true;
            this.btnKind10.Click += new System.EventHandler(this.btnKind10_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(308, 322);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(144, 94);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "전체보기";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 442);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnKind7);
            this.Controls.Add(this.btnKind10);
            this.Controls.Add(this.btnKind8);
            this.Controls.Add(this.btnKind9);
            this.Controls.Add(this.btnKind6);
            this.Controls.Add(this.btnKind5);
            this.Controls.Add(this.btnKind4);
            this.Controls.Add(this.btnKind3);
            this.Controls.Add(this.btnKind2);
            this.Controls.Add(this.btnKind1);
            this.Controls.Add(this.Menu_Main);
            this.MainMenuStrip = this.Menu_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "화장품 메인화면";
            this.Menu_Main.ResumeLayout(false);
            this.Menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Main;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_file_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Regist;
        private System.Windows.Forms.ToolStripMenuItem Menu_regist_Regist;
        private System.Windows.Forms.ToolStripMenuItem Menu_regist_Revision;
        private System.Windows.Forms.ToolStripMenuItem Menu_regist_Delete;
        private System.Windows.Forms.ToolStripMenuItem Menu_Data;
        private System.Windows.Forms.ToolStripMenuItem Menu_data_Today;
        private System.Windows.Forms.ToolStripMenuItem Menu_data_Monthly;
        private System.Windows.Forms.ToolStripMenuItem Menu_data_Year;
        private System.Windows.Forms.ToolStripMenuItem Menu_Search;
        private System.Windows.Forms.ToolStripMenuItem Menu_search_Cosmetic;
        private System.Windows.Forms.Button btnKind1;
        private System.Windows.Forms.Button btnKind2;
        private System.Windows.Forms.Button btnKind3;
        private System.Windows.Forms.Button btnKind4;
        private System.Windows.Forms.Button btnKind5;
        private System.Windows.Forms.Button btnKind6;
        private System.Windows.Forms.Button btnKind9;
        private System.Windows.Forms.Button btnKind8;
        private System.Windows.Forms.Button btnKind7;
        private System.Windows.Forms.Button btnKind10;
        private System.Windows.Forms.Button btnAll;
    }
}