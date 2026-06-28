namespace EmojiQuiz;

public partial class ResultForm : Form
{
    public ResultForm(int score, int total)
    {
        InitializeComponent();
        int percent = total > 0 ? score * 100 / total : 0;
        labelResult.Text = $"Правильных ответов: {score} из {total}\nРезультат: {percent}%";
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}