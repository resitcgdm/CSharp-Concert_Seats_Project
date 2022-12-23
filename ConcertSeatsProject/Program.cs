using System;

namespace ConcertSeatsProject
{
    public class Program
    {
        static void Main(string[] args)
        {   
            // Creating Arrays

            int[][] seats1 = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },             
                new int[] { 7, 8, 9 }
            };
            int[][] seats2 = new int[][] {
                new int[] { 0, 0, 0 },
                new int[] { 1, 1, 1 },              
                new int[] { 2, 2, 2 }
            };
            int[][] seats3 = new int[][] {
                new int[] { 2, 0, 0 },
                new int[] { 1, 1, 1 },              
                new int[] { 2, 2, 2 }
            };
            int[][] seats4 = new int[][] {
                new int[] { 1, 0, 0 },              
                new int[] { 1, 1, 1 },
                new int[] { 2, 2, 2 }
            };

            // Displaying
            Console.WriteLine(canSeeStage(seats1));
            Console.WriteLine(canSeeStage(seats2));
            Console.WriteLine(canSeeStage(seats3));
            Console.WriteLine(canSeeStage(seats4));
        }

        // Creating Function
        static bool canSeeStage(int[][] seats)
        {
            for (int i = 1; i < seats.Length; i++)
            {
                for (int j = 0; j < seats[i].Length; j++)
                {
                    if (seats[i][j] <= seats[i - 1][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}

