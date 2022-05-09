using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary {
    public class AlgebraClass {

        public static double Inverse(double a) {
            if (a == 0) {
                throw new DivideByZeroException("a cannot be zero.");
            }
            return 1 / a;
        }
        public static int Modulo(int a, int b) {
            return a % b;
        }
       
        public static long Cubed(int a) {
            return a * a * a;
        }
    }
}
