using System.Collections.Generic;

class PromptGenerator{
    public List<string> _prompts = new List<string>{
        "Who made me smile today and why?",
        "What did I learn from a conversation I had today?",
        "What is one thing I want to remember about today five years from now?",
        "What was a challenge I faced today and how did I handle it?",
        "When did I feel at peace today, even if things were busy?",
    };

    public string GetRandomPrompt(){
        Random randomNumGenerator = new Random();
        int randomNumber = randomNumGenerator.Next(0,4);
        return _prompts[randomNumber]; 
    }

}