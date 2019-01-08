using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUITestCalculator.Utils
{
    public static class UIMapHelper
    {
        public static WinButton GetButtonByName(this UIMap src, string buttonName)
        {
            UICalculatorWindow ui = src.UICalculatorWindow;
            switch (buttonName)
            {
                case "0"               : return ui.UINum0.Button;
                case "1"               : return ui.UINum1.Button;
                case "2"               : return ui.UINum2.Button;
                case "3"               : return ui.UINum3.Button;
                case "4"               : return ui.UINum4.Button;
                case "5"               : return ui.UINum5.Button;
                case "6"               : return ui.UINum6.Button;
                case "7"               : return ui.UINum7.Button;
                case "8"               : return ui.UINum8.Button;
                case "9"               : return ui.UINum9.Button;
                case "DecimalSeparator": return ui.UIDecimalSeparator.Button;
                case "Clear"           : return ui.UIClear.Button;
                case "ClearEntry"      : return ui.UIClearEntry.Button;
                case "Equals"          : return ui.UIEquals.Button;

                case "+":
                case "Add":
                    return ui.UIAdd.Button;
                case "-":
                case "Subtract":
                    return ui.UISubtract.Button;
                case "*":
                case "Multiply":
                    return ui.UIMultiply.Button;
                case "/":
                case "Divide":
                    return ui.UIDivide.Button;

                default:
                    throw new InvalidOperationException("[TestCalculator::GetButtonByName] - Received invalid input for button name.");
            }
        }

        public static string GetTextBoxTextByName(this UIMap src, string textBoxName)
        {
            UICalculatorWindow ui = src.UICalculatorWindow;
            switch (textBoxName)
            {
                case "ResultBox":
                    return ui.UIResultBox.TextBox.DisplayText;

                default:
                    throw new InvalidOperationException("[TestCalculator::GetTextBoxTextByName] - Received invalid input for control name.");
            }
        }
    }
}
