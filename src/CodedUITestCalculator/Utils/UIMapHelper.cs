using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUITestCalculator.Utils
{
    public static class UIMapHelper
    {
        public static T GetControl<T>(this WinWindow src)
        {
            PropertyInfo[] props = src.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (PropertyInfo prop in props)
            {
                if (prop.Name.EndsWith(typeof(T).Name))
                    return (T)prop.GetValue(src);
            }

            throw new InstanceNotFoundException("[UIMapHelper::GetControl] - Could not find the required control instance.");
        }

        public static WinButton GetButtonByName(this UICalculatorWindow src, string buttonName)
        {
            switch (buttonName)
            {
                case "0"               : return src.UINum0.Button;
                case "1"               : return src.UINum1.Button;
                case "2"               : return src.UINum2.Button;
                case "3"               : return src.UINum3.Button;
                case "4"               : return src.UINum4.Button;
                case "5"               : return src.UINum5.Button;
                case "6"               : return src.UINum6.Button;
                case "7"               : return src.UINum7.Button;
                case "8"               : return src.UINum8.Button;
                case "9"               : return src.UINum9.Button;
                case "DecimalSeparator": return src.UIDecimalSeparator.Button;
                case "Clear"           : return src.UIClear.Button;
                case "ClearEntry"      : return src.UIClearEntry.Button;
                case "Equals"          : return src.UIEquals.Button;

                case "+":
                case "Add":
                    return src.UIAdd.Button;
                case "-":
                case "Subtract":
                    return src.UISubtract.Button;
                case "*":
                case "Multiply":
                    return src.UIMultiply.Button;
                case "/":
                case "Divide":
                    return src.UIDivide.Button;

                default:
                    throw new InvalidOperationException("[TestCalculator::GetButtonByName] - Received invalid input for button name.");
            }
        }

        public static string GetTextBoxTextByName(this UICalculatorWindow src, string textBoxName)
        {
            switch (textBoxName)
            {
                case "ResultBox":
                    return src.UIResultBox.TextBox.DisplayText;

                default:
                    throw new InvalidOperationException("[TestCalculator::GetTextBoxTextByName] - Received invalid input for control name.");
            }
        }
    }
}
