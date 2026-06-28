using System.ComponentModel;

namespace EmojiQuiz;

partial class GameForm
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
        components = new System.ComponentModel.Container();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        labelEmoji = new System.Windows.Forms.Label();
        labelScore = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        labelTimer = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(65, 236);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(178, 42);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(303, 236);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(173, 42);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(65, 305);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(177, 45);
        button3.TabIndex = 2;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(303, 305);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(172, 44);
        button4.TabIndex = 3;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // labelEmoji
        // 
        labelEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelEmoji.Location = new System.Drawing.Point(75, 29);
        labelEmoji.Name = "labelEmoji";
        labelEmoji.Size = new System.Drawing.Size(384, 74);
        labelEmoji.TabIndex = 4;
        labelEmoji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelScore
        // 
        labelScore.Location = new System.Drawing.Point(63, 150);
        labelScore.Name = "labelScore";
        labelScore.Size = new System.Drawing.Size(179, 29);
        labelScore.TabIndex = 5;
        labelScore.Text = "Счёт: 0";
        // 
        // labelResult
        // 
        labelResult.Location = new System.Drawing.Point(325, 150);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(171, 29);
        labelResult.TabIndex = 6;
        // 
        // timer1
        // 
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // labelTimer
        // 
        labelTimer.Location = new System.Drawing.Point(67, 190);
        labelTimer.Name = "labelTimer";
        labelTimer.Size = new System.Drawing.Size(236, 23);
        labelTimer.TabIndex = 7;
        labelTimer.Text = "label1";
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(564, 378);
        Controls.Add(labelTimer);
        Controls.Add(labelResult);
        Controls.Add(labelScore);
        Controls.Add(labelEmoji);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "GameForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelTimer;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label labelScore;

    private System.Windows.Forms.Label labelEmoji;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion
}