// using System.Collections.Generic;
// using System.Linq;
using System;
namespace paiza_C.Questions
{
    public class SuffixArray
    {
        private string S;
        private int N;
        public int[] SA;
        public SuffixArray(string s)
        {
            this.S = s;
            this.N = s.Length;
            this.SA = new int[N + 1];
            CreateSuffixArray();
        }

        private void CreateSuffixArray()
        {
            for (int i = 0; i < N + 1; i++)
            {
                SA[i] = i;
            }
            // ソート ※計算量O(N^2logN)で遅い
            Array.Sort(SA, CompareSA);
        }
        
        public int CompareSA(int i, int j)
        {
            // 単純に開始位置から末尾までの文字列で比較
            return string.CompareOrdinal(S, i, S, j, N);
        }

        // 部分文字列にTが含まれるかどうかを判定する
        public bool Contains(string t)
        {
            var l = 0;
            var r = N;
            while (r - l > 1)
            {
                var mid = l + (r - l) / 2;
                var index = SA[mid];
                var cmp = string.CompareOrdinal(S, index, t, 0, t.Length);
                if (cmp < 0) l = mid;
                else r = mid;
            }
            return string.CompareOrdinal(S, SA[r], t, 0, t.Length) == 0;
        }
    }
}
