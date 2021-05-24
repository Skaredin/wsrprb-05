
namespace wsrprb_05
{
    partial class Redaktirovanie_agentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redaktirovanie_agentes));
            System.Windows.Forms.Label id_INNAgentaLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label naimenovanie_agentaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label indeksLabel;
            System.Windows.Forms.Label ylicaLabel;
            System.Windows.Forms.Label domLabel;
            System.Windows.Forms.Label imaLabel;
            System.Windows.Forms.Label otcesatvoLabel;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label prioritetLabel;
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label tip_agentaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this._wsrprb_05DataSet = new wsrprb_05._wsrprb_05DataSet();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new wsrprb_05._wsrprb_05DataSetTableAdapters.AgentTableAdapter();
            this.tableAdapterManager = new wsrprb_05._wsrprb_05DataSetTableAdapters.TableAdapterManager();
            this.agentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.agentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_INNAgentaTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.naimenovanie_agentaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.indeksTextBox = new System.Windows.Forms.TextBox();
            this.ylicaTextBox = new System.Windows.Forms.TextBox();
            this.domTextBox = new System.Windows.Forms.TextBox();
            this.imaTextBox = new System.Windows.Forms.TextBox();
            this.otcesatvoTextBox = new System.Windows.Forms.TextBox();
            this.familiaTextBox = new System.Windows.Forms.TextBox();
            this.prioritetTextBox = new System.Windows.Forms.TextBox();
            this.logoComboBox = new System.Windows.Forms.ComboBox();
            this.Deleted = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Rigiht = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.PhotoPB = new System.Windows.Forms.PictureBox();
            this.tip_agentaComboBox = new System.Windows.Forms.ComboBox();
            id_INNAgentaLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            naimenovanie_agentaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            indeksLabel = new System.Windows.Forms.Label();
            ylicaLabel = new System.Windows.Forms.Label();
            domLabel = new System.Windows.Forms.Label();
            imaLabel = new System.Windows.Forms.Label();
            otcesatvoLabel = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            prioritetLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            tip_agentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._wsrprb_05DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).BeginInit();
            this.agentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Редактирование";
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
            this.agentBindingNavigator.Size = new System.Drawing.Size(783, 25);
            this.agentBindingNavigator.TabIndex = 4;
            this.agentBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // agentBindingNavigatorSaveItem
            // 
            this.agentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agentBindingNavigatorSaveItem.Image")));
            this.agentBindingNavigatorSaveItem.Name = "agentBindingNavigatorSaveItem";
            this.agentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agentBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.agentBindingNavigatorSaveItem.Click += new System.EventHandler(this.agentBindingNavigatorSaveItem_Click_1);
            // 
            // id_INNAgentaLabel
            // 
            id_INNAgentaLabel.AutoSize = true;
            id_INNAgentaLabel.Location = new System.Drawing.Point(263, 107);
            id_INNAgentaLabel.Name = "id_INNAgentaLabel";
            id_INNAgentaLabel.Size = new System.Drawing.Size(34, 13);
            id_INNAgentaLabel.TabIndex = 4;
            id_INNAgentaLabel.Text = "ИНН:";
            // 
            // id_INNAgentaTextBox
            // 
            this.id_INNAgentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Id_INNAgenta", true));
            this.id_INNAgentaTextBox.Location = new System.Drawing.Point(383, 104);
            this.id_INNAgentaTextBox.Name = "id_INNAgentaTextBox";
            this.id_INNAgentaTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_INNAgentaTextBox.TabIndex = 5;
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(263, 133);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(33, 13);
            kPPLabel.TabIndex = 6;
            kPPLabel.Text = "КПП:";
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Location = new System.Drawing.Point(383, 130);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(121, 20);
            this.kPPTextBox.TabIndex = 7;
            // 
            // naimenovanie_agentaLabel
            // 
            naimenovanie_agentaLabel.AutoSize = true;
            naimenovanie_agentaLabel.Location = new System.Drawing.Point(263, 185);
            naimenovanie_agentaLabel.Name = "naimenovanie_agentaLabel";
            naimenovanie_agentaLabel.Size = new System.Drawing.Size(114, 13);
            naimenovanie_agentaLabel.TabIndex = 10;
            naimenovanie_agentaLabel.Text = "Naimenovanie agenta:";
            // 
            // naimenovanie_agentaTextBox
            // 
            this.naimenovanie_agentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Naimenovanie_agenta", true));
            this.naimenovanie_agentaTextBox.Location = new System.Drawing.Point(383, 182);
            this.naimenovanie_agentaTextBox.Name = "naimenovanie_agentaTextBox";
            this.naimenovanie_agentaTextBox.Size = new System.Drawing.Size(121, 20);
            this.naimenovanie_agentaTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(133, 186);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(13, 215);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 14;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(133, 212);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonTextBox.TabIndex = 15;
            // 
            // indeksLabel
            // 
            indeksLabel.AutoSize = true;
            indeksLabel.Location = new System.Drawing.Point(263, 211);
            indeksLabel.Name = "indeksLabel";
            indeksLabel.Size = new System.Drawing.Size(48, 13);
            indeksLabel.TabIndex = 16;
            indeksLabel.Text = "Индекс:";
            // 
            // indeksTextBox
            // 
            this.indeksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Indeks", true));
            this.indeksTextBox.Location = new System.Drawing.Point(383, 208);
            this.indeksTextBox.Name = "indeksTextBox";
            this.indeksTextBox.Size = new System.Drawing.Size(121, 20);
            this.indeksTextBox.TabIndex = 17;
            // 
            // ylicaLabel
            // 
            ylicaLabel.AutoSize = true;
            ylicaLabel.Location = new System.Drawing.Point(263, 289);
            ylicaLabel.Name = "ylicaLabel";
            ylicaLabel.Size = new System.Drawing.Size(33, 13);
            ylicaLabel.TabIndex = 22;
            ylicaLabel.Text = "Ylica:";
            // 
            // ylicaTextBox
            // 
            this.ylicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Ylica", true));
            this.ylicaTextBox.Location = new System.Drawing.Point(383, 286);
            this.ylicaTextBox.Name = "ylicaTextBox";
            this.ylicaTextBox.Size = new System.Drawing.Size(121, 20);
            this.ylicaTextBox.TabIndex = 23;
            // 
            // domLabel
            // 
            domLabel.AutoSize = true;
            domLabel.Location = new System.Drawing.Point(263, 315);
            domLabel.Name = "domLabel";
            domLabel.Size = new System.Drawing.Size(32, 13);
            domLabel.TabIndex = 24;
            domLabel.Text = "Dom:";
            // 
            // domTextBox
            // 
            this.domTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Dom", true));
            this.domTextBox.Location = new System.Drawing.Point(383, 312);
            this.domTextBox.Name = "domTextBox";
            this.domTextBox.Size = new System.Drawing.Size(121, 20);
            this.domTextBox.TabIndex = 25;
            // 
            // imaLabel
            // 
            imaLabel.AutoSize = true;
            imaLabel.Location = new System.Drawing.Point(13, 111);
            imaLabel.Name = "imaLabel";
            imaLabel.Size = new System.Drawing.Size(27, 13);
            imaLabel.TabIndex = 26;
            imaLabel.Text = "Ima:";
            // 
            // imaTextBox
            // 
            this.imaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Ima", true));
            this.imaTextBox.Location = new System.Drawing.Point(133, 108);
            this.imaTextBox.Name = "imaTextBox";
            this.imaTextBox.Size = new System.Drawing.Size(121, 20);
            this.imaTextBox.TabIndex = 27;
            // 
            // otcesatvoLabel
            // 
            otcesatvoLabel.AutoSize = true;
            otcesatvoLabel.Location = new System.Drawing.Point(13, 137);
            otcesatvoLabel.Name = "otcesatvoLabel";
            otcesatvoLabel.Size = new System.Drawing.Size(59, 13);
            otcesatvoLabel.TabIndex = 28;
            otcesatvoLabel.Text = "Otcesatvo:";
            // 
            // otcesatvoTextBox
            // 
            this.otcesatvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Otcesatvo", true));
            this.otcesatvoTextBox.Location = new System.Drawing.Point(133, 134);
            this.otcesatvoTextBox.Name = "otcesatvoTextBox";
            this.otcesatvoTextBox.Size = new System.Drawing.Size(121, 20);
            this.otcesatvoTextBox.TabIndex = 29;
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.Location = new System.Drawing.Point(13, 163);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(42, 13);
            familiaLabel.TabIndex = 30;
            familiaLabel.Text = "Familia:";
            // 
            // familiaTextBox
            // 
            this.familiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Familia", true));
            this.familiaTextBox.Location = new System.Drawing.Point(133, 160);
            this.familiaTextBox.Name = "familiaTextBox";
            this.familiaTextBox.Size = new System.Drawing.Size(121, 20);
            this.familiaTextBox.TabIndex = 31;
            // 
            // prioritetLabel
            // 
            prioritetLabel.AutoSize = true;
            prioritetLabel.Location = new System.Drawing.Point(13, 268);
            prioritetLabel.Name = "prioritetLabel";
            prioritetLabel.Size = new System.Drawing.Size(45, 13);
            prioritetLabel.TabIndex = 32;
            prioritetLabel.Text = "Prioritet:";
            // 
            // prioritetTextBox
            // 
            this.prioritetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Prioritet", true));
            this.prioritetTextBox.Location = new System.Drawing.Point(133, 265);
            this.prioritetTextBox.Name = "prioritetTextBox";
            this.prioritetTextBox.Size = new System.Drawing.Size(121, 20);
            this.prioritetTextBox.TabIndex = 33;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(13, 241);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(34, 13);
            logoLabel.TabIndex = 34;
            logoLabel.Text = "Logo:";
            // 
            // logoComboBox
            // 
            this.logoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Logo", true));
            this.logoComboBox.FormattingEnabled = true;
            this.logoComboBox.Items.AddRange(new object[] {
            "agents\\agent_93.png",
            "agents\\agent_116.png",
            "agents\\agent_66.png",
            "agents\\agent_96.png",
            "agents\\agent_58.png",
            "agents\\agent_n",
            "agents\\agent_108.png",
            "agents\\agent_97.png",
            "agents\\agent_100.png",
            "agents\\agent_59.png",
            "agents\\agent_38.png",
            "agents\\agent_45.png",
            "agents\\agent_46.png",
            "agents\\agent_54.png",
            "agents\\agent_78.png",
            "agents\\agent_76.png",
            "agents\\agent_30.png",
            "agents\\agent_92.png",
            "agents\\agent_120.png",
            "agents\\agent_31.png",
            "agents\\agent_44.png",
            "agents\\agent_95.png",
            "agents\\agent_106.png",
            "agents\\agent_37.png",
            "agents\\agent_105.png",
            "agents\\agent_62.png",
            "agents\\agent_74.png",
            "agents\\agent_63.png",
            "agents\\agent_41.png",
            "agents\\agent_90.png",
            "agents\\agent_47.png",
            "agents\\agent_85.png",
            "agents\\agent_86.png",
            "agents\\agent_53.png",
            "agents\\agent_71.png",
            "agents\\agent_77.png",
            "agents\\agent_68.png",
            "agents\\agent_42.png",
            "agents\\agent_23.png",
            "agents\\agent_88.png",
            "agents\\agent_118.png",
            "agents\\agent_69.png",
            "agents\\agent_70.png",
            "agents\\agent_112.png",
            "agents\\agent_27.png",
            "agents\\agent_111.png",
            "agents\\agent_109.png",
            "agents\\agent_39.png",
            "agents\\agent_104.png",
            "agents\\agent_33.png",
            "agents\\agent_21.png",
            "agents\\agent_65.png",
            "agents\\agent_117.png",
            "agents\\agent_57.png",
            "agents\\agent_101.png",
            "agents\\agent_50.png",
            "agents\\agent_80.png",
            "agents\\agent_82.png",
            "agents\\agent_91.png",
            "agents\\agent_61.png",
            "agents\\agent_28.png",
            "agents\\agent_103.png",
            "agents\\agent_94.png",
            "agents\\agent_87.png",
            "agents\\agent_43.png",
            "agents\\agent_25.png",
            "agents\\agent_114.png",
            "agents\\agent_119.png",
            "agents\\agent_67.png",
            "agents\\agent_56.png",
            "agents\\agent_98.png",
            "agents\\agent_40.png",
            "agents\\agent_72.png",
            "agents\\agent_75.png",
            "agents\\agent_99.png",
            "agents\\agent_49.png",
            "agents\\agent_83.png",
            "agents\\agent_79.png",
            "agents\\agent_48.png",
            "agents\\agent_32.png",
            "agents\\agent_60.png",
            "agents\\agent_110.png",
            "agents\\agent_35.png",
            "agents\\agent_64.png",
            "agents\\agent_51.png",
            "agents\\agent_52.png",
            "agents\\agent_81.png",
            "agents\\agent_115.png",
            "agents\\agent_24.png",
            "agents\\agent_36.png",
            "agents\\agent_55.png"});
            this.logoComboBox.Location = new System.Drawing.Point(133, 238);
            this.logoComboBox.Name = "logoComboBox";
            this.logoComboBox.Size = new System.Drawing.Size(121, 21);
            this.logoComboBox.TabIndex = 35;
            // 
            // Deleted
            // 
            this.Deleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Deleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Deleted.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Deleted.Location = new System.Drawing.Point(302, 351);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(141, 35);
            this.Deleted.TabIndex = 40;
            this.Deleted.Text = "Удалдение";
            this.Deleted.UseVisualStyleBackColor = false;
            this.Deleted.Click += new System.EventHandler(this.Deleted_Click);
            // 
            // Left
            // 
            this.Left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Left.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Left.Location = new System.Drawing.Point(8, 351);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(141, 35);
            this.Left.TabIndex = 39;
            this.Left.Text = "Предыдущий";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Rigiht
            // 
            this.Rigiht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rigiht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Rigiht.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rigiht.Location = new System.Drawing.Point(155, 351);
            this.Rigiht.Name = "Rigiht";
            this.Rigiht.Size = new System.Drawing.Size(141, 35);
            this.Rigiht.TabIndex = 38;
            this.Rigiht.Text = "Следующий";
            this.Rigiht.UseVisualStyleBackColor = false;
            this.Rigiht.Click += new System.EventHandler(this.Rigiht_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.Save.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Save.Location = new System.Drawing.Point(449, 351);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 35);
            this.Save.TabIndex = 36;
            this.Save.Text = "Сохранение";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PhotoPB
            // 
            this.PhotoPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhotoPB.Location = new System.Drawing.Point(510, 94);
            this.PhotoPB.Name = "PhotoPB";
            this.PhotoPB.Size = new System.Drawing.Size(238, 246);
            this.PhotoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPB.TabIndex = 41;
            this.PhotoPB.TabStop = false;
            // 
            // tip_agentaLabel
            // 
            tip_agentaLabel.AutoSize = true;
            tip_agentaLabel.Location = new System.Drawing.Point(263, 159);
            tip_agentaLabel.Name = "tip_agentaLabel";
            tip_agentaLabel.Size = new System.Drawing.Size(66, 13);
            tip_agentaLabel.TabIndex = 41;
            tip_agentaLabel.Text = "Тип агента:";
            // 
            // tip_agentaComboBox
            // 
            this.tip_agentaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Tip_agenta", true));
            this.tip_agentaComboBox.FormattingEnabled = true;
            this.tip_agentaComboBox.Location = new System.Drawing.Point(383, 156);
            this.tip_agentaComboBox.Name = "tip_agentaComboBox";
            this.tip_agentaComboBox.Size = new System.Drawing.Size(121, 21);
            this.tip_agentaComboBox.TabIndex = 42;
            // 
            // Redaktirovanie_agentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 398);
            this.Controls.Add(tip_agentaLabel);
            this.Controls.Add(this.tip_agentaComboBox);
            this.Controls.Add(this.PhotoPB);
            this.Controls.Add(this.Deleted);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Rigiht);
            this.Controls.Add(this.Save);
            this.Controls.Add(id_INNAgentaLabel);
            this.Controls.Add(this.id_INNAgentaTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(naimenovanie_agentaLabel);
            this.Controls.Add(this.naimenovanie_agentaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(indeksLabel);
            this.Controls.Add(this.indeksTextBox);
            this.Controls.Add(ylicaLabel);
            this.Controls.Add(this.ylicaTextBox);
            this.Controls.Add(domLabel);
            this.Controls.Add(this.domTextBox);
            this.Controls.Add(imaLabel);
            this.Controls.Add(this.imaTextBox);
            this.Controls.Add(otcesatvoLabel);
            this.Controls.Add(this.otcesatvoTextBox);
            this.Controls.Add(familiaLabel);
            this.Controls.Add(this.familiaTextBox);
            this.Controls.Add(prioritetLabel);
            this.Controls.Add(this.prioritetTextBox);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoComboBox);
            this.Controls.Add(this.agentBindingNavigator);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Redaktirovanie_agentes";
            this.Text = "Приятный шелест";
            this.Load += new System.EventHandler(this.Redaktirovanie_agentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this._wsrprb_05DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingNavigator)).EndInit();
            this.agentBindingNavigator.ResumeLayout(false);
            this.agentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).EndInit();
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
        private System.Windows.Forms.TextBox id_INNAgentaTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox naimenovanie_agentaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox indeksTextBox;
        private System.Windows.Forms.TextBox ylicaTextBox;
        private System.Windows.Forms.TextBox domTextBox;
        private System.Windows.Forms.TextBox imaTextBox;
        private System.Windows.Forms.TextBox otcesatvoTextBox;
        private System.Windows.Forms.TextBox familiaTextBox;
        private System.Windows.Forms.TextBox prioritetTextBox;
        private System.Windows.Forms.ComboBox logoComboBox;
        private System.Windows.Forms.Button Deleted;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Rigiht;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox PhotoPB;
        private System.Windows.Forms.ComboBox tip_agentaComboBox;
    }
}