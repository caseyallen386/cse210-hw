using System;

    public class Fraction
    {
        //top number
        private int _numberator;

        //bottom number
        private int _demoninator;


        public Fraction()
        {
            _numberator = 1;
            _demoninator = 1;
        }

        public Fraction(int wholeNumber)
        {
            _numberator = wholeNumber;
            _demoninator = 1;
        }

        public Fraction(int numberator, int denominator)
        {
            _numberator = numberator;
            _demoninator = denominator;
        }

        public void setNumberator(int numberator)
        {
            _numberator = numberator;
        }

        public void setDemoninator(int denominator)
        {
            _demoninator = denominator;
        }

        public int GetNumberator()
        {
            return _numberator;
        }

        public int GetDemoninator()
        {
            return _demoninator;
        }

        public string ToFractionString()
        {
            return $"{_numberator}/{_demoninator}";
        }

        public double ToDecimal()
        {
            return (double)_numberator / (double)_demoninator;
        }


    }

