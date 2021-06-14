using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int[] nums2 = { 2, 1, 4, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos=SearchInsert(nums,target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            int Lnum=LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5

            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ma);   
            Console.WriteLine();

            //Question 10
            // Console.WriteLine("Question 10");
            // int[] costs = { 10, 15, 20 };
            // int minCost=MinCostToClimb(costs);
            // Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            // Console.WriteLine();
        }

        //Question 1
        /// <summary>
        //Given two integer arrays nums1 and nums2, return an array of their intersection.
        //Each element in the result must be unique and you may return the result in any order.
        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [9,4]
        //
        /// </summary>

        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                
                int[] common = nums1.Intersect(nums2).ToArray();
                
                if (common.Length == 0)
                    Console.WriteLine("No intersection of numbers in array");
                else
                {
                    Console.Write(common[0]);
                    for (int i = 1; i < common.Length; i++)
                        Console.Write(", {0}", common[i]);
                    Console.Read();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //LOGIC: using inbulit function for intersection of two arrays
        ///if there are no common numbers between the arrays then the output would be "No intersection of numbers in array"
        ///SELF-REFLECTION: Usage of inbuilt fucntion to check intersection of two arrays

        //Question 2:
        /// <summary>
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //Note: You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        //Example 4:
        //Input: nums = [1, 3, 5, 6], target = 0
        //Output: 0
        /// </summary>

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                int left = 0;
                int right  = nums.Length - 1;
                int mid = 0;
                while (left <= right)
                {
                    mid = (left + right) / 2;
                    //comparing 
                    if (nums[mid] == target)
                        return mid;

                    else if (nums[mid] < target)
                        //increse begin value
                        left = mid + 1;

                    else
                        ////decrease stop value
                        right = mid - 1;
                }

                //returns the insert position
                return right + 1;
            }
            catch(Exception)
            {
                return -1;
                throw;
            }
        }
        ///LOGIC:initialize left , right, middle value. Comapring the middle value to target, if true we return the middle value.
        ///If false then we comapre if middle value is less than the target, if true return the left value, if false return the right value.
        ///SELF-REFLECTION: value comparision 

        //Question 3
        /// <summary>
        //Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
        //Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
        //Example 1:
        //Input: arr = [2, 2, 3, 4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        /// </summary>

        private static int LuckyNumber(int[] nums)
        {
            try
            {
                Dictionary<int, int> repeat = new Dictionary<int, int>();
                if (nums.Length >= 1)
                {
                    foreach (int i in nums)
                    {
                        if (i <= 500)
                        {
                            if (repeat.ContainsKey(i))
                                repeat[i]++;
                            else
                                repeat.Add(i, 1);
                        }
                        else
                            return -1;
                    }

                    int luckyvalue = -1;
                    foreach (var a in repeat.Keys)
                    {
                        if (a == repeat[a] && a > luckyvalue)
                            luckyvalue = a;
                    }

                    return luckyvalue;
                }
                else
                    return -1;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }
        ///LOGIC: checking if number is equal to  repeated value
        ///If the value is greater than previously stored value then we can return the actual number
        ///SELF-REFLECTION: Real challange in sorting and providing the lucky number though the use of dictionary

        //Question 4:
        /// <summary>
        //You are given an integer n.An array nums of length n + 1 is generated in the following way:
        //•	nums[0] = 0
        //•	nums[1] = 1
        //•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
        //•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
       // Return the maximum integer in the array nums.

        //Example 1:
        //Input: n = 7
        //Output: 3
        //Explanation: According to the given rules:
        //nums[0] = 0
        //nums[1] = 1
        //nums[(1 * 2) = 2] = nums[1] = 1
        //nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
        //nums[(2 * 2) = 4] = nums[2] = 1
        //nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
        //nums[(3 * 2) = 6] = nums[3] = 2
        //nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
        //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.

        /// </summary>
        private static int  GenerateNums(int n)
        {
            try
            {
                if (n >= 0 && n <= 500)
                {
                    int[] value = new int[n + 1];
                    value[0] = 0;
                    value[1] = 1;
                    int nlength = n / 2;
                    for (int i = 1; i <= nlength; i++)
                    {
                        if ((2 * i) < n + 1)
                            value[2 * i] = value[i];
                        if (((2 * i) + 1) < n + 1)
                            value[(2 * i) + 1] = value[i] + value[i + 1];
                    }
                    int maxvalue = value.Max();
                    return maxvalue;
                }
                else
                   return -1;

            }

            catch (Exception)
            {
                return -1;
                throw;
            }

        }
        ///LOGIC: Finding the largest value from the list of given values
        ///SELF-REFLECTION: Learnt a new logic altogether

        //Question 5
        /// <summary>
        //You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        //It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        //Example 1:
        //Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        //Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
        /// </summary>
        public static string DestCity(List<List<string>> paths)
        {
            try
            {
                List<string> cities = new List<string>();
                foreach (var city in paths)
                {
                    cities.Add(city[1]);
                }
                foreach (var destination in paths)
                {
                    if (cities.Contains(destination[0]))
                    {
                        cities.Remove(destination[0]);
                    }
                }
                return "";
            }
            
            catch (Exception)
            {

                throw;
            }
        }

        ///SELF-REFLECTION: working with the list and usage of inbuilt functions like Add/remove /contains

        //Question 6:
        /// <summary>
        //Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        //Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
        //You may not use the same element twice, there will be only one solution for a given array
        //Example 1:
        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        /// </summary>
        private static void targetSum(int[] nums,int target)
        {
            try
            {
                int start = 0;
                int end = nums.Length - 1;
                if (nums.Length >= 2 && nums.Length <= 3 * 104)
                {
                    while (start < end)
                    {
                        if (nums[start] > -1  && nums[end] > -1)
                        {
                            if ((nums[start] + nums[end]) < target)
                                start++;
                            else if ((nums[start] + nums[end]) > target)
                                end--;
                            else if ((nums[start] + nums[end]) == target)
                                break;
                        }
                        else
                            throw new Exception();
                    }
                    Console.WriteLine("{0},{1}", start + 1, end + 1);
                    Console.ReadLine();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
        ///LOGIC: working with ascending ordered list and indexes and breaking them into two halves. after that applying the logic of comparision.
        ///SELF-REFLCETION: Learnt new logic

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                List<int[]> score = new List<int[]>();
                List<int[,]> value = new List<int[,]>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    
                    score.Add(new int[] { items[i, 0], items[i, 1] });
                }
                //sorting the elements
                score.Sort((p, q) => { return (p[0] < q[0]) ? -1 : ((p[0] == q[0]) ? ((p[1] <= q[1]) ? 1 : -1) : 1); });
                int x = score[0][0];
                int index = 1;
                int sum = score[0][1];
                for (int i = 1; i < score.Count; i++)
                {
                    if (score[i][0] == x && index < 5)
                    {
                        sum += score[i][1];
                        index += 1;
                    }
                    else if (score[i][0] != x)
                    {

                        value.Add(new int[,] { { x, sum / 5 } });
                        Console.Write("[[" + x + "," + sum / 5 + "]" + ",");
                        x = score[i][0];
                        index = 1;
                        sum = score[i][1];
                    }
                }
                value.Add(new int[,] { { x, sum / 5 } });
                Console.Write("[" + x + "," + sum / 5 + "]]");
                Console.Write("\n");

            }
            catch (Exception)
            {

                throw;
            }
        }
        ///LOGIC: Adding the elements to list and then sorting the elements
        ///SELF-REFELECTION: Working with list arrays and use of inbuilt functions

        //Question 8
        /// <summary>
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Print the Final array after rotation.
        //Example 1:
        //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]
        //Example 2:
        //Input: nums = [-1,-100,3,99], k = 2
        //Output: [3,99,-1,-100]
        //Explanation: 
        //rotate 1 steps to the right: [99,-1,-100,3]
        //rotate 2 steps to the right: [3,99,-1,-100]
        /// </summary>

        private static void RotateArray(int[] arr,int n)
        {
            try
            {
                var loopvalue = 0;
                var currentvalue = 0;
                var current = arr[currentvalue];
                if (arr.Length >= 1 && n >= 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= -231 && arr[i] <= 230)
                        {
                            currentvalue = (currentvalue + n) % arr.Length;
                            var temp = arr[currentvalue];
                            arr[currentvalue] = current;
                            current = temp;

                            if (currentvalue == loopvalue)
                            {
                                currentvalue = (++loopvalue) % arr.Length;
                                current = arr[currentvalue];
                            }
                        }
                        else
                            throw new Exception();
                    }
                    Console.WriteLine(String.Join(",", arr));

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        ///LOGIC: Using the logic of temp value and replacing the original value to create a loop
      

        //Question 9
        /// <summary>
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum
        //Example 1:
        //Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Example 2:
        //Input: nums = [1]
        //Output: 1
       // Example 3:
       // Input: nums = [5,4,-1,7,8]
        //Output: 23
        /// </summary>

        private static int MaximumSum(int[] arr)
        {
            try
            {
                if (arr.Length >= 0 && arr.Length <= 30)
                {
                    var large1 = arr[0];
                    var large2 = arr[0];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= -1 && arr[i] <= 100)
                        {
                            large2 = Math.Max(arr[i], large2 + arr[i]);
                            large1 = Math.Max(large1, large2);
                        }
                        else
                            throw new Exception();
                    }
                    return large1;
                }
                else
                   return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}