using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_8
{
    /// <summary>
	/// Форма записей об оплате
	/// </summary>
    public partial class Form1 : Form
    {
        private string filePath;
        private List<PaymentRecord> paymentRecords = new List<PaymentRecord>();

        /// <summary>
		/// Конструктор
		/// Кнопки добавить, удалить и поиск заблокированы
		/// </summary>
        public Form1()
        {
            InitializeComponent();
            add.Enabled = false;
            remove.Enabled = false;
            find.Enabled = false;
            cancelSearch.Enabled = false;
        }

        /// <summary>
		/// Нажатие на кнопку загрузка
		/// Загрузка данных из выбранного .xml файла
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    parseXML(openFileDialog.FileName);
                }
                catch (ArgumentException)
                {
                    paymentRecords.Clear();
                    MessageBox.Show("Некорректный путь к xml-файлу",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                catch (NullReferenceException)
                {
                    paymentRecords.Clear();
                    MessageBox.Show("Некорректный данные в xml-файле",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    paymentRecords.Clear();
                    MessageBox.Show("Что-то пошло не так: " + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                filePath = openFileDialog.FileName;
            }
        }

        /// <summary>
		/// Выгрузка строк из xml файла
		/// </summary>
		/// <param name="filePathInput">Путь к файлу</param>
        public void parseXML(string filePathInput)
        {
            XDocument document;

            try
            {
                document = XDocument.Load(filePathInput);
            }
            catch
            {
                throw new ArgumentException();
            }

            paymentRecords.Clear();

            foreach (XElement record in document.Element("records").Elements("record"))
            {
                XElement houseNumber = record.Element("houseNumber");
                XElement apartNumber = record.Element("apartNumber");
                XElement lastname = record.Element("lastname");
                XElement paymentType = record.Element("paymentType");
                XElement paymentSum = record.Element("paymentSum");
                XElement paymentDate = record.Element("paymentDate");
                XElement pennyPercent = record.Element("pennyPercent");
                XElement paymentDaysLeft = record.Element("paymentDaysLeft");

                if (houseNumber == null || apartNumber == null ||
                    lastname == null || paymentType == null ||
                    paymentSum == null || paymentDate == null ||
                    pennyPercent == null || paymentDaysLeft == null)
                {
                    throw new NullReferenceException();
                }

                PaymentRecord paymentRecord = new PaymentRecord(houseNumber.Value,
                        apartNumber.Value,
                        lastname.Value,
                        paymentType.Value,
                        paymentDate.Value,
                        paymentSum.Value,
                        pennyPercent.Value,
                        paymentDaysLeft.Value);

                if (!paymentRecord.isCorrect())
                    throw new NullReferenceException();

                paymentRecords.Add(paymentRecord);
            }


            add.Enabled = true;
            remove.Enabled = paymentRecords.Count() > 0;
            find.Enabled = paymentRecords.Count() > 0;

            addItemsToListView(paymentRecords);
        }

        /// <summary>
		/// Добавление элементов из списка записей на экран
		/// </summary>
		/// <param name="records">Список записей</param>
        private void addItemsToListView(List<PaymentRecord> records)
        {
            listView1.Items.Clear();

            foreach (PaymentRecord record in records)
            {
                string[] row = { record.houseNumber, record.apartNumber, record.lastname, record.paymentType, record.paymentDate,
                    record.paymentSum, record.pennyPercent, record.paymentDaysLeft };
                listView1.Items.Add(new ListViewItem(row));
            }
            ResizeListViewColumns();
        }

        /// <summary>
		/// Выравнивание колонок
		/// </summary>
        private void ResizeListViewColumns()
        {
            int width = 0;

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }

            foreach (ColumnHeader column in listView1.Columns)
            {
                width += column.Width;
            }

            Width = width + 20;
        }

        /// <summary>
		/// Загрузка окна
		/// Выравнивание колонок
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeListViewColumns();
        }

        /// <summary>
		/// Нажатие на кнопку добавить
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            using (AddRecordForm addRecordForm = new AddRecordForm())
            {
                addRecordForm.ShowDialog();

                if (!addRecordForm.isSaved) return;

                try
                {
                    addRecordToXml(filePath, addRecordForm.record);
                    paymentRecords.Add(addRecordForm.record);
                    addItemsToListView(paymentRecords);
                    remove.Enabled = paymentRecords.Count() > 0;
                    find.Enabled = paymentRecords.Count() > 0;
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Некорректный данные для записи в xml-файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Некорректный путь к xml-файлу",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так: " + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
		/// Добавление записи в файл xml
		/// </summary>
		/// <param name="filePathInput">Путь к файлу</param>
		/// <param name="record">Запись</param>
        public void addRecordToXml(string filePathInput, PaymentRecord record)
        {
            if (filePathInput == null || record == null)
                throw new ArgumentNullException();

            XDocument document;

            try
            {
                document = XDocument.Load(filePathInput);
            }
            catch
            {
                throw new ArgumentException();
            }

            var newElement = new XElement("record",
                      new XElement("houseNumber", record.houseNumber),
                      new XElement("apartNumber", record.apartNumber),
                      new XElement("lastname", record.lastname),
                      new XElement("paymentType", record.paymentType),
                      new XElement("paymentSum", record.paymentSum),
                      new XElement("paymentDate", record.paymentDate),
                      new XElement("pennyPercent", record.pennyPercent),
                      new XElement("paymentDaysLeft", record.paymentDaysLeft));

            document.Element("records").Add(newElement);
            document.Save(filePathInput);
        }

        /// <summary>
		/// Нажатие на кнопку удалить
		/// Удаляет выделенные записи
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void remove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    PaymentRecord record;

                    try
                    {
                        record = new PaymentRecord(item.SubItems[0].Text,
                                                   item.SubItems[1].Text,
                                                   item.SubItems[2].Text,
                                                   item.SubItems[3].Text,
                                                   item.SubItems[4].Text,
                                                   item.SubItems[5].Text,
                                                   item.SubItems[6].Text,
                                                   item.SubItems[7].Text);

                        removeRecordFromXML(filePath, record);
                        paymentRecords.RemoveAll(element => element.isEqual(record));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Что-то пошло не так: " + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }
                }

                remove.Enabled = paymentRecords.Count() > 0;
                find.Enabled = paymentRecords.Count() > 0;

                addItemsToListView(paymentRecords);
            }
            else
            {
                MessageBox.Show("Выберите записи для удаления",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// Удаление записи из файла xml
		/// </summary>
		/// <param name="filePathInput">Путь к файлу</param>
		/// <param name="record">Запись</param>
        public void removeRecordFromXML(string filePathInput, PaymentRecord record)
        {
            if (filePathInput == null || record == null)
                throw new ArgumentNullException();

            XDocument document;

            try
            {
                document = XDocument.Load(filePathInput);
            }
            catch
            {
                throw new ArgumentException();
            }

            var findedRecords = document.Element("records").Elements("record")
                            .Where(elem => elem.Element("houseNumber").Value == record.houseNumber &&
                                    elem.Element("apartNumber").Value == record.apartNumber &&
                                    elem.Element("lastname").Value == record.lastname &&
                                    elem.Element("paymentType").Value == record.paymentType &&
                                    elem.Element("paymentSum").Value == record.paymentSum &&
                                    elem.Element("paymentDate").Value == record.paymentDate &&
                                    elem.Element("pennyPercent").Value == record.pennyPercent &&
                                    elem.Element("paymentDaysLeft").Value == record.paymentDaysLeft);

            if (findedRecords == null)
                throw new NullReferenceException();

            findedRecords.Remove();
            document.Save(filePathInput);
        }

        /// <summary>
		/// Нажатие на кнопку поиск по номеру дома
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void searchByHouseNumber_Click(object sender, EventArgs e)
        {
            using (StringSearch form = new StringSearch())
            {
                form.configure(StringSearch.SearchType.HouseNumber);
                form.ShowDialog();

                if (!form.isSaved) return;
                
                var filteredRecords = paymentRecords.Where(elem => elem.houseNumber == form.searchString);

                if (filteredRecords.Count() > 0)
                {
                    addItemsToListView(filteredRecords.ToList());
                    cancelSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ничего не найдено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                
            }
        }

        /// <summary>
		/// Нажатие на кнопку поиск по фамилии владельца
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void searchByLastname_Click(object sender, EventArgs e)
        {
            using (StringSearch form = new StringSearch())
            {
                form.configure(StringSearch.SearchType.Lastname);
                form.ShowDialog();

                if (!form.isSaved) return;

                var filteredRecords = paymentRecords.Where(elem => elem.lastname == form.searchString);

                if (filteredRecords.Count() > 0)
                {
                    addItemsToListView(filteredRecords.ToList());
                    cancelSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ничего не найдено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
		/// Нажатие на кнопку поиск по типу платежа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void searchByPaymentType_Click(object sender, EventArgs e)
        {
            using (TypeSearch form = new TypeSearch())
            {
                form.ShowDialog();

                if (!form.isSaved) return;

                var filteredRecords = paymentRecords.Where(elem => elem.paymentType == form.paymentType);

                if (filteredRecords.Count() > 0)
                {
                    addItemsToListView(filteredRecords.ToList());
                    cancelSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ничего не найдено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
		/// Поиск по дате платежа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void searchByPaymentDate_Click(object sender, EventArgs e)
        {
            using (DateSearch form = new DateSearch())
            {
                form.ShowDialog();

                if (!form.isSaved) return;

                var filteredRecords = paymentRecords.Where(elem => elem.paymentDate == form.paymentDate);

                if (filteredRecords.Count() > 0)
                {
                    addItemsToListView(filteredRecords.ToList());
                    cancelSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ничего не найдено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
		/// Нажатие на кнопку поиск по номеру квартиры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void searchByApertNumber_Click(object sender, EventArgs e)
        {
            using (StringSearch form = new StringSearch())
            {
                form.configure(StringSearch.SearchType.ApartNumber);
                form.ShowDialog();

                if (!form.isSaved) return;

                var filteredRecords = paymentRecords.Where(elem => elem.apartNumber == form.searchString);

                if (filteredRecords.Count() > 0)
                {
                    addItemsToListView(filteredRecords.ToList());
                    cancelSearch.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ничего не найдено",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
		/// Сброс поиска
		/// Вывод всех записей
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void cancelSearch_Click(object sender, EventArgs e)
        {
            cancelSearch.Enabled = false;
            addItemsToListView(paymentRecords);
        }
    }
}
