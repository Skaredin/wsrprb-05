
namespace wsrprb_05
{
    partial class Agentes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agentes));
            this.label1 = new System.Windows.Forms.Label();
            this._wsrprb_05DataSet = new wsrprb_05._wsrprb_05DataSet();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new wsrprb_05._wsrprb_05DataSetTableAdapters.AgentTableAdapter();
            this.tableAdapterManager = new wsrprb_05._wsrprb_05DataSetTableAdapters.TableAdapterManager();
            this.agentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Redaktirovanie = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Label();
            this.SortirovkaName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SortirovkaPrioritet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FiltraciaTipAgent = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._wsrprb_05DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).BeginInit();
            this.agentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица агенты";
            // 
            // _wsrprb_05DataSet
            // 
            this._wsrprb_05DataSet.DataSetName = "_wsrprb_05DataSet";
            this._wsrprb_05DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this._wsrprb_05DataSet;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentTableAdapter = this.agentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CexTableAdapter = null;
            this.tableAdapterManager.GorodTableAdapter = null;
            this.tableAdapterManager.OblastTableAdapter = null;
            this.tableAdapterManager.ProdagaProdukciiTableAdapter = null;
            this.tableAdapterManager.ProdukciaTableAdapter = null;
            this.tableAdapterManager.Tip_AgentaTableAdapter = null;
            this.tableAdapterManager.Tip_produkciiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = wsrprb_05._wsrprb_05DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agentBindingNavigator
            // 
            this.agentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agentBindingNavigator.BindingSource = this.agentBindingSource;
            this.agentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agentBindingNavigatorSaveItem});
            this.agentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agentBindingNavigator.Name = "agentBindingNavigator";
            this.agentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agentBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.agentBindingNavigator.TabIndex = 3;
            this.agentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agentBindingNavigatorSaveItem
            // 
            this.agentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agentBindingNavigatorSaveItem.Image")));
            this.agentBindingNavigatorSaveItem.Name = "agentBindingNavigatorSaveItem";
            this.agentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.agentBindingNavigatorSaveItem.Click += new System.EventHandler(this.agentBindingNavigatorSaveItem_Click);
            // 
            // agentDataGridView
            // 
            this.agentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agentDataGridView.AutoGenerateColumns = false;
            this.agentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.agentDataGridView.DataSource = this.agentBindingSource;
            this.agentDataGridView.Location = new System.Drawing.Point(12, 191);
            this.agentDataGridView.Name = "agentDataGridView";
            this.agentDataGridView.Size = new System.Drawing.Size(776, 247);
            this.agentDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_INNAgenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KPP";
            this.dataGridViewTextBoxColumn2.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tip_agenta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип агента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Naimenovanie_agenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование агента";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Indeks";
            this.dataGridViewTextBoxColumn7.HeaderText = "Индекс";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Oblast";
            this.dataGridViewTextBoxColumn8.HeaderText = "Область";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Gorod";
            this.dataGridViewTextBoxColumn9.HeaderText = "Город";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ylica";
            this.dataGridViewTextBoxColumn10.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Dom";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Ima";
            this.dataGridViewTextBoxColumn12.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Otcesatvo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Familia";
            this.dataGridViewTextBoxColumn14.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Prioritet";
            this.dataGridViewTextBoxColumn15.HeaderText = "Приоритет";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Logo";
            this.dataGridViewTextBoxColumn16.HeaderText = "Картинка";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Redaktirovanie
            // 
            this.Redaktirovanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Redaktirovanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Redaktirovanie.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Redaktirovanie.Location = new System.Drawing.Point(516, 150);
            this.Redaktirovanie.Name = "Redaktirovanie";
            this.Redaktirovanie.Size = new System.Drawing.Size(133, 35);
            this.Redaktirovanie.TabIndex = 4;
            this.Redaktirovanie.Text = "Редактирование";
            this.Redaktirovanie.UseVisualStyleBackColor = false;
            this.Redaktirovanie.Click += new System.EventHandler(this.Redaktirovanie_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Add.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Add.Location = new System.Drawing.Point(655, 150);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 35);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавление";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Nazad
            // 
            this.Nazad.AutoSize = true;
            this.Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Nazad.Location = new System.Drawing.Point(9, 37);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(25, 13);
            this.Nazad.TabIndex = 115;
            this.Nazad.Text = "<----";
            // 
            // SortirovkaName
            // 
            this.SortirovkaName.FormattingEnabled = true;
            this.SortirovkaName.Items.AddRange(new object[] {
            "Всё",
            "От а до я",
            "От я до а"});
            this.SortirovkaName.Location = new System.Drawing.Point(146, 82);
            this.SortirovkaName.Name = "SortirovkaName";
            this.SortirovkaName.Size = new System.Drawing.Size(121, 21);
            this.SortirovkaName.TabIndex = 116;
            this.SortirovkaName.Text = "Всё";
            this.SortirovkaName.SelectedIndexChanged += new System.EventHandler(this.SortirovkaName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Сортиров агентьов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "Сортировка приоритета";
            // 
            // SortirovkaPrioritet
            // 
            this.SortirovkaPrioritet.FormattingEnabled = true;
            this.SortirovkaPrioritet.Items.AddRange(new object[] {
            "Всё",
            "От а до я",
            "От я до а"});
            this.SortirovkaPrioritet.Location = new System.Drawing.Point(146, 109);
            this.SortirovkaPrioritet.Name = "SortirovkaPrioritet";
            this.SortirovkaPrioritet.Size = new System.Drawing.Size(121, 21);
            this.SortirovkaPrioritet.TabIndex = 118;
            this.SortirovkaPrioritet.Text = "Всё";
            this.SortirovkaPrioritet.SelectedIndexChanged += new System.EventHandler(this.SortirovkaPrioritet_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Фильтрация по типу агента";
            // 
            // FiltraciaTipAgent
            // 
            this.FiltraciaTipAgent.FormattingEnabled = true;
            this.FiltraciaTipAgent.Items.AddRange(new object[] {
            "Все",
            "МФО",
            "ПАО",
            "ООО",
            "ЗАО",
            "ОАО",
            "МКК"});
            this.FiltraciaTipAgent.Location = new System.Drawing.Point(426, 82);
            this.FiltraciaTipAgent.Name = "FiltraciaTipAgent";
            this.FiltraciaTipAgent.Size = new System.Drawing.Size(121, 21);
            this.FiltraciaTipAgent.TabIndex = 120;
            this.FiltraciaTipAgent.Text = "Все";
            this.FiltraciaTipAgent.SelectedIndexChanged += new System.EventHandler(this.FiltraciaTipAgent_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(273, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 13);
            this.label.TabIndex = 123;
            this.label.Text = "Сортировка";
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.Location = new System.Drawing.Point(426, 109);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(121, 20);
            this.filter.TabIndex = 122;
            this.filter.TextChanged += new System.EventHandler(this.filter_TextChanged);
            // 
            // Agentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FiltraciaTipAgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortirovkaPrioritet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortirovkaName);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Redaktirovanie);
            this.Controls.Add(this.agentDataGridView);
            this.Controls.Add(this.agentBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agentes";
            this.Text = "Приятный шелест";
            this.Load += new System.EventHandler(this.Agentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this._wsrprb_05DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).EndInit();
            this.agentBindingNavigator.ResumeLayout(false);
            this.agentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _wsrprb_05DataSet _wsrprb_05DataSet;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private _wsrprb_05DataSetTableAdapters.AgentTableAdapter agentTableAdapter;
        private _wsrprb_05DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView agentDataGridView;
        private System.Windows.Forms.Button Redaktirovanie;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Label Nazad;
        private System.Windows.Forms.ComboBox SortirovkaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SortirovkaPrioritet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FiltraciaTipAgent;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox filter;
    }
}