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
    /// SelectiveScrollingOrientation列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class SelectiveScrollingOrientationAndBooleanConverter : IValueConverter
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
        private SelectiveScrollingOrientation _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのSelectiveScrollingOrientation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SelectiveScrollingOrientation ConvertWhenTrue
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
        private SelectiveScrollingOrientation _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのSelectiveScrollingOrientation列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public SelectiveScrollingOrientation ConvertWhenFalse
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
            if (!(value is SelectiveScrollingOrientation)) throw new ArgumentException();

            var enumValue = (SelectiveScrollingOrientation)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Horizontal":
					if (_isConvertBackWhenHorizontalSet)
					{
						return ConvertBackWhenHorizontal;
					}
					break;
				case "Vertical":
					if (_isConvertBackWhenVerticalSet)
					{
						return ConvertBackWhenVertical;
					}
					break;
				case "Both":
					if (_isConvertBackWhenBothSet)
					{
						return ConvertBackWhenBoth;
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
        /// SelectiveScrollingOrientationの値をbool値に変換する際のデフォルト値を指定、または取得します。
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
        /// SelectiveScrollingOrientationの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenHorizontalSet;
        private bool _convertBackWhenHorizontal;
		/// <summary>
        /// SelectiveScrollingOrientationの値がHorizontalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHorizontal
        {
            get
            {
                return _convertBackWhenHorizontal;
            }
            set
            {
                _convertBackWhenHorizontal = value;
                _isConvertBackWhenHorizontalSet = true;
            }
        }
        private bool _isConvertBackWhenVerticalSet;
        private bool _convertBackWhenVertical;
		/// <summary>
        /// SelectiveScrollingOrientationの値がVerticalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenVertical
        {
            get
            {
                return _convertBackWhenVertical;
            }
            set
            {
                _convertBackWhenVertical = value;
                _isConvertBackWhenVerticalSet = true;
            }
        }
        private bool _isConvertBackWhenBothSet;
        private bool _convertBackWhenBoth;
		/// <summary>
        /// SelectiveScrollingOrientationの値がBothの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenBoth
        {
            get
            {
                return _convertBackWhenBoth;
            }
            set
            {
                _convertBackWhenBoth = value;
                _isConvertBackWhenBothSet = true;
            }
        }
    }
}