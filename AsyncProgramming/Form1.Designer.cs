namespace AsyncProgramming
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
			this.syncMethod = new System.Windows.Forms.Button();
			this.asyncMethod = new System.Windows.Forms.Button();
			this.parallelMethod = new System.Windows.Forms.Button();
			this.txtSyncTime = new System.Windows.Forms.TextBox();
			this.txtAsyncTime = new System.Windows.Forms.TextBox();
			this.txtParellelTime = new System.Windows.Forms.TextBox();
			this.txtTaskId = new System.Windows.Forms.TextBox();
			this.richTxtInfo = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// syncMethod
			// 
			this.syncMethod.Location = new System.Drawing.Point(84, 12);
			this.syncMethod.Name = "syncMethod";
			this.syncMethod.Size = new System.Drawing.Size(157, 23);
			this.syncMethod.TabIndex = 0;
			this.syncMethod.Text = "Synchronized Method";
			this.syncMethod.UseVisualStyleBackColor = true;
			this.syncMethod.Click += new System.EventHandler(this.syncMethod_Click);
			// 
			// asyncMethod
			// 
			this.asyncMethod.Location = new System.Drawing.Point(84, 59);
			this.asyncMethod.Name = "asyncMethod";
			this.asyncMethod.Size = new System.Drawing.Size(157, 23);
			this.asyncMethod.TabIndex = 1;
			this.asyncMethod.Text = "Asynchronized Method";
			this.asyncMethod.UseVisualStyleBackColor = true;
			this.asyncMethod.Click += new System.EventHandler(this.asyncMethod_Click);
			// 
			// parallelMethod
			// 
			this.parallelMethod.Location = new System.Drawing.Point(84, 110);
			this.parallelMethod.Name = "parallelMethod";
			this.parallelMethod.Size = new System.Drawing.Size(187, 23);
			this.parallelMethod.TabIndex = 2;
			this.parallelMethod.Text = "Parallel Asynchronized Method";
			this.parallelMethod.UseVisualStyleBackColor = true;
			this.parallelMethod.Click += new System.EventHandler(this.parallelMethod_Click);
			// 
			// txtSyncTime
			// 
			this.txtSyncTime.Location = new System.Drawing.Point(350, 15);
			this.txtSyncTime.Name = "txtSyncTime";
			this.txtSyncTime.Size = new System.Drawing.Size(100, 20);
			this.txtSyncTime.TabIndex = 3;
			// 
			// txtAsyncTime
			// 
			this.txtAsyncTime.Location = new System.Drawing.Point(350, 62);
			this.txtAsyncTime.Name = "txtAsyncTime";
			this.txtAsyncTime.Size = new System.Drawing.Size(100, 20);
			this.txtAsyncTime.TabIndex = 4;
			// 
			// txtParellelTime
			// 
			this.txtParellelTime.Location = new System.Drawing.Point(350, 113);
			this.txtParellelTime.Name = "txtParellelTime";
			this.txtParellelTime.Size = new System.Drawing.Size(100, 20);
			this.txtParellelTime.TabIndex = 5;
			// 
			// txtTaskId
			// 
			this.txtTaskId.Location = new System.Drawing.Point(594, 150);
			this.txtTaskId.Name = "txtTaskId";
			this.txtTaskId.ReadOnly = true;
			this.txtTaskId.Size = new System.Drawing.Size(207, 20);
			this.txtTaskId.TabIndex = 6;
			// 
			// richTxtInfo
			// 
			this.richTxtInfo.Location = new System.Drawing.Point(-3, 176);
			this.richTxtInfo.Name = "richTxtInfo";
			this.richTxtInfo.Size = new System.Drawing.Size(804, 277);
			this.richTxtInfo.TabIndex = 7;
			this.richTxtInfo.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(536, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Task No";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTxtInfo);
			this.Controls.Add(this.txtTaskId);
			this.Controls.Add(this.txtParellelTime);
			this.Controls.Add(this.txtAsyncTime);
			this.Controls.Add(this.txtSyncTime);
			this.Controls.Add(this.parallelMethod);
			this.Controls.Add(this.asyncMethod);
			this.Controls.Add(this.syncMethod);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button syncMethod;
		private System.Windows.Forms.Button asyncMethod;
		private System.Windows.Forms.Button parallelMethod;
		private System.Windows.Forms.TextBox txtSyncTime;
		private System.Windows.Forms.TextBox txtAsyncTime;
		private System.Windows.Forms.TextBox txtParellelTime;
		private System.Windows.Forms.TextBox txtTaskId;
		private System.Windows.Forms.RichTextBox richTxtInfo;
		private System.Windows.Forms.Label label1;
	}
}

