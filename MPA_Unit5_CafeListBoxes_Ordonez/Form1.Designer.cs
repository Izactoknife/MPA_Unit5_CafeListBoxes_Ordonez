namespace MPA_Unit5_CafeListBoxes_Ordonez
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
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.recieptListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.recieptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuListBox
            // 
            this.MenuListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 22;
            this.MenuListBox.Location = new System.Drawing.Point(8, 38);
            this.MenuListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(248, 268);
            this.MenuListBox.TabIndex = 0;
            this.MenuListBox.SelectedIndexChanged += new System.EventHandler(this.MenuListBox_SelectedIndexChanged);
            // 
            // orderListBox
            // 
            this.orderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 22;
            this.orderListBox.Location = new System.Drawing.Point(268, 38);
            this.orderListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(248, 268);
            this.orderListBox.TabIndex = 1;
            this.orderListBox.Click += new System.EventHandler(this.orderListBox_Click);
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatebutton.Location = new System.Drawing.Point(268, 372);
            this.Calculatebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(247, 32);
            this.Calculatebutton.TabIndex = 2;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // recieptListBox
            // 
            this.recieptListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptListBox.FormattingEnabled = true;
            this.recieptListBox.ItemHeight = 22;
            this.recieptListBox.Location = new System.Drawing.Point(8, 372);
            this.recieptListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recieptListBox.Name = "recieptListBox";
            this.recieptListBox.Size = new System.Drawing.Size(248, 114);
            this.recieptListBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(268, 418);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(247, 32);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(268, 462);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(247, 32);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(94, 10);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(70, 26);
            this.menuLabel.TabIndex = 7;
            this.menuLabel.Text = "Menu";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(345, 10);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(72, 26);
            this.orderLabel.TabIndex = 8;
            this.orderLabel.Text = "Order";
            // 
            // recieptLabel
            // 
            this.recieptLabel.AutoSize = true;
            this.recieptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptLabel.Location = new System.Drawing.Point(82, 344);
            this.recieptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recieptLabel.Name = "recieptLabel";
            this.recieptLabel.Size = new System.Drawing.Size(93, 26);
            this.recieptLabel.TabIndex = 9;
            this.recieptLabel.Text = "Reciept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 502);
            this.Controls.Add(this.recieptLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.recieptListBox);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.MenuListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.ListBox recieptListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label recieptLabel;
    }
}

