using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btAdd;
        private CheckBox checkBoxDelivery;
        private TextBox tbQuantity;
        private ComboBox cbArticle;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label5;
        private GroupBox groupBox4;
        private Button button5;
        private Button btDelete;
        private Button btReceipt;
        private PictureBox pictureBox1;
        private TextBox tbReceipt;
        private Label label8;
        private Label lbTotal;
        private Label lbDeliveryPrice;
        private Label lbOrderPrice;
        private Label lbWorker;
        private Button btTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btReceipt = new System.Windows.Forms.Button();
            this.btTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbReceipt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbOrderPrice = new System.Windows.Forms.Label();
            this.lbDeliveryPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAST FOOD RESTAURANT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(483, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"LA CASA\"";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.checkBoxDelivery);
            this.groupBox1.Controls.Add(this.tbQuantity);
            this.groupBox1.Controls.Add(this.cbArticle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAdd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAdd.Location = new System.Drawing.Point(206, 152);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(104, 51);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "ADD";
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxDelivery.Location = new System.Drawing.Point(21, 121);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(161, 24);
            this.checkBoxDelivery.TabIndex = 5;
            this.checkBoxDelivery.Text = "Home delivery";
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(134, 76);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(176, 22);
            this.tbQuantity.TabIndex = 4;
            // 
            // cbArticle
            // 
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(134, 41);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(176, 24);
            this.cbArticle.TabIndex = 3;
            this.cbArticle.SelectedIndexChanged += new System.EventHandler(this.cbArticle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Article";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.lbDeliveryPrice);
            this.groupBox2.Controls.Add(this.lbOrderPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(32, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 216);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "DELIVERY PRICE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "ORDER PRICE:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.btDelete);
            this.groupBox4.Controls.Add(this.btReceipt);
            this.groupBox4.Controls.Add(this.btTotal);
            this.groupBox4.Location = new System.Drawing.Point(436, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 216);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(173, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDelete.Location = new System.Drawing.Point(32, 118);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(104, 51);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btReceipt
            // 
            this.btReceipt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btReceipt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btReceipt.Location = new System.Drawing.Point(173, 43);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(104, 51);
            this.btReceipt.TabIndex = 8;
            this.btReceipt.Text = "RECEIPT";
            this.btReceipt.UseVisualStyleBackColor = false;
            // 
            // btTotal
            // 
            this.btTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btTotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btTotal.Location = new System.Drawing.Point(32, 43);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(104, 51);
            this.btTotal.TabIndex = 7;
            this.btTotal.Text = "TOTAL";
            this.btTotal.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresentationLayer.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(436, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 231);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tbReceipt
            // 
            this.tbReceipt.Location = new System.Drawing.Point(804, 119);
            this.tbReceipt.Multiline = true;
            this.tbReceipt.Name = "tbReceipt";
            this.tbReceipt.Size = new System.Drawing.Size(343, 468);
            this.tbReceipt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "CURRENT WORKER:";
            // 
            // lbOrderPrice
            // 
            this.lbOrderPrice.AutoSize = true;
            this.lbOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOrderPrice.ForeColor = System.Drawing.Color.Black;
            this.lbOrderPrice.Location = new System.Drawing.Point(178, 32);
            this.lbOrderPrice.Name = "lbOrderPrice";
            this.lbOrderPrice.Size = new System.Drawing.Size(0, 25);
            this.lbOrderPrice.TabIndex = 6;
            // 
            // lbDeliveryPrice
            // 
            this.lbDeliveryPrice.AutoSize = true;
            this.lbDeliveryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeliveryPrice.ForeColor = System.Drawing.Color.Black;
            this.lbDeliveryPrice.Location = new System.Drawing.Point(203, 71);
            this.lbDeliveryPrice.Name = "lbDeliveryPrice";
            this.lbDeliveryPrice.Size = new System.Drawing.Size(0, 25);
            this.lbDeliveryPrice.TabIndex = 7;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(94, 146);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 25);
            this.lbTotal.TabIndex = 8;
            // 
            // lbWorker
            // 
            this.lbWorker.AutoSize = true;
            this.lbWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWorker.ForeColor = System.Drawing.Color.White;
            this.lbWorker.Location = new System.Drawing.Point(235, 618);
            this.lbWorker.Name = "lbWorker";
            this.lbWorker.Size = new System.Drawing.Size(0, 25);
            this.lbWorker.TabIndex = 9;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(89)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1192, 675);
            this.Controls.Add(this.lbWorker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbReceipt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "FAST FOOD RESTAURANT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            cbArticle.SelectedIndex = -1;
            tbQuantity.Text = "";
            tbReceipt.Text = "";
            checkBoxDelivery.Checked = false;
            lbOrderPrice.Text = "";
            lbDeliveryPrice.Text = "";
            lbTotal.Text = "";
        }
    }
}
