namespace App2_15
{
    public static class MatrixLineSorter
    {

        private static void SwapRows(double[,] a, int i1, int i2)
        {
            var m = a.GetLength(1);

            for (var col = 0; col < m; col++)
            {
                var val = a[i1, col];
                a[i1, col] = a[i2, col];
                a[i2, col] = val;
            }
        }

        public static void Sort(double[,] a )
        {
            var n = a.GetLength(0);
            var m = a.GetLength(1);

            var sums = new double[n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    sums[i] += a[i, j];
                }
            }

            // сортировка массива сумм и односременно переставановка строк исходной матрицы (сортировка вставками)

            var i1 = 1;
            while (i1 < n)
            {
                var j1 = i1;

                while (j1 > 0 && sums[j1] > sums[j1 - 1])
                {
                    var r = sums[j1];
                    sums[j1] = sums[j1 - 1];
                    sums[j1 - 1] = r;

                    // меняю местами строки исходной матрицы
                    SwapRows(a, j1, j1 - 1);

                    j1--;
                }
                i1++;
            }
        }
    }
}
