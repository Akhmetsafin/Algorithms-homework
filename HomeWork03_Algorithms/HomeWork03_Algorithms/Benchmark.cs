using BenchmarkDotNet.Attributes;

namespace HomeWork03_Algorithms
{
    public class Benchmark
    {

        [Benchmark]
        public void ClassFload()
        {
            PointFloat pointFloat = new PointFloat();
            pointFloat.Class_Float();
        }
        [Benchmark]
        public void StructureFloat()
        {
            StrucutrFloat strucutrFloat = new StrucutrFloat();
            strucutrFloat.RunStructFloat();
        }
        [Benchmark]
        public void StructureDouble()
        {
            StructurDouble structurDouble = new StructurDouble();
            structurDouble.RunStructFloat();
        }
        [Benchmark]
        public void StructureFloatNoSqrt()
        {
            StrucutrFloatNoSqrt strucutrFloatNoSqrt = new StrucutrFloatNoSqrt();
            strucutrFloatNoSqrt.RunStructFloatNoSqrt();
        }

    }
}
