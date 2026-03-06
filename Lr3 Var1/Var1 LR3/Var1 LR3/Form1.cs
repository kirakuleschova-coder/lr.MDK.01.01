using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization; // Для парсинга чисел с точкой

namespace Var1_LR3
{
    public partial class Form1: Form
    {
        // Список для хранения всех загруженных материалов
        private List<Material> materials = new List<Material>();
        // Словарь для хранения выбранных позиций заказа (ключ - название материала, значение - количество)
        private Dictionary<string, int> orderItems = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            // Подписка на события происходит один раз в конструкторе
            this.Load += Form1_Load;
            cmbMaterials.SelectedIndexChanged += cmbMaterials_SelectedIndexChanged;
            btnOrder.Click += btnOrder_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromCsv("data.csv.txt"); // Загружаем данные
            FillComboBoxWithMaterials(); // Заполняем комбобокс названиями материалов

            // Устанавливаем начальные значения для NumericUpDown
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 1000;
            nudQuantity.Value = 1;

            // Очищаем поле вывода
            txtOrderOutput.Clear();

            // Если есть материалы, отображаем первый
            if (cmbMaterials.Items.Count > 0)
            {
                cmbMaterials.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Загрузка данных из CSV-файла
        /// </summary>
        private void LoadDataFromCsv(string filePath)
        {
            // Пытаемся найти файл в нескольких местах (рядом с exe или в корне проекта)
            string fullPath = Path.Combine(Application.StartupPath, filePath);
            if (!File.Exists(fullPath))
            {
                // Если файла нет, показываем ошибку, но не вылетаем
                MessageBox.Show($"Файл данных не найден: {fullPath}. Загружены тестовые данные.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadTestData(); // Загружаем тестовые данные для отладки
                return;
            }

            try
            {
                var lines = File.ReadAllLines(fullPath, System.Text.Encoding.UTF8);
                materials.Clear();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = line.Split(';');
                    if (parts.Length >= 5) // Должно быть минимум 5 частей (группа;имя;цена;поставщик;номенклатура;картинка)
                    {
                        var material = new Material
                        {
                            PartGroup = parts[0].Trim(),
                            Name = parts[1].Trim(),
                            // Пытаемся корректно распарсить цену (с учетом возможных культур)
                            Cost = decimal.TryParse(parts[2].Trim().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cost) ? cost : 0,
                            Supplier = parts[3].Trim(),
                            NomenclatureGroup = parts[4].Trim(),
                            ImagePath = parts.Length > 5 ? parts[5].Trim() : string.Empty
                        };
                        materials.Add(material);
                    }
                }

                if (materials.Count == 0)
                {
                    MessageBox.Show("Файл данных не содержит записей.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadTestData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadTestData();
            }
        }

        /// <summary>
        /// Загрузка тестовых данных, если нет файла
        /// </summary>
        private void LoadTestData()
        {
            materials = new List<Material>
            {
                new Material { PartGroup = "Деталь А", Name = "Сталь листовая", Cost = 1500, Supplier = "ООО \"МеталлТорг\"", NomenclatureGroup = "Листовые материалы", ImagePath = "" },
                new Material { PartGroup = "Деталь А", Name = "Краска порошковая", Cost = 800, Supplier = "ЗАО \"Полимер\"", NomenclatureGroup = "Лакокрасочные", ImagePath = "" },
                new Material { PartGroup = "Деталь Б", Name = "Пластик АБС", Cost = 1200, Supplier = "Пластмасс-импорт", NomenclatureGroup = "Полимеры", ImagePath = "" },
                new Material { PartGroup = "Деталь Б", Name = "Болт М8", Cost = 50, Supplier = "Крепеж-Сервис", NomenclatureGroup = "Метизы", ImagePath = "" }
            };
        }

        /// <summary>
        /// Заполнение ComboBox уникальными названиями материалов
        /// </summary>
        private void FillComboBoxWithMaterials()
        {
            cmbMaterials.Items.Clear();
            // Берем уникальные названия материалов
            var uniqueMaterials = materials.Select(m => m.Name).Distinct().ToArray();
            cmbMaterials.Items.AddRange(uniqueMaterials);
        }

        /// <summary>
        /// Событие при выборе материала в ComboBox - обновляем карточку
        /// </summary>
        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterials.SelectedItem == null) return;

            string selectedMaterialName = cmbMaterials.SelectedItem.ToString();
            // Ищем первый материал с таким именем (предполагаем, что у одного названия материала одинаковые атрибуты)
            var material = materials.FirstOrDefault(m => m.Name == selectedMaterialName);

            if (material != null)
            {
                // Обновляем Label'ы
                NameLabel.Text = $"Название: {material.Name}";
                CostLabel.Text = $"Стоимость: {material.Cost:C2}"; // Формат валюты
                SupplierLabel.Text = $"Поставщик: {material.Supplier}";
                NomenclatureLabel.Text = $"Номенклатурная группа: {material.NomenclatureGroup}";

                // Загрузка изображения
                if (!string.IsNullOrEmpty(material.ImagePath))
                {
                    string imageFullPath = Path.Combine(Application.StartupPath, material.ImagePath);
                    if (File.Exists(imageFullPath))
                    {
                        try
                        {
                            // Важно: PictureBox нужно освобождать старое изображение
                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                            }
                            pictureBox1.Image = Image.FromFile(imageFullPath);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Масштабируем
                        }
                        catch
                        {
                            pictureBox1.Image = null;
                            // Можно показать заглушку
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "Заказать"
        /// </summary>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Проверка 1: Выбран ли материал
            if (cmbMaterials.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите материал.", "Ошибка заказа",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка 2: Корректное ли количество (хотя NumericUpDown сам это контролирует)
            int quantity = (int)nudQuantity.Value; // Преобразуем decimal в int
            if (quantity <= 0)
            {
                MessageBox.Show("Количество должно быть положительным числом.", "Ошибка заказа",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMaterialName = cmbMaterials.SelectedItem.ToString();

            // Добавляем или обновляем позицию в заказе
            if (orderItems.ContainsKey(selectedMaterialName))
            {
                orderItems[selectedMaterialName] += quantity;
            }
            else
            {
                orderItems.Add(selectedMaterialName, quantity);
            }

            // Обновляем вывод заказа
            UpdateOrderOutput();

            // Сбрасываем количество для следующего выбора
            nudQuantity.Value = 1;
        }

        /// <summary>
        /// Обновление текстового поля с итоговым заказом
        /// </summary>
        private void UpdateOrderOutput()
        {
            txtOrderOutput.Clear();

            if (orderItems.Count == 0)
            {
                txtOrderOutput.Text = "Заказ пуст. Добавьте материалы.";
                return;
            }

            decimal totalCost = 0;
            var outputLines = new List<string>();
            outputLines.Add("=== ВАШ ЗАКАЗ ===");
            outputLines.Add("");

            foreach (var item in orderItems)
            {
                var material = materials.FirstOrDefault(m => m.Name == item.Key);
                if (material != null)
                {
                    decimal itemTotal = material.Cost * item.Value;
                    totalCost += itemTotal;
                    outputLines.Add($"Деталь: {material.PartGroup}");
                    outputLines.Add($"  Материал: {item.Key}");
                    outputLines.Add($"  Количество: {item.Value} шт.");
                    outputLines.Add($"  Цена за ед.: {material.Cost:C2}");
                    outputLines.Add($"  Сумма: {itemTotal:C2}");
                    outputLines.Add("---");
                }
                else
                {
                    // На случай, если материал вдруг не найден (не должно происходить)
                    outputLines.Add($"Материал: {item.Key}, Количество: {item.Value} шт.");
                }
            }

            outputLines.Add("");
            outputLines.Add($"ИТОГО: {totalCost:C2}");

            txtOrderOutput.Lines = outputLines.ToArray();
        }

        // Для удобства можно добавить кнопку "Очистить заказ"
        // Не забудьте добавить эту кнопку на форму в дизайнере
        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            orderItems.Clear();
            UpdateOrderOutput();
        }
    }
}
