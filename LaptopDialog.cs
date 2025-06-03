using LashaShraieri.Final.Models;
using System;
using System.Windows.Forms;

namespace LashaShraieri.Final
{
    public partial class LaptopDialog : Form
    {
        public string Model { get; private set; }
        public int ReleaseYear { get; private set; }
        public int MemorySize { get; private set; }
        public int Cores { get; private set; }
        public int LaptopId { get; private set; } // Added to store ID for editing

        // Constructor for adding a new laptop
        public LaptopDialog()
        {
            InitializeComponent();
            LaptopId = 0; // Indicate a new laptop
        }

        // New constructor for editing an existing laptop
        public LaptopDialog(Laptop laptopToEdit) : this() // Call default constructor first
        {
            LaptopId = laptopToEdit.Id;
            ModelTxtBox.Text = laptopToEdit.Model;
            ReleaseYearTxtBox.Text = laptopToEdit.ReleaseYear.ToString();
            MemorySizeTxtBox.Text = laptopToEdit.MemorySize.ToString();
            CoresTxtBox.Text = laptopToEdit.Cores.ToString();
        }


        private void DoneButton_Click(object sender, EventArgs e)
        {
            Model = ModelTxtBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Model))
            {
                MessageBox.Show("Please enter a model name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ReleaseYearTxtBox.Text, out int releaseYear))
            {
                MessageBox.Show("Please enter a valid release year (e.g., 2023).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ReleaseYear = releaseYear;

            if (!int.TryParse(MemorySizeTxtBox.Text, out int memorySize))
            {
                MessageBox.Show("Please enter a valid memory size in GB (e.g., 16).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MemorySize = memorySize;

            if (!int.TryParse(CoresTxtBox.Text, out int cores))
            {
                MessageBox.Show("Please enter a valid number of cores (e.g., 8).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cores = cores;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
