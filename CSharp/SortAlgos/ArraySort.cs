﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgos
{
    internal static class ArraySort
    {
        /// <summary>
        /// 거품 정렬 
        /// O(N^2)
        /// Stable. 
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            int i, j;
            for (i = 0; i < arr.Length - 1; i++)    // i = 전체 순회 횟수
            {
                for (j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// 선택 정렬
        /// O(N^2)
        /// 같을 때 바꾸면 Unstable, 바꾸지 않으면 Stable
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(int[] arr)
        {
            int i, j, minIdx;
            for (i = 0; i < arr.Length-1; i++)
            {
                minIdx = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx]) 
                        minIdx = j;
                }

                Swap(ref arr[i], ref arr[minIdx]);
            }
        }

        /// <summary>
        /// 삽입정렬
        /// O(N^2)
        /// Stable
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(int[] arr)
        {
            int i, j;
            int key; // 인덱스 X, 값

            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }


        /// <summary>
        /// Merge sort
        /// </summary>
        /// <param name="arr"></param>

        public static void MergeSort(int[] arr)
        {
            int length = arr.Length;

            for (int mergeSize = 1; mergeSize < length; mergeSize *= 2)
            {
                for (int start = 0; start < length; start += 2 * mergeSize)
                {
                    int mid = Math.Min(start + mergeSize - 1, length - 1);
                    int end = Math.Min(start + 2 * mergeSize - 1, length - 1);

                    Merge(arr, start, mid, end);
                }
            }
        }

        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int part1 = start;  // 전체 배열이 아니라 정복하기 위한 곳의 처음이라는 것을 헷갈리지 말자
            int part2 = mid + 1;
            // 복제본을 만들어.. 덮어쓰기를 하면서 진행해야함.
            // 덮어쓰면 참고하면서 진행해야할 값이 날아가므로 만들어놓는다.
            int length1 = mid - start + 1; // part1의 길이
            int length2 = end - mid;       // part2의 길이

            int[] copy1 = new int[length1];
            int[] copy2 = new int[length2];

            int i = 0; // Copy1 index
            int j = 0; // Copy2 index
            for (i = 0; i < length1; i++)
                copy1[i] = arr[start + i];

            for (j = 0; j < length2; j++)
                copy2[j] = arr[mid + 1 + j];

            int index = start;
            i = 0;
            j = 0;

            while (i < length1 && j < length2)
            {
                if (copy1[i] <= copy2[j])
                    arr[index++] = copy1[i++];
                else
                    arr[index++] = copy2[j++];
            }

            while (i < length1)
                arr[index++] = copy1[i++];
        }



        public static void RecursiveMergeSort(int[] arr)
        {
            RecursiveMergeSort(arr, 0, arr.Length - 1);
        }

        private static void RecursiveMergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = end + (start - end + 1) / 2 - 1; // == (start + end + 1) /2 - 1, Overflow 방지용
                                                           // => 중간값을 구할 때는 잊지말고 하자 ex) (b+c)/2 = c + (b-c)/2
                RecursiveMergeSort(arr, start, mid);
                RecursiveMergeSort(arr, mid + 1, end);

                Merge(arr, start, mid, end);
            }
        }
        // 정복할 범위 나눠야함 => 재귀함수

        /// <summary>
        /// Quick Sort
        /// </summary>
        /// <param name="arr"></param>
        public static void QuickSort(int[] arr)
        {
            Stack<int> partionStack = new Stack<int>();
            partionStack.Push(0);
            partionStack.Push(arr.Length - 1);

            while (partionStack.Count > 0)
            {
                int end = partionStack.Pop();
                int start = partionStack.Pop();
                int partition = Partition(arr, start, end);

                // left side
                if (partition - 1 > start)
                {
                    partionStack.Push(start);
                    partionStack.Push(partition - 1);
                }

                // right side
                if (partition + 1 < end)
                {
                    partionStack.Push(partition + 1);
                    partionStack.Push(end);
                }
            }
        }

        public static void RecursiveQuickSort(int[] arr)
        {
            RecursiveQuickSort(arr, 0, arr.Length - 1);
        }

        public static void RecursiveQuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int partition = Partition(arr, start, end);
                RecursiveQuickSort(arr, start, partition - 1);
                RecursiveQuickSort(arr, partition + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[(start + end) / 2];

            while (true)
            {
                while (arr[start] < pivot) start++;
                while (arr[end] > pivot) end--;

                if (start < end)
                {
                    if (arr[start] == pivot && arr[end] == pivot)
                        end--;
                    else
                        Swap(ref arr[start], ref arr[end]);
                }
                else
                {
                    return end;
                }
            }
        }



        /// <summary>
        /// Heap Sort
        /// </summary>
        /// <param name="arr"></param>
        public static void HeapSort(int[] arr)
        {
            //HeapifyTopDown(arr);
            HeapifyBottomUp(arr);

            InverseHeapify(arr);
        }

        // O(NLogN)
        public static void HeapifyTopDown(int[] arr)
        {
            int end = 1;
            while (end < arr.Length)
            {
                SIFT_Up(arr, 0, end++);
            }
        }

        // O(N) - 모든 단말노드에 대해서 수행할 필요가 없기 때문
        public static void HeapifyBottomUp(int[] arr)
        {
            int end = arr.Length - 1;
            int current = end;

            while (current >= 0)
            {
                SIFT_Down(arr, end, current--);
            }
        }

        // O(NLogN)
        public static void InverseHeapify(int[] arr)
        {
            int end = arr.Length - 1;
            while (end > 0)
            {
                Swap(ref arr[0], ref arr[end]);
                end--;
                SIFT_Down(arr, end, 1);
            }
        }

        // 자식이 부모를 탐색해서 스왑하면서 올라가는 형태의 알고리즘
        public static void SIFT_Up(int[] arr, int root, int current)
        {
            int parent = (current - 1) / 2;
            while (current > root)
            {
                if (arr[current] > arr[parent])
                {
                    Swap(ref arr[current], ref arr[parent]);
                    current = parent;
                    parent = (current - 1) / 2;
                }
                else
                {
                    return;
                }
            }
        }

        // 부모가 자식을 탐색해서 스왑하면서 내려가는 형태의 알고리즘
        public static void SIFT_Down(int[] arr, int end, int current)
        {
            int parent = (current - 1) / 2;

            while (current <= end)
            {
                // 오른쪽이 더 크면 스왑 대상을 오른쪽으로 바꿈
                if (current + 1 <= end &&
                    arr[current] < arr[current + 1])
                    current = current + 1;

                if (arr[current] > arr[parent])
                {
                    Swap(ref arr[current], ref arr[parent]);
                    parent = current;
                    current = parent * 2 + 1;
                }
                else
                {
                    return;
                }
            }
        }

        // ref : 인자를 변수의 참조로 받아야할때 사용하는 키워드
        public static void Swap(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }
    }
}

