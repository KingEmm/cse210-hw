// I fetched scripture from "https://api.nephi.org/scriptures/" 

using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static void HideRandoms(Scripture scripture, int len)
    {
        string[] words = scripture.GetDisplayText().Split(' ');
        List<int> li= new List<int>();
        for(int i=0; i<words.Count(); i++)
        {
            if (!words[i].Contains('_'))
            {
                li.Add(i);
            }
        }
        double lleen = len/3;

        double llen = Math.Ceiling(lleen);

        for(var i=0; llen > i; i++)
            {
                Random random = new Random();
                int rand = random.Next(0,li.Count());
                // if(IsCompletelyHidden())
                if (!scripture.IsCompletelyHidden())
                {
                    scripture.HideRandomWords(li[rand]);
                }
            }
        
    }
    static async Task Main()
    {
        string url = "https://api.nephi.org/scriptures/?q=";
        Console.Write("Enter Scripture Passage You want to memorize eg: '1 nephi 1:1-5' : ");
        string scriptureVerse = Console.ReadLine();
        string[] scriptversse = scriptureVerse.Split(' ', ':', '-');

        Reference reff;

        if (scriptversse.Count() == 3)
        {
            reff = new Reference(scriptversse[0], int.Parse(scriptversse[1]), int.Parse(scriptversse[2]));
            if (scriptversse[0].Contains('&'))
            {
                scriptversse[0].Replace("&","%26");
            }
            url=$"{url}{scriptversse[0]}+{int.Parse(scriptversse[1])}:{int.Parse(scriptversse[2])}";
        }
        else if (scriptversse.Count() == 4)
        {
            try
            {
                reff = new Reference(scriptversse[0], int.Parse(scriptversse[1]), int.Parse(scriptversse[2]), int.Parse(scriptversse[3]));
                if (scriptversse[0].Contains('&'))
                {
                    scriptversse[0].Replace("&","%26");
                }
                url=$"{url}{scriptversse[0]}+{int.Parse(scriptversse[1])}:{int.Parse(scriptversse[2])}-{int.Parse(scriptversse[3])}";
            }
            catch (System.FormatException)
            {
                reff = new Reference(scriptversse[0]+scriptversse[1], int.Parse(scriptversse[2]), int.Parse(scriptversse[3]));
                if (scriptversse[0].Contains('&'))
                {
                    scriptversse[0].Replace("&","%26");
                }
                url=$"{url}{scriptversse[0]}+{scriptversse[1]}+{int.Parse(scriptversse[2])}:{int.Parse(scriptversse[3])}";
            }
        }
        else if (scriptversse.Count() == 5)
        {
            reff = new Reference(scriptversse[0]+scriptversse[1], int.Parse(scriptversse[2]), int.Parse(scriptversse[3]), int.Parse(scriptversse[4]));
            if (scriptversse[0].Contains('&'))
            {
                scriptversse[0].Replace("&","%26");
            }
            url=$"{url}{scriptversse[0]}+{(scriptversse[1])}+{int.Parse(scriptversse[2])}:{int.Parse(scriptversse[3])}-{int.Parse(scriptversse[4])}";
        }
        else
        {
            reff = new Reference("alma", 37,38);
            Console.WriteLine("Invalid way of Entering.");
            await Main();
        }

        try
        {
            var response = await new HttpClient().GetAsync(url);
            string data = await response.Content.ReadAsStringAsync();
            var jsonData = JsonDocument.Parse(data);
            var verse = jsonData.RootElement.GetProperty("scriptures");
            
            // string word = verse.EnumerateArray().First().GetProperty("text").GetString();
            var texts = verse.EnumerateArray().Select(s => s.GetProperty("text").GetString());

            string word="";
            foreach(string text in texts)
            {
                word = $"{word} \n{text}";
            }

            // string word = "If you have a birthday shout Hooray";
            int len = word.Split(' ').Count();

            // Reference alma = new Reference("alma", 37,38);

            Scripture scripture = new Scripture(reff, word);

            string ans="";

            Console.Clear();
            while(ans.ToLower() != "quit")
            {
                Console.Clear();
                Console.WriteLine(reff.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                ans = Console.ReadLine();

                ans = ans.ToLower().TrimStart();
                // Console.WriteLine(ans);

                if(ans == "")
                {
                    if (scripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("Hidden Completelly !!");
                        Console.Write("Would you love to memorise another one (y/n) ");
                        ans = Console.ReadLine();
                        if (ans.ToLower()=="y" | ans.ToLower() == "yes")
                        {
                            await Main();
                        }
                        else if(ans.ToLower()=="no" | ans.ToLower() == "n")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input !!!");
                            await Main();
                        }
                    }
                    HideRandoms(scripture, len-1);
                }
                else if(ans == "quit")
                    ans = ans.ToLower();
                else
                    Console.WriteLine("Invalid input Only Enter ");
                
            }

        }
        catch (System.Net.Http.HttpRequestException)
        {
            Console.WriteLine("Can't Connect to the Internet.");
            Thread.Sleep(10000);
            await Main();
        }
        catch (System.InvalidOperationException)
        {
            Console.WriteLine("Invalid Url Format");
        }
        // Console.WriteLine(data);
        // var JsonData = JsonDocument.Parse(verse.GetProperty());

        // HideRandoms(scripture, len);
        // scripture.HideRandomWords(30);
        // scripture.HideRandomWords(0);
    }
}