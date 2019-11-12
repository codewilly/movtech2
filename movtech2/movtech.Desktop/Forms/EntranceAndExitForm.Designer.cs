namespace movtech.Desktop.Forms
{
    partial class EntranceAndExitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVehicle = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClearEntrance = new System.Windows.Forms.Button();
            this.buttonRegisterEntrance = new System.Windows.Forms.Button();
            this.textKMEntrance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClearExit = new System.Windows.Forms.Button();
            this.buttonRegisterExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextCPFEntrance = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextCPFExit = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextLicensePlateEntrance = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextLicensePlateExit = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVehicle
            // 
            this.dataGridVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridVehicle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridVehicle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridVehicle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVehicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridVehicle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVehicle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridVehicle.ColumnHeadersHeight = 40;
            this.dataGridVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVehicle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridVehicle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridVehicle.EnableHeadersVisualStyles = false;
            this.dataGridVehicle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridVehicle.Location = new System.Drawing.Point(0, 353);
            this.dataGridVehicle.Name = "dataGridVehicle";
            this.dataGridVehicle.ReadOnly = true;
            this.dataGridVehicle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVehicle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridVehicle.RowHeadersVisible = false;
            this.dataGridVehicle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridVehicle.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridVehicle.RowTemplate.Height = 40;
            this.dataGridVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVehicle.Size = new System.Drawing.Size(1011, 136);
            this.dataGridVehicle.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada e Saída";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 253);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.95054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.04946F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 244);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maskedTextLicensePlateEntrance);
            this.panel3.Controls.Add(this.maskedTextCPFEntrance);
            this.panel3.Controls.Add(this.buttonClearEntrance);
            this.panel3.Controls.Add(this.buttonRegisterEntrance);
            this.panel3.Controls.Add(this.textKMEntrance);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 236);
            this.panel3.TabIndex = 0;
            // 
            // buttonClearEntrance
            // 
            this.buttonClearEntrance.BackColor = System.Drawing.Color.Silver;
            this.buttonClearEntrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearEntrance.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonClearEntrance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonClearEntrance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClearEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearEntrance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonClearEntrance.Location = new System.Drawing.Point(249, 167);
            this.buttonClearEntrance.Name = "buttonClearEntrance";
            this.buttonClearEntrance.Size = new System.Drawing.Size(116, 45);
            this.buttonClearEntrance.TabIndex = 7;
            this.buttonClearEntrance.Text = "Limpar";
            this.buttonClearEntrance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClearEntrance.UseVisualStyleBackColor = false;
            this.buttonClearEntrance.Click += new System.EventHandler(this.buttonClearEntrance_Click);
            // 
            // buttonRegisterEntrance
            // 
            this.buttonRegisterEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonRegisterEntrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterEntrance.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRegisterEntrance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRegisterEntrance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRegisterEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterEntrance.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterEntrance.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegisterEntrance.Location = new System.Drawing.Point(378, 167);
            this.buttonRegisterEntrance.Name = "buttonRegisterEntrance";
            this.buttonRegisterEntrance.Size = new System.Drawing.Size(116, 45);
            this.buttonRegisterEntrance.TabIndex = 4;
            this.buttonRegisterEntrance.Text = "Registrar";
            this.buttonRegisterEntrance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegisterEntrance.UseVisualStyleBackColor = false;
            // 
            // textKMEntrance
            // 
            this.textKMEntrance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKMEntrance.Location = new System.Drawing.Point(371, 89);
            this.textKMEntrance.Name = "textKMEntrance";
            this.textKMEntrance.Size = new System.Drawing.Size(119, 47);
            this.textKMEntrance.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quilometragem";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "CPF";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Placa";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar Entrada";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.maskedTextLicensePlateExit);
            this.panel4.Controls.Add(this.maskedTextCPFExit);
            this.panel4.Controls.Add(this.buttonClearExit);
            this.panel4.Controls.Add(this.buttonRegisterExit);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(508, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 236);
            this.panel4.TabIndex = 1;
            // 
            // buttonClearExit
            // 
            this.buttonClearExit.BackColor = System.Drawing.Color.Silver;
            this.buttonClearExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonClearExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonClearExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonClearExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonClearExit.Location = new System.Drawing.Point(243, 167);
            this.buttonClearExit.Name = "buttonClearExit";
            this.buttonClearExit.Size = new System.Drawing.Size(116, 45);
            this.buttonClearExit.TabIndex = 8;
            this.buttonClearExit.Text = "Limpar";
            this.buttonClearExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClearExit.UseVisualStyleBackColor = false;
            this.buttonClearExit.Click += new System.EventHandler(this.buttonClearExit_Click);
            // 
            // buttonRegisterExit
            // 
            this.buttonRegisterExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.buttonRegisterExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegisterExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonRegisterExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRegisterExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonRegisterExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegisterExit.Location = new System.Drawing.Point(380, 167);
            this.buttonRegisterExit.Name = "buttonRegisterExit";
            this.buttonRegisterExit.Size = new System.Drawing.Size(116, 45);
            this.buttonRegisterExit.TabIndex = 7;
            this.buttonRegisterExit.Text = "Registrar";
            this.buttonRegisterExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegisterExit.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Placa";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "CPF";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Registrar Saída";
            // 
            // maskedTextCPFEntrance
            // 
            this.maskedTextCPFEntrance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextCPFEntrance.Location = new System.Drawing.Point(150, 89);
            this.maskedTextCPFEntrance.Mask = "000,000,000-00";
            this.maskedTextCPFEntrance.Name = "maskedTextCPFEntrance";
            this.maskedTextCPFEntrance.Size = new System.Drawing.Size(215, 47);
            this.maskedTextCPFEntrance.TabIndex = 8;
            // 
            // maskedTextCPFExit
            // 
            this.maskedTextCPFExit.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextCPFExit.Location = new System.Drawing.Point(153, 89);
            this.maskedTextCPFExit.Mask = "000.000.000-00";
            this.maskedTextCPFExit.Name = "maskedTextCPFExit";
            this.maskedTextCPFExit.Size = new System.Drawing.Size(215, 47);
            this.maskedTextCPFExit.TabIndex = 9;
            // 
            // maskedTextLicensePlateEntrance
            // 
            this.maskedTextLicensePlateEntrance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextLicensePlateEntrance.Location = new System.Drawing.Point(8, 89);
            this.maskedTextLicensePlateEntrance.Mask = "AAA-0000";
            this.maskedTextLicensePlateEntrance.Name = "maskedTextLicensePlateEntrance";
            this.maskedTextLicensePlateEntrance.Size = new System.Drawing.Size(136, 47);
            this.maskedTextLicensePlateEntrance.TabIndex = 9;
            // 
            // maskedTextLicensePlateExit
            // 
            this.maskedTextLicensePlateExit.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextLicensePlateExit.Location = new System.Drawing.Point(3, 89);
            this.maskedTextLicensePlateExit.Mask = "AAA-0000";
            this.maskedTextLicensePlateExit.Name = "maskedTextLicensePlateExit";
            this.maskedTextLicensePlateExit.Size = new System.Drawing.Size(144, 47);
            this.maskedTextLicensePlateExit.TabIndex = 10;
            // 
            // EntranceAndExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntranceAndExitForm";
            this.Text = "EntranceAndExit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKMEntrance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRegisterEntrance;
        private System.Windows.Forms.Button buttonRegisterExit;
        private System.Windows.Forms.Button buttonClearEntrance;
        private System.Windows.Forms.Button buttonClearExit;
        private System.Windows.Forms.MaskedTextBox maskedTextLicensePlateEntrance;
        private System.Windows.Forms.MaskedTextBox maskedTextCPFEntrance;
        private System.Windows.Forms.MaskedTextBox maskedTextLicensePlateExit;
        private System.Windows.Forms.MaskedTextBox maskedTextCPFExit;
    }
}