using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public struct ZFunction
        {
            public double dX;
            public double dY;
            public double dZ;

            public ZFunction(double dX, double dY)
            {
                this.dX = dX;
                this.dY = dY;
                this.dZ = 2 * Math.Pow(dX, 3) + 3 * Math.Pow(dY, 3) + 6;
                this.dZ = Math.Round(this.dZ, 3);
            }
        }


        static void Main(string[] args)
        {
            int nNumber = 0;

            {
                int[] myIntArray = { 5, 9, 10, 2, 99 };
            }

            {
                int[] myIntArray = new int[5] { 5, 9, 10, 2, 99 };
            }

            {
                int[] myIntArray = new int[5];

                myIntArray[0] = 5;
                myIntArray[1] = 9;
                myIntArray[2] = 10;
                myIntArray[3] = 2;
                myIntArray[4] = 99;
            }

            {
                int arraySize = 5;
                int[] myIntArray = new int[arraySize];
            }

            {
                // single dimension array useful for lists for 2d graphs
                int[] funcVal = new int[21];
                int x = 0;
                int xCntr = 0;
                int y = 0;

                // the value of y at x
                funcVal[x] = y;

                // cannot access arrays with negative indexes
                //funcVal[-10] = 45;

                // we may want a parallel array to store each value of x
                int[] xArray = new int[21];

                // for example: y = 2 * x^2 + 3
                // fill the array for -10 <= x <= 10 (21 data points)
                for (x = -10; x <= 10; ++x, ++xCntr)
                {
                    // Math.Pow() returns a double, so we need to cast as int
                    y = 2 * (int)Math.Pow(x, 2) + 3;

                    // the array indexer must be a positive integer and 0-based
                    // (ie. we cannot store funcVal[-10])
                    funcVal[xCntr] = y;
                    xArray[xCntr] = x;
                }


                /////////////////////////////////////////////////////////////////////////
                // or we may want to add a dimension to the array to store x as well
                int[,] funcVal2 = new int[21, 2];

                // for example: y = 2 * x^2 + 3
                // fill the array for -10 <= x <= 10 (21 data points)

                xCntr = 0;
                for (x = -10; x <= 10; ++x)
                {
                    y = 2 * (int)Math.Pow(x, 2) + 3;

                    // store x in the first element of the second dimension
                    funcVal2[xCntr, 0] = x;

                    // store y in the second element of the second dimension
                    funcVal2[xCntr, 1] = y;

                    ++xCntr;
                }



            }

            {
                // 2 dimension array useful for 3d graphs
                int[,] funcVal = new int[10, 10];
                int x = 0;
                int y = 0;
                int z = 0;

                // eg. the height at any location
                funcVal[x, y] = z;
            }

            {
                // 3 dimension array useful for 4-d data
                int[,,] funcVal = new int[10, 10, 10];
                int x = 0;
                int y = 0;
                int z = 0;
                int temperature = 0;

                // eg. the temperature at any location on earth
                funcVal[x, y, z] = temperature;
            }

            {
                // 4 dimension array useful for 5-d data
                int[,,,] funcVal = new int[10, 10, 10, 10];
                int planet = 0;
                int x = 0;
                int y = 0;
                int z = 0;
                int temperature = 0;

                // eg. the temperature at any location in solar system
                funcVal[planet, x, y, z] = temperature;
            }

            {
                // 3-d formula example with rectangular array

                // implement the code to calculate: z = 2x ^ 3 + 3y ^ 3 + 6
                // for -4 <= x <= 4 in 0.1 increments: there are 81 values of x
                // for -2 <= y <= 5 in 0.2 increments: there are 36 values of y

                double x = 0;
                double y = 0;
                double z = 0;

                int nX = 0;
                int nY = 0;

                // we declare our 3 dimensional array to hold:
                //        81 values of x
                //        36 values of y for each value of x
                //        3 values for each data point: the x, y and z
                double[,,] zFunc = new double[81, 36, 3];

                for (x = -4; x <= 4; x += 0.1, nX++)
                {
                    x = Math.Round(x, 1);

                    // start with the 0'th "y" bucket for this value of x
                    nY = 0;

                    for (y = -2; y <= 5; y += 0.2, ++nY)
                    {
                        y = Math.Round(y, 1);

                        z = 2 * Math.Pow(x, 3) + 3 * Math.Pow(y, 3) + 6;

                        z = Math.Round(z, 3);

                        zFunc[nX, nY, 0] = x;
                        zFunc[nX, nY, 1] = y;
                        zFunc[nX, nY, 2] = z;
                    }
                }
            }

            {
                int[][] jaggedIntArray;
                jaggedIntArray = new int[2][];
                jaggedIntArray[0] = new int[3];
                jaggedIntArray[1] = new int[4];

                jaggedIntArray[0][0] = 1;
                jaggedIntArray[0][1] = 2;
                jaggedIntArray[0][2] = 3;
                jaggedIntArray[0][3] = 5;

                jaggedIntArray[1][0] = 1;
                jaggedIntArray[1][1] = 2;
                jaggedIntArray[1][2] = 3;
                jaggedIntArray[1][3] = 4;

            }

            {
                // 3-d formula example with jagged array

                // implement the code to calculate: z = 2x ^ 3 + 3y ^ 3 + 6
                // for -4 <= x <= 4 in 0.1 increments: there are 81 values of x
                // for -2 <= y <= 5 in 0.2 increments: there are 36 values of y

                double x = 0;
                double y = 0;
                double z = 0;

                int nX = 0;
                int nY = 0;
                int nThirdDim = 0;

                // we declare our 3 dimensional array to hold:
                //        81 values of x
                //        36 values of y for each value of x
                //        3 values for each data point: the x, y and z
                double[][][] zFunc = new double[81][][];

                // we need to allocate each dimension of the array separately
                for (nX = 0; nX < 81; ++nX)
                {
                    // allocate the 36 "y" elements for each of the 81 "x" elements
                    zFunc[nX] = new double[36][];

                    for (nThirdDim = 0; nThirdDim < 3; ++nThirdDim)
                    {
                        // allocate the 3 elements of the 3rd dimension for each [x][y] dimension
                        zFunc[nX][nThirdDim] = new double[3];
                    }
                }

                for (x = -4; x <= 4; x += 0.1, nX++)
                {
                    x = Math.Round(x, 1);

                    // start with the 0'th "y" bucket for this value of x
                    nY = 0;

                    for (y = -2; y <= 5; y += 0.2, ++nY)
                    {
                        y = Math.Round(y, 1);

                        z = 2 * Math.Pow(x, 3) + 3 * Math.Pow(y, 3) + 6;

                        z = Math.Round(z, 3);

                        zFunc[nX][nY][0] = x;
                        zFunc[nX][nY][1] = y;
                        zFunc[nX][nY][2] = z;
                    }
                }
            }

            {
                // 3-d formula example with rectangular array

                // implement the code to calculate: z = 2x ^ 3 + 3y ^ 3 + 6
                // for -4 <= x <= 4 in 0.1 increments: there are 81 values of x
                // for -2 <= y <= 5 in 0.2 increments: there are 36 values of y

                double x = 0;
                double y = 0;
                double z = 0;

                int nX = 0;
                int nY = 0;

                // we declare our 3 dimensional array to hold:
                //        81 values of x
                //        36 values of y for each value of x
                //        3 values for each data point: the x, y and z
                //double[,,] zFunc = new double[81, 36, 3];
                ZFunction[] zArray = new ZFunction[81 * 36];

                int dataPointCntr = 0;

                for (x = -4; x <= 4; x += 0.1, nX++)
                {
                    x = Math.Round(x, 1);

                    // start with the 0'th "y" bucket for this value of x
                    nY = 0;

                    for (y = -2; y <= 5; y += 0.2, ++nY)
                    {
                        y = Math.Round(y, 1);

                        ZFunction thisDataPoint = new ZFunction(x, y);
                        zArray[dataPointCntr++] = thisDataPoint;

                        // zArray[dataPointCntr++] = new ZFunction(x,y);
                    }
                }
            }
        }
    }
}