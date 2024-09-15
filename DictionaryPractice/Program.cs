// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections;

int[] input = new int[]{2,4,6,1,4,7};
int target = 9;

var pairs = FindPairs(input, target);
foreach(var pair in pairs){
    Console.WriteLine($"Pair: {pair[0]}, {pair[1]}");
}
IList<IList<int>> FindPairs(int[] nums, int target){
    IList<IList<int>> result = new List<IList<int>>();
    HashSet<int> seenNumbers = new HashSet<int>();

    foreach (var num in nums){
        int complement = target - num;
        if(seenNumbers.Contains(complement)){
            result.Add(new List<int> {complement, num});
        }
        seenNumbers.Add(num);
    }
    return result;
}
