
namespace Тумаков_12
{
    internal class Complex_num 
    {
        public double ReZ { get; set; }
        public double ImZ { get; set; }

        public Complex_num(double reZ, double imZ)
        {
            ReZ = reZ;
            ImZ = imZ;
        }

        public static Complex_num operator +(Complex_num Value_1, Complex_num Value_2)
        {
            return new Complex_num(Value_1.ReZ + Value_2.ReZ, Value_1.ImZ + Value_2.ImZ);
        }

        public static Complex_num operator *(Complex_num Value_1, Complex_num Value_2)
        {
            return new Complex_num(Value_1.ReZ * Value_2.ReZ - Value_1.ImZ * Value_2.ImZ, Value_1.ReZ * Value_2.ImZ + Value_1.ImZ * Value_2.ReZ);
        }

        public static Complex_num operator -(Complex_num Value_1, Complex_num Value_2)
        {
            return new Complex_num(Value_1.ReZ - Value_2.ReZ, Value_1.ImZ - Value_2.ImZ);
        }

        public static bool operator ==(Complex_num Value_1, Complex_num Value_2)
        {
            return Value_1.ReZ == Value_2.ReZ && Value_1.ImZ == Value_2.ImZ;
        }

        public static bool operator !=(Complex_num Value_1, Complex_num Value_2)
        {
            return !(Value_1 == Value_2);
        }

        public override string ToString()
        {
            return $"{ReZ} + {ImZ}i";
        }

    }
}
