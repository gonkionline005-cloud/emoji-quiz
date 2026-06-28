namespace EmojiQuiz;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji  = textEmoji.Text.Trim();
        string answer = textAnswer.Text.Trim();
        string cat    = textCategory.Text.Trim();

        if (emoji == "" || answer == "")
        {
            MessageBox.Show("Заполните эмодзи и ответ.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (Db.Exists(answer))
        {
            MessageBox.Show("Такой ответ уже есть в базе.", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Db.Add(emoji, answer, cat);
        MessageBox.Show("Добавлено!", "Успех",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        textEmoji.Clear();
        textAnswer.Clear();
        textCategory.Clear();

    }
}