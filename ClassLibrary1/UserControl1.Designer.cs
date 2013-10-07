﻿namespace ChronoEngine_SwAddin
{
    partial class SWTaskpaneHost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SWTaskpaneHost));
            this.button_export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_surfaces = new System.Windows.Forms.CheckBox();
            this.checkBox_collshapes = new System.Windows.Forms.CheckBox();
            this.checkBox_constraints = new System.Windows.Forms.CheckBox();
            this.toolTipSavePython = new System.Windows.Forms.ToolTip(this.components);
            this.button_setcollshape = new System.Windows.Forms.Button();
            this.checkBox_separateobj = new System.Windows.Forms.CheckBox();
            this.checkBox_saveUV = new System.Windows.Forms.CheckBox();
            this.button_runtest = new System.Windows.Forms.Button();
            this.checkBox_savetest = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_dt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_length = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_length)).BeginInit();
            this.SuspendLayout();
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(17, 56);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(163, 32);
            this.button_export.TabIndex = 0;
            this.button_export.Text = "Save as Python...";
            this.button_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSavePython.SetToolTip(this.button_export, resources.GetString("button_export.ToolTip"));
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chrono::Engine";
            // 
            // checkBox_surfaces
            // 
            this.checkBox_surfaces.AutoSize = true;
            this.checkBox_surfaces.Checked = true;
            this.checkBox_surfaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_surfaces.Location = new System.Drawing.Point(17, 95);
            this.checkBox_surfaces.Name = "checkBox_surfaces";
            this.checkBox_surfaces.Size = new System.Drawing.Size(102, 17);
            this.checkBox_surfaces.TabIndex = 2;
            this.checkBox_surfaces.Text = "Export surfaces ";
            this.toolTipSavePython.SetToolTip(this.checkBox_surfaces, resources.GetString("checkBox_surfaces.ToolTip"));
            this.checkBox_surfaces.UseVisualStyleBackColor = true;
            this.checkBox_surfaces.CheckedChanged += new System.EventHandler(this.checkBox_surfaces_CheckedChanged);
            // 
            // checkBox_collshapes
            // 
            this.checkBox_collshapes.AutoSize = true;
            this.checkBox_collshapes.Checked = true;
            this.checkBox_collshapes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_collshapes.Location = new System.Drawing.Point(17, 162);
            this.checkBox_collshapes.Name = "checkBox_collshapes";
            this.checkBox_collshapes.Size = new System.Drawing.Size(131, 17);
            this.checkBox_collshapes.TabIndex = 3;
            this.checkBox_collshapes.Text = "Export collison shapes";
            this.toolTipSavePython.SetToolTip(this.checkBox_collshapes, resources.GetString("checkBox_collshapes.ToolTip"));
            this.checkBox_collshapes.UseVisualStyleBackColor = true;
            // 
            // checkBox_constraints
            // 
            this.checkBox_constraints.AutoSize = true;
            this.checkBox_constraints.Checked = true;
            this.checkBox_constraints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_constraints.Location = new System.Drawing.Point(17, 185);
            this.checkBox_constraints.Name = "checkBox_constraints";
            this.checkBox_constraints.Size = new System.Drawing.Size(110, 17);
            this.checkBox_constraints.TabIndex = 4;
            this.checkBox_constraints.Text = "Export constraints";
            this.toolTipSavePython.SetToolTip(this.checkBox_constraints, resources.GetString("checkBox_constraints.ToolTip"));
            this.checkBox_constraints.UseVisualStyleBackColor = true;
            this.checkBox_constraints.CheckedChanged += new System.EventHandler(this.checkBox_constraints_CheckedChanged);
            // 
            // toolTipSavePython
            // 
            this.toolTipSavePython.ToolTipTitle = "Press this button to create a .py script with C::E assets";
            // 
            // button_setcollshape
            // 
            this.button_setcollshape.Location = new System.Drawing.Point(17, 289);
            this.button_setcollshape.Name = "button_setcollshape";
            this.button_setcollshape.Size = new System.Drawing.Size(163, 32);
            this.button_setcollshape.TabIndex = 5;
            this.button_setcollshape.Text = "Set body as collision shape";
            this.button_setcollshape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSavePython.SetToolTip(this.button_setcollshape, resources.GetString("button_setcollshape.ToolTip"));
            this.button_setcollshape.UseVisualStyleBackColor = true;
            this.button_setcollshape.Click += new System.EventHandler(this.button_setcollshape_Click);
            // 
            // checkBox_separateobj
            // 
            this.checkBox_separateobj.AutoSize = true;
            this.checkBox_separateobj.Location = new System.Drawing.Point(33, 118);
            this.checkBox_separateobj.Name = "checkBox_separateobj";
            this.checkBox_separateobj.Size = new System.Drawing.Size(172, 17);
            this.checkBox_separateobj.TabIndex = 6;
            this.checkBox_separateobj.Text = "Separate .obj per each subpart";
            this.toolTipSavePython.SetToolTip(this.checkBox_separateobj, resources.GetString("checkBox_separateobj.ToolTip"));
            this.checkBox_separateobj.UseVisualStyleBackColor = true;
            // 
            // checkBox_saveUV
            // 
            this.checkBox_saveUV.AutoSize = true;
            this.checkBox_saveUV.Checked = true;
            this.checkBox_saveUV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saveUV.Location = new System.Drawing.Point(33, 139);
            this.checkBox_saveUV.Name = "checkBox_saveUV";
            this.checkBox_saveUV.Size = new System.Drawing.Size(149, 17);
            this.checkBox_saveUV.TabIndex = 7;
            this.checkBox_saveUV.Text = "Save UV map  information";
            this.toolTipSavePython.SetToolTip(this.checkBox_saveUV, resources.GetString("checkBox_saveUV.ToolTip"));
            this.checkBox_saveUV.UseVisualStyleBackColor = true;
            this.checkBox_saveUV.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_runtest
            // 
            this.button_runtest.Location = new System.Drawing.Point(113, 209);
            this.button_runtest.Name = "button_runtest";
            this.button_runtest.Size = new System.Drawing.Size(69, 22);
            this.button_runtest.TabIndex = 8;
            this.button_runtest.Text = "Run test";
            this.toolTipSavePython.SetToolTip(this.button_runtest, "If you saved a test Python program, with the check button at \r\nthe left, then you" +
                    " can also run the program directly by pressing\r\nthis button. \r\nNOTE: you must ha" +
                    "ve Python installed.");
            this.button_runtest.UseVisualStyleBackColor = true;
            this.button_runtest.Click += new System.EventHandler(this.button_runtest_Click);
            // 
            // checkBox_savetest
            // 
            this.checkBox_savetest.AutoSize = true;
            this.checkBox_savetest.Location = new System.Drawing.Point(17, 209);
            this.checkBox_savetest.Name = "checkBox_savetest";
            this.checkBox_savetest.Size = new System.Drawing.Size(88, 17);
            this.checkBox_savetest.TabIndex = 9;
            this.checkBox_savetest.Text = "Save test .py";
            this.toolTipSavePython.SetToolTip(this.checkBox_savetest, resources.GetString("checkBox_savetest.ToolTip"));
            this.checkBox_savetest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "dt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numeric_dt
            // 
            this.numeric_dt.DecimalPlaces = 5;
            this.numeric_dt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric_dt.Location = new System.Drawing.Point(113, 231);
            this.numeric_dt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_dt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.numeric_dt.Name = "numeric_dt";
            this.numeric_dt.Size = new System.Drawing.Size(67, 20);
            this.numeric_dt.TabIndex = 11;
            this.toolTipSavePython.SetToolTip(this.numeric_dt, "Timestep [s]");
            this.numeric_dt.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numeric_length
            // 
            this.numeric_length.DecimalPlaces = 2;
            this.numeric_length.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_length.Location = new System.Drawing.Point(113, 253);
            this.numeric_length.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numeric_length.Name = "numeric_length";
            this.numeric_length.Size = new System.Drawing.Size(67, 20);
            this.numeric_length.TabIndex = 13;
            this.toolTipSavePython.SetToolTip(this.numeric_length, "Duration of the test simulation [s]");
            this.numeric_length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SWTaskpaneHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.numeric_length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numeric_dt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_savetest);
            this.Controls.Add(this.button_runtest);
            this.Controls.Add(this.checkBox_saveUV);
            this.Controls.Add(this.checkBox_separateobj);
            this.Controls.Add(this.button_setcollshape);
            this.Controls.Add(this.checkBox_constraints);
            this.Controls.Add(this.checkBox_collshapes);
            this.Controls.Add(this.checkBox_surfaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_export);
            this.Name = "SWTaskpaneHost";
            this.Size = new System.Drawing.Size(205, 374);
            this.toolTipSavePython.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_surfaces;
        private System.Windows.Forms.CheckBox checkBox_collshapes;
        private System.Windows.Forms.CheckBox checkBox_constraints;
        private System.Windows.Forms.ToolTip toolTipSavePython;
        private System.Windows.Forms.Button button_setcollshape;
        private System.Windows.Forms.CheckBox checkBox_separateobj;
        private System.Windows.Forms.CheckBox checkBox_saveUV;
        private System.Windows.Forms.Button button_runtest;
        private System.Windows.Forms.CheckBox checkBox_savetest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_length;
    }
}
