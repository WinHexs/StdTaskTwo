using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StdTaskTwo
{
    public partial class MainForm : Form
    {
        private const int NumberOfParticipantsInRace = 5; // количесвто одновременно стартующих участников в соревновании
        private const string AllowedChars = "АаБбВвГгДдЕеЁёЖжЗзИиЙиКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя- "; // разрешённые символы в фамилии

        private readonly DateTime DefaultStartTime = new DateTime(1, 1, 1, 10, 0, 0); // Время старта
        private readonly DateTime DefaultEndTime = new DateTime(1, 1, 1, 13, 0, 0);   // Время финиша
        private readonly DateTime IncreaseTime = new DateTime(1, 1, 1, 0, 5, 0);      // Значение увеличения времени

        /* Структура заголовка */
        private struct ColumnData
        {
            public int Id { get; set; }                              // индекс столбца
            public bool Frozen { get; set; }                         // зафиксирован
            public string HeaderText { get; set; }                   // отображаемое имя заголовка    
            public string Name { get; set; }                         // имя заголовка
            public bool ReadOnly { get; set; }                       // может ли пользователь изменять поля столбца
            public DataGridViewColumnSortMode SortMode { get; set; } // режим сортировка столбца
            /* Конструктор */
            public ColumnData(int id, bool frozen, string headerText, string name, bool readOnly, DataGridViewColumnSortMode sortMode)
            {
                Id = id;
                Frozen = frozen;
                HeaderText = headerText;
                Name = name;
                ReadOnly = readOnly;
                SortMode = sortMode;
            }
        }
        /* Структура соревнования */
        private struct RaceData
        {
            public int Id { get; set; }      // индекс столбца
            public int Count { get; set; }   // количество участников
            public DateTime Date {get; set;} // дата соревнования
            /* Конструктор */
            public RaceData(int id, int count, DateTime date)
            {
                Id = id;
                Count = count;
                Date = date;
            }
        }
        /* Словарь отчёта */
        private Dictionary<string, ColumnData> reportPrimaryColumns = new Dictionary<string, ColumnData>
        {
            {"NameColumn",      new ColumnData(
                                    0,
                                    true,
                                    "Фамилия",
                                    "NameColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"DateColumn",      new ColumnData(
                                    1,
                                    true,
                                    "Дата Соревнования",
                                    "DateColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"StartTimeColumn", new ColumnData(
                                    2,
                                    true,
                                    "Время старта",
                                    "StartTimeColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"EndTimeColumn",   new ColumnData(
                                    3,
                                    true,
                                    "Время финиша",
                                    "EndTimeColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"DistanceColumn",  new ColumnData(
                                    4,
                                    true,
                                    "Дистанция",
                                    "DistanceColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"RaceColumn",      new ColumnData(
                                    5,
                                    true,
                                    "Соревнование",
                                    "RaceColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"DistTimeColumn",  new ColumnData(
                                    6,
                                    true,
                                    "Время прохождения дистанции",
                                    "DistTimeColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"AverageTimeColumn",  new ColumnData(
                                    7,
                                    true,
                                    "Среднее время",
                                    "AverageTimeColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )}
        };
        /* Словарь отчёта с результатами */
        private Dictionary<string, ColumnData> reportResultColumns = new Dictionary<string, ColumnData>
        {
            {"NameColumn",      new ColumnData(
                                    0,
                                    true,
                                    "Фамилия",
                                    "NameColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"RaceAColumn",      new ColumnData(
                                    1,
                                    true,
                                    "Соревнование А",
                                    "RaceAColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"RaceBColumn",      new ColumnData(
                                    2,
                                    true,
                                    "Соревнование B",
                                    "RaceBColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"RaceCColumn",      new ColumnData(
                                    3,
                                    true,
                                    "Соревнование C",
                                    "RaceCColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )},
            {"AverageTimeColumn", new ColumnData(
                                    4,
                                    true,
                                    "Среднее время",
                                    "AverageTimeColumn",
                                    true,
                                    DataGridViewColumnSortMode.NotSortable
            )}
        };
        /* Словарь соревнований */
        private Dictionary<object, RaceData> raceValues = new Dictionary<object, RaceData>
        {
            {"Марафон A", new RaceData(
                             0,
                             0,
                             new DateTime(2019, 4, 20)
             )},
            {"Марафон B", new RaceData(
                             1,
                             0,
                             new DateTime(2019, 7, 14)
             )},
            {"Марафон C", new RaceData(
                             2,
                             0,
                             new DateTime(2019, 9, 28)
             )}
        };

        private List<object[]> primaryContent; // список для контента
        private bool isDone = false; // нажата кнопка начать

        /* Изменение дня соревнования */
        private void SetDays(int value)
        {
            dayNumericUpDown.Maximum = value;
        }
        /* Измение часов начала соревнования */
        private void SetStartHours(decimal value)
        {
            if (value > 23)
                value = 0;

            hoursStartTimeNumericUpDown.Maximum = value;
            hoursStartTimeNumericUpDown.Value = value;
            hoursStartTimeNumericUpDown.Minimum = value;
        }
        /* Измение минут начала соревнования */
        private void SetStartMinutes(decimal value)
        {
            minutesStartTimeNumericUpDown.Maximum = value;
            minutesStartTimeNumericUpDown.Value = value;
            minutesStartTimeNumericUpDown.Minimum = value; 
        }
        /* Измение секунд начала соревнования */
        private void SetStartSeconds(decimal value)
        {
            secondsStartTimeNumericUpDown.Maximum = value;
            secondsStartTimeNumericUpDown.Value = value;
            secondsStartTimeNumericUpDown.Minimum = value;
        }
        /* Перерасчёт количества участников в соревнованиях */
        private void RecalculateRacesCount()
        {
            var Counts = new int[raceValues.Count];
            var handlerDictinary = new Dictionary<object, RaceData>(raceValues);

            for (int i = 0; i < reportDataGridView.RowCount; i++)
            {
                var key = reportDataGridView[reportPrimaryColumns["RaceColumn"].Id, i].Value;

                if (raceValues.ContainsKey(key))
                    Counts[raceValues[key].Id]++;
            }
           
            foreach (var race in handlerDictinary) {
                var value = new RaceData(race.Value.Id, Counts[race.Value.Id], race.Value.Date);
                raceValues[race.Key] = value;
            }
        }
        /* Отрисовка заголовков */
        private void PrintHeaders(Dictionary<string, ColumnData> headers)
        {
            reportDataGridView.Rows.Clear();
            reportDataGridView.Columns.Clear();

            foreach (var header in headers.Values)
            {
                var column = new DataGridViewTextBoxColumn();
                column.Frozen = header.Frozen;
                column.HeaderText = header.HeaderText;
                column.Name = header.Name;
                column.ReadOnly = header.ReadOnly;
                column.SortMode = header.SortMode;

                reportDataGridView.Columns.Add(column);
            }
        }
        /* Добавление нового участника */
        private void AddData(string name, DateTime startTime, DateTime endTime, int distance, object race, DateTime averageTime)
        {
            var values = new object[] { name, startTime.ToLongDateString(), startTime.ToLongTimeString(), endTime.ToLongTimeString(), distance, race, endTime.Subtract(startTime), averageTime.ToLongTimeString() };
            reportDataGridView.Rows.Add(values);
        }
        /* Удаление выделенных строк */
        private void RemoveSelected()
        {
            if (isDone)
                return;

            raceComboBox.SelectedIndex = -1;

            foreach (DataGridViewRow row in reportDataGridView.SelectedRows) {
                var race = reportDataGridView[reportPrimaryColumns["RaceColumn"].Id, row.Index].Value;
                var value = raceValues[race];
                value.Count--;
                raceValues[race] = value;
                reportDataGridView.Rows.RemoveAt(row.Index);
            }

            /* Расчёт среднего времени */
            var averageTime = new DateTime();
            var distTime = GetValues(reportPrimaryColumns["NameColumn"].Id, nameTextBox.Text, reportPrimaryColumns["DistTimeColumn"].Id);
            
            for (int i = 0; i < distTime.Count; i++)
            {
                var tempTime = ParseDateTime(distTime[i]);
                averageTime = averageTime.AddHours(tempTime.Hour).AddMinutes(tempTime.Minute).AddSeconds(tempTime.Second);
            }

            var averageSeconds = GetAverageSeconds(averageTime, distTime.Count);
            averageTime = new DateTime() + averageSeconds;

            SetValues(reportPrimaryColumns["NameColumn"].Id, nameTextBox.Text, reportPrimaryColumns["AverageTimeColumn"].Id, averageTime.ToLongTimeString());

        }
        /* Получение даты */
        private DateTime GetDateTime(object day, object mounth, object year, object hours, object minutes, object seconds)
        {
            int d = Convert.ToInt32(day);
            int mm = Convert.ToInt32(mounth) + 1;
            int y = Convert.ToInt32(year);

            int h = Convert.ToInt32(hours);
            int m = Convert.ToInt32(minutes);
            int s = Convert.ToInt32(seconds);

            return new DateTime(y, mm, d, h, m, s);
        }
        /* Получение даты из строки */
        private DateTime ParseDateTime(object dateTime)
        {
            return DateTime.Parse(Convert.ToString(dateTime));
        }
        /* Перевод времени в секунды */
        private TimeSpan GetAverageSeconds(DateTime dateTime, int count)
        {
            if (count == 0)
                count = 1;

            return TimeSpan.FromSeconds((dateTime.Ticks / TimeSpan.TicksPerSecond) / count);
        }
        /* Существует ли значение */
        private bool Exists(int sourceIndex, string sourceValue, int destinationIndex, string destinationValue)
        {
            for (int row = 0; row < reportDataGridView.Rows.Count; row++)
            {
                if (string.Equals(reportDataGridView[sourceIndex, row].Value, sourceValue))
                {
                    if (string.Equals(reportDataGridView[destinationIndex, row].Value, destinationValue))
                        return true;
                }
            }

            return false;
        }
        /* Количество записей */
        private int CountOfEntries(int sourceIndex, string sourceValue)
        {
            var count = 0;

            for (int row = 0; row < reportDataGridView.Rows.Count; row++)
            {
                if (string.Equals(reportDataGridView[sourceIndex, row].Value, sourceValue))
                    count++;
            }

            return count;
        }
        /* Возвращает список значений */
        private List<object> GetValues(int sourceIndex, string sourceValue, int destinationIndex)
        {
            var handlerList = new List<object>();

            for (int row = 0; row < reportDataGridView.Rows.Count; row++)
            {
                if (string.Equals(reportDataGridView[sourceIndex, row].Value, sourceValue))
                    handlerList.Add(reportDataGridView[destinationIndex, row].Value);
            }

            return handlerList;
        }
        /* Заменяет значения */
        private void SetValues(int sourceIndex, string sourceValue, int destinationIndex, string destinationValue)
        {
            for (int row = 0; row < reportDataGridView.Rows.Count; row++)
            {
                if (string.Equals(reportDataGridView[sourceIndex, row].Value, sourceValue))
                    reportDataGridView[destinationIndex, row].Value = destinationValue;
            }
        }
        /* Шейкерная сортировка */
        private List<object[]> Sort(List<object[]> list, int sourceIndex)
        {
            var left = 0;
            var right = list.Count - 1;
            object[] temp;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (GetAverageSeconds(ParseDateTime(list[i][sourceIndex]), 3) < GetAverageSeconds(ParseDateTime(list[i + 1][sourceIndex]), 3))
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if (GetAverageSeconds(ParseDateTime(list[i - 1][sourceIndex]), 3) < GetAverageSeconds(ParseDateTime(list[i][sourceIndex]), 3))
                    {
                        temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                    }
                }

                left++;
            }

            return list;
        }
        /* Перевод DataGridView в List */
        private List<object[]> ReportToList()
        {
            List<object[]> result = new List<object[]>();

            for (int i = 0; i < reportDataGridView.Rows.Count; i++)
            {
                object[] temp = new object[reportDataGridView.Columns.Count];
                for (int j = 0; j < reportDataGridView.Columns.Count; j++)
                    temp[j] = reportDataGridView[j, i].Value;
                result.Add(temp);
            }

            return result;
        }
        /* Чтение из файла */ 
        private void Open(string path)
        {
            using (StreamReader sReader = new StreamReader(path))
            {
                var separator = '\t';
                while (!sReader.EndOfStream)
                {
                    var values = sReader.ReadLine();
                    var split = values.Split(separator);
                    reportDataGridView.Rows.Add(split);
                }
            }
        }
        /* Сохранение в файл */
        private void Save(string path)
        {       
            using (StreamWriter sWriter = new StreamWriter(path))
            {
                for (int i = 0; i < reportDataGridView.RowCount; i++)
                {
                    for (int j = 0; j < reportDataGridView.ColumnCount; j++)
                    {
                        sWriter.Write(reportDataGridView[j, i].Value + "\t");
                    }
                    sWriter.Write("\r\n");
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            /* Каталог по умолчанию */
            openFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            /* Установка времени старта соревнования */
            SetStartHours(DefaultStartTime.Hour);
            SetStartMinutes(DefaultStartTime.Minute);
            SetStartSeconds(DefaultStartTime.Second);
            /* Добавление элементов в raceComboBox */
            foreach (string race in raceValues.Keys) {
                raceComboBox.Items.Add(race);
            }
            /* Вывод заголовков */
            PrintHeaders(reportPrimaryColumns);
        }
        /* При нажатии на кнопку Добавить */
        private void addButton_Click(object sender, EventArgs e)
        {
            if (isDone)
                return;

            nameTextBox.Text = nameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show(this, "Необходимо ввести фамилию участника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < nameTextBox.Text.Length; i++)
            {
                if (!AllowedChars.Contains(nameTextBox.Text[i]))
                {
                    MessageBox.Show(this, "Запрещённый символ в фамилии участника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (monthComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Необходимо указать месяц соревнования!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (raceComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Необходимо выбрать соревнование!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var raceIndex = raceComboBox.SelectedIndex;

            if (Exists(reportPrimaryColumns["NameColumn"].Id, nameTextBox.Text, reportPrimaryColumns["RaceColumn"].Id, raceComboBox.Items[raceIndex].ToString()))
            {
                MessageBox.Show(this, $"{nameTextBox.Text} уже участвовал в '{raceComboBox.Items[raceIndex]}'!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var startTime = GetDateTime(dayNumericUpDown.Value, monthComboBox.SelectedIndex, yearNumericUpDown.Value, hoursStartTimeNumericUpDown.Value, minutesStartTimeNumericUpDown.Value, secondsStartTimeNumericUpDown.Value);
            var endTime = GetDateTime(dayNumericUpDown.Value, monthComboBox.SelectedIndex, yearNumericUpDown.Value, hoursEndTimeNumericUpDown.Value, minutesEndTimeNumericUpDown.Value, secondsEndTimeNumericUpDown.Value);

            if (endTime < startTime)
            {
                MessageBox.Show(this, "Время финиша не может быть меньше времени старта!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (endTime.Subtract(startTime) <= TimeSpan.FromHours(2))
            {
                MessageBox.Show(this, "Невозможно пробежать марафон менее, чем за 2 часа!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /* Расчёт среднего времени */
            var averageTime = new DateTime();
            var distTime = GetValues(reportPrimaryColumns["NameColumn"].Id, nameTextBox.Text, reportPrimaryColumns["DistTimeColumn"].Id);
            distTime.Add(endTime.Subtract(startTime));

            for (int i = 0; i < distTime.Count; i++) {
                var tempTime = ParseDateTime(distTime[i]);
                averageTime = averageTime.AddHours(tempTime.Hour).AddMinutes(tempTime.Minute).AddSeconds(tempTime.Second);
            }

            var averageSeconds = GetAverageSeconds(averageTime, distTime.Count);
            averageTime = new DateTime() + averageSeconds;

            SetValues(reportPrimaryColumns["NameColumn"].Id, nameTextBox.Text, reportPrimaryColumns["AverageTimeColumn"].Id, averageTime.ToLongTimeString());
            AddData(nameTextBox.Text, startTime, endTime, 42, raceComboBox.Items[raceIndex].ToString(), averageTime);

            var value = raceValues[raceComboBox.Items[raceIndex]];
            value.Count++;
            raceValues[raceComboBox.Items[raceIndex]] = value;

            raceComboBox.SelectedIndex = -1;
        }
        /* Очистка компонентов добавления участника */
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = string.Empty;
            monthComboBox.SelectedIndex = -1;
            SetStartHours(DefaultStartTime.Hour);
            SetStartMinutes(DefaultStartTime.Minute);
            SetStartSeconds(DefaultStartTime.Second);
            hoursEndTimeNumericUpDown.Value = DefaultEndTime.Hour;
            minutesEndTimeNumericUpDown.Value = DefaultEndTime.Minute;
            secondsEndTimeNumericUpDown.Value = DefaultEndTime.Second;
            raceComboBox.SelectedIndex = -1;
        }
        /* Не смотрите сюда */
        private void actionButton_Click(object sender, EventArgs e)
        {
            if (isDone)
            {
                isDone = false;
                PrintHeaders(reportPrimaryColumns);
                for (int i = 0; i < primaryContent.Count; i++) {
                    reportDataGridView.Rows.Add(primaryContent[i]);
                }
                //RecalculateRacesCount();
                actionButton.Text = "Результаты";


            }
            else
            {
                isDone = true;
                primaryContent = ReportToList(); // сохранение содержимого таблицы
                /* Список участников */
                /* Сигнатура массива */
                /* int[] { 1, -1, -1, -1 } */
                /* { количество повторений имени, номер строки, номер строки, номер строки } */
                Dictionary<object, int[]> nameValues = new Dictionary<object, int[]>();
                /* Щито я тут написал, как это работает O_o ? */
                for (int row = 0; row < reportDataGridView.Rows.Count; row++)
                {
                    var nameTemp = reportDataGridView[reportPrimaryColumns["NameColumn"].Id, row].Value;
                    /* участник отсутсвует в словаре */
                    if (!nameValues.ContainsKey(nameTemp))
                    {
                        var values = new int[] { 1, row, -1, -1 };
                        nameValues.Add(nameTemp, values);
                    }
                    else
                    {
                        var values = nameValues[nameTemp]; // получаем массив
                        values[0]++; // +1 к количеству повторений
                        int index = values[0];
                        values[index] = row; // запоминаем номер строки
                        nameValues[nameTemp] = values; // записываем обратно в словарь
                    }
                }

                var handlerList = new List<object[]>();

                foreach (KeyValuePair<object, int[]> name in nameValues)
                {
                    /* Если участвовал в 3 соревнованиях */
                    if (name.Value[0] > 2)
                    {
                        var tempValue = new object[5]; // фамилия, время забега А, время забега В, время забега С, среднее время
                        var averageTime = new DateTime();
                        var isDec = true;

                        tempValue[0] = name.Key;
                        /* Cортировка марафонов */
                        for (int i = 1; i < name.Value.Length; i++)
                        {
                            switch (raceValues[reportDataGridView[reportPrimaryColumns["RaceColumn"].Id, name.Value[i]].Value].Id)
                            {
                                case 0:
                                    tempValue[1] = reportDataGridView[reportPrimaryColumns["DistTimeColumn"].Id, name.Value[i]].Value;
                                    break;

                                case 1:
                                    tempValue[2] = reportDataGridView[reportPrimaryColumns["DistTimeColumn"].Id, name.Value[i]].Value;
                                    break;

                                case 2:
                                    tempValue[3] = reportDataGridView[reportPrimaryColumns["DistTimeColumn"].Id, name.Value[i]].Value;
                                    break;
                            }

                            var tempTime = ParseDateTime(reportDataGridView[reportPrimaryColumns["DistTimeColumn"].Id, name.Value[i]].Value);
                            averageTime = averageTime.AddHours(tempTime.Hour).AddMinutes(tempTime.Minute).AddSeconds(tempTime.Second);
                        }
                        /* Поиск участников не ухудшивших результаты */
                        for (int i = 2; i < name.Value.Length; i++)
                        {
                            if (ParseDateTime(tempValue[i]) >= ParseDateTime(tempValue[i - 1]))
                                isDec = false;
                        }

                        if (isDec)
                        {
                            var averageSeconds = TimeSpan.FromSeconds((averageTime.Ticks / TimeSpan.TicksPerSecond) / 3);
                            averageTime = new DateTime() + averageSeconds;
                            tempValue[4] = averageTime.ToLongTimeString();

                            handlerList.Add(tempValue);
                        }
                    }
                }

                PrintHeaders(reportResultColumns);
                for (int i = 0; i < handlerList.Count; i++) {
                    reportDataGridView.Rows.Add(handlerList[i]);
                }

                actionButton.Text = "Сброс";
            }
        }
        /* Экспорт */
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDone)
                return;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save(saveFileDialog.FileName);
            }
        }
        /* Импорт */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDone)
                return;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PrintHeaders(reportPrimaryColumns);
                Open(openFileDialog.FileName);
                RecalculateRacesCount();
            }
        }
        /* Удаление */
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }
        /* Сортировка */
        private void raceAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDone)
                return;

            var handlerList = Sort(ReportToList(), reportResultColumns["RaceAColumn"].Id);

            PrintHeaders(reportResultColumns);
            for (int i = 0; i < handlerList.Count; i++)
            {
                reportDataGridView.Rows.Add(handlerList[i]);
            }
        }
        private void raceBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDone)
                return;

            var handlerList = Sort(ReportToList(), reportResultColumns["RaceBColumn"].Id);

            PrintHeaders(reportResultColumns);
            for (int i = 0; i < handlerList.Count; i++)
            {
                reportDataGridView.Rows.Add(handlerList[i]);
            }
        }
        private void raceCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDone)
                return;

            var handlerList = Sort(ReportToList(), reportResultColumns["RaceCColumn"].Id);

            PrintHeaders(reportResultColumns);
            for (int i = 0; i < handlerList.Count; i++)
            {
                reportDataGridView.Rows.Add(handlerList[i]);
            }
        }
        private void averageTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDone)
                return;

            var handlerList = Sort(ReportToList(), reportResultColumns["AverageTimeColumn"].Id);

            PrintHeaders(reportResultColumns);
            for (int i = 0; i < handlerList.Count; i++)
            {
                reportDataGridView.Rows.Add(handlerList[i]);
            }
        }
        /* При изменении соревнования */
        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var raceIndex = raceComboBox.SelectedIndex;

            if (raceIndex < 0)
            {
                SetStartHours(DefaultStartTime.Hour);
                SetStartMinutes(DefaultStartTime.Minute);
                return;
            }
            /* Расчёт времени старта */
            var value = raceValues[raceComboBox.Items[raceIndex]];
            var mod = value.Count / NumberOfParticipantsInRace;

            SetStartHours(DefaultStartTime.Hour + IncreaseTime.Minute * mod / 60);
            SetStartMinutes(IncreaseTime.Minute * mod % 60);
            /* Изменение даты забега */
            yearNumericUpDown.Value = value.Date.Year;
            monthComboBox.SelectedIndex = value.Date.Month - 1;
            dayNumericUpDown.Value = value.Date.Day;
        }
        /* При изменении года */
        private void yearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex < 0)
                return;

            SetDays(DateTime.DaysInMonth(Convert.ToInt32(yearNumericUpDown.Value), monthComboBox.SelectedIndex + 1));
        }
        /* При изменении месяца */
        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDays(DateTime.DaysInMonth(Convert.ToInt32(yearNumericUpDown.Value), monthComboBox.SelectedIndex + 1));
        }
        /* В момент отпускания клавиши  */
        private void reportDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveSelected();
        }      
    }
}
