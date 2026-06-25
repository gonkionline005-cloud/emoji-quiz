namespace EmojiQuiz;

partial class MainForm
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
        buttonPlay = new System.Windows.Forms.Button();
        buttonAdmin = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // buttonPlay
        // 
        buttonPlay.Location = new System.Drawing.Point(98, 74);
        buttonPlay.Name = "buttonPlay";
        buttonPlay.Size = new System.Drawing.Size(215, 45);
        buttonPlay.TabIndex = 0;
        buttonPlay.Text = "Играть";
        buttonPlay.UseVisualStyleBackColor = true;
        buttonPlay.Click += buttonPlay_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.Location = new System.Drawing.Point(98, 185);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(215, 46);
        buttonAdmin.TabIndex = 1;
        buttonAdmin.Text = "Администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(400, 307);
        Controls.Add(buttonAdmin);
        Controls.Add(buttonPlay);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonPlay;
    private System.Windows.Forms.Button buttonAdmin;

    #endregion
}