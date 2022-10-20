using System.Security.Cryptography.X509Certificates;

namespace lab1.Folder
{
    public class Calculate
    {
        public Calculate(int value)
        {
            Value = value;
        }
        private int Value { get; set; }

        public void Increase(int value)
        {
            Value += value;
        }
        public void Decrease(int value)
        {
            Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
