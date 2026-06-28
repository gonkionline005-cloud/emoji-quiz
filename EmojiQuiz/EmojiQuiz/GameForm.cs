namespace EmojiQuiz;

public partial class GameForm : Form
{
    static readonly Random rng = new();
    Question? current;
    int score = 0;
    int total = 0;
    int timeLeft = 15;
    string category = "";
    
    public GameForm(string cat = "")
    {
        InitializeComponent();
        category = cat;
        timer1.Interval = 1000;
        timer1.Start();
        NextQuestion();
    }
    
    void NextQuestion()
    {
        timeLeft = 15;
        labelTimer.Text = "Время: 15";
        
        current = Db.GetRandom(category);
        if (current == null) { labelEmoji.Text = "База пуста"; return; }

        labelEmoji.Text = current.Emoji;

        var options = Db.GetWrongAnswers(current.Answer, 3, category);
        options.Add(current.Answer);
        Shuffle(options);

        var buttons = new[] { button1, button2, button3, button4 };
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i < options.Count)
            {
                buttons[i].Text = options[i];
                buttons[i].Visible = true;
            }
            else
            {
                buttons[i].Visible = false;
            }
        }
    }

    void CheckAnswer(string chosen)
    {
        if (current == null) return;
        total++;
        if (chosen == current.Answer)
        {
            score++;
            labelResult.Text = "Верно";
        }
        else
        {
            labelResult.Text = "Неверно, это " + current.Answer;
        }
        labelScore.Text = "Счёт: " + score;
        NextQuestion();
    }

    void Shuffle(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }
    
    private void timer1_Tick(object sender, EventArgs e)
    {
        timeLeft--;
        labelTimer.Text = "Время: " + timeLeft;
        if (timeLeft <= 0)
        {
            labelResult.Text = "Время вышло!";
            NextQuestion();
        }
    }

    private void buttonFinish_Click(object sender, EventArgs e)
    {
        timer1.Stop();
        new ResultForm(score, total).ShowDialog();
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CheckAnswer(button1.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        CheckAnswer(button2.Text);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        CheckAnswer(button3.Text);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        CheckAnswer(button4.Text);
    }
}
