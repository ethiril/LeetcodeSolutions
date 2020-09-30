using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.PascalsTriangle
{
    class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            // First base case; if user requests zero rows, they get zero rows.
            if (numRows == 0)
            {
                return triangle;
            }

            // Second base case; first row is always [1].
            triangle.Add(new List<int>());
            triangle[0].Add(1);

            for (int rowNum = 1; rowNum < numRows; rowNum++)
            {
                IList<int> row = new List<int>();
                IList<int> prevRow = triangle[rowNum - 1];

                // The first row element is always 1.
                row.Add(1);

                // Each triangle element (other than the first and last of each row)
                // is equal to the sum of the elements above-and-to-the-left and
                // above-and-to-the-right.
                for (int j = 1; j < rowNum; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                // The last row element is always 1.
                row.Add(1);

                triangle.Add(row);
            }

            return triangle;
        }
    }
}
