﻿namespace QuikSharpDemo
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxLogsWindow = new System.Windows.Forms.TextBox();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCommandRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSecCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClassCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccountID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirmID = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBestBid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLastPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBestOffer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxGuaranteeProviding = new System.Windows.Forms.TextBox();
            this.timerRenewForm = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(13, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(1032, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "CONNECT";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxLogsWindow
            // 
            this.textBoxLogsWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogsWindow.Location = new System.Drawing.Point(243, 229);
            this.textBoxLogsWindow.Multiline = true;
            this.textBoxLogsWindow.Name = "textBoxLogsWindow";
            this.textBoxLogsWindow.ReadOnly = true;
            this.textBoxLogsWindow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogsWindow.Size = new System.Drawing.Size(802, 306);
            this.textBoxLogsWindow.TabIndex = 1;
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(242, 98);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(378, 95);
            this.listBoxCommands.TabIndex = 2;
            this.listBoxCommands.SelectedIndexChanged += new System.EventHandler(this.listBoxCommands_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBoxDescription.Location = new System.Drawing.Point(627, 98);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(417, 95);
            this.textBoxDescription.TabIndex = 3;
            // 
            // buttonCommandRun
            // 
            this.buttonCommandRun.Location = new System.Drawing.Point(242, 200);
            this.buttonCommandRun.Name = "buttonCommandRun";
            this.buttonCommandRun.Size = new System.Drawing.Size(378, 23);
            this.buttonCommandRun.TabIndex = 4;
            this.buttonCommandRun.Text = "Выполнить команду";
            this.buttonCommandRun.UseVisualStyleBackColor = true;
            this.buttonCommandRun.Click += new System.EventHandler(this.buttonCommandRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SecCode";
            // 
            // textBoxSecCode
            // 
            this.textBoxSecCode.Location = new System.Drawing.Point(93, 42);
            this.textBoxSecCode.Name = "textBoxSecCode";
            this.textBoxSecCode.Size = new System.Drawing.Size(140, 20);
            this.textBoxSecCode.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ClassCode";
            // 
            // textBoxClassCode
            // 
            this.textBoxClassCode.Enabled = false;
            this.textBoxClassCode.Location = new System.Drawing.Point(93, 98);
            this.textBoxClassCode.Name = "textBoxClassCode";
            this.textBoxClassCode.Size = new System.Drawing.Size(140, 20);
            this.textBoxClassCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AccountID";
            // 
            // textBoxAccountID
            // 
            this.textBoxAccountID.Enabled = false;
            this.textBoxAccountID.Location = new System.Drawing.Point(93, 151);
            this.textBoxAccountID.Name = "textBoxAccountID";
            this.textBoxAccountID.Size = new System.Drawing.Size(140, 20);
            this.textBoxAccountID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ClientCode";
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Enabled = false;
            this.textBoxClientCode.Location = new System.Drawing.Point(93, 124);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(140, 20);
            this.textBoxClientCode.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FirmID";
            // 
            // textBoxFirmID
            // 
            this.textBoxFirmID.Enabled = false;
            this.textBoxFirmID.Location = new System.Drawing.Point(93, 177);
            this.textBoxFirmID.Name = "textBoxFirmID";
            this.textBoxFirmID.Size = new System.Drawing.Size(140, 20);
            this.textBoxFirmID.TabIndex = 6;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.Location = new System.Drawing.Point(13, 69);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(1031, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ShortName";
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Enabled = false;
            this.textBoxShortName.Location = new System.Drawing.Point(93, 213);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(140, 20);
            this.textBoxShortName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lot";
            // 
            // textBoxLot
            // 
            this.textBoxLot.Enabled = false;
            this.textBoxLot.Location = new System.Drawing.Point(93, 239);
            this.textBoxLot.Name = "textBoxLot";
            this.textBoxLot.Size = new System.Drawing.Size(140, 20);
            this.textBoxLot.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Шаг цены";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Enabled = false;
            this.textBoxStep.Location = new System.Drawing.Point(93, 265);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(140, 20);
            this.textBoxStep.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Best Bid";
            // 
            // textBoxBestBid
            // 
            this.textBoxBestBid.Enabled = false;
            this.textBoxBestBid.Location = new System.Drawing.Point(93, 384);
            this.textBoxBestBid.Name = "textBoxBestBid";
            this.textBoxBestBid.Size = new System.Drawing.Size(140, 20);
            this.textBoxBestBid.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Last Price";
            // 
            // textBoxLastPrice
            // 
            this.textBoxLastPrice.Enabled = false;
            this.textBoxLastPrice.Location = new System.Drawing.Point(93, 358);
            this.textBoxLastPrice.Name = "textBoxLastPrice";
            this.textBoxLastPrice.Size = new System.Drawing.Size(140, 20);
            this.textBoxLastPrice.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Best Offer";
            // 
            // textBoxBestOffer
            // 
            this.textBoxBestOffer.Enabled = false;
            this.textBoxBestOffer.Location = new System.Drawing.Point(93, 332);
            this.textBoxBestOffer.Name = "textBoxBestOffer";
            this.textBoxBestOffer.Size = new System.Drawing.Size(140, 20);
            this.textBoxBestOffer.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "ГО";
            // 
            // textBoxGuaranteeProviding
            // 
            this.textBoxGuaranteeProviding.Enabled = false;
            this.textBoxGuaranteeProviding.Location = new System.Drawing.Point(93, 288);
            this.textBoxGuaranteeProviding.Name = "textBoxGuaranteeProviding";
            this.textBoxGuaranteeProviding.Size = new System.Drawing.Size(140, 20);
            this.textBoxGuaranteeProviding.TabIndex = 6;
            // 
            // timerRenewForm
            // 
            this.timerRenewForm.Interval = 500;
            this.timerRenewForm.Tick += new System.EventHandler(this.timerRenewForm_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 417);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Active Order Number:";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Enabled = false;
            this.textBoxOrderNumber.Location = new System.Drawing.Point(93, 436);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(140, 20);
            this.textBoxOrderNumber.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(270, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "- НЕОБХОДИМО УКАЗАТЬ ТИКЕР ИНСТРУМЕНТА";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 547);
            this.Controls.Add(this.textBoxFirmID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAccountID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClassCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBestOffer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxLastPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxBestBid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxGuaranteeProviding);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSecCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCommandRun);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.textBoxLogsWindow);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "QuikSharp Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxLogsWindow;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCommandRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSecCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClassCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirmID;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBestBid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLastPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBestOffer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxGuaranteeProviding;
        private System.Windows.Forms.Timer timerRenewForm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label label14;
    }
}

