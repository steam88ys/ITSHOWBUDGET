﻿
namespace ITSHOWBUDGET
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hakbunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hakbunDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.contestDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(707, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "전체보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 109);
            this.button2.TabIndex = 2;
            this.button2.Text = "가나다순";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 109);
            this.button3.TabIndex = 3;
            this.button3.Text = "개발과";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 109);
            this.button4.TabIndex = 4;
            this.button4.Text = "디자인과";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(612, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 109);
            this.button5.TabIndex = 5;
            this.button5.Text = "예산이 높은순";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(ITSHOWBUDGET.UserInfo);
            // 
            // hakbunDataGridViewTextBoxColumn
            // 
            this.hakbunDataGridViewTextBoxColumn.DataPropertyName = "hakbun";
            this.hakbunDataGridViewTextBoxColumn.HeaderText = "hakbun";
            this.hakbunDataGridViewTextBoxColumn.Name = "hakbunDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // contestDataGridViewTextBoxColumn
            // 
            this.contestDataGridViewTextBoxColumn.DataPropertyName = "contest";
            this.contestDataGridViewTextBoxColumn.HeaderText = "contest";
            this.contestDataGridViewTextBoxColumn.Name = "contestDataGridViewTextBoxColumn";
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "budget";
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "3102 김윤서";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
    }
}

