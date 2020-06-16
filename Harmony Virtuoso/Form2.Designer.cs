namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.comboInstrument = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioChords = new System.Windows.Forms.RadioButton();
            this.radioNotes = new System.Windows.Forms.RadioButton();
            this.forInstrument = new System.Windows.Forms.ErrorProvider(this.components);
            this.forGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.forGame = new System.Windows.Forms.ErrorProvider(this.components);
            this.forName = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRadio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBeginner = new System.Windows.Forms.RadioButton();
            this.radioIntermediate = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.radioAdvanced = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.forInstrument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboInstrument
            // 
            this.comboInstrument.FormattingEnabled = true;
            this.comboInstrument.Items.AddRange(new object[] {
            "Guitar",
            "Piano"});
            this.comboInstrument.Location = new System.Drawing.Point(164, 168);
            this.comboInstrument.Name = "comboInstrument";
            this.comboInstrument.Size = new System.Drawing.Size(176, 21);
            this.comboInstrument.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(161, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose your main instrument:";
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Heavy Metal",
            "Rock",
            "Jazz",
            "Classical Music"});
            this.comboGenre.Location = new System.Drawing.Point(164, 218);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(176, 21);
            this.comboGenre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(161, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please choose your favourite genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "What game do you want to play?";
            // 
            // radioChords
            // 
            this.radioChords.AutoSize = true;
            this.radioChords.BackColor = System.Drawing.Color.Transparent;
            this.radioChords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioChords.Location = new System.Drawing.Point(124, 288);
            this.radioChords.Name = "radioChords";
            this.radioChords.Size = new System.Drawing.Size(126, 19);
            this.radioChords.TabIndex = 4;
            this.radioChords.Text = "Guess The Chords";
            this.radioChords.UseVisualStyleBackColor = false;
            // 
            // radioNotes
            // 
            this.radioNotes.AutoSize = true;
            this.radioNotes.BackColor = System.Drawing.Color.Transparent;
            this.radioNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNotes.Location = new System.Drawing.Point(272, 288);
            this.radioNotes.Name = "radioNotes";
            this.radioNotes.Size = new System.Drawing.Size(113, 19);
            this.radioNotes.TabIndex = 4;
            this.radioNotes.Text = "Guess the notes";
            this.radioNotes.UseVisualStyleBackColor = false;
            this.radioNotes.CheckedChanged += new System.EventHandler(this.radioNotes_CheckedChanged);
            // 
            // forInstrument
            // 
            this.forInstrument.ContainerControl = this;
            // 
            // forGenre
            // 
            this.forGenre.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(161, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 6;
            // 
            // forGame
            // 
            this.forGame.ContainerControl = this;
            // 
            // forName
            // 
            this.forName.ContainerControl = this;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.BackColor = System.Drawing.Color.Transparent;
            this.lblRadio.ForeColor = System.Drawing.Color.Red;
            this.lblRadio.Location = new System.Drawing.Point(159, 319);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(0, 13);
            this.lblRadio.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 91);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 3;
            // 
            // radioBeginner
            // 
            this.radioBeginner.AutoSize = true;
            this.radioBeginner.BackColor = System.Drawing.Color.Transparent;
            this.radioBeginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBeginner.Location = new System.Drawing.Point(6, 33);
            this.radioBeginner.Name = "radioBeginner";
            this.radioBeginner.Size = new System.Drawing.Size(88, 19);
            this.radioBeginner.TabIndex = 4;
            this.radioBeginner.TabStop = true;
            this.radioBeginner.Text = "BEGINNER";
            this.radioBeginner.UseVisualStyleBackColor = false;
            // 
            // radioIntermediate
            // 
            this.radioIntermediate.AutoSize = true;
            this.radioIntermediate.BackColor = System.Drawing.Color.Transparent;
            this.radioIntermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIntermediate.Location = new System.Drawing.Point(6, 58);
            this.radioIntermediate.Name = "radioIntermediate";
            this.radioIntermediate.Size = new System.Drawing.Size(114, 19);
            this.radioIntermediate.TabIndex = 4;
            this.radioIntermediate.TabStop = true;
            this.radioIntermediate.Text = "INTERMEDIATE";
            this.radioIntermediate.UseVisualStyleBackColor = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.Red;
            this.lblLevel.Location = new System.Drawing.Point(161, 489);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 7;
            // 
            // radioAdvanced
            // 
            this.radioAdvanced.AutoSize = true;
            this.radioAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.radioAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdvanced.Location = new System.Drawing.Point(6, 83);
            this.radioAdvanced.Name = "radioAdvanced";
            this.radioAdvanced.Size = new System.Drawing.Size(89, 19);
            this.radioAdvanced.TabIndex = 4;
            this.radioAdvanced.TabStop = true;
            this.radioAdvanced.Text = "ADVANCED";
            this.radioAdvanced.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(272, 524);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioIntermediate);
            this.groupBox1.Controls.Add(this.radioBeginner);
            this.groupBox1.Controls.Add(this.radioAdvanced);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(131, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What level do you want to play in?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioChords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.comboInstrument);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Harmony Virtuoso";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forInstrument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboInstrument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioChords;
        private System.Windows.Forms.RadioButton radioNotes;
        private System.Windows.Forms.ErrorProvider forInstrument;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider forGenre;
        private System.Windows.Forms.ErrorProvider forGame;
        private System.Windows.Forms.ErrorProvider forName;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.RadioButton radioAdvanced;
        private System.Windows.Forms.RadioButton radioIntermediate;
        private System.Windows.Forms.RadioButton radioBeginner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}