namespace LashaShraieri.Final.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int ReleaseYear { get; set; }
        public int MemorySize { get; set; }
        public int Cores { get; set; }

        public Laptop(string model, int releaseYear, int memorySize, int cores)
        {
            Model = model;
            ReleaseYear = releaseYear;
            MemorySize = memorySize;
            Cores = cores;
        }

        public override string ToString()
        {
            return $"{Model} ({ReleaseYear})";
        }
    }
}
