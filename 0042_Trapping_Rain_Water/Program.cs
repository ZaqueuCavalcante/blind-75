int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1, };

int[] maxLeft = new int[height.Length];
int[] maxRight = new int[height.Length];
int[] top = new int[height.Length];

var max = 0;
for (int i = 0; i < height.Length; i++)
{
    maxLeft[i] = max;
    if (height[i] > max) max = height[i];
}

max = 0;
for (int i = height.Length - 1; i > 0; i--)
{
    maxRight[i] = max;
    if (height[i] > max) max = height[i];
}

for (int i = 0; i < height.Length; i++)
{
    var water = Math.Min(maxLeft[i], maxRight[i]) - height[i];
    top[i] = water < 0 ? 0 : water;
}

Console.WriteLine(top.Sum());
