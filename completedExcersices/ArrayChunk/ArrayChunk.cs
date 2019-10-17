using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.ArrayChunk
{
    // --- Directions
    // Given an array and chunk size, divide the array into many subarrays
    // where each subarray is of length size
    // --- Examples
    // chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
    // chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
    // chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
    // chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
    // chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]
    public static class ArrayChunk
    {
        public static Array[,] ArrayChunkProblem(int[] array, int chunk)
        {
            var currentChunk = 1;
            var currentChunkIindex = 0;
            int totalChunksCount = Convert.ToInt32(Math.Ceiling((double)array.Length / chunk));
            int[,] totalChunksArray = new int[totalChunksCount, chunk];
            for (int i = 0; i < array.Length; i++)
            {                
                if (i > (chunk * currentChunk) - 1)
                {
                    currentChunkIindex = 0;
                    currentChunk++;
                }
                totalChunksArray[currentChunk - 1, currentChunkIindex] = array[i];
                currentChunkIindex++;
            }
            return null;
        }
    }
}
