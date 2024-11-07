int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int minimum = nums.Min(); // returns 10
int maximum = nums.Max(); // returns 523863
int maxValue = nums.Where(x => x < 10000).Max(); // "where" pulls the numbers greater than 10000, then gives the maximum
int[] firstValues = nums.Where(x => x > 10 && x < 100).ToArray();
int[] nextValues = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
int count = nums.Count(x => x % 2 == 0); // counts all values that are even

// Explain the difference between LINQ query syntax and lambda syntax:

// Query syntax will obtain the requested data from a collection that fits the specified criteria, while lambda syntax will iterate through the entire collection of data
// and put each element within a variable (such as x). It will then compare the values within the variable to the criteria and add it to the return collection if it meets
// the criteria. Both query and lambda syntax will provide the same result when executed, however, lambda syntax is typically much more concise.
