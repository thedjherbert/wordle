using Microsoft.AspNetCore.Components;

namespace Wordle;

public class WordleClass {
    public string Content { get; set; }
    public Random Random { get; set; } = new Random();
    public int GenNumber { get; set; }
    public string[] Lines { get; set; } = new string[]{};
    public string Word { get; set; }
    public string[,] Letters { get; set; } = new string[6, 5];
    public ElementReference[,] InputRef { get; set; } = new ElementReference[6,5];
    public string[,] BgColour { get; set; } = new string[6, 5];

    public int CurrentRow { get; set; } = 0;

}