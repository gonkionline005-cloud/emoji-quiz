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
        comboCategory = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // buttonPlay
        // 
        buttonPlay.Location = new System.Drawing.Point(67, 84);
        buttonPlay.Name = "buttonPlay";
        buttonPlay.Size = new System.Drawing.Size(215, 45);
        buttonPlay.TabIndex = 0;
        buttonPlay.Text = "Играть";
        buttonPlay.UseVisualStyleBackColor = true;
        buttonPlay.Click += buttonPlay_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.Location = new System.Drawing.Point(67, 154);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(215, 46);
        buttonAdmin.TabIndex = 1;
        buttonAdmin.Text = "Администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // comboCategory
        // 
        comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboCategory.FormattingEnabled = true;
        comboCategory.Items.AddRange(new object[] { "Фильмы", "Сериалы", "Бренды" });
        comboCategory.Location = new System.Drawing.Point(69, 33);
        comboCategory.Name = "comboCategory";
        comboCategory.Size = new System.Drawing.Size(213, 23);
        comboCategory.TabIndex = 2;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(359, 221);
        Controls.Add(comboCategory);
        Controls.Add(buttonAdmin);
        Controls.Add(buttonPlay);
        Text = "EmojiQuiz";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox comboCategory;

    private System.Windows.Forms.Button buttonPlay;
    private System.Windows.Forms.Button buttonAdmin;

    #endregion
}