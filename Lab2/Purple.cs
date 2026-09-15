namespace Lab2
{
    public class Purple
    {
        private const double E = 0.0001;

        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here

            while (n-- > 0)
            {
                answer += (p + (n) * h) * (p + (n) * h);
            }

            // end

            return answer;
        }

        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;

            // end

            return (quotient, remainder);
        }

        public double Task3()
        {
            double answer = 0;

            // code here

            double TargetEpsilon = 0.0001;

            int numeratorPresent = 3;
            int denominatorPresent = 2;
            int numeratorPast = 2;
            int denominatorPast = 1;

            while (Math.Abs(((double)numeratorPresent / denominatorPresent) - ((double)numeratorPast / denominatorPast)) >= TargetEpsilon)
            {
                numeratorPresent += numeratorPast;
                denominatorPresent += denominatorPast;
                numeratorPast = numeratorPresent - numeratorPast;
                denominatorPast = denominatorPresent - denominatorPast;
            }

            answer = (double)numeratorPresent / denominatorPresent;

            // end

            return answer;
        }

        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }

        public long Task6()
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}