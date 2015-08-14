namespace OrderGrid
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
            this.components = new System.ComponentModel.Container();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.richTextBoxDetailsGrid = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTestTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestTable)).BeginInit();
            this.SuspendLayout();
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(549, 86);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(147, 23);
            this.buttonMoveUp.TabIndex = 1;
            this.buttonMoveUp.Text = "MoveUp";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(549, 115);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(147, 23);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonMoveDown.Text = "ModeDown";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // richTextBoxDetailsGrid
            // 
            this.richTextBoxDetailsGrid.Location = new System.Drawing.Point(549, 186);
            this.richTextBoxDetailsGrid.Name = "richTextBoxDetailsGrid";
            this.richTextBoxDetailsGrid.Size = new System.Drawing.Size(279, 157);
            this.richTextBoxDetailsGrid.TabIndex = 4;
            this.richTextBoxDetailsGrid.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewTestTable
            // 
            this.dataGridViewTestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestTable.Location = new System.Drawing.Point(75, 86);
            this.dataGridViewTestTable.Name = "dataGridViewTestTable";
            this.dataGridViewTestTable.Size = new System.Drawing.Size(450, 257);
            this.dataGridViewTestTable.TabIndex = 5;
            this.dataGridViewTestTable.SelectionChanged += new System.EventHandler(this.dataGridViewTestTable_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 386);
            this.Controls.Add(this.dataGridViewTestTable);
            this.Controls.Add(this.richTextBoxDetailsGrid);
            this.Controls.Add(this.buttonMoveDown);
            this.Controls.Add(this.buttonMoveUp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource testTableBindingSource;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.RichTextBox richTextBoxDetailsGrid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewTestTable;
    }
}

