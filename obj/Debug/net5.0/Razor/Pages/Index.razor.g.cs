#pragma checksum "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7510cd4c59cdfc01b6652db3efb381d85f0aa24f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .container {\n        width: 400px;\n    }\n\n    button {\n        width: 100px;\n        height: 100px;\n        font-size: 50px;\n    }\n</style>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "<div class=\"row\"><h4>Select a difficulty:</h4></div>\n    \n   \n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
#nullable restore
#line 22 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
         for (var animalNumber = 0; animalNumber < shuffledAnimals.Count; animalNumber++)
        {
            var animal = shuffledAnimals[animalNumber];
            var uniqueDescription = $"Button #{animalNumber}";

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                                    () => ButtonClick(animal, uniqueDescription)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "class", "btn-outline-dark");
            __builder.OpenElement(12, "h1");
            __builder.AddContent(13, 
#nullable restore
#line 29 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                         animal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "h2");
            __builder.AddContent(18, "Matches found: ");
            __builder.AddContent(19, 
#nullable restore
#line 35 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                            matchesFound

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row");
            __builder.OpenElement(23, "h2");
            __builder.AddContent(24, "Time: ");
            __builder.AddContent(25, 
#nullable restore
#line 38 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                   timeDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "h2");
            __builder.AddContent(30, "Scores: ");
            __builder.AddContent(31, 
#nullable restore
#line 41 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                     scoreDisplay

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
      
    List<string> difficultyLevel = new List<string>()
    {
            "Easy",
            "Medium",
            "Hard",

        };
    //create a list of eight pairs of emoji.
    List<string> animalEmoji = new List<string>()
{
        "🦊","🦊",
        "🐸","🐸",
        "🐏","🐏",
        "🐺","🐺",
        "🦉","🦉",
        "🐰","🐰",
        "🐯","🐯",
        "🐶","🐶",
    };

    //create a second list to store the shuffled emoji.
    List<string> shuffledAnimals = new List<string>();
    int matchesFound = 0;
    Timer timer;
    int tenthsOfSecondsElapsed = 0;
    string timeDisplay;
    int scoreDisplay = 0;

    //set up the game every time the page is reload.
    protected override void OnInitialized()
    {
        timer = new Timer(100);
        timer.Elapsed += Timer_Tick;

        SetUpGame();
    }

    //the beginning of a method that sets up the game.
    private void SetUpGame()
    {
        //create a new random generator.
        Random random = new Random();
        //create copies of the animal emoji, shuffled them,and store them in the shuffledAnimals list.
        shuffledAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .ToList();

        matchesFound = 0;
        tenthsOfSecondsElapsed = 0;
        scoreDisplay = matchesFound *100;
    }
    //the end of a method the sets up the game


    string lastAnimalFound = string.Empty;
    string lastDescription = string.Empty;

    private void ButtonClick(string animal, string animalDescription)
    {
        if (lastAnimalFound == string.Empty)
        {
            //First selection of the pair. Remember it.
            lastAnimalFound = animal;
            lastDescription = animalDescription;

            timer.Start();
        }
        else if ((lastAnimalFound == animal) && (animalDescription != lastDescription))
        {
            //Match found! Reset for next pair.
            lastAnimalFound = string.Empty;

            //Replace found animals with empty string to hide them.
            shuffledAnimals = shuffledAnimals
                .Select(a => a.Replace(animal, string.Empty))
                .ToList();

            matchesFound++;
            scoreDisplay++;

            if (matchesFound == 8)
            {
                timer.Stop();
                timeDisplay += " - Play Again?";
                SetUpGame();
            }
        }
        else
        {

            //User selected a pair that don't match.
            //Reset selection.
            lastAnimalFound = string.Empty;

        }

    }
    private void Timer_Tick(Object source, ElapsedEventArgs e)
    {
        InvokeAsync(() =>
        {
            tenthsOfSecondsElapsed++;
            timeDisplay = (tenthsOfSecondsElapsed / 10F)
                .ToString("0.0s");
            StateHasChanged();
        });
    }
    /******* 
    Change this game become a memorized game.
    Set up a button to start the game
    At the first two second player can saw all the emoji.
    Then, these emojis should be invisible.
    Players need to use their memory to find the corresponding pairing.******/

    /***********
    -------------------------------- For REQUIREMENT A --------------------------------------
    Get 100 pts when the player find a pair;
    Easy: There is only one chance. The game ends when the player chooses the wrong pair for the second time.
    Medium: There are three chances, The game ends when the player chooses the wrong pair for the fourth time.
    Hard: There are Five chances, The game ends when the player chooses the wrong pair for the sixth time.
                                                                                                            ***********/


    /***********
    -------------------------------- For REQUIREMENT B --------------------------------------
    I will set up this matching game in three difficulties: Easy, Medium and Hard.
    Player can click a button before they start the game. 
    Easy: 4pairs
    "🦊","🦊",
    "🐸","🐸",
    "🐏","🐏",
    "🐺","🐺".
    Medium: 8pairs
    "🦊","🦊",
    "🐸","🐸",
    "🐏","🐏",
    "🐺","🐺",
    "🦉","🦉",
    "🐰","🐰",
    "🐯","🐯",
    "🐶","🐶".
    Hard: 16pairs
    "🦊","🦊","🐭","🐭",
    "🐸","🐸","🦁","🦁",
    "🐺","🐺","🐷","🐷",
    "🐰","🐰","🦋","🦋",
    "🐶","🐶","🐼","🐼",
    "🐏","🐏","🐤","🐤",
    "🦉","🦉","🐵","🐵",
    "🐯","🐯","🐹","🐹".
                                                                                                                 ******/
    /**********
    -------------------------------- For REQUIREMENT C --------------------------------------
    Make the game timer count down instead of up. If the timer reaches 0 before all matches are made, the player loses.
    Add a variable to keep track of the shortest time to complete all matches
                                                                                                              *********/

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
