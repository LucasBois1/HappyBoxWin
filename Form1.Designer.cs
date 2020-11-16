using System;
using System.Windows.Forms;

namespace Happy_Box
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.randWord = new System.Windows.Forms.Button();
            this.seeDescription = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WordsTabs = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totallyRandom = new System.Windows.Forms.RadioButton();
            this.lastWeek = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.WordsTabs.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // randWord
            // 
            resources.ApplyResources(this.randWord, "randWord");
            this.randWord.Name = "randWord";
            this.randWord.UseVisualStyleBackColor = true;
            this.randWord.Click += new System.EventHandler(this.RandWord_Click);
            // 
            // seeDescription
            // 
            resources.ApplyResources(this.seeDescription, "seeDescription");
            this.seeDescription.Name = "seeDescription";
            this.seeDescription.UseVisualStyleBackColor = true;
            this.seeDescription.Click += new System.EventHandler(this.SeeDescription_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WordsTabs);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // WordsTabs
            // 
            this.WordsTabs.Controls.Add(this.tabAdd);
            this.WordsTabs.Controls.Add(this.tabRemove);
            this.WordsTabs.Controls.Add(this.tabList);
            resources.ApplyResources(this.WordsTabs, "WordsTabs");
            this.WordsTabs.Multiline = true;
            this.WordsTabs.Name = "WordsTabs";
            this.WordsTabs.SelectedIndex = 0;
            this.WordsTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.richTextBox4);
            this.tabAdd.Controls.Add(this.button1);
            this.tabAdd.Controls.Add(this.richTextBox3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label1);
            resources.ApplyResources(this.tabAdd, "tabAdd");
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.UseVisualStyleBackColor = true;
            this.tabAdd.Click += new System.EventHandler(this.TabAdd_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox4, "richTextBox4");
            this.richTextBox4.Name = "richTextBox4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox3, "richTextBox3");
            this.richTextBox3.Name = "richTextBox3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.richTextBox6);
            this.tabRemove.Controls.Add(this.richTextBox7);
            this.tabRemove.Controls.Add(this.label4);
            this.tabRemove.Controls.Add(this.label5);
            this.tabRemove.Controls.Add(this.richTextBox5);
            this.tabRemove.Controls.Add(this.button3);
            this.tabRemove.Controls.Add(this.CheckButton);
            this.tabRemove.Controls.Add(this.label3);
            resources.ApplyResources(this.tabRemove, "tabRemove");
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox6, "richTextBox6");
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            // 
            // richTextBox7
            // 
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox7, "richTextBox7");
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.richTextBox5, "richTextBox5");
            this.richTextBox5.Name = "richTextBox5";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // CheckButton
            // 
            resources.ApplyResources(this.CheckButton, "CheckButton");
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.button2);
            this.tabList.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabList, "tabList");
            this.tabList.Name = "tabList";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ImageList = this.imageList1;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "reload2.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Word});
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // totallyRandom
            // 
            resources.ApplyResources(this.totallyRandom, "totallyRandom");
            this.totallyRandom.Name = "totallyRandom";
            this.totallyRandom.UseVisualStyleBackColor = true;
            this.totallyRandom.CheckedChanged += new System.EventHandler(this.TotallyRandom_CheckedChanged);
            // 
            // lastWeek
            // 
            resources.ApplyResources(this.lastWeek, "lastWeek");
            this.lastWeek.Checked = true;
            this.lastWeek.Name = "lastWeek";
            this.lastWeek.TabStop = true;
            this.lastWeek.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.DetectUrls = false;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.DetectUrls = false;
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Id
            // 
            this.Id.FillWeight = 30.45685F;
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Word
            // 
            this.Word.FillWeight = 134.7716F;
            resources.ApplyResources(this.Word, "Word");
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lastWeek);
            this.Controls.Add(this.totallyRandom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seeDescription);
            this.Controls.Add(this.randWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.WordsTabs.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.tabRemove.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Button randWord;
        private System.Windows.Forms.Button seeDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton totallyRandom;
        private System.Windows.Forms.RadioButton lastWeek;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabControl WordsTabs;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox3;
        private Label label2;
        private Button button3;
        private Button CheckButton;
        private Label label3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Button button2;
        private ImageList imageList1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Word;
    }
}

