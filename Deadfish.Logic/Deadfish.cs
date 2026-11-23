using System.Diagnostics.Metrics;

namespace Deadfish.Logic;

public class Deadfish
{
  int counter = 0;
  public static int[] Parse(string input)
  {
    var fish = new Deadfish();
    return fish.Interpret(input);

    
  }
  public int[] Interpret(string input)
  {
    while(input[0] == 'i')
    {
      counter++;
      input = input.Substring(1);
    }

    return [counter];
  }
}
