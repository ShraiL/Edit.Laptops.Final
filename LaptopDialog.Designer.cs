namespace LashaShraieri.Final
{
    partial class LaptopDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox ModelTxtBox;
        private TextBox ReleaseYearTxtBox;
        private TextBox MemorySizeTxtBox;
        private TextBox CoresTxtBox;
        private Button DoneButton;
        private Label modelLbl;
        private Label releaseyearLbl;
        private Label memorySizeLbl;
        private Label coresLbl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ModelTxtBox = new TextBox();
            ReleaseYearTxtBox = new TextBox();
            MemorySizeTxtBox = new TextBox();
            CoresTxtBox = new TextBox();
            DoneButton = new Button();
            modelLbl = new Label();
            releaseyearLbl = new Label();
            memorySizeLbl = new Label();
            coresLbl = new Label();
            SuspendLayout();
            // 
            // ModelTxtBox
            // 
            ModelTxtBox.Location = new Point(12, 30);
            ModelTxtBox.Name = "ModelTxtBox";
            ModelTxtBox.Size = new Size(222, 23);
            ModelTxtBox.TabIndex = 4;
            // 
            // ReleaseYearTxtBox
            // 
            ReleaseYearTxtBox.Location = new Point(12, 80);
            ReleaseYearTxtBox.Name = "ReleaseYearTxtBox";
            ReleaseYearTxtBox.Size = new Size(222, 23);
            ReleaseYearTxtBox.TabIndex = 3;
            // 
            // MemorySizeTxtBox
            // 
            MemorySizeTxtBox.Location = new Point(12, 130);
            MemorySizeTxtBox.Name = "MemorySizeTxtBox";
            MemorySizeTxtBox.Size = new Size(222, 23);
            MemorySizeTxtBox.TabIndex = 2;
            // 
            // CoresTxtBox
            // 
            CoresTxtBox.Location = new Point(12, 186);
            CoresTxtBox.Name = "CoresTxtBox";
            CoresTxtBox.Size = new Size(222, 23);
            CoresTxtBox.TabIndex = 1;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(23, 240);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(200, 30);
            DoneButton.TabIndex = 0;
            DoneButton.Text = "Save";
            DoneButton.Click += DoneButton_Click;
            // 
            // modelLbl
            // 
            modelLbl.Location = new Point(12, 10);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(100, 23);
            modelLbl.TabIndex = 5;
            modelLbl.Text = "Model:";
            // 
            // releaseyearLbl
            // 
            releaseyearLbl.Location = new Point(12, 60);
            releaseyearLbl.Name = "releaseyearLbl";
            releaseyearLbl.Size = new Size(100, 23);
            releaseyearLbl.TabIndex = 6;
            releaseyearLbl.Text = "Release Year:";
            // 
            // memorySizeLbl
            // 
            memorySizeLbl.Location = new Point(12, 110);
            memorySizeLbl.Name = "memorySizeLbl";
            memorySizeLbl.Size = new Size(100, 23);
            memorySizeLbl.TabIndex = 7;
            memorySizeLbl.Text = "Memory Size (GB):";
            // 
            // coresLbl
            // 
            coresLbl.Location = new Point(12, 160);
            coresLbl.Name = "coresLbl";
            coresLbl.Size = new Size(100, 23);
            coresLbl.TabIndex = 8;
            coresLbl.Text = "Cores:";
            // 
            // LaptopDialog
            // 
            ClientSize = new Size(256, 282);
            Controls.Add(DoneButton);
            Controls.Add(CoresTxtBox);
            Controls.Add(MemorySizeTxtBox);
            Controls.Add(ReleaseYearTxtBox);
            Controls.Add(ModelTxtBox);
            Controls.Add(modelLbl);
            Controls.Add(releaseyearLbl);
            Controls.Add(memorySizeLbl);
            Controls.Add(coresLbl);
            Name = "LaptopDialog";
            Text = "Laptop Details";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
