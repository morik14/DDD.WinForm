namespace DDD.WinForm.Views
{
    partial class LatestView
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AreaIdTextBox = new System.Windows.Forms.TextBox();
            this.MeasureDateTextBox = new System.Windows.Forms.TextBox();
            this.MeasureValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(143, 272);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(364, 56);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "エリアID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "計測日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "計測値";
            // 
            // AreaIdTextBox
            // 
            this.AreaIdTextBox.Location = new System.Drawing.Point(209, 56);
            this.AreaIdTextBox.Name = "AreaIdTextBox";
            this.AreaIdTextBox.ReadOnly = true;
            this.AreaIdTextBox.Size = new System.Drawing.Size(352, 31);
            this.AreaIdTextBox.TabIndex = 2;
            // 
            // MeasureDateTextBox
            // 
            this.MeasureDateTextBox.Location = new System.Drawing.Point(209, 111);
            this.MeasureDateTextBox.Name = "MeasureDateTextBox";
            this.MeasureDateTextBox.ReadOnly = true;
            this.MeasureDateTextBox.Size = new System.Drawing.Size(352, 31);
            this.MeasureDateTextBox.TabIndex = 2;
            // 
            // MeasureValueTextBox
            // 
            this.MeasureValueTextBox.Location = new System.Drawing.Point(209, 176);
            this.MeasureValueTextBox.Name = "MeasureValueTextBox";
            this.MeasureValueTextBox.ReadOnly = true;
            this.MeasureValueTextBox.Size = new System.Drawing.Size(352, 31);
            this.MeasureValueTextBox.TabIndex = 2;
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 406);
            this.Controls.Add(this.MeasureValueTextBox);
            this.Controls.Add(this.MeasureDateTextBox);
            this.Controls.Add(this.AreaIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AreaIdTextBox;
        private System.Windows.Forms.TextBox MeasureDateTextBox;
        private System.Windows.Forms.TextBox MeasureValueTextBox;
    }
}