namespace QuanLyNhaSach
{
    partial class NhapKhoForm
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
            this.NhapPhieuButton = new System.Windows.Forms.Button();
            this.PhieuNhapDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.GiaNhapTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoLuongTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TuaSachComboBox = new System.Windows.Forms.ComboBox();
            this.MaPNTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSachColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSachColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhapColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NhapPhieuButton
            // 
            this.NhapPhieuButton.Location = new System.Drawing.Point(720, 477);
            this.NhapPhieuButton.Name = "NhapPhieuButton";
            this.NhapPhieuButton.Size = new System.Drawing.Size(167, 32);
            this.NhapPhieuButton.TabIndex = 53;
            this.NhapPhieuButton.Text = "NHẬP PHIẾU";
            this.NhapPhieuButton.UseVisualStyleBackColor = true;
            // 
            // PhieuNhapDataGridView
            // 
            this.PhieuNhapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PhieuNhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhieuNhapDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSachColumn,
            this.TuaSachColumn,
            this.SoLuongColumn,
            this.GiaNhapColumn});
            this.PhieuNhapDataGridView.Location = new System.Drawing.Point(12, 179);
            this.PhieuNhapDataGridView.Name = "PhieuNhapDataGridView";
            this.PhieuNhapDataGridView.RowHeadersWidth = 51;
            this.PhieuNhapDataGridView.RowTemplate.Height = 24;
            this.PhieuNhapDataGridView.Size = new System.Drawing.Size(875, 292);
            this.PhieuNhapDataGridView.TabIndex = 50;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(802, 139);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 32);
            this.DeleteButton.TabIndex = 49;
            this.DeleteButton.Text = "XÓA";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(711, 139);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 32);
            this.AddButton.TabIndex = 48;
            this.AddButton.Text = "THÊM";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // GiaNhapTextBox
            // 
            this.GiaNhapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiaNhapTextBox.Location = new System.Drawing.Point(523, 139);
            this.GiaNhapTextBox.Name = "GiaNhapTextBox";
            this.GiaNhapTextBox.Size = new System.Drawing.Size(182, 32);
            this.GiaNhapTextBox.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Giá nhập:";
            // 
            // SoLuongTextBox
            // 
            this.SoLuongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongTextBox.Location = new System.Drawing.Point(390, 139);
            this.SoLuongTextBox.Name = "SoLuongTextBox";
            this.SoLuongTextBox.Size = new System.Drawing.Size(127, 32);
            this.SoLuongTextBox.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tựa Sách:";
            // 
            // TuaSachComboBox
            // 
            this.TuaSachComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachComboBox.FormattingEnabled = true;
            this.TuaSachComboBox.Location = new System.Drawing.Point(12, 139);
            this.TuaSachComboBox.Name = "TuaSachComboBox";
            this.TuaSachComboBox.Size = new System.Drawing.Size(372, 34);
            this.TuaSachComboBox.TabIndex = 42;
            // 
            // MaPNTextBox
            // 
            this.MaPNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaPNTextBox.Location = new System.Drawing.Point(11, 81);
            this.MaPNTextBox.Name = "MaPNTextBox";
            this.MaPNTextBox.Size = new System.Drawing.Size(170, 32);
            this.MaPNTextBox.TabIndex = 39;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(8, 58);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(123, 20);
            this.UsernameLabel.TabIndex = 38;
            this.UsernameLabel.Text = "Mã phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "PHIẾU NHẬP";
            // 
            // MaSachColumn
            // 
            this.MaSachColumn.HeaderText = "Mã Sách";
            this.MaSachColumn.MinimumWidth = 6;
            this.MaSachColumn.Name = "MaSachColumn";
            // 
            // TuaSachColumn
            // 
            this.TuaSachColumn.HeaderText = "Tựa Sách";
            this.TuaSachColumn.MinimumWidth = 6;
            this.TuaSachColumn.Name = "TuaSachColumn";
            // 
            // SoLuongColumn
            // 
            this.SoLuongColumn.HeaderText = "Số Lượng";
            this.SoLuongColumn.MinimumWidth = 6;
            this.SoLuongColumn.Name = "SoLuongColumn";
            // 
            // GiaNhapColumn
            // 
            this.GiaNhapColumn.HeaderText = "Giá Nhập";
            this.GiaNhapColumn.MinimumWidth = 6;
            this.GiaNhapColumn.Name = "GiaNhapColumn";
            // 
            // NhapKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 513);
            this.Controls.Add(this.NhapPhieuButton);
            this.Controls.Add(this.PhieuNhapDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GiaNhapTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoLuongTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TuaSachComboBox);
            this.Controls.Add(this.MaPNTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "NhapKhoForm";
            this.Text = "NhapKhoForm";
            ((System.ComponentModel.ISupportInitialize)(this.PhieuNhapDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NhapPhieuButton;
        private System.Windows.Forms.DataGridView PhieuNhapDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox GiaNhapTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoLuongTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TuaSachComboBox;
        private System.Windows.Forms.TextBox MaPNTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSachColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSachColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhapColumn;
    }
}