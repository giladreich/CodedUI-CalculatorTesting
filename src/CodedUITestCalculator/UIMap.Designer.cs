﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestCalculator
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        #region Properties
        public UICalculatorWindow UICalculatorWindow
        {
            get
            {
                if ((this.mUICalculatorWindow == null))
                {
                    this.mUICalculatorWindow = new UICalculatorWindow();
                }
                return this.mUICalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICalculatorWindow mUICalculatorWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UICalculatorWindow : WinWindow
    {
        
        public UICalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public UINum0 UINum0
        {
            get
            {
                if ((this.mUINum0 == null))
                {
                    this.mUINum0 = new UINum0(this);
                }
                return this.mUINum0;
            }
        }
        
        public UINum1 UINum1
        {
            get
            {
                if ((this.mUINum1 == null))
                {
                    this.mUINum1 = new UINum1(this);
                }
                return this.mUINum1;
            }
        }
        
        public UINum2 UINum2
        {
            get
            {
                if ((this.mUINum2 == null))
                {
                    this.mUINum2 = new UINum2(this);
                }
                return this.mUINum2;
            }
        }
        
        public UINum3 UINum3
        {
            get
            {
                if ((this.mUINum3 == null))
                {
                    this.mUINum3 = new UINum3(this);
                }
                return this.mUINum3;
            }
        }
        
        public UINum4 UINum4
        {
            get
            {
                if ((this.mUINum4 == null))
                {
                    this.mUINum4 = new UINum4(this);
                }
                return this.mUINum4;
            }
        }
        
        public UINum5 UINum5
        {
            get
            {
                if ((this.mUINum5 == null))
                {
                    this.mUINum5 = new UINum5(this);
                }
                return this.mUINum5;
            }
        }
        
        public UINum6 UINum6
        {
            get
            {
                if ((this.mUINum6 == null))
                {
                    this.mUINum6 = new UINum6(this);
                }
                return this.mUINum6;
            }
        }
        
        public UINum7 UINum7
        {
            get
            {
                if ((this.mUINum7 == null))
                {
                    this.mUINum7 = new UINum7(this);
                }
                return this.mUINum7;
            }
        }
        
        public UINum8 UINum8
        {
            get
            {
                if ((this.mUINum8 == null))
                {
                    this.mUINum8 = new UINum8(this);
                }
                return this.mUINum8;
            }
        }
        
        public UINum9 UINum9
        {
            get
            {
                if ((this.mUINum9 == null))
                {
                    this.mUINum9 = new UINum9(this);
                }
                return this.mUINum9;
            }
        }
        
        public UIDecimalSeparator UIDecimalSeparator
        {
            get
            {
                if ((this.mUIDecimalSeparator == null))
                {
                    this.mUIDecimalSeparator = new UIDecimalSeparator(this);
                }
                return this.mUIDecimalSeparator;
            }
        }
        
        public UIAdd UIAdd
        {
            get
            {
                if ((this.mUIAdd == null))
                {
                    this.mUIAdd = new UIAdd(this);
                }
                return this.mUIAdd;
            }
        }
        
        public UISubtract UISubtract
        {
            get
            {
                if ((this.mUISubtract == null))
                {
                    this.mUISubtract = new UISubtract(this);
                }
                return this.mUISubtract;
            }
        }
        
        public UIMultiply UIMultiply
        {
            get
            {
                if ((this.mUIMultiply == null))
                {
                    this.mUIMultiply = new UIMultiply(this);
                }
                return this.mUIMultiply;
            }
        }
        
        public UIDivide UIDivide
        {
            get
            {
                if ((this.mUIDivide == null))
                {
                    this.mUIDivide = new UIDivide(this);
                }
                return this.mUIDivide;
            }
        }
        
        public UIEquals UIEquals
        {
            get
            {
                if ((this.mUIEquals == null))
                {
                    this.mUIEquals = new UIEquals(this);
                }
                return this.mUIEquals;
            }
        }
        
        public UIClear UIClear
        {
            get
            {
                if ((this.mUIClear == null))
                {
                    this.mUIClear = new UIClear(this);
                }
                return this.mUIClear;
            }
        }
        
        public UIClearEntry UIClearEntry
        {
            get
            {
                if ((this.mUIClearEntry == null))
                {
                    this.mUIClearEntry = new UIClearEntry(this);
                }
                return this.mUIClearEntry;
            }
        }
        
        public UIResultBox UIResultBox
        {
            get
            {
                if ((this.mUIResultBox == null))
                {
                    this.mUIResultBox = new UIResultBox(this);
                }
                return this.mUIResultBox;
            }
        }
        #endregion
        
        #region Fields
        private UINum0 mUINum0;
        
        private UINum1 mUINum1;
        
        private UINum2 mUINum2;
        
        private UINum3 mUINum3;
        
        private UINum4 mUINum4;
        
        private UINum5 mUINum5;
        
        private UINum6 mUINum6;
        
        private UINum7 mUINum7;
        
        private UINum8 mUINum8;
        
        private UINum9 mUINum9;
        
        private UIDecimalSeparator mUIDecimalSeparator;
        
        private UIAdd mUIAdd;
        
        private UISubtract mUISubtract;
        
        private UIMultiply mUIMultiply;
        
        private UIDivide mUIDivide;
        
        private UIEquals mUIEquals;
        
        private UIClear mUIClear;
        
        private UIClearEntry mUIClearEntry;
        
        private UIResultBox mUIResultBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum0 : WinWindow
    {
        
        public UINum0(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "130";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "0";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum1 : WinWindow
    {
        
        public UINum1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "131";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "1";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum2 : WinWindow
    {
        
        public UINum2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "132";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "2";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum3 : WinWindow
    {
        
        public UINum3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "133";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "3";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum4 : WinWindow
    {
        
        public UINum4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "134";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "4";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum5 : WinWindow
    {
        
        public UINum5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "135";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "5";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum6 : WinWindow
    {
        
        public UINum6(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "136";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "6";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum7 : WinWindow
    {
        
        public UINum7(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "137";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "7";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum8 : WinWindow
    {
        
        public UINum8(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "138";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "8";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UINum9 : WinWindow
    {
        
        public UINum9(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "139";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "9";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDecimalSeparator : WinWindow
    {
        
        public UIDecimalSeparator(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "84";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Decimal separator";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIAdd : WinWindow
    {
        
        public UIAdd(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "93";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UISubtract : WinWindow
    {
        
        public UISubtract(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "94";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Subtract";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMultiply : WinWindow
    {
        
        public UIMultiply(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "92";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Multiply";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDivide : WinWindow
    {
        
        public UIDivide(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "91";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Divide";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIEquals : WinWindow
    {
        
        public UIEquals(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "121";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIClear : WinWindow
    {
        
        public UIClear(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "81";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIClearEntry : WinWindow
    {
        
        public UIClearEntry(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "82";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton Button
        {
            get
            {
                if ((this.mButton == null))
                {
                    this.mButton = new WinButton(this);
                    #region Search Criteria
                    this.mButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear entry";
                    this.mButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIResultBox : WinWindow
    {
        
        public UIResultBox(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "150";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinText TextBox
        {
            get
            {
                if ((this.mTextBox == null))
                {
                    this.mTextBox = new WinText(this);
                    #region Search Criteria
                    this.mTextBox.SearchProperties[WinText.PropertyNames.Name] = "Result";
                    this.mTextBox.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mTextBox;
            }
        }
        #endregion
        
        #region Fields
        private WinText mTextBox;
        #endregion
    }
}