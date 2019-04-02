using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestKim319
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Menu_file_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "종료하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("종료합니다.");
                this.Close();
            }
        }

        private void Menu_regist_Regist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 등록 창으로 이동합니다.");
            FormRegist frmregist = new FormRegist();
            frmregist.Show();
        }

        private void Menu_regist_Revision_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 수정 창으로 이동합니다.");
            FormRevision frmrevision = new FormRevision();
            frmrevision.Show();
        }

        private void Menu_regist_Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 삭제 창으로 이동합니다.");
            FormDelete frmdelete = new FormDelete();
            frmdelete.Show();
        }

        private void Menu_data_Today_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일간 통계 창으로 이동합니다.");
            FormToday frmtoday = new FormToday();
            frmtoday.Show();
        }

        private void Menu_data_Monthly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("월간 통계 창으로 이동합니다.");
            FormMonthly frmmonthly = new FormMonthly();
            frmmonthly.Show();
        }

        private void Menu_data_Year_Click(object sender, EventArgs e)
        {
            MessageBox.Show("연간 통계 창으로 이동합니다.");
            FormYear frmyear = new FormYear();
            frmyear.Show();
        }

        private void Menu_search_Cosmetic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 검색 창으로 이동합니다.");
            FormCosmetic frmcosmetic = new FormCosmetic();
            frmcosmetic.Show();
        }

        private void btnKind1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "스킨";
            FormMenu.test = "스킨";
            frmmenu.Show();
        }

        private void btnKind2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "에센스/크림";
            FormMenu.test = "에센스/크림";
            frmmenu.Show();
        }

        private void btnKind3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "로션";
            FormMenu.test = "로션";
            frmmenu.Show();
        }

        private void btnKind4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "팩/마스크";
            FormMenu.test = "팩/마스크";
            frmmenu.Show();
        }

        private void btnKind5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "선케어/BB";
            FormMenu.test = "선케어/BB";
            frmmenu.Show();
        }

        private void btnKind6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "쉐이빙/클렌징 폼";
            FormMenu.test = "쉐이빙/클렌징 폼";
            frmmenu.Show();
        }

        private void btnKind7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "헤어스타일링";
            FormMenu.test = "헤어스타일링";
            frmmenu.Show();
        }

        private void btnKind8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "기획 세트";
            FormMenu.test = "기획 세트";
            frmmenu.Show();
        }

        private void btnKind9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "퍼퓸";
            FormMenu.test = "퍼퓸";
            frmmenu.Show();
        }

        private void btnKind10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "기타";
            FormMenu.test = "기타";
            frmmenu.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("화장품 리스트 창으로 이동합니다.");
            FormMenu frmmenu = new FormMenu();
            frmmenu.Text = "전체보기";
            frmmenu.Show();
        }
    }
}
