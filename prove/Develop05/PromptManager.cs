class PromptManager
{
    private List<string> _prompts;
    private List<string> _usedPrompts;
    public PromptManager(List<string> prompts)
    {
        this._prompts = prompts;
        this._usedPrompts = new List<string>();
    }
    public string GetRandomPrompt()
    {
        if(_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];

        _prompts.RemoveAt(index);
        _usedPrompts.Add(selectedPrompt);

        return selectedPrompt;
    }
}