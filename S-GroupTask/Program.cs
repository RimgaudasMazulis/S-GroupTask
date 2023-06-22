namespace S_GroupTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Data/Numbers.txt";

            try
            {
                string fileContent = File.ReadAllText(filePath);
                int[] numbers = ParseHelper.ParseNumbers(fileContent);

                if (numbers.Length > 0)
                {
                    Console.WriteLine($"Sum of numbers: {Algorithm.CalculateSum(numbers)}.");
                    Console.WriteLine($"Sum of even numbers: {Algorithm.CalculateSumEven(numbers)}.");
                }
                else
                {
                    Console.WriteLine("No numbers found in the file.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}