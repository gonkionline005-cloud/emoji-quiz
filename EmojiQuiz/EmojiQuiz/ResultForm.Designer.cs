using System.ComponentModel;

namespace EmojiQuiz;

partial class ResultForm
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
        labelResult = new System.Windows.Forms.Label();
        buttonBack = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // labelResult
        // 
        labelResult.Location = new System.Drawing.Point(79, 34);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(267, 53);
        labelResult.TabIndex = 0;
        // 
        // buttonBack
        // 
        buttonBack.Location = new System.Drawing.Point(97, 157);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new System.Drawing.Size(229, 53);
        buttonBack.TabIndex = 1;
        buttonBack.Text = "В меню";
        buttonBack.UseVisualStyleBackColor = true;
        buttonBack.Click += buttonBack_Click;
        // 
        // ResultForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(420, 262);
        Controls.Add(buttonBack);
        Controls.Add(labelResult);
        Text = "ResultForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Button buttonBack;

    #endregion
}