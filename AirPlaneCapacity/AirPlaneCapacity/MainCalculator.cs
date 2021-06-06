using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneCapacity
{
    public struct Product
    {
        public decimal Weight;
        public int Cost;
        public Product(decimal weight, int cost)
        {
            Weight = weight;
            Cost = cost;
        }
    }
    class MainCalculator
    {
        const int PRODUCT_NUMBER = 6;
        const int COEFFICIENTS_NUMBER = PRODUCT_NUMBER;
        public int[] MinNumbersOfProducts { get; set; } = new int[PRODUCT_NUMBER];
        public int[] Coefficients { get; set; } = new int[COEFFICIENTS_NUMBER];

        private Product[] Products;
        public MainCalculator(int[] minNumbersOfProducts, Product[] products)
        {
            int i = 0;
            foreach(int minNumberOfProduct in minNumbersOfProducts)
            {
                MinNumbersOfProducts[i] = minNumberOfProduct;
                i++;
            }
            Products = products;
        }
        private int distributiveMultiplier(int currentStep, int aimStep)
        {
            if ((currentStep / aimStep > 0) && !(currentStep == aimStep))
                return 1;
            else
                return 0;
        }
        public int CalculateMaxCost(decimal weight, int step = PRODUCT_NUMBER - 1)
        {
            if (step == 0)
                return (int)Math.Truncate(weight / Products[step].Weight) * Products[step].Cost;
            int lengthFunctionArray = (int)(weight / Products[step].Weight);
            int[] results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            int maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            return maxResult;
        }
        public int[] GetArrayByStep(decimal weight, int aimStep, int[] aimNunbers,int step = PRODUCT_NUMBER - 1)
        {
            int lengthFunctionArray = (int)(weight / Products[step].Weight);
            int[] results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            if (step == aimStep - 1)
            return results;
            weight -= (aimNunbers[step] - 1) * Products[step].Weight;
            //2-nd iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            if (step == aimStep - 1)
                return results;
            weight -= (aimNunbers[step] - 1) * Products[step].Weight;
            //3-rd iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            if (step == aimStep - 1)
                return results;
            weight -= (aimNunbers[step] - 1) * Products[step].Weight;
            //4-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            if (step == aimStep - 1)
                return results;
            weight -= (aimNunbers[step] - 1) * Products[step].Weight;
            //5-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            if (step == aimStep - 1)
                return results;
            weight -= (aimNunbers[step] - 1) * Products[step].Weight;
            //6-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1; i++)
            {
                results[i] = i * Products[step].Cost;
            }
            return results;
        }
        public void GetCoefficients(int maxCost, decimal weight, int step = PRODUCT_NUMBER - 1)
        {
            //1-st iteration
            int lengthFunctionArray = (int)(weight / Products[step].Weight);
            int[] results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            int maxIndex = 0;
            for (int i = 0; i < lengthFunctionArray + 1; i++)
            {
                if (maxCost == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
            //2-nd iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            int maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            maxIndex = MinNumbersOfProducts[step];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
            //3-rd iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            maxIndex = 0;
            for (int i = 0; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
            //4-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            maxIndex = MinNumbersOfProducts[step];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
            //5-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1;)
            {
                if (weight - Products[step].Weight * i >= Products[5].Weight * MinNumbersOfProducts[5] * distributiveMultiplier(step, 5) +
                    Products[4].Weight * MinNumbersOfProducts[4] * distributiveMultiplier(step, 4) +
                    Products[3].Weight * MinNumbersOfProducts[3] * distributiveMultiplier(step, 3) +
                    Products[2].Weight * MinNumbersOfProducts[2] * distributiveMultiplier(step, 2) +
                    Products[1].Weight * MinNumbersOfProducts[1] * distributiveMultiplier(step, 1) +
                    Products[0].Weight * MinNumbersOfProducts[0])
                {
                    results[i] = Products[step].Cost * i + CalculateMaxCost(weight - Products[step].Weight * i, step - 1);
                    i++;
                }
                else
                    break;
            }
            maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            maxIndex = MinNumbersOfProducts[step];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
            //6-th iteration
            step--;
            lengthFunctionArray = (int)(weight / Products[step].Weight);
            results = new int[lengthFunctionArray + 1];
            for (int i = 0; i < lengthFunctionArray + 1; i++)
            {
                results[i] = i * Products[step].Cost;
            }
            maxResult = results[MinNumbersOfProducts[step]];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult < results[i])
                    maxResult = results[i];
            }
            maxIndex = MinNumbersOfProducts[step];
            for (int i = MinNumbersOfProducts[step]; i < lengthFunctionArray + 1; i++)
            {
                if (maxResult == results[i])
                {
                    maxIndex = i;
                    break;
                }
            }
            Coefficients[step] = maxIndex;
            weight -= maxIndex * Products[step].Weight;
        }
    }
}
