namespace ParkingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtPlateNo = new TextBox();
            btnSave = new Button();
            dgvCustomer = new DataGridView();
            label2 = new Label();
            txtColor = new TextBox();
            label3 = new Label();
            txtTimeIn = new TextBox();
            label4 = new Label();
            txtTimeOut = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 0;
            label1.Text = "Plate No";
            // 
            // txtPlateNo
            // 
            txtPlateNo.Location = new Point(120, 14);
            txtPlateNo.Name = "txtPlateNo";
            txtPlateNo.Size = new Size(194, 23);
            txtPlateNo.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DimGray;
            btnSave.Location = new Point(341, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 26);
            btnSave.TabIndex = 2;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvCustomer
            // 
            dgvCustomer.BackgroundColor = SystemColors.WindowFrame;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.GridColor = SystemColors.ControlDarkDark;
            dgvCustomer.Location = new Point(341, 14);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowTemplate.Height = 30;
            dgvCustomer.Size = new Size(560, 362);
            dgvCustomer.TabIndex = 3;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 0;
            label2.Text = "Color";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(120, 46);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(194, 23);
            txtColor.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 83);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 0;
            label3.Text = "Time In";
            // 
            // txtTimeIn
            // 
            txtTimeIn.Location = new Point(120, 79);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(194, 23);
            txtTimeIn.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 116);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 0;
            label4.Text = "Time Out";
            // 
            // txtTimeOut
            // 
            txtTimeOut.Location = new Point(120, 112);
            txtTimeOut.Name = "txtTimeOut";
            txtTimeOut.Size = new Size(194, 23);
            txtTimeOut.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DimGray;
            btnDelete.Location = new Point(433, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 26);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DimGray;
            btnCancel.Location = new Point(526, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 26);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(914, 510);
            Controls.Add(dgvCustomer);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtTimeOut);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtTimeIn);
            Controls.Add(label3);
            Controls.Add(txtPlateNo);
            Controls.Add(label1);
            Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlateNo;
        private Button btnSave;
        private DataGridView dgvCustomer;
        private Label label2;
        private TextBox txtColor;
        private Label label3;
        private TextBox txtTimeIn;
        private Label label4;
        private TextBox txtTimeOut;
        private Button btnDelete;
        private Button btnCancel;
    }
}