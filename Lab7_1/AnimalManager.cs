using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Lab7_1
{
    public partial class AnimalManager : Form
    {
        private readonly Context _context;

        public AnimalManager()
        {
            InitializeComponent();

            _context = Context.Instance;
            _context.Database.EnsureCreated();
            //_context.Database.

            _context.Animals.Load();
            _context.Biomes.Load();
            _context.Eats.Load();
            _context.Klasses.Load();
            

            AddListViewAnimals();
        }

        private void AddListViewAnimals()
        {
            lvAnimals.Items.Clear();
            foreach (var animal in _context.Animals.ToList())
            {
                ListViewItem lvi = new ListViewItem($"{animal.Biome}");
                lvi.SubItems.Add(animal.Name);
                lvi.SubItems.Add($"{animal.LimbCount}");

                lvi.SubItems.Add(animal.Biome.Name);
                lvi.SubItems.Add($"{animal.Klass.Name}");
                lvi.SubItems.Add(string.Join(", ", animal.Eats.Select(n => n.Name)));
                lvAnimals.Items.Add(lvi);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();

            add.ShowDialog();
            AddListViewAnimals();
        }
    }
}
