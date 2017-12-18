namespace DynamicLINQ
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSqlQuery = new System.Windows.Forms.Button();
            this.btnExecuteSQLCommand = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnCustOrderHist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSqlQuery
            // 
            this.btnSqlQuery.Location = new System.Drawing.Point(37, 12);
            this.btnSqlQuery.Name = "btnSqlQuery";
            this.btnSqlQuery.Size = new System.Drawing.Size(75, 23);
            this.btnSqlQuery.TabIndex = 1;
            this.btnSqlQuery.Text = "查詢";
            this.btnSqlQuery.UseVisualStyleBackColor = true;
            this.btnSqlQuery.Click += new System.EventHandler(this.btnSqlQuery_Click);
            // 
            // btnExecuteSQLCommand
            // 
            this.btnExecuteSQLCommand.Location = new System.Drawing.Point(135, 11);
            this.btnExecuteSQLCommand.Name = "btnExecuteSQLCommand";
            this.btnExecuteSQLCommand.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteSQLCommand.TabIndex = 2;
            this.btnExecuteSQLCommand.Text = "更新";
            this.btnExecuteSQLCommand.UseVisualStyleBackColor = true;
            this.btnExecuteSQLCommand.Click += new System.EventHandler(this.btnExecuteSQLCommand_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(769, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnCustOrderHist
            // 
            this.btnCustOrderHist.Location = new System.Drawing.Point(238, 11);
            this.btnCustOrderHist.Name = "btnCustOrderHist";
            this.btnCustOrderHist.Size = new System.Drawing.Size(122, 23);
            this.btnCustOrderHist.TabIndex = 4;
            this.btnCustOrderHist.Text = "預存程序方法化";
            this.btnCustOrderHist.UseVisualStyleBackColor = true;
            this.btnCustOrderHist.Click += new System.EventHandler(this.btnCustOrderHist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 491);
            this.Controls.Add(this.btnCustOrderHist);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExecuteSQLCommand);
            this.Controls.Add(this.btnSqlQuery);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSqlQuery;
        private System.Windows.Forms.Button btnExecuteSQLCommand;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCustOrderHist;
    }
}

