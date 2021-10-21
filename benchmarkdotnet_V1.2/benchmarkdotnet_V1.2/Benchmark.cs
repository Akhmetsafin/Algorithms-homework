using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


namespace benchmarkdotnet_V1._2
{
    public class Benchmark
    {
        [Benchmark]
        public void StructureDouble()
        {
            Tochka tochka = new Tochka();
            tochka.RunStruct();
        }
        [Benchmark]
        public void StructureClass()
        {
            Point point = new Point();
            point.RunClass();
        }
        [Benchmark]
        public void StructureFloat()
        {
            StructurFloat structurFloat = new StructurFloat();
            structurFloat.RunStructFloat();
        }

    }
}
