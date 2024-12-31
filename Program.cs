using System;

class ClsCalculator
{
    private float _Number;
    private float _Result;
    private String _Operation;
    private float Number { get { return _Number;}}
    private float Result { get { return _Result;}}
    private string Character { get { return _Operation;}}
    private float _Add(int Value) {
        _Operation = "Adding" ;
        _Number = Value; _Result += Number; return Result;
    }
    private float _Subtract(int Value) {
        _Operation = "Subtracting";
        _Number = Value; _Result -= Value; return Result;
    }
    private float _Divide(int Value) {/////////////
        _Operation = "Dividing"; if (Value == 0) { Console.WriteLine("Division by zero is not allowed."); Value=1; }
        _Number = Value; _Result /= _Number; return _Result;
    }
    private float _Multiply(int Value = 0) {
        _Operation = "Multiplying";
        _Number = Value; _Result *= Value; return Result;
    }
    private float _Clear(int Value = 0) {
        _Operation = "Clear";
        _Number = 0; _Result = 0; return Result;
    }
    private void _PrintResult(){
        Console.WriteLine($"Result after {Character} {Number} is: {Result}");
    }

    //=====Public Function=====//

    public float Add(int Value){
        return _Add(Value);
    }

    public float Subtract(int Value){
        return _Subtract(Value);
    }

    public float Divide(int Value){ 
        return _Divide(Value);
    }

    public float Multiply(int Value = 0){
        return _Multiply(Value);
    }

    public float Clear(int Value = 0){ 
        return _Clear(Value);
    }

    public void PrintResult(){
        _PrintResult();

    }

    public float GetFinalResult() {
        return _Result;
    }


}

internal class Program
{
    public static void Main(string[] args) 
    {
        ClsCalculator Calculator1 = new ClsCalculator();
        Calculator1.Add(10);
        Calculator1.PrintResult();
        Calculator1.Add(100);
        Calculator1.PrintResult();
        Calculator1.Subtract(20);
        Calculator1.PrintResult();
        Calculator1.Divide(0);
        Calculator1.PrintResult();
        Calculator1.Divide(2);
        Calculator1.PrintResult();
        Calculator1.Multiply(3);
        Calculator1.PrintResult();
        Calculator1.Clear();
        Calculator1.PrintResult();
        Calculator1.GetFinalResult();
    }
}