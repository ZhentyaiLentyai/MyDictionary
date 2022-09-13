namespace DictionaryLib
{
    public class Dictionary
    {
        public static void Search(Dictionary<int, string> numbers)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (!numbers.ContainsKey(key))
            {
                Console.WriteLine("No key");
            }
            else
            {
                Console.WriteLine($"Key: {key}, values: {SearchKey(numbers, key)}");
            }
        }
        public static string SearchKey(Dictionary<int, string> numbers, int key)
        {
            return numbers[key];
        }
    }
}