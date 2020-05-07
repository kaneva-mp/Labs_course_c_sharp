namespace lab_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByHouseNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByLastname = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByPaymentType = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByPaymentDate = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByApertNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.houseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pennyPercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentDaysLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.load,
            this.add,
            this.remove,
            this.find,
            this.cancelSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(225, 38);
            this.load.Text = "Загрузить записи";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(222, 38);
            this.add.Text = "Добавить запись";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(204, 38);
            this.remove.Text = "Удалить запись";
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // find
            // 
            this.find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByHouseNumber,
            this.searchByLastname,
            this.searchByPaymentType,
            this.searchByPaymentDate,
            this.searchByApertNumber});
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(110, 38);
            this.find.Text = "Искать";
            // 
            // searchByHouseNumber
            // 
            this.searchByHouseNumber.Name = "searchByHouseNumber";
            this.searchByHouseNumber.Size = new System.Drawing.Size(359, 44);
            this.searchByHouseNumber.Text = "По номеру дома";
            this.searchByHouseNumber.Click += new System.EventHandler(this.searchByHouseNumber_Click);
            // 
            // searchByLastname
            // 
            this.searchByLastname.Name = "searchByLastname";
            this.searchByLastname.Size = new System.Drawing.Size(359, 44);
            this.searchByLastname.Text = "По владельцу";
            this.searchByLastname.Click += new System.EventHandler(this.searchByLastname_Click);
            // 
            // searchByPaymentType
            // 
            this.searchByPaymentType.Name = "searchByPaymentType";
            this.searchByPaymentType.Size = new System.Drawing.Size(359, 44);
            this.searchByPaymentType.Text = "По виду платежа";
            this.searchByPaymentType.Click += new System.EventHandler(this.searchByPaymentType_Click);
            // 
            // searchByPaymentDate
            // 
            this.searchByPaymentDate.Name = "searchByPaymentDate";
            this.searchByPaymentDate.Size = new System.Drawing.Size(359, 44);
            this.searchByPaymentDate.Text = "По дате платежа";
            this.searchByPaymentDate.Click += new System.EventHandler(this.searchByPaymentDate_Click);
            // 
            // searchByApertNumber
            // 
            this.searchByApertNumber.Name = "searchByApertNumber";
            this.searchByApertNumber.Size = new System.Drawing.Size(359, 44);
            this.searchByApertNumber.Text = "По квартире";
            this.searchByApertNumber.Click += new System.EventHandler(this.searchByApertNumber_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.houseNumber,
            this.apartNumber,
            this.lastname,
            this.paymentType,
            this.paymentDate,
            this.paymentSum,
            this.pennyPercent,
            this.paymentDaysLeft});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1080, 307);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // houseNumber
            // 
            this.houseNumber.Text = "Номер дома";
            this.houseNumber.Width = 312;
            // 
            // apartNumber
            // 
            this.apartNumber.Text = "Номер квартиры";
            this.apartNumber.Width = 282;
            // 
            // lastname
            // 
            this.lastname.Text = "Фамилия владельца";
            this.lastname.Width = 218;
            // 
            // paymentType
            // 
            this.paymentType.Text = "Вид платежа";
            this.paymentType.Width = 236;
            // 
            // paymentDate
            // 
            this.paymentDate.Text = "Дата платежа";
            this.paymentDate.Width = 252;
            // 
            // paymentSum
            // 
            this.paymentSum.Text = "Сумма платежа";
            this.paymentSum.Width = 186;
            // 
            // pennyPercent
            // 
            this.pennyPercent.Text = "Процент пенни";
            this.pennyPercent.Width = 168;
            // 
            // paymentDaysLeft
            // 
            this.paymentDaysLeft.Text = "Дней просрочено";
            this.paymentDaysLeft.Width = 160;
            // 
            // cancelSearch
            // 
            this.cancelSearch.Name = "cancelSearch";
            this.cancelSearch.Size = new System.Drawing.Size(211, 38);
            this.cancelSearch.Text = "Сбросить поиск";
            this.cancelSearch.Click += new System.EventHandler(this.cancelSearch_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1080, 349);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem searchByHouseNumber;
        private System.Windows.Forms.ToolStripMenuItem searchByLastname;
        private System.Windows.Forms.ToolStripMenuItem searchByPaymentType;
        private System.Windows.Forms.ToolStripMenuItem searchByPaymentDate;
        private System.Windows.Forms.ToolStripMenuItem searchByApertNumber;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader houseNumber;
        private System.Windows.Forms.ColumnHeader apartNumber;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader paymentType;
        private System.Windows.Forms.ColumnHeader paymentDate;
        private System.Windows.Forms.ColumnHeader paymentSum;
        private System.Windows.Forms.ColumnHeader pennyPercent;
        private System.Windows.Forms.ColumnHeader paymentDaysLeft;
        private System.Windows.Forms.ToolStripMenuItem cancelSearch;
    }
}

