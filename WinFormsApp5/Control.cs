namespace WinFormsApp5
{
    class Control
    {

        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string? Operator { get; set; }
        public bool IsChecked { get; set; }
        public bool ClickEquals { get; set; }
        public bool ClickToOp { get; set; }
        public int Count { get; set; }
        public string? Result { get; set; }
        public int CountCalc { get; set; }

        public Control(double number1, double number2, string? @operator, bool isChecked, bool clickEquals, bool clickToOp, int count, string? result, int countCalc)
        {
            Number1 = number1;
            Number2 = number2;
            Operator = @operator;
            IsChecked = isChecked;
            ClickEquals = clickEquals;
            ClickToOp = clickToOp;
            Count = count;
            Result = result;
            CountCalc = countCalc;
        }

        public Control()
        {

        }
    }
}
