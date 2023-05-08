namespace Basic02
{
    class Class1
    {
        public int i { get; set; }
        public string str = "";
        public bool chk { get; set; } = true;
        public float f { get; set; }
        private int y { get; set; } = 1;
        private int x { get; set; } = 2;

        public int func_plus()
        {
            return x + y;
        }
        public int func_minus()
        {
            return x - y;
        }
        public int func_multiply()
        {
            return x * y;
        }
        public int func_divide()
        {
            return x / y;
        }
        public void func_print()
        {
            Console.WriteLine(str);
        }
    }

}
