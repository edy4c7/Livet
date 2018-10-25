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
    /// FontEastAsianWidths列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FontEastAsianWidthsAndBooleanConverter : IValueConverter
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
        private FontEastAsianWidths _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFontEastAsianWidths列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEastAsianWidths ConvertWhenTrue
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
        private FontEastAsianWidths _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFontEastAsianWidths列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FontEastAsianWidths ConvertWhenFalse
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
            if (!(value is FontEastAsianWidths)) throw new ArgumentException();

            var enumValue = (FontEastAsianWidths)value;

			switch(enumValue.ToString())
			{
				case "Normal":
					if (_isConvertBackWhenNormalSet)
					{
						return ConvertBackWhenNormal;
					}
					break;
				case "Proportional":
					if (_isConvertBackWhenProportionalSet)
					{
						return ConvertBackWhenProportional;
					}
					break;
				case "Full":
					if (_isConvertBackWhenFullSet)
					{
						return ConvertBackWhenFull;
					}
					break;
				case "Half":
					if (_isConvertBackWhenHalfSet)
					{
						return ConvertBackWhenHalf;
					}
					break;
				case "Third":
					if (_isConvertBackWhenThirdSet)
					{
						return ConvertBackWhenThird;
					}
					break;
				case "Quarter":
					if (_isConvertBackWhenQuarterSet)
					{
						return ConvertBackWhenQuarter;
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
        /// FontEastAsianWidthsの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenNormalSet;
        private bool _convertBackWhenNormal;
		/// <summary>
        /// FontEastAsianWidthsの値がNormalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNormal
        {
            get
            {
                return _convertBackWhenNormal;
            }
            set
            {
                _convertBackWhenNormal = value;
                _isConvertBackWhenNormalSet = true;
            }
        }
        private bool _isConvertBackWhenProportionalSet;
        private bool _convertBackWhenProportional;
		/// <summary>
        /// FontEastAsianWidthsの値がProportionalの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenProportional
        {
            get
            {
                return _convertBackWhenProportional;
            }
            set
            {
                _convertBackWhenProportional = value;
                _isConvertBackWhenProportionalSet = true;
            }
        }
        private bool _isConvertBackWhenFullSet;
        private bool _convertBackWhenFull;
		/// <summary>
        /// FontEastAsianWidthsの値がFullの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFull
        {
            get
            {
                return _convertBackWhenFull;
            }
            set
            {
                _convertBackWhenFull = value;
                _isConvertBackWhenFullSet = true;
            }
        }
        private bool _isConvertBackWhenHalfSet;
        private bool _convertBackWhenHalf;
		/// <summary>
        /// FontEastAsianWidthsの値がHalfの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenHalf
        {
            get
            {
                return _convertBackWhenHalf;
            }
            set
            {
                _convertBackWhenHalf = value;
                _isConvertBackWhenHalfSet = true;
            }
        }
        private bool _isConvertBackWhenThirdSet;
        private bool _convertBackWhenThird;
		/// <summary>
        /// FontEastAsianWidthsの値がThirdの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenThird
        {
            get
            {
                return _convertBackWhenThird;
            }
            set
            {
                _convertBackWhenThird = value;
                _isConvertBackWhenThirdSet = true;
            }
        }
        private bool _isConvertBackWhenQuarterSet;
        private bool _convertBackWhenQuarter;
		/// <summary>
        /// FontEastAsianWidthsの値がQuarterの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenQuarter
        {
            get
            {
                return _convertBackWhenQuarter;
            }
            set
            {
                _convertBackWhenQuarter = value;
                _isConvertBackWhenQuarterSet = true;
            }
        }
    }
}