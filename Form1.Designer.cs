namespace LashaShraieri.Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox LaptopsListBox;
        private System.Windows.Forms.Button AddLaptopButton;
        private System.Windows.Forms.Button DeleteLaptopButton;
        private System.Windows.Forms.Button EditLaptopButton; // Added new button

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
            LaptopsListBox = new ListBox();
            AddLaptopButton = new Button();
            DeleteLaptopButton = new Button();
            EditLaptopButton = new Button(); // Initialize the new button
            Laptopslbl = new Label();
            SuspendLayout();
            //
            // LaptopsListBox
            //
            LaptopsListBox.FormattingEnabled = true;
            LaptopsListBox.Location = new Point(12, 32);
            LaptopsListBox.Margin = new Padding(3, 2, 3, 2);
            LaptopsListBox.Name = "LaptopsListBox";
            LaptopsListBox.Size = new Size(307, 289);
            LaptopsListBox.TabIndex = 0;
            //
            // AddLaptopButton
            //
            AddLaptopButton.Location = new Point(332, 32);
            AddLaptopButton.Margin = new Padding(3, 2, 3, 2);
            AddLaptopButton.Name = "AddLaptopButton";
            AddLaptopButton.Size = new Size(131, 30);
            AddLaptopButton.TabIndex = 1;
            AddLaptopButton.Text = "Add Laptop";
            AddLaptopButton.UseVisualStyleBackColor = true;
            AddLaptopButton.Click += AddLaptopButton_Click;
            //
            // DeleteLaptopButton
            //
            DeleteLaptopButton.Location = new Point(332, 138); // Adjusted position
            DeleteLaptopButton.Margin = new Padding(3, 2, 3, 2);
            DeleteLaptopButton.Name = "DeleteLaptopButton";
            DeleteLaptopButton.Size = new Size(131, 30);
            DeleteLaptopButton.TabIndex = 0;
            DeleteLaptopButton.Text = "Delete Laptop";
            DeleteLaptopButton.UseVisualStyleBackColor = true;
            DeleteLaptopButton.Click += DeleteLaptopButton_Click;
            //
            // EditLaptopButton
            //
            EditLaptopButton.Location = new Point(332, 85); // Positioned between Add and Delete
            EditLaptopButton.Margin = new Padding(3, 2, 3, 2);
            EditLaptopButton.Name = "EditLaptopButton";
            EditLaptopButton.Size = new Size(131, 30);
            EditLaptopButton.TabIndex = 2; // Assign a new TabIndex
            EditLaptopButton.Text = "Edit Laptop";
            EditLaptopButton.UseVisualStyleBackColor = true;
            EditLaptopButton.Click += EditLaptopButton_Click; // New event handler
            //
            // Laptopslbl
            //
            Laptopslbl.AutoSize = true;
            Laptopslbl.Location = new Point(12, 9);
            Laptopslbl.Name = "Laptopslbl";
            Laptopslbl.Size = new Size(68, 15);
            Laptopslbl.TabIndex = 2;
            Laptopslbl.Text = "Laptop List:";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 343);
            Controls.Add(Laptopslbl);
            Controls.Add(DeleteLaptopButton);
            Controls.Add(EditLaptopButton); // Add to controls
            Controls.Add(AddLaptopButton);
            Controls.Add(LaptopsListBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Laptop Management";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Laptopslbl;
    }
}
