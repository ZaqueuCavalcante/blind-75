int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1, };

var maxArea = 0;
var bestStart = 0;
var bestEnd = 0;

for (int i = 0; i < height.Length - 1; i++)
{
    for (int j = height.Length - 1; j > i; j--)
    {
        var h = height[i] > height[j] ? height[j] : height[i];
        var area = (j - i) * h;
        if (area > maxArea)
        {
            bestStart = i;
            bestEnd = j;
            maxArea = area;
        }
        if (height[j] >= height[i])
        {
            j = i;
        }
    }
}

Console.WriteLine($"bestStart={bestStart} -- bestEnd={bestEnd} -- maxArea={maxArea}");
