namespace Homwork;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        button1 = new System.Windows.Forms.Button();
        checkBox1 = new System.Windows.Forms.CheckBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        checkBox2 = new System.Windows.Forms.CheckBox();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(476, 151);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(123, 33);
        button1.TabIndex = 0;
        button1.Text = "Порахувати";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click_1;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(197, 216);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(104, 24);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(206, 114);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(58, 28);
        label1.TabIndex = 3;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(432, 263);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(59, 32);
        label2.TabIndex = 4;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(590, 58);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(98, 30);
        label3.TabIndex = 5;
        label3.Text = "label3";
        // 
        // checkBox2
        // 
        checkBox2.Location = new System.Drawing.Point(58, 136);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(104, 24);
        checkBox2.TabIndex = 6;
        checkBox2.Text = "checkBox2";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(63, 282);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(100, 27);
        textBox1.TabIndex = 7;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(411, 334);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(188, 27);
        textBox2.TabIndex = 8;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(387, 57);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 9;
        label4.Text = "label4";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label4);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(checkBox2);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(checkBox1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox checkBox1;

    #endregion
}