namespace FlexibleMethod
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
            this.textBoxVariableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateObject = new System.Windows.Forms.Button();
            this.comboBoxVariableList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMethodList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonViewMethods = new System.Windows.Forms.Button();
            this.buttonExecuteMethod = new System.Windows.Forms.Button();
            this.comboBoxInternalMethodList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddInternalMethod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.buttonGenCode = new System.Windows.Forms.Button();
            this.textBoxFunctionName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxVariableName
            // 
            this.textBoxVariableName.Location = new System.Drawing.Point(95, 16);
            this.textBoxVariableName.Name = "textBoxVariableName";
            this.textBoxVariableName.Size = new System.Drawing.Size(121, 20);
            this.textBoxVariableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variable Name";
            // 
            // buttonCreateObject
            // 
            this.buttonCreateObject.Location = new System.Drawing.Point(229, 19);
            this.buttonCreateObject.Name = "buttonCreateObject";
            this.buttonCreateObject.Size = new System.Drawing.Size(103, 23);
            this.buttonCreateObject.TabIndex = 2;
            this.buttonCreateObject.Text = "Create object";
            this.buttonCreateObject.UseVisualStyleBackColor = true;
            this.buttonCreateObject.Click += new System.EventHandler(this.buttonCreateObject_Click);
            // 
            // comboBoxVariableList
            // 
            this.comboBoxVariableList.FormattingEnabled = true;
            this.comboBoxVariableList.Location = new System.Drawing.Point(95, 80);
            this.comboBoxVariableList.Name = "comboBoxVariableList";
            this.comboBoxVariableList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariableList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Variable List";
            // 
            // comboBoxMethodList
            // 
            this.comboBoxMethodList.FormattingEnabled = true;
            this.comboBoxMethodList.Location = new System.Drawing.Point(95, 117);
            this.comboBoxMethodList.Name = "comboBoxMethodList";
            this.comboBoxMethodList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethodList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Method List";
            // 
            // buttonViewMethods
            // 
            this.buttonViewMethods.Location = new System.Drawing.Point(232, 80);
            this.buttonViewMethods.Name = "buttonViewMethods";
            this.buttonViewMethods.Size = new System.Drawing.Size(100, 23);
            this.buttonViewMethods.TabIndex = 7;
            this.buttonViewMethods.Text = "View Methods";
            this.buttonViewMethods.UseVisualStyleBackColor = true;
            this.buttonViewMethods.Click += new System.EventHandler(this.buttonViewMethods_Click);
            // 
            // buttonExecuteMethod
            // 
            this.buttonExecuteMethod.Location = new System.Drawing.Point(232, 117);
            this.buttonExecuteMethod.Name = "buttonExecuteMethod";
            this.buttonExecuteMethod.Size = new System.Drawing.Size(100, 23);
            this.buttonExecuteMethod.TabIndex = 8;
            this.buttonExecuteMethod.Text = "Execute Method";
            this.buttonExecuteMethod.UseVisualStyleBackColor = true;
            this.buttonExecuteMethod.Click += new System.EventHandler(this.buttonExecuteMethod_Click);
            // 
            // comboBoxInternalMethodList
            // 
            this.comboBoxInternalMethodList.FormattingEnabled = true;
            this.comboBoxInternalMethodList.Location = new System.Drawing.Point(115, 169);
            this.comboBoxInternalMethodList.Name = "comboBoxInternalMethodList";
            this.comboBoxInternalMethodList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInternalMethodList.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Internal Methods";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "External Methods";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            // 
            // buttonAddInternalMethod
            // 
            this.buttonAddInternalMethod.Location = new System.Drawing.Point(243, 169);
            this.buttonAddInternalMethod.Name = "buttonAddInternalMethod";
            this.buttonAddInternalMethod.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInternalMethod.TabIndex = 13;
            this.buttonAddInternalMethod.Text = "Add Method";
            this.buttonAddInternalMethod.UseVisualStyleBackColor = true;
            this.buttonAddInternalMethod.Click += new System.EventHandler(this.buttonAddInternalMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load Plugin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxScript
            // 
            this.textBoxScript.Location = new System.Drawing.Point(115, 256);
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.Size = new System.Drawing.Size(266, 108);
            this.textBoxScript.TabIndex = 15;
            // 
            // buttonGenCode
            // 
            this.buttonGenCode.Location = new System.Drawing.Point(19, 256);
            this.buttonGenCode.Name = "buttonGenCode";
            this.buttonGenCode.Size = new System.Drawing.Size(75, 39);
            this.buttonGenCode.TabIndex = 16;
            this.buttonGenCode.Text = "Generate Method";
            this.buttonGenCode.UseVisualStyleBackColor = true;
            this.buttonGenCode.Click += new System.EventHandler(this.buttonGenCode_Click);
            // 
            // textBoxFunctionName
            // 
            this.textBoxFunctionName.Location = new System.Drawing.Point(115, 230);
            this.textBoxFunctionName.Name = "textBoxFunctionName";
            this.textBoxFunctionName.Size = new System.Drawing.Size(203, 20);
            this.textBoxFunctionName.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 391);
            this.Controls.Add(this.textBoxFunctionName);
            this.Controls.Add(this.buttonGenCode);
            this.Controls.Add(this.textBoxScript);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddInternalMethod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxInternalMethodList);
            this.Controls.Add(this.buttonExecuteMethod);
            this.Controls.Add(this.buttonViewMethods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMethodList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxVariableList);
            this.Controls.Add(this.buttonCreateObject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVariableName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVariableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateObject;
        private System.Windows.Forms.ComboBox comboBoxVariableList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMethodList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonViewMethods;
        private System.Windows.Forms.Button buttonExecuteMethod;
        private System.Windows.Forms.ComboBox comboBoxInternalMethodList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddInternalMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Button buttonGenCode;
        private System.Windows.Forms.TextBox textBoxFunctionName;
    }
}

