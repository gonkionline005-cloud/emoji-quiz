namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        string cat = comboCategory.SelectedItem?.ToString() ?? "";
        new GameForm(cat).ShowDialog();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog();
    }
}