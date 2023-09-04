namespace OS
{
    partial class FIFO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Information = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pages = new System.Windows.Forms.MaskedTextBox();
            this.MemoryPages = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Memory = new System.Windows.Forms.Button();
            this.button2Memory = new System.Windows.Forms.Button();
            this.button3Memory = new System.Windows.Forms.Button();
            this.button4Memory = new System.Windows.Forms.Button();
            this.button5Memory = new System.Windows.Forms.Button();
            this.button1Page = new System.Windows.Forms.Button();
            this.button2Page = new System.Windows.Forms.Button();
            this.button3Page = new System.Windows.Forms.Button();
            this.button4Page = new System.Windows.Forms.Button();
            this.button5Page = new System.Windows.Forms.Button();
            this.button6Page = new System.Windows.Forms.Button();
            this.button7Page = new System.Windows.Forms.Button();
            this.button8Page = new System.Windows.Forms.Button();
            this.button9Page = new System.Windows.Forms.Button();
            this.button10Page = new System.Windows.Forms.Button();
            this.button11Page = new System.Windows.Forms.Button();
            this.button12Page = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PageFaults = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::OS.Properties.Resources.iinactive;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.InfoToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HelpToolStripMenuItem.Text = "Помощь";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(879, 427);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::OS.Properties.Resources.iinactive;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8068F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.1932F));
            this.tableLayoutPanel1.Controls.Add(this.Information, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OK, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Information
            // 
            this.Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(3, 3);
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.ReadOnly = true;
            this.Information.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Information.Size = new System.Drawing.Size(281, 381);
            this.Information.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pages);
            this.panel1.Controls.Add(this.MemoryPages);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1Memory);
            this.panel1.Controls.Add(this.button2Memory);
            this.panel1.Controls.Add(this.button3Memory);
            this.panel1.Controls.Add(this.button4Memory);
            this.panel1.Controls.Add(this.button5Memory);
            this.panel1.Controls.Add(this.button1Page);
            this.panel1.Controls.Add(this.button2Page);
            this.panel1.Controls.Add(this.button3Page);
            this.panel1.Controls.Add(this.button4Page);
            this.panel1.Controls.Add(this.button5Page);
            this.panel1.Controls.Add(this.button6Page);
            this.panel1.Controls.Add(this.button7Page);
            this.panel1.Controls.Add(this.button8Page);
            this.panel1.Controls.Add(this.button9Page);
            this.panel1.Controls.Add(this.button10Page);
            this.panel1.Controls.Add(this.button11Page);
            this.panel1.Controls.Add(this.button12Page);
            this.panel1.Location = new System.Drawing.Point(290, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 381);
            this.panel1.TabIndex = 2;
            // 
            // Pages
            // 
            this.Pages.BeepOnError = true;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pages.Location = new System.Drawing.Point(255, 155);
            this.Pages.Mask = "00 00 00 00 00 00 00 00 00 00 00 00";
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(130, 22);
            this.Pages.TabIndex = 43;
            this.Pages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MemoryPages
            // 
            this.MemoryPages.BeepOnError = true;
            this.MemoryPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoryPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryPages.Location = new System.Drawing.Point(255, 3);
            this.MemoryPages.Mask = "00 00 00 00 00";
            this.MemoryPages.Name = "MemoryPages";
            this.MemoryPages.Size = new System.Drawing.Size(130, 22);
            this.MemoryPages.TabIndex = 42;
            this.MemoryPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MemoryPages.TextChanged += new System.EventHandler(this.MemoryPages_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(261, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Память";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(261, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Страницы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Замещаемые страницы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Страницы, находящиеся в памяти:";
            // 
            // button1Memory
            // 
            this.button1Memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Memory.BackColor = System.Drawing.Color.Thistle;
            this.button1Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Memory.Location = new System.Drawing.Point(16, 61);
            this.button1Memory.Margin = new System.Windows.Forms.Padding(13);
            this.button1Memory.Name = "button1Memory";
            this.button1Memory.Size = new System.Drawing.Size(90, 78);
            this.button1Memory.TabIndex = 20;
            this.button1Memory.Text = "button1";
            this.button1Memory.UseVisualStyleBackColor = false;
            this.button1Memory.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button2Memory
            // 
            this.button2Memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2Memory.BackColor = System.Drawing.Color.Thistle;
            this.button2Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Memory.Location = new System.Drawing.Point(132, 61);
            this.button2Memory.Margin = new System.Windows.Forms.Padding(13);
            this.button2Memory.Name = "button2Memory";
            this.button2Memory.Size = new System.Drawing.Size(90, 78);
            this.button2Memory.TabIndex = 21;
            this.button2Memory.Text = "button2";
            this.button2Memory.UseVisualStyleBackColor = false;
            this.button2Memory.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button3Memory
            // 
            this.button3Memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3Memory.BackColor = System.Drawing.Color.Thistle;
            this.button3Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3Memory.Location = new System.Drawing.Point(248, 61);
            this.button3Memory.Margin = new System.Windows.Forms.Padding(13);
            this.button3Memory.Name = "button3Memory";
            this.button3Memory.Size = new System.Drawing.Size(90, 78);
            this.button3Memory.TabIndex = 22;
            this.button3Memory.Text = "button3";
            this.button3Memory.UseVisualStyleBackColor = false;
            this.button3Memory.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button4Memory
            // 
            this.button4Memory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4Memory.BackColor = System.Drawing.Color.Thistle;
            this.button4Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4Memory.Location = new System.Drawing.Point(364, 61);
            this.button4Memory.Margin = new System.Windows.Forms.Padding(13);
            this.button4Memory.Name = "button4Memory";
            this.button4Memory.Size = new System.Drawing.Size(90, 78);
            this.button4Memory.TabIndex = 23;
            this.button4Memory.Text = "button4";
            this.button4Memory.UseVisualStyleBackColor = false;
            this.button4Memory.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button5Memory
            // 
            this.button5Memory.BackColor = System.Drawing.Color.Thistle;
            this.button5Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5Memory.Location = new System.Drawing.Point(480, 61);
            this.button5Memory.Margin = new System.Windows.Forms.Padding(13);
            this.button5Memory.Name = "button5Memory";
            this.button5Memory.Size = new System.Drawing.Size(90, 78);
            this.button5Memory.TabIndex = 24;
            this.button5Memory.Text = "button5";
            this.button5Memory.UseVisualStyleBackColor = false;
            this.button5Memory.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button1Page
            // 
            this.button1Page.BackColor = System.Drawing.Color.Thistle;
            this.button1Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1Page.Location = new System.Drawing.Point(8, 207);
            this.button1Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button1Page.Name = "button1Page";
            this.button1Page.Size = new System.Drawing.Size(90, 78);
            this.button1Page.TabIndex = 26;
            this.button1Page.Text = "button6";
            this.button1Page.UseVisualStyleBackColor = false;
            this.button1Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button2Page
            // 
            this.button2Page.BackColor = System.Drawing.Color.Thistle;
            this.button2Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2Page.Location = new System.Drawing.Point(104, 207);
            this.button2Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button2Page.Name = "button2Page";
            this.button2Page.Size = new System.Drawing.Size(90, 78);
            this.button2Page.TabIndex = 27;
            this.button2Page.Text = "button7";
            this.button2Page.UseVisualStyleBackColor = false;
            this.button2Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button3Page
            // 
            this.button3Page.BackColor = System.Drawing.Color.Thistle;
            this.button3Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3Page.Location = new System.Drawing.Point(200, 207);
            this.button3Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button3Page.Name = "button3Page";
            this.button3Page.Size = new System.Drawing.Size(90, 78);
            this.button3Page.TabIndex = 28;
            this.button3Page.Text = "button8";
            this.button3Page.UseVisualStyleBackColor = false;
            this.button3Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button4Page
            // 
            this.button4Page.BackColor = System.Drawing.Color.Thistle;
            this.button4Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4Page.Location = new System.Drawing.Point(296, 207);
            this.button4Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button4Page.Name = "button4Page";
            this.button4Page.Size = new System.Drawing.Size(90, 78);
            this.button4Page.TabIndex = 29;
            this.button4Page.Text = "button9";
            this.button4Page.UseVisualStyleBackColor = false;
            this.button4Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button5Page
            // 
            this.button5Page.BackColor = System.Drawing.Color.Thistle;
            this.button5Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5Page.Location = new System.Drawing.Point(392, 207);
            this.button5Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button5Page.Name = "button5Page";
            this.button5Page.Size = new System.Drawing.Size(90, 78);
            this.button5Page.TabIndex = 30;
            this.button5Page.Text = "button10";
            this.button5Page.UseVisualStyleBackColor = false;
            this.button5Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button6Page
            // 
            this.button6Page.BackColor = System.Drawing.Color.Thistle;
            this.button6Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6Page.Location = new System.Drawing.Point(488, 207);
            this.button6Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button6Page.Name = "button6Page";
            this.button6Page.Size = new System.Drawing.Size(90, 78);
            this.button6Page.TabIndex = 31;
            this.button6Page.Text = "button11";
            this.button6Page.UseVisualStyleBackColor = false;
            this.button6Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button7Page
            // 
            this.button7Page.BackColor = System.Drawing.Color.Thistle;
            this.button7Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7Page.Location = new System.Drawing.Point(8, 299);
            this.button7Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button7Page.Name = "button7Page";
            this.button7Page.Size = new System.Drawing.Size(90, 78);
            this.button7Page.TabIndex = 32;
            this.button7Page.Text = "button12";
            this.button7Page.UseVisualStyleBackColor = false;
            this.button7Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button8Page
            // 
            this.button8Page.BackColor = System.Drawing.Color.Thistle;
            this.button8Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8Page.Location = new System.Drawing.Point(104, 299);
            this.button8Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button8Page.Name = "button8Page";
            this.button8Page.Size = new System.Drawing.Size(90, 78);
            this.button8Page.TabIndex = 33;
            this.button8Page.Text = "button13";
            this.button8Page.UseVisualStyleBackColor = false;
            this.button8Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button9Page
            // 
            this.button9Page.BackColor = System.Drawing.Color.Thistle;
            this.button9Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9Page.Location = new System.Drawing.Point(200, 299);
            this.button9Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button9Page.Name = "button9Page";
            this.button9Page.Size = new System.Drawing.Size(90, 78);
            this.button9Page.TabIndex = 34;
            this.button9Page.Text = "button14";
            this.button9Page.UseVisualStyleBackColor = false;
            this.button9Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button10Page
            // 
            this.button10Page.BackColor = System.Drawing.Color.Thistle;
            this.button10Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10Page.Location = new System.Drawing.Point(296, 299);
            this.button10Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button10Page.Name = "button10Page";
            this.button10Page.Size = new System.Drawing.Size(90, 78);
            this.button10Page.TabIndex = 35;
            this.button10Page.Text = "button15";
            this.button10Page.UseVisualStyleBackColor = false;
            this.button10Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button11Page
            // 
            this.button11Page.BackColor = System.Drawing.Color.Thistle;
            this.button11Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11Page.Location = new System.Drawing.Point(392, 299);
            this.button11Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button11Page.Name = "button11Page";
            this.button11Page.Size = new System.Drawing.Size(90, 78);
            this.button11Page.TabIndex = 36;
            this.button11Page.Text = "button16";
            this.button11Page.UseVisualStyleBackColor = false;
            this.button11Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // button12Page
            // 
            this.button12Page.BackColor = System.Drawing.Color.Thistle;
            this.button12Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12Page.Location = new System.Drawing.Point(488, 299);
            this.button12Page.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button12Page.Name = "button12Page";
            this.button12Page.Size = new System.Drawing.Size(90, 78);
            this.button12Page.TabIndex = 37;
            this.button12Page.Text = "button17";
            this.button12Page.UseVisualStyleBackColor = false;
            this.button12Page.Click += new System.EventHandler(this.button1Page_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.8363F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.1637F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PageFaults, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 390);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 32);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество прерываний:";
            // 
            // PageFaults
            // 
            this.PageFaults.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PageFaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageFaults.Location = new System.Drawing.Point(188, 5);
            this.PageFaults.Name = "PageFaults";
            this.PageFaults.ReadOnly = true;
            this.PageFaults.Size = new System.Drawing.Size(90, 22);
            this.PageFaults.TabIndex = 0;
            this.PageFaults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OK
            // 
            this.OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK.Location = new System.Drawing.Point(544, 394);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 44;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FIFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(879, 451);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FIFO";
            this.Text = "FIFO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Information;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1Memory;
        private System.Windows.Forms.Button button2Memory;
        private System.Windows.Forms.Button button3Memory;
        private System.Windows.Forms.Button button4Memory;
        private System.Windows.Forms.Button button5Memory;
        private System.Windows.Forms.Button button1Page;
        private System.Windows.Forms.Button button2Page;
        private System.Windows.Forms.Button button3Page;
        private System.Windows.Forms.Button button4Page;
        private System.Windows.Forms.Button button5Page;
        private System.Windows.Forms.Button button6Page;
        private System.Windows.Forms.Button button7Page;
        private System.Windows.Forms.Button button8Page;
        private System.Windows.Forms.Button button9Page;
        private System.Windows.Forms.Button button10Page;
        private System.Windows.Forms.Button button11Page;
        private System.Windows.Forms.Button button12Page;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox PageFaults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MemoryPages;
        private System.Windows.Forms.MaskedTextBox Pages;
        private System.Windows.Forms.Button OK;
    }
}

