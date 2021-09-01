﻿namespace SimplePaint
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbShapeMode = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clbShape = new System.Windows.Forms.CheckedListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.psfMain = new SimplePaint.PaintSurface();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbShapeMode);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnCurve);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 47);
            this.panel1.TabIndex = 0;
            // 
            // cmbShapeMode
            // 
            this.cmbShapeMode.FormattingEnabled = true;
            this.cmbShapeMode.Items.AddRange(new object[] {
            "No fill shape",
            "Fill shape"});
            this.cmbShapeMode.Location = new System.Drawing.Point(13, 13);
            this.cmbShapeMode.Name = "cmbShapeMode";
            this.cmbShapeMode.Size = new System.Drawing.Size(156, 21);
            this.cmbShapeMode.TabIndex = 3;
            this.cmbShapeMode.SelectedIndexChanged += new System.EventHandler(this.CmbShapeMode_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(545, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(45, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnCurve.FlatAppearance.BorderSize = 0;
            this.btnCurve.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.Location = new System.Drawing.Point(409, 12);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(44, 23);
            this.btnCurve.TabIndex = 2;
            this.btnCurve.Text = "Curve";
            this.btnCurve.UseVisualStyleBackColor = false;
            this.btnCurve.Click += new System.EventHandler(this.BtnCurve_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(367, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(44, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(318, 12);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(51, 23);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(274, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(46, 23);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(210, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(66, 23);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(175, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(37, 23);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(652, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 47);
            this.panel2.TabIndex = 0;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(33, 7);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(36, 34);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clbShape);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(992, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 578);
            this.panel3.TabIndex = 1;
            // 
            // clbShape
            // 
            this.clbShape.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbShape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbShape.CheckOnClick = true;
            this.clbShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbShape.FormattingEnabled = true;
            this.clbShape.Location = new System.Drawing.Point(0, 80);
            this.clbShape.Margin = new System.Windows.Forms.Padding(0);
            this.clbShape.Name = "clbShape";
            this.clbShape.Size = new System.Drawing.Size(203, 498);
            this.clbShape.TabIndex = 1;
            this.clbShape.SelectedIndexChanged += new System.EventHandler(this.ClbShape_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 80);
            this.panel5.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(16, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // psfMain
            // 
            this.psfMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.psfMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psfMain.Location = new System.Drawing.Point(0, 47);
            this.psfMain.Name = "psfMain";
            this.psfMain.Size = new System.Drawing.Size(992, 578);
            this.psfMain.TabIndex = 2;
            this.psfMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PsfMain_Paint);
            this.psfMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseDown);
            this.psfMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseMove);
            this.psfMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 625);
            this.Controls.Add(this.psfMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(973, 618);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbShape;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbShapeMode;
        private PaintSurface psfMain;
    }
}

