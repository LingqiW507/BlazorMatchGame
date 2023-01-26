// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/Pages/Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Users/maggieweng/Desktop/dgm 6308/projects/BlazorMatchGameFinal/BlazorMatchGame/Pages/Index.razor"
      

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
    //create a list of eight pairs to hide all the emoji.
    List<string> hiddenEmoji = new List<string>()
{
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
        "🚩","🚩",
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
        tenthsOfSecondsElapsed = 450; //Set up the time:45s

        //reset the hidden emoji. Let it get back to the beginning
        for (int h = 0; h < hiddenEmoji.Count; h++)
        {
            hiddenEmoji[h] = "🚩";
        }
    }
    //the end of a method the sets up the game


    string lastAnimalFound = string.Empty;
    string lastDescription = string.Empty;
    int firstSelected;
    int lastSelected;

    private void ButtonClick(string animal, string animalDescription, int index)
    {
        if ((lastAnimalFound == string.Empty) && (hiddenEmoji[index] != string.Empty))
        {
            if (hiddenEmoji[firstSelected] != string.Empty)
            {
                hiddenEmoji[firstSelected] = "🚩";
                hiddenEmoji[lastSelected] = "🚩";
            }

            //First selection of the pair. Remember it.
            lastAnimalFound = animal;
            lastDescription = animalDescription;
            firstSelected = index; // Record the first clicked button's index

            hiddenEmoji[index] = animal;

            timer.Start();
        }

        else if ((lastAnimalFound == animal) && (animalDescription != lastDescription) && (hiddenEmoji[index] != string.Empty))
        {
            //Match found! Reset for next pair.
            lastAnimalFound = string.Empty;
            hiddenEmoji[index] = animal;
            //Replace found animals with empty string to hide them.
            hiddenEmoji = hiddenEmoji
            .Select(a => a.Replace(animal, string.Empty))
            .ToList();

            matchesFound++;
            scoreDisplay += 100;// 1 pair of emojis found get 1(and I want to let 1 pair worth 100point I don't know where can I put and How to do multiplication)

            if (matchesFound == 8)
            {
                timer.Stop();
                timeDisplay += " - Play Again?";


                SetUpGame();
            }
        }
        else if (hiddenEmoji[index] != string.Empty)
        {

            //User selected a pair that don't match.
            //Reset selection.
            lastAnimalFound = string.Empty;
            lastSelected = index;
            hiddenEmoji[index] = animal;

        }

    }
    private void Timer_Tick(Object source, ElapsedEventArgs e)
    {
        InvokeAsync(() =>
        {//let the time countdown
            tenthsOfSecondsElapsed--;
            timeDisplay = (tenthsOfSecondsElapsed / 10F)
                .ToString("0.0s");
            if (tenthsOfSecondsElapsed <= 0)
            {
                timer.Stop();
                timeDisplay = "0.0s - You lost!";
                lastAnimalFound = string.Empty;
                SetUpGame();
            }

            StateHasChanged();
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
