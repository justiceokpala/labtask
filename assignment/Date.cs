namespace DateTest{
public class Date
{
  public string Month{get; set;}
   public int Day{get; set;}
  public int Year{get; set;}

  // Create a class constructor with multiple parameters
  public Date(string month, int day, int year)
  {
    Month = month;
    Day = day;
    Year = year;
  }

   public void DisplayDate(){
   System.Console.WriteLine($"{Month}/{Day}/{Year}");
   }
}
 

}