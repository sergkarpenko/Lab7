namespace Lab7_1
{
    partial class Add
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
            tiAdd = new TabControl();
            tabPage1 = new TabPage();
            lbClasses = new ListBox();
            lbBiomes = new ListBox();
            label5 = new Label();
            label4 = new Label();
            clbAnimalEat = new CheckedListBox();
            nudLimbCount = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            tbAnimalName = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            nudCalories = new NumericUpDown();
            label7 = new Label();
            tbEatName = new TextBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            tbBiomeName = new TextBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            tbClassName = new TextBox();
            label9 = new Label();
            bAdd = new Button();
            bExit = new Button();
            bClear = new Button();
            tiAdd.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimbCount).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalories).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tiAdd
            // 
            tiAdd.Controls.Add(tabPage1);
            tiAdd.Controls.Add(tabPage2);
            tiAdd.Controls.Add(tabPage3);
            tiAdd.Controls.Add(tabPage4);
            tiAdd.Location = new Point(12, 12);
            tiAdd.Name = "tiAdd";
            tiAdd.SelectedIndex = 0;
            tiAdd.Size = new Size(428, 428);
            tiAdd.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbClasses);
            tabPage1.Controls.Add(lbBiomes);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(clbAnimalEat);
            tabPage1.Controls.Add(nudLimbCount);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbAnimalName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(420, 400);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Тварину";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbClasses
            // 
            lbClasses.FormattingEnabled = true;
            lbClasses.ItemHeight = 15;
            lbClasses.Location = new Point(11, 325);
            lbClasses.Name = "lbClasses";
            lbClasses.Size = new Size(166, 64);
            lbClasses.TabIndex = 11;
            // 
            // lbBiomes
            // 
            lbBiomes.FormattingEnabled = true;
            lbBiomes.ItemHeight = 15;
            lbBiomes.Location = new Point(6, 234);
            lbBiomes.Name = "lbBiomes";
            lbBiomes.Size = new Size(166, 64);
            lbBiomes.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 210);
            label5.Name = "label5";
            label5.Size = new Size(214, 21);
            label5.TabIndex = 9;
            label5.Text = "Виберіть місце проживання:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 301);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 8;
            label4.Text = "Виберіть Вид Тварини:";
            // 
            // clbAnimalEat
            // 
            clbAnimalEat.FormattingEnabled = true;
            clbAnimalEat.Location = new Point(6, 149);
            clbAnimalEat.Name = "clbAnimalEat";
            clbAnimalEat.Size = new Size(166, 58);
            clbAnimalEat.TabIndex = 7;
            // 
            // nudLimbCount
            // 
            nudLimbCount.Location = new Point(6, 99);
            nudLimbCount.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudLimbCount.Name = "nudLimbCount";
            nudLimbCount.Size = new Size(166, 23);
            nudLimbCount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 4;
            label3.Text = "Виберіть Їжу:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 2;
            label2.Text = "Виберіть кількість кінцівок:";
            // 
            // tbAnimalName
            // 
            tbAnimalName.Location = new Point(6, 49);
            tbAnimalName.Name = "tbAnimalName";
            tbAnimalName.Size = new Size(166, 23);
            tbAnimalName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Виберіть Ім'я:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(nudCalories);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tbEatName);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(420, 400);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Їжу";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // nudCalories
            // 
            nudCalories.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudCalories.Location = new Point(6, 86);
            nudCalories.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudCalories.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudCalories.Name = "nudCalories";
            nudCalories.Size = new Size(166, 23);
            nudCalories.TabIndex = 8;
            nudCalories.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(202, 21);
            label7.TabIndex = 7;
            label7.Text = "Виберіть кількість Калорій:";
            // 
            // tbEatName
            // 
            tbEatName.Location = new Point(6, 36);
            tbEatName.Name = "tbEatName";
            tbEatName.Size = new Size(166, 23);
            tbEatName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(6, 12);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 2;
            label6.Text = "Виберіть назву їжі:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tbBiomeName);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(420, 400);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Місце Проживання";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbBiomeName
            // 
            tbBiomeName.Location = new Point(6, 47);
            tbBiomeName.Name = "tbBiomeName";
            tbBiomeName.Size = new Size(166, 23);
            tbBiomeName.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(6, 23);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 4;
            label8.Text = "Виберіть назву:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tbClassName);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(420, 400);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Класс тварин";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbClassName
            // 
            tbClassName.Location = new Point(3, 44);
            tbClassName.Name = "tbClassName";
            tbClassName.Size = new Size(166, 23);
            tbClassName.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 20);
            label9.Name = "label9";
            label9.Size = new Size(181, 21);
            label9.TabIndex = 4;
            label9.Text = "Створіть Класс тварини:";
            // 
            // bAdd
            // 
            bAdd.Location = new Point(12, 442);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(143, 50);
            bAdd.TabIndex = 1;
            bAdd.Text = "Створити";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(293, 442);
            bExit.Name = "bExit";
            bExit.Size = new Size(143, 50);
            bExit.TabIndex = 2;
            bExit.Text = "Закрити";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // bClear
            // 
            bClear.Location = new Point(161, 442);
            bClear.Name = "bClear";
            bClear.Size = new Size(126, 50);
            bClear.TabIndex = 3;
            bClear.Text = "Очистити поля";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 504);
            Controls.Add(bClear);
            Controls.Add(bExit);
            Controls.Add(bAdd);
            Controls.Add(tiAdd);
            Name = "Add";
            Text = "Добавити...";
            tiAdd.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimbCount).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCalories).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tiAdd;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;
        private TextBox tbAnimalName;
        private NumericUpDown nudLimbCount;
        private Label label3;
        private CheckedListBox clbAnimalEat;
        private ListBox lbClasses;
        private ListBox lbBiomes;
        private Label label5;
        private Label label4;
        private Button bAdd;
        private Button bExit;
        private TabPage tabPage4;
        private NumericUpDown nudCalories;
        private Label label7;
        private TextBox tbEatName;
        private Label label6;
        private TextBox tbBiomeName;
        private Label label8;
        private TextBox tbClassName;
        private Label label9;
        private Button bClear;
    }
}