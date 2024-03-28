namespace Lab7_1
{
    partial class AnimalManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            bAdd = new Button();
            lvAnimals = new ListView();
            AnimalId = new ColumnHeader();
            AnimalName = new ColumnHeader();
            AnimalLimbCount = new ColumnHeader();
            AnimalBiome = new ColumnHeader();
            AnimalClass = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // bAdd
            // 
            bAdd.Location = new Point(626, 27);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(126, 40);
            bAdd.TabIndex = 1;
            bAdd.Text = "Додати...";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // lvAnimals
            // 
            lvAnimals.Columns.AddRange(new ColumnHeader[] { AnimalId, AnimalName, AnimalLimbCount, AnimalBiome, AnimalClass, columnHeader1 });
            lvAnimals.GridLines = true;
            lvAnimals.Location = new Point(12, 12);
            lvAnimals.Name = "lvAnimals";
            lvAnimals.Size = new Size(495, 424);
            lvAnimals.TabIndex = 2;
            lvAnimals.UseCompatibleStateImageBehavior = false;
            lvAnimals.View = View.Details;
            // 
            // AnimalId
            // 
            AnimalId.Text = "Id";
            AnimalId.Width = 30;
            // 
            // AnimalName
            // 
            AnimalName.Text = "Ім'я";
            AnimalName.Width = 100;
            // 
            // AnimalLimbCount
            // 
            AnimalLimbCount.Text = "Кінцівки:";
            AnimalLimbCount.TextAlign = HorizontalAlignment.Center;
            AnimalLimbCount.Width = 80;
            // 
            // AnimalBiome
            // 
            AnimalBiome.Text = "Місце знаходження";
            AnimalBiome.Width = 120;
            // 
            // AnimalClass
            // 
            AnimalClass.Text = "Вид тварини";
            AnimalClass.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Їжа";
            // 
            // AnimalManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(lvAnimals);
            Controls.Add(bAdd);
            Name = "AnimalManager";
            Text = "AnimalManager";
            ResumeLayout(false);
        }

        #endregion
        private Button bAdd;
        private ListView lvAnimals;
        private ColumnHeader AnimalId;
        private ColumnHeader AnimalName;
        private ColumnHeader AnimalLimbCount;
        private ColumnHeader AnimalBiome;
        private ColumnHeader AnimalClass;
        private ColumnHeader columnHeader1;
    }
}
