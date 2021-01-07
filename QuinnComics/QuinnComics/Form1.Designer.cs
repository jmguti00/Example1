namespace QuinnComics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoBtnLN = new System.Windows.Forms.RadioButton();
            this.rdoBtnPhone = new System.Windows.Forms.RadioButton();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnPullList = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 38);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Yellow;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(306, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoBtnLN
            // 
            this.rdoBtnLN.AutoSize = true;
            this.rdoBtnLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnLN.Location = new System.Drawing.Point(439, 35);
            this.rdoBtnLN.Name = "rdoBtnLN";
            this.rdoBtnLN.Size = new System.Drawing.Size(212, 36);
            this.rdoBtnLN.TabIndex = 3;
            this.rdoBtnLN.TabStop = true;
            this.rdoBtnLN.Text = "By Last Name";
            this.rdoBtnLN.UseVisualStyleBackColor = true;
            // 
            // rdoBtnPhone
            // 
            this.rdoBtnPhone.AutoSize = true;
            this.rdoBtnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnPhone.Location = new System.Drawing.Point(439, 77);
            this.rdoBtnPhone.Name = "rdoBtnPhone";
            this.rdoBtnPhone.Size = new System.Drawing.Size(156, 36);
            this.rdoBtnPhone.TabIndex = 4;
            this.rdoBtnPhone.TabStop = true;
            this.rdoBtnPhone.Text = "by Phone";
            this.rdoBtnPhone.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 386);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(235, 52);
            this.btnNewCustomer.TabIndex = 5;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnPullList
            // 
            this.btnPullList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPullList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPullList.Location = new System.Drawing.Point(494, 386);
            this.btnPullList.Name = "btnPullList";
            this.btnPullList.Size = new System.Drawing.Size(235, 52);
            this.btnPullList.TabIndex = 6;
            this.btnPullList.Text = "Pull List";
            this.btnPullList.UseVisualStyleBackColor = false;
            this.btnPullList.Click += new System.EventHandler(this.btnPullList_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.Green;
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerList.Location = new System.Drawing.Point(253, 385);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(235, 52);
            this.btnCustomerList.TabIndex = 7;
            this.btnCustomerList.Text = "Customer List";
            this.btnCustomerList.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.btnPullList);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.rdoBtnPhone);
            this.Controls.Add(this.rdoBtnLN);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoBtnLN;
        private System.Windows.Forms.RadioButton rdoBtnPhone;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnPullList;
        private System.Windows.Forms.Button btnCustomerList;
    }
}

