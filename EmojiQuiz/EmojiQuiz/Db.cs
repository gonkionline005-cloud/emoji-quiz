using Microsoft.EntityFrameworkCore;

namespace EmojiQuiz;

static class Db
{
    public static void EnsureCreated()
    {
        using var ctx = new QuizContext();
        ctx.Database.EnsureCreated();
    }

    public static int Count()
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Count();
    }
    
    public static bool Exists(string answer)
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Any(q => q.Answer == answer);
    }


    public static void Add(string emoji, string answer, string category)
    {
        using var ctx = new QuizContext();
        ctx.Questions.Add(new Question { Emoji = emoji, Answer = answer, Category = category ?? "" });
        ctx.SaveChanges();
    }

    public static Question? GetRandom(string cat = "")
    {
        using var ctx = new QuizContext();
        var q = ctx.Questions.AsQueryable();
        if (cat != "") q = q.Where(x => x.Category == cat);
        return q.OrderBy(x => EF.Functions.Random()).FirstOrDefault();
    }

    public static List<string> GetWrongAnswers(string correct, int count, string cat = "")
    {
        using var ctx = new QuizContext();
        var q = ctx.Questions.Where(x => x.Answer != correct);
        if (cat != "") q = q.Where(x => x.Category == cat);
        return q.OrderBy(x => EF.Functions.Random())
            .Select(x => x.Answer)
            .Take(count)
            .ToList();
    }


    public static void SeedFromFile(string path)
    {
        if (Count() > 0) return;
        foreach (var line in File.ReadLines(path).Skip(1))
        {
            var parts = line.Split('\t');
            if (parts.Length >= 3)
                Add(parts[2], parts[1], "Фильмы");
        }
    }
}