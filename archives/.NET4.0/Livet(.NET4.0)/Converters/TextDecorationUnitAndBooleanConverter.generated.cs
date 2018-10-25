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
    /// TextDecorationUnit列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class TextDecorationUnitAndBooleanConverter : IValueConverter
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
        private TextDecorationUnit _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのTextDecorationUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDecorationUnit ConvertWhenTrue
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
        private TextDecorationUnit _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのTextDecorationUnit列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public TextDecorationUnit ConvertWhenFalse
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
            if (!(value is TextDecorationUnit)) throw new ArgumentException();

            var enumValue = (TextDecorationUnit)value;

			switch(enumValue.ToString())
			{
				case "FontRecommended":
					if (_isConvertBackWhenFontRecommendedSet)
					{
						return ConvertBackWhenFontRecommended;
					}
					break;
				case "FontRenderingEmSize":
					if (_isConvertBackWhenFontRenderingEmSizeSet)
					{
						return ConvertBackWhenFontRenderingEmSize;
					}
					break;
				case "Pixel":
					if (_isConvertBackWhenPixelSet)
					{
						return ConvertBackWhenPixel;
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
        /// TextDecorationUnitの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenFontRecommendedSet;
        private bool _convertBackWhenFontRecommended;
		/// <summary>
        /// TextDecorationUnitの値がFontRecommendedの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFontRecommended
        {
            get
            {
                return _convertBackWhenFontRecommended;
            }
            set
            {
                _convertBackWhenFontRecommended = value;
                _isConvertBackWhenFontRecommendedSet = true;
            }
        }
        private bool _isConvertBackWhenFontRenderingEmSizeSet;
        private bool _convertBackWhenFontRenderingEmSize;
		/// <summary>
        /// TextDecorationUnitの値がFontRenderingEmSizeの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenFontRenderingEmSize
        {
            get
            {
                return _convertBackWhenFontRenderingEmSize;
            }
            set
            {
                _convertBackWhenFontRenderingEmSize = value;
                _isConvertBackWhenFontRenderingEmSizeSet = true;
            }
        }
        private bool _isConvertBackWhenPixelSet;
        private bool _convertBackWhenPixel;
		/// <summary>
        /// TextDecorationUnitの値がPixelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPixel
        {
            get
            {
                return _convertBackWhenPixel;
            }
            set
            {
                _convertBackWhenPixel = value;
                _isConvertBackWhenPixelSet = true;
            }
        }
    }
}