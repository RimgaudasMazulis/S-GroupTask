namespace S_GroupTask
{
    public static class ParseHelper
    {
        public static int[] ParseNumbers(string content)
        {
            return content
                .Split(',')
                .Select(str => int.TryParse(str, out int num) ? num : -1)
                .Where(num => num >= 0)
                .ToArray();
        }
    }
}
