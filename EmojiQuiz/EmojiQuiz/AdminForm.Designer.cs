using System.ComponentModel;

namespace EmojiQuiz;

partial class AdminForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        textEmoji = new System.Windows.Forms.TextBox();
        textAnswer = new System.Windows.Forms.TextBox();
        textCategory = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        buttonAdd = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(203, 57);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(265, 23);
        textEmoji.TabIndex = 0;
        // 
        //  textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(203, 117);
        textAnswer.Name = " textAnswer";
        textAnswer.Size = new System.Drawing.Size(265, 23);
        textAnswer.TabIndex = 1;
        // 
        // textCategory
        // 
        textCategory.Location = new System.Drawing.Point(203, 178);
        textCategory.Name = "textCategory";
        textCategory.Size = new System.Drawing.Size(265, 23);
        textCategory.TabIndex = 2;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(80, 57);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(109, 22);
        label1.TabIndex = 3;
        label1.Text = "Эмодзи:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(80, 120);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(107, 23);
        label2.TabIndex = 4;
        label2.Text = "Ответ:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(82, 178);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(107, 23);
        label3.TabIndex = 5;
        label3.Text = "Категория:";
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(162, 237);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(270, 35);
        buttonAdd.TabIndex = 6;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(568, 325);
        Controls.Add(buttonAdd);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textCategory);
        Controls.Add(textAnswer);
        Controls.Add(textEmoji);
        Text = "AdminForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textEmoji;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textAnswer;
    private System.Windows.Forms.TextBox textCategory;

    #endregion
}