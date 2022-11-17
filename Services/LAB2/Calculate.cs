namespace WebApplication1.Services.LAB2
{
    public class Calculate
    {
        public Calculate(int value1)
        {
            Value = value1;
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
