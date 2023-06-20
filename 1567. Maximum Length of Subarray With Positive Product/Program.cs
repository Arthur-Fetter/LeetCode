public class Solution
{
    public int GetMaxLen(int[] nums)
    {
        int max_count = 0;
        int count = 0;
        int count_negative = 0;

        List<int> negative_occourences = new List<int>();
        int starting_index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (count_negative % 2 == 0)
                {
                    max_count = Math.Max(max_count, count);
                }
                else
                {
                    count = Math.Max((count - (negative_occourences[0] + 1 - starting_index)),
                    (negative_occourences[negative_occourences.Count - 1] - starting_index));

                    max_count = Math.Max(count, max_count);
                }

                negative_occourences.Clear();
                count = 0;
                count_negative = 0;
                starting_index = i + 1;
            }
            else if (nums[i] < 0)
            {
                count++;
                count_negative++;

                negative_occourences.Add(i);
            }
            else
            {
                count++;
            }
        }

        if (count_negative % 2 == 0)
        {
            max_count = Math.Max(max_count, count);
        }
        else
        {
            count = Math.Max((count - (negative_occourences[0] + 1 - starting_index)),
            (negative_occourences[negative_occourences.Count - 1] - starting_index));

            max_count = Math.Max(count, max_count);
        }

        return max_count;
    }
}