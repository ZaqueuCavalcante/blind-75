int[] nums = new int[] { 45, 2, 7, 12, 15 };

int target = 47;
int[] result = Array.Empty<int>();

for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target) result = new int[] { i, j };
    }
}

Array.ForEach(result, Console.WriteLine);
