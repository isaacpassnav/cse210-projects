using System;
using System.Collections.Generic;

class ReflectionActivity : BaseActivity
{
    private List<string> _prompts;
    private List<string> _questions;
    private PromptManager _promptManager;

    public ReflectionActivity(string name, string description):base(name,description)
    {
        this._prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _promptManager = new PromptManager(_prompts);

        this._questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different from other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
    public override void StartActivity()
    {
        ShowStartMessage();
        
        string selectedPrompt = _promptManager.GetRandomPrompt(); 
        Console.WriteLine($"\nPrompt: {selectedPrompt}");
        PauseWithAnimation(5);

        int timeElapsed =0;

        while(timeElapsed < _duration)
        {
            Random random = new Random();
            string selectedQuestion = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"\nQuestion: {selectedQuestion}");
            PauseWithAnimation(5);
            timeElapsed += 5;
        }
        ShowEndMessage();
    }
}