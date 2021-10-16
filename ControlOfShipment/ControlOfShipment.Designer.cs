
namespace ControlOfShipment
{
    partial class ControlOfShipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlOfShipment));
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetTable = new System.Windows.Forms.DataGridView();
            this.Get = new System.Windows.Forms.TextBox();
            this.Give = new System.Windows.Forms.TextBox();
            this.GiveTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiveTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearButton.Location = new System.Drawing.Point(73, 487);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(162, 45);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(710, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поле ввода данных для отгрузки";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(149, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поле ввода данных для приёма";
            // 
            // GetTable
            // 
            this.GetTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetTable.Location = new System.Drawing.Point(73, 149);
            this.GetTable.Name = "GetTable";
            this.GetTable.ReadOnly = true;
            this.GetTable.Size = new System.Drawing.Size(334, 296);
            this.GetTable.TabIndex = 3;
            // 
            // Get
            // 
            this.Get.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Get.Location = new System.Drawing.Point(152, 67);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(193, 20);
            this.Get.TabIndex = 4;
            this.Get.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Get_CheckEnter);
            // 
            // Give
            // 
            this.Give.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Give.Location = new System.Drawing.Point(713, 67);
            this.Give.Name = "Give";
            this.Give.Size = new System.Drawing.Size(202, 20);
            this.Give.TabIndex = 5;
            this.Give.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Give_CheckEnter);
            // 
            // GiveTable
            // 
            this.GiveTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GiveTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiveTable.Location = new System.Drawing.Point(639, 149);
            this.GiveTable.Name = "GiveTable";
            this.GiveTable.ReadOnly = true;
            this.GiveTable.Size = new System.Drawing.Size(343, 296);
            this.GiveTable.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(208, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ПРИЁМ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(780, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ОТГРУЗКА";
            // 
            // ControlOfShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GiveTable);
            this.Controls.Add(this.Give);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.GetTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlOfShipment";
            this.Text = "Управление приёмкой и отгрузкой";
            this.Load += new System.EventHandler(this.ControlOfShipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GetTable;
        private System.Windows.Forms.TextBox Get;
        private System.Windows.Forms.TextBox Give;
        private System.Windows.Forms.DataGridView GiveTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

