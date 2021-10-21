using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace benchmarkdotnet_V1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Tochka tochka = new Tochka();

            StructurFloat structFloat = new StructurFloat();
            
            

            point.RunClass();//Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).

            structFloat.RunStructFloat();//Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).

            tochka.RunStruct();//Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).


             BenchmarkRunner.Run<Benchmark>();
        }
    }
}
