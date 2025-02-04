public class StringVii
{


// i and j are start-end indexes used to extract a substring from input 's'.
/*conditions to throw error
i or j < 0
i or j >= string.Length
*/

    public string SubString(string s, int i, int j)
  {
      string result;
      try
      {
          int inputLength = s.Length;
          if (i < 0 || j < 0 || i >= inputLength || j >= inputLength)
              throw new Exception();
              
          //write var to assign startIndex
          int startIndex = i < j? i : j;
          int substringLength = Math.Abs(j-i)+1; 
          result = s.Substring(startIndex, substringLength);
      }
      catch (Exception e)
      {
          return "<error>";
      }
      return result;
  }
}