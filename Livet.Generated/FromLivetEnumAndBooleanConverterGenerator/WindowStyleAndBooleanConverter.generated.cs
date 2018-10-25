﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// WindowStyle列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class WindowStyleAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private WindowStyle _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのWindowStyle列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WindowStyle ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private WindowStyle _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのWindowStyle列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public WindowStyle ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is WindowStyle)) throw new ArgumentException();

            var enumValue = (WindowStyle)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "SingleBorderWindow":
					if (_isConvertBackWhenSingleBorderWindowSet)
					{
						return ConvertBackWhenSingleBorderWindow;
					}
					break;
				case "ThreeDBorderWindow":
					if (_isConvertBackWhenThreeDBorderWindowSet)
					{
						return ConvertBackWhenThreeDBorderWindow;
					}
					break;
				case "ToolWindow":
					if (_isConvertBackWhenToolWindowSet)
					{
						return ConvertBackWhenToolWindow;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// WindowStyleの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// WindowStyleの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenSingleBorderWindowSet;
        private bool _convertBackWhenSingleBorderWindow;
		/// <summary>
        /// WindowStyleの値がSingleBorderWindowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenSingleBorderWindow
        {
            get
            {
                return _convertBackWhenSingleBorderWindow;
            }
            set
            {
                _convertBackWhenSingleBorderWindow = value;
                _isConvertBackWhenSingleBorderWindowSet = true;
            }
        }
        private bool _isConvertBackWhenThreeDBorderWindowSet;
        private bool _convertBackWhenThreeDBorderWindow;
		/// <summary>
        /// WindowStyleの値がThreeDBorderWindowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenThreeDBorderWindow
        {
            get
            {
                return _convertBackWhenThreeDBorderWindow;
            }
            set
            {
                _convertBackWhenThreeDBorderWindow = value;
                _isConvertBackWhenThreeDBorderWindowSet = true;
            }
        }
        private bool _isConvertBackWhenToolWindowSet;
        private bool _convertBackWhenToolWindow;
		/// <summary>
        /// WindowStyleの値がToolWindowの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenToolWindow
        {
            get
            {
                return _convertBackWhenToolWindow;
            }
            set
            {
                _convertBackWhenToolWindow = value;
                _isConvertBackWhenToolWindowSet = true;
            }
        }
    }
}