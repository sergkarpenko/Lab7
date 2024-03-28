using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lab7_1
{
    public partial class Add : Form
    {
        private readonly Context _context;

        private delegate void Function();

        private readonly List<Function> _functions = [];

        public Add()
        {
            InitializeComponent();

            _context = Context.Instance;

            _functions.Add(AddAnimal);
            _functions.Add(AddEat);
            _functions.Add(AddBiomes);
            _functions.Add(AddClass);

            ClearAllData();
        }

        private void ClearAllData()
        {
            tbAnimalName.Text = "";
            nudLimbCount.Value = 0m;

            tbEatName.Text = "";
            nudCalories.Value = 50;

            tbBiomeName.Text = "";

            tbClassName.Text = "";

            try
            {
                List<string> eats = [.. _context.Eats.Select(b => b.Name)];
                clbAnimalEat.Items.AddRange(eats.ToArray());

                List<string> biomes = [.. _context.Biomes.Select(b => b.Name)];
                lbBiomes.Items.AddRange(biomes.ToArray());

                List<string> classAnimals =[.. _context.Klasses.Select(b => b.Name).ToList()];
                lbClasses.Items.AddRange(classAnimals.ToArray());
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            int index = tiAdd.SelectedIndex;
            _functions[index]();
        }


        private void AddAnimal()
        {
            /*if (ValidationAddAnimal())
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }*/

            if (AddNotRepeatValidation(_context.Animals, b => b.Name == tbAnimalName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }

            _context.Add(CreateAnimal());
            SaveAndExit();
        }

        private bool ValidationAddAnimal()
        {
            return // Regex.IsMatch(tbAnimalName.Text, @"[\p{L}\s]+") &&
                   clbAnimalEat.CheckedItems.Count > 0 &&
                   lbBiomes.SelectedIndex != -1 &&
                   lbClasses.SelectedIndex != -1;
        }

        private Animal CreateAnimal()
        {


            List<string> selectedFoodNames = clbAnimalEat.CheckedItems.Cast<string>().ToList();
            List<Eat> selectedEats = _context.Eats.Where(e => selectedFoodNames.Contains(e.Name)).ToList();



            List<string> selectedBiomesNames = lbBiomes.SelectedItems.Cast<string>().ToList();
            List<Biome> biomes = _context.Biomes.Where(b => selectedBiomesNames.Contains(b.Name)).ToList(); 
            
            List<string> selectedAnimalClassNames = lbClasses.SelectedItems.Cast<string>().ToList();
            List<Klass> classes = _context.Klasses.Where(ac 
                => selectedAnimalClassNames.Contains(ac.Name)).ToList();

            Animal animal = new Animal
            {
                Name = tbAnimalName.Text,
                LimbCount = (int)nudLimbCount.Value,
                Eats = [.. selectedEats],
                Biome = _context.Biomes.Where(b => selectedBiomesNames.Contains(b.Name)).FirstOrDefault(),
                Klass = _context.Klasses.Where(ac => selectedAnimalClassNames.Contains(ac.Name)).FirstOrDefault()
            };

            return animal;
        }


        private void AddEat()
        {
            if (!Regex.IsMatch(tbEatName.Text, @"[\p{L}\s]+"))
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }

            if (AddNotRepeatValidation(_context.Eats, b => b.Name == tbEatName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }

            _context.Add(new Eat { Name = tbEatName.Text, Calories = (int)nudCalories.Value });
            SaveAndExit();
        }


        private void AddBiomes()
        {
            if (!Regex.IsMatch(tbBiomeName.Text, @"[\p{L}\s]+"))
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }

            if (AddNotRepeatValidation(_context.Biomes, b => b.Name == tbBiomeName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }


            _context.Add(new Biome { Name = tbBiomeName.Text });
            SaveAndExit();
        }

        private void AddClass()
        {
            if (!Regex.IsMatch(tbClassName.Text, @"[\p{L}\s]+"))
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }
            if (AddNotRepeatValidation(_context.Klasses, b => b.Name == tbClassName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }

            _context.Add(new Klass { Name = tbClassName.Text });
            SaveAndExit();
        }

        private bool AddNotRepeatValidation<T>(DbSet<T> dbSet, Func<T, bool> predicate) where T : class
        {
            return dbSet.Any(predicate);
        }

        private void SaveAndExit()
        {
            _context.SaveChanges();
            Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
    }
}
