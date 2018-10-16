namespace KeyTrainer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtExample = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnShowNewText = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblFieldForInput = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pbxKeyboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExample
            // 
            this.txtExample.BackColor = System.Drawing.SystemColors.Window;
            this.txtExample.Enabled = false;
            this.txtExample.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExample.Location = new System.Drawing.Point(13, 56);
            this.txtExample.Name = "txtExample";
            this.txtExample.ReadOnly = true;
            this.txtExample.Size = new System.Drawing.Size(983, 22);
            this.txtExample.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInput.Location = new System.Drawing.Point(13, 143);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(983, 22);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnShowNewText
            // 
            this.btnShowNewText.Location = new System.Drawing.Point(12, 186);
            this.btnShowNewText.Name = "btnShowNewText";
            this.btnShowNewText.Size = new System.Drawing.Size(184, 50);
            this.btnShowNewText.TabIndex = 2;
            this.btnShowNewText.Text = "Новый текст";
            this.btnShowNewText.UseVisualStyleBackColor = true;
            this.btnShowNewText.Click += new System.EventHandler(this.btnShowNewText_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(472, 27);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Текст";
            // 
            // lblFieldForInput
            // 
            this.lblFieldForInput.AutoSize = true;
            this.lblFieldForInput.Location = new System.Drawing.Point(448, 115);
            this.lblFieldForInput.Name = "lblFieldForInput";
            this.lblFieldForInput.Size = new System.Drawing.Size(87, 13);
            this.lblFieldForInput.TabIndex = 4;
            this.lblFieldForInput.Text = "Поле для ввода";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 280);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(184, 32);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 242);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(183, 32);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pbxKeyboard
            // 
            this.pbxKeyboard.Image = global::KeyTrainer.Properties.Resources.keyboard;
            this.pbxKeyboard.Location = new System.Drawing.Point(202, 179);
            this.pbxKeyboard.Name = "pbxKeyboard";
            this.pbxKeyboard.Size = new System.Drawing.Size(585, 171);
            this.pbxKeyboard.TabIndex = 6;
            this.pbxKeyboard.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnShowNewText;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 362);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbxKeyboard);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblFieldForInput);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnShowNewText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtExample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.pbxKeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnShowNewText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblFieldForInput;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pbxKeyboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
    }
}

