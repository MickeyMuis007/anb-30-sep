using System;
using System.Diagnostics;
using System.Threading;

namespace Test
{
    class Program
    {
        /*
        Test 1 
        Fix the code for Test1
        Expected output 
                    #
                   ##
                  ###
                 ####
                #####

        Test 2

        Improve the algorithm for test 1
        Show execution times

        Test 3 Expected output 
        Validate if a sentence is a palindrome
            Eg.    step on no pets
                   Hi my name is Bob

        Test 4 Expected output 
        The total meters between two latitude and longitude points
            Eg.    point 1 =  -33.93758083398224, 18.85560933777421 
                   point 2 =  -34.101290896639355, 18.853087865159306
                   Result  = 18204.335806567509 m

        */
        static void Main(string[] args)
        {
            runTest1and2(5);  
            runTest3("step on no pets"); 
            runTest3("Hi my name is Bob"); 

            Point point1 = new Point() { Latitude = -33.93758083398224, Longitude = 18.85560933777421};
            Point point2 = new Point() { Latitude = -34.101290896639355, Longitude = 18.853087865159306};

            runTest4(point1, point2);
        }

        static void runTest1and2(int n) {
            Console.WriteLine("***** Test 1 ******");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Util.staircase(n);
            stopWatch.Stop();
            TimeSpan test1Time = stopWatch.Elapsed;
            stopWatch.Reset();

            // Improvements in time start showing the hire the number for n is. 
            // Processing 10 000 items the improvements take about 30s whereas test 1 takes about 1m30s,
            // on my current laptop.
            Console.WriteLine("\n***** Test 2.1 ******");
            stopWatch = new Stopwatch();
            stopWatch.Start();
            Util.staircaseImprove1(n);
            stopWatch.Stop();
            TimeSpan test2Time = stopWatch.Elapsed;
            stopWatch.Reset();

            Console.WriteLine("\n***** Test 2.2 ******");
            stopWatch = new Stopwatch();
            stopWatch.Start();
            Util.staircaseImprove2(n);
            stopWatch.Stop();
            TimeSpan test3Time = stopWatch.Elapsed;
            stopWatch.Reset();

            Console.WriteLine("test 1 time: " + test1Time);
            Console.WriteLine("test 2.1 time: " + test2Time);
            Console.WriteLine("test 2.2 time: " + test3Time);
        }

        static void runTest3(string str) {
            Console.WriteLine("\n***** Test 3 ******");
            Test3 test3 = new Test3();

            bool isPalindrome = test3.isPalindrome(str);

            Console.WriteLine(string.Format("Is '{0}' a palindrome: {1}", str, isPalindrome));
        }

        static void runTest4(Point point1, Point point2) {
            Console.WriteLine("\n***** Test 4 ******");
            Test4 test4 = new Test4();

            double distanceBetweenPoints = test4.GetTotalMetersBetweenTwoPoints(point1, point2);

            Console.WriteLine(string.Format("Distance between Point 1 (Latitude: {0}, Longitude: {1}) and Point 2 (Latitude: {2}, Longitude: {3}) is {4}m", 
                point1.Latitude, point1.Longitude, point2.Latitude, point2.Longitude, distanceBetweenPoints));

        }
    }
}
