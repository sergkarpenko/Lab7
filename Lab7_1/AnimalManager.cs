using System.Data.Entity;

namespace Lab7_1
{
    public partial class AnimalManager : Form
    {
        private Context _context;

        public AnimalManager()
        {
            InitializeComponent();

            _context = Context.GetInstance();

            _context.Biomes.Load();
            _context.Eat.Load();
            _context.Biomes.Load();
            _context.AnimalEat.Load();
            _context.AnimalClass.Load();
            

            AddListViewAnimals();
        }

        private void AddListViewAnimals()
        {
            var animals = _context.Animals
                .Include(b => b.AnimalBiomes).Select(q => q);

            foreach (var an in animals)
            {
                
                
                ListViewItem lvi = new ListViewItem($"{an.AnimalBiomes}");
                lvi.SubItems.Add(an.Name);
                lvi.SubItems.Add($"{an.LimbCount}");

                string biome = an.AnimalBiomes.AnimalBiomes;
                lvi.SubItems.Add(biome);
                lvi.SubItems.Add($"{an.AnimalClass.ClassName}");
                //lvi.SubItems.Add($"{string.Join(" ",an.AnimalEats)}");
                lvAnimals.Items.Add(lvi);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();

            add.ShowDialog();
        }
    }
}
