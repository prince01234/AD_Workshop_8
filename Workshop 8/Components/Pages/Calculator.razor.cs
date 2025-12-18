using Microsoft.AspNetCore.Components;

namespace Workshop_8.Components.Pages
{
    public partial class Calculator : ComponentBase
    {
        // Two-way binding variables
        private double Number1 { get; set; }
        private double Number2 { get; set; }

        // Result
        private double Result { get; set; }

        // Event handling for buttons
        private void Add() => Result = Number1 + Number2;
        private void Subtract() => Result = Number1 - Number2;
        private void Multiply() => Result = Number1 * Number2;
        private void Divide()
        {
            if (Number2 != 0)
                Result = Number1 / Number2;
            else
                Result = double.NaN;
        }
    }
}