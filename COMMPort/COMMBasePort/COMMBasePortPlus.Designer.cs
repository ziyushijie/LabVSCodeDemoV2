﻿namespace Harry.LabCOMMPort
{
	partial class COMMBasePortPlus
	{
		   /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMMBasePortPlus));
			this.groupBox_COMM = new System.Windows.Forms.GroupBox();
			this.panel_COMMName = new System.Windows.Forms.Panel();
			this.pictureBox_COMM = new System.Windows.Forms.PictureBox();
			this.button_COMM = new System.Windows.Forms.Button();
			this.label_COMMName = new System.Windows.Forms.Label();
			this.comboBox_COMM = new System.Windows.Forms.ComboBox();
			this.panel_COMM = new System.Windows.Forms.Panel();
			this.groupBox_COMM.SuspendLayout();
			this.panel_COMMName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM)).BeginInit();
			this.panel_COMM.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_COMM
			// 
			this.groupBox_COMM.Controls.Add(this.panel_COMMName);
			resources.ApplyResources(this.groupBox_COMM, "groupBox_COMM");
			this.groupBox_COMM.Name = "groupBox_COMM";
			this.groupBox_COMM.TabStop = false;
			// 
			// panel_COMMName
			// 
			this.panel_COMMName.Controls.Add(this.pictureBox_COMM);
			this.panel_COMMName.Controls.Add(this.button_COMM);
			this.panel_COMMName.Controls.Add(this.label_COMMName);
			this.panel_COMMName.Controls.Add(this.comboBox_COMM);
			resources.ApplyResources(this.panel_COMMName, "panel_COMMName");
			this.panel_COMMName.Name = "panel_COMMName";
			// 
			// pictureBox_COMM
			// 
			resources.ApplyResources(this.pictureBox_COMM, "pictureBox_COMM");
			this.pictureBox_COMM.Name = "pictureBox_COMM";
			this.pictureBox_COMM.TabStop = false;
			this.pictureBox_COMM.Tag = "1";
			// 
			// button_COMM
			// 
			resources.ApplyResources(this.button_COMM, "button_COMM");
			this.button_COMM.Name = "button_COMM";
			this.button_COMM.UseVisualStyleBackColor = true;
			// 
			// label_COMMName
			// 
			resources.ApplyResources(this.label_COMMName, "label_COMMName");
			this.label_COMMName.Name = "label_COMMName";
			// 
			// comboBox_COMM
			// 
			this.comboBox_COMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_COMM.FormattingEnabled = true;
			resources.ApplyResources(this.comboBox_COMM, "comboBox_COMM");
			this.comboBox_COMM.Name = "comboBox_COMM";
			// 
			// panel_COMM
			// 
			this.panel_COMM.Controls.Add(this.groupBox_COMM);
			resources.ApplyResources(this.panel_COMM, "panel_COMM");
			this.panel_COMM.Name = "panel_COMM";
			// 
			// COMMBasePortPlus
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel_COMM);
			this.Name = "COMMBasePortPlus";
			this.groupBox_COMM.ResumeLayout(false);
			this.panel_COMMName.ResumeLayout(false);
			this.panel_COMMName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_COMM)).EndInit();
			this.panel_COMM.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_COMMName;
		public System.Windows.Forms.Panel panel_COMMName;
		public System.Windows.Forms.PictureBox pictureBox_COMM;
		public System.Windows.Forms.Button button_COMM;
		public System.Windows.Forms.Panel panel_COMM;
		public System.Windows.Forms.GroupBox groupBox_COMM;
		private System.Windows.Forms.ComboBox comboBox_COMM;
	}
}
