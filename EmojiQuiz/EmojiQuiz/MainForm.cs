namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
            var q = Db.GetRandom();
            if (q != null) labelEmoji.Text = q.Emoji;
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        new GameForm().Show();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().Show();
    }
}