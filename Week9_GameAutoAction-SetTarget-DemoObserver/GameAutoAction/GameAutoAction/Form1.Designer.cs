using System;

namespace GameAutoAction
{
    partial class Form1
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
            this.textBoxFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVillager = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBuildingWonder = new System.Windows.Forms.Label();
            this.textBoxBuildingWonder = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxFood
            // 
            this.textBoxFood.Location = new System.Drawing.Point(112, 13);
            this.textBoxFood.Name = "textBoxFood";
            this.textBoxFood.Size = new System.Drawing.Size(100, 20);
            this.textBoxFood.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food";
            // 
            // textBoxVillager
            // 
            this.textBoxVillager.Location = new System.Drawing.Point(112, 42);
            this.textBoxVillager.Name = "textBoxVillager";
            this.textBoxVillager.Size = new System.Drawing.Size(100, 20);
            this.textBoxVillager.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Villagers";
            // 
            // textBoxTurn
            // 
            this.textBoxTurn.Location = new System.Drawing.Point(331, 12);
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.Size = new System.Drawing.Size(100, 20);
            this.textBoxTurn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turn";
            // 
            // labelBuildingWonder
            // 
            this.labelBuildingWonder.AutoSize = true;
            this.labelBuildingWonder.Location = new System.Drawing.Point(16, 81);
            this.labelBuildingWonder.Name = "labelBuildingWonder";
            this.labelBuildingWonder.Size = new System.Drawing.Size(85, 13);
            this.labelBuildingWonder.TabIndex = 6;
            this.labelBuildingWonder.Text = "Building Wonder";
            // 
            // textBoxBuildingWonder
            // 
            this.textBoxBuildingWonder.Location = new System.Drawing.Point(112, 73);
            this.textBoxBuildingWonder.Name = "textBoxBuildingWonder";
            this.textBoxBuildingWonder.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuildingWonder.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(96, 125);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 379);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxBuildingWonder);
            this.Controls.Add(this.labelBuildingWonder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVillager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVillager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBuildingWonder;
        private System.Windows.Forms.TextBox textBoxBuildingWonder;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

