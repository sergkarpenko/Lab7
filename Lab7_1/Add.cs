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

            _context = Context.GetInstance();

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
                List<string> eats = [.. _context.Eat.Select(b => b.EatName)];
                clbAnimalEat.Items.AddRange(eats.ToArray());

                List<string> biomes = [.. _context.Biomes.Select(b => b.AnimalBiomes)];
                lbBiomes.Items.AddRange(biomes.ToArray());

                List<string> classAnimals =[.. _context.AnimalClass.Select(b => b.ClassName).ToList()];
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
            List<Eat> selectedEats = _context.Eat.Where(e => selectedFoodNames.Contains(e.EatName)).ToList();



            List<string> selectedBiomesNames = lbBiomes.SelectedItems.Cast<string>().ToList();
            List<Biomes> biomes = _context.Biomes.Where(b => selectedBiomesNames.Contains(b.AnimalBiomes)).ToList(); 
            
            List<string> selectedAnimalClassNames = lbClasses.SelectedItems.Cast<string>().ToList();
            List<AnimalClass> classes = _context.AnimalClass.Where(ac 
                => selectedAnimalClassNames.Contains(ac.ClassName)).ToList();

            Animal animal = new Animal
            {
                Name = tbAnimalName.Text,
                LimbCount = (int)nudLimbCount.Value,
                AnimalEats = selectedEats.Select(eat => new AnimalEat
                {
                    Eat = eat
                }).ToList(),
                AnimalBiomes = _context.Biomes.Where(b => selectedBiomesNames.Contains(b.AnimalBiomes)).FirstOrDefault(),
                AnimalClass = _context.AnimalClass.Where(ac => selectedAnimalClassNames.Contains(ac.ClassName)).FirstOrDefault()
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

            if (AddNotRepeatValidation(_context.Eat, b => b.EatName == tbEatName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }

            _context.Add(new Eat { EatName = tbEatName.Text, Calories = (int)nudCalories.Value });
            SaveAndExit();
        }


        private void AddBiomes()
        {
            if (!Regex.IsMatch(tbBiomeName.Text, @"[\p{L}\s]+"))
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }

            if (AddNotRepeatValidation(_context.Biomes, b => b.AnimalBiomes == tbBiomeName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }


            _context.Add(new Biomes { AnimalBiomes = tbBiomeName.Text });
            SaveAndExit();
        }

        private void AddClass()
        {
            if (!Regex.IsMatch(tbClassName.Text, @"[\p{L}\s]+"))
            {
                MessageBox.Show("Неправильно введені поля.");
                return;
            }
            if (AddNotRepeatValidation(_context.AnimalClass, b => b.ClassName == tbClassName.Text))
            {
                MessageBox.Show("Таке ім'я вже існує.");
                return;
            }

            _context.Add(new AnimalClass { ClassName = tbClassName.Text });
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
