ublic class Solution {
    public List<string> FizzBuzz(int n) {
        List<string> fizzbuzzes = new List<string>();

        for (int i = 1; i <= n; i++){
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                fizzbuzzes.Add("FizzBuzz");
            } else if (i % 3 == 0) 
            {
                fizzbuzzes.Add("Fizz");
            } else if (i % 5 == 0) 
            {
                fizzbuzzes.Add("Buzz");
            }
            else
            {
                fizzbuzzes.Add(i.ToString());
            }
        }

        return fizzbuzzes;
    }
}