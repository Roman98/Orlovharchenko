
namespace Calculator.SortMass
{
    public class SortMass1 :ISortMass
    {
        public void Calculate(double[] arr)
        {
            /*По очереди будем просматривать все подмножества
              элементов массива (0 - последний, 1-последний, 
              2-последний,...)*/
            for (int i = 0; i < arr.Length; i++)
            {
                /*Предполагаем, что первый элемент (в каждом
                   подмножестве элементов) является минимальным */
                double min = arr[i];
                int min_i = i;
                /*В оставшейся части подмножества ищем элемент,
                   который меньше предположенного минимума*/
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //Если находим, запоминаем его индекс
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        min_i = j;
                    }
                }
                /*Если нашелся элемент, меньший, чем на текущей позиции,
                  меняем их местами*/
                if (i != min_i)
                {
                    double tmp = arr[i];
                    arr[i] = arr[min_i];
                    arr[min_i] = tmp;
                }
            }
        }

    }
}