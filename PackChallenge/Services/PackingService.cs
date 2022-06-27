using PackChallenge.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackChallenge.Services

{
    public class PackingService
    {
        public Dictionary<int,int> GroupScrew(int total)
        {
            int fiveCount = 0;
            int threeCount = 0;
            Dictionary<int, int> result = new Dictionary<int, int>(); 
            fiveCount = total / 5;
            while (total >= 3) 
            {
                if (total == fiveCount * 5)
                {
                    result.Add(5, fiveCount);
                    result.Add(3, threeCount);
                    return result;
                }
                else 
                {
                    var tempTotal = total - (fiveCount * 5);
                    if (tempTotal % 3 == 0)
                    {
                        threeCount = tempTotal / 3;
                        result.Add(5, fiveCount);
                        result.Add(3, threeCount);
                        return result;

                    }
                    else
                    {
                        fiveCount--;
                    }
                }

            }

            return result;
        }

        public Dictionary<int, int> GroupNails(int total)
        {
            int eightCount = 0;
            int fiveCount = 0;
            int twoCount = 0;

            Dictionary<int, int> result = new Dictionary<int, int>();
            eightCount = total / 8;
            while (total >= 2)
            {
                if (total == eightCount * 8)
                {
                    result.Add(8, eightCount);
                    result.Add(5, fiveCount);
                    result.Add(2, twoCount);
                    return result;
                }
                else
                {
                    var tempTotal = total - (eightCount * 8);
                    if (tempTotal % 5 == 0)
                    {
                        fiveCount = tempTotal / 5;
                        result.Add(8, eightCount);
                        result.Add(5, fiveCount);
                        result.Add(2, twoCount);
                        return result;

                    }
                    else
                    {
                        tempTotal = total - (eightCount * 8);
                        fiveCount = tempTotal / 5;
                        if (tempTotal % 5 == 0)
                        {
                            result.Add(8, eightCount);
                            result.Add(5, fiveCount);
                            result.Add(2, twoCount);
                            return result;
                        }
                        else
                        {
                            tempTotal = tempTotal - (fiveCount * 5);
                            twoCount = tempTotal / 2;
                            if (tempTotal % 2 == 0)
                            {
                                result.Add(8, eightCount);
                                result.Add(5, fiveCount);
                                result.Add(2, twoCount);
                                return result;
                            }
                        }
                        fiveCount--;
                    }
                    eightCount--;

                }
            }
            return result;
        }

        public Dictionary<int, int> GroupHooks(int total)
        {
            int nineCount = 0;
            int fiveCount = 0;
            int threeCount = 0;

            Dictionary<int, int> result = new Dictionary<int, int>();
            nineCount = total / 9;
            while (total >= 2)
            {
                if (total == nineCount * 8)
                {
                    result.Add(9, nineCount);
                    result.Add(5, fiveCount);
                    result.Add(3, threeCount);
                    return result;
                }
                else
                {
                    var tempTotal = total - (nineCount * 9);
                    if (tempTotal % 5 == 0)
                    {
                        fiveCount = tempTotal / 5;
                        result.Add(9, nineCount);
                        result.Add(5, fiveCount);
                        result.Add(3, threeCount);
                        return result;

                    }
                    else
                    {
                        tempTotal = total - (nineCount * 9);
                        fiveCount = tempTotal / 5;
                        if (tempTotal % 5 == 0)
                        {
                            result.Add(9, nineCount);
                            result.Add(5, fiveCount);
                            result.Add(3, threeCount);
                            return result;
                        }
                        else
                        {
                            tempTotal = tempTotal - (fiveCount * 5);
                            threeCount = tempTotal / 3;
                            if (tempTotal % 2 == 0)
                            {
                                result.Add(9, nineCount);
                                result.Add(5, fiveCount);
                                result.Add(3, threeCount);
                                return result;
                            }
                        }
                        fiveCount--;
                    }
                    nineCount--;

                }
            }
            return result;
        }

        public decimal GetPrice(Items item, int pack, int count)
        {
            double packagingPrice = 0;

            switch (item)
            {
                case Items.Screw:
                    if (pack == 5)
                    {
                        packagingPrice = 8.99;
                    }
                    if (pack == 3)
                    {
                        packagingPrice = 6.99;
                    }
                    break;
                case Items.Nail:
                    if (pack == 8)
                    {
                        packagingPrice = 24.95;
                    }
                    if (pack == 5)
                    {
                        packagingPrice = 16.95;
                    }
                    if (pack == 2)
                    {
                        packagingPrice = 9.95;
                    }
                    break;
                case Items.Hook:
                    if (pack == 9)
                    {
                        packagingPrice = 16.99;
                    }
                    if (pack == 5)
                    {
                        packagingPrice = 9.95;
                    }
                    if (pack == 3)
                    {
                        packagingPrice = 5.95;
                    }
                    break;
                default:
                    packagingPrice = 0;
                    break;
            }

            return (decimal)(packagingPrice * count);
        }
    }
}
