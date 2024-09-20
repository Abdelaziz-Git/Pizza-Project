namespace Pizza_Project
{
    partial class frmPizzaOrder
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
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbPizzaCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbPizzaToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomates = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbWhereToEatChoiced = new System.Windows.Forms.Label();
            this.lbWhereToEatTitle = new System.Windows.Forms.Label();
            this.lbToppingChoiced = new System.Windows.Forms.Label();
            this.lbToppingsTitle = new System.Windows.Forms.Label();
            this.lbCrustChoiced = new System.Windows.Forms.Label();
            this.lbCrustTypeTitle = new System.Windows.Forms.Label();
            this.lbSizeChoiced = new System.Windows.Forms.Label();
            this.lbSizeTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPizzaSize.SuspendLayout();
            this.gbPizzaCrustType.SuspendLayout();
            this.gbPizzaToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.Location = new System.Drawing.Point(36, 82);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(151, 190);
            this.gbPizzaSize.TabIndex = 3;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Pizza Size";            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(33, 136);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(89, 31);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.Tag = "10";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(33, 90);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(115, 31);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "8";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rdMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(33, 44);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(89, 31);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbPizzaCrustType
            // 
            this.gbPizzaCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaCrustType.Controls.Add(this.rbThinkCrust);
            this.gbPizzaCrustType.Controls.Add(this.rbThinCrust);
            this.gbPizzaCrustType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaCrustType.Location = new System.Drawing.Point(36, 286);
            this.gbPizzaCrustType.Name = "gbPizzaCrustType";
            this.gbPizzaCrustType.Size = new System.Drawing.Size(151, 147);
            this.gbPizzaCrustType.TabIndex = 6;
            this.gbPizzaCrustType.TabStop = false;
            this.gbPizzaCrustType.Text = "Pizza Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkCrust.Location = new System.Drawing.Point(33, 103);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(145, 31);
            this.rbThinkCrust.TabIndex = 7;
            this.rbThinkCrust.Tag = "2";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(33, 48);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(134, 31);
            this.rbThinCrust.TabIndex = 6;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbPizzaToppings
            // 
            this.gbPizzaToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaToppings.Controls.Add(this.cbGreenPeppers);
            this.gbPizzaToppings.Controls.Add(this.cbOlives);
            this.gbPizzaToppings.Controls.Add(this.cbOnion);
            this.gbPizzaToppings.Controls.Add(this.cbTomates);
            this.gbPizzaToppings.Controls.Add(this.cbMushrooms);
            this.gbPizzaToppings.Controls.Add(this.cbExtraCheese);
            this.gbPizzaToppings.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaToppings.Location = new System.Drawing.Point(220, 82);
            this.gbPizzaToppings.Name = "gbPizzaToppings";
            this.gbPizzaToppings.Size = new System.Drawing.Size(345, 190);
            this.gbPizzaToppings.TabIndex = 13;
            this.gbPizzaToppings.TabStop = false;
            this.gbPizzaToppings.Text = "Pizza Toppings";
            this.gbPizzaToppings.Enter += new System.EventHandler(this.gbPizzaToppings_Enter);
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGreenPeppers.Location = new System.Drawing.Point(195, 145);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(175, 31);
            this.cbGreenPeppers.TabIndex = 18;
            this.cbGreenPeppers.Tag = "1";
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOlives.Location = new System.Drawing.Point(195, 91);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(96, 31);
            this.cbOlives.TabIndex = 17;
            this.cbOlives.Tag = "1";
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnion.Location = new System.Drawing.Point(195, 45);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(95, 31);
            this.cbOnion.TabIndex = 16;
            this.cbOnion.Tag = "1";
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbTomates
            // 
            this.cbTomates.AutoSize = true;
            this.cbTomates.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTomates.Location = new System.Drawing.Point(30, 145);
            this.cbTomates.Name = "cbTomates";
            this.cbTomates.Size = new System.Drawing.Size(119, 31);
            this.cbTomates.TabIndex = 15;
            this.cbTomates.Tag = "1";
            this.cbTomates.Text = "Tomates";
            this.cbTomates.UseVisualStyleBackColor = true;
            this.cbTomates.CheckedChanged += new System.EventHandler(this.cbTomates_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMushrooms.Location = new System.Drawing.Point(30, 91);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(149, 31);
            this.cbMushrooms.TabIndex = 14;
            this.cbMushrooms.Tag = "1";
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraCheese.Location = new System.Drawing.Point(30, 44);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(159, 31);
            this.cbExtraCheese.TabIndex = 13;
            this.cbExtraCheese.Tag = "1";
            this.cbExtraCheese.Text = "Extra Cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(220, 326);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(345, 87);
            this.gbWhereToEat.TabIndex = 14;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where to eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(195, 29);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(123, 31);
            this.rbTakeOut.TabIndex = 18;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(30, 29);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(91, 31);
            this.rbEatIn.TabIndex = 17;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Lime;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(416, 451);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(164, 52);
            this.btnOrderPizza.TabIndex = 15;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Red;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(205, 451);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(164, 52);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbWhereToEatChoiced);
            this.groupBox2.Controls.Add(this.lbWhereToEatTitle);
            this.groupBox2.Controls.Add(this.lbToppingChoiced);
            this.groupBox2.Controls.Add(this.lbToppingsTitle);
            this.groupBox2.Controls.Add(this.lbCrustChoiced);
            this.groupBox2.Controls.Add(this.lbCrustTypeTitle);
            this.groupBox2.Controls.Add(this.lbSizeChoiced);
            this.groupBox2.Controls.Add(this.lbSizeTitle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(588, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 289);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Summary";
            // 
            // lbWhereToEatChoiced
            // 
            this.lbWhereToEatChoiced.AutoSize = true;
            this.lbWhereToEatChoiced.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEatChoiced.ForeColor = System.Drawing.Color.Black;
            this.lbWhereToEatChoiced.Location = new System.Drawing.Point(61, 253);
            this.lbWhereToEatChoiced.Name = "lbWhereToEatChoiced";
            this.lbWhereToEatChoiced.Size = new System.Drawing.Size(60, 26);
            this.lbWhereToEatChoiced.TabIndex = 34;
            this.lbWhereToEatChoiced.Text = "Eat in";
            // 
            // lbWhereToEatTitle
            // 
            this.lbWhereToEatTitle.AutoSize = true;
            this.lbWhereToEatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEatTitle.Location = new System.Drawing.Point(42, 216);
            this.lbWhereToEatTitle.Name = "lbWhereToEatTitle";
            this.lbWhereToEatTitle.Size = new System.Drawing.Size(153, 25);
            this.lbWhereToEatTitle.TabIndex = 33;
            this.lbWhereToEatTitle.Text = "Where To Eat:";
            // 
            // lbToppingChoiced
            // 
            this.lbToppingChoiced.AutoSize = true;
            this.lbToppingChoiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbToppingChoiced.ForeColor = System.Drawing.Color.Black;
            this.lbToppingChoiced.Location = new System.Drawing.Point(45, 177);
            this.lbToppingChoiced.MaximumSize = new System.Drawing.Size(225, 0);
            this.lbToppingChoiced.Name = "lbToppingChoiced";
            this.lbToppingChoiced.Size = new System.Drawing.Size(122, 24);
            this.lbToppingChoiced.TabIndex = 32;
            this.lbToppingChoiced.Text = "No Toppings.....";
            this.lbToppingChoiced.UseCompatibleTextRendering = true;
            // 
            // lbToppingsTitle
            // 
            this.lbToppingsTitle.AutoSize = true;
            this.lbToppingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingsTitle.Location = new System.Drawing.Point(42, 147);
            this.lbToppingsTitle.Name = "lbToppingsTitle";
            this.lbToppingsTitle.Size = new System.Drawing.Size(109, 25);
            this.lbToppingsTitle.TabIndex = 31;
            this.lbToppingsTitle.Text = "Toppings:";
            // 
            // lbCrustChoiced
            // 
            this.lbCrustChoiced.AutoSize = true;
            this.lbCrustChoiced.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustChoiced.ForeColor = System.Drawing.Color.Black;
            this.lbCrustChoiced.Location = new System.Drawing.Point(132, 97);
            this.lbCrustChoiced.Name = "lbCrustChoiced";
            this.lbCrustChoiced.Size = new System.Drawing.Size(99, 26);
            this.lbCrustChoiced.TabIndex = 30;
            this.lbCrustChoiced.Text = "Thin Crust";
            // 
            // lbCrustTypeTitle
            // 
            this.lbCrustTypeTitle.AutoSize = true;
            this.lbCrustTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustTypeTitle.Location = new System.Drawing.Point(42, 94);
            this.lbCrustTypeTitle.Name = "lbCrustTypeTitle";
            this.lbCrustTypeTitle.Size = new System.Drawing.Size(126, 25);
            this.lbCrustTypeTitle.TabIndex = 29;
            this.lbCrustTypeTitle.Text = "Crust Type:";
            // 
            // lbSizeChoiced
            // 
            this.lbSizeChoiced.AutoSize = true;
            this.lbSizeChoiced.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeChoiced.ForeColor = System.Drawing.Color.Black;
            this.lbSizeChoiced.Location = new System.Drawing.Point(81, 49);
            this.lbSizeChoiced.Name = "lbSizeChoiced";
            this.lbSizeChoiced.Size = new System.Drawing.Size(85, 26);
            this.lbSizeChoiced.TabIndex = 28;
            this.lbSizeChoiced.Text = "Medium";
            this.lbSizeChoiced.Click += new System.EventHandler(this.lbSizeChoiced_Click);
            // 
            // lbSizeTitle
            // 
            this.lbSizeTitle.AutoSize = true;
            this.lbSizeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeTitle.Location = new System.Drawing.Point(44, 47);
            this.lbSizeTitle.Name = "lbSizeTitle";
            this.lbSizeTitle.Size = new System.Drawing.Size(62, 25);
            this.lbSizeTitle.TabIndex = 27;
            this.lbSizeTitle.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Price:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(723, 442);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(85, 61);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "0$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(143, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(749, 55);
            this.label2.TabIndex = 20;
            this.label2.Text = "Make Your Pizza";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbPizzaToppings);
            this.Controls.Add(this.gbPizzaCrustType);
            this.Controls.Add(this.gbPizzaSize);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbPizzaCrustType.ResumeLayout(false);
            this.gbPizzaCrustType.PerformLayout();
            this.gbPizzaToppings.ResumeLayout(false);
            this.gbPizzaToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbPizzaCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbPizzaToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomates;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbWhereToEatChoiced;
        private System.Windows.Forms.Label lbWhereToEatTitle;
        private System.Windows.Forms.Label lbToppingChoiced;
        private System.Windows.Forms.Label lbToppingsTitle;
        private System.Windows.Forms.Label lbCrustChoiced;
        private System.Windows.Forms.Label lbCrustTypeTitle;
        private System.Windows.Forms.Label lbSizeChoiced;
        private System.Windows.Forms.Label lbSizeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label2;
    }
}

