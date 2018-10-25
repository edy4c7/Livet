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
    /// FigureUnitType列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FigureUnitTypeAndBooleanConverter : IValueConverter
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
        private FigureUnitType _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFigureUnitType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureUnitType ConvertWhenTrue
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
        private FigureUnitType _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFigureUnitType列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FigureUnitType ConvertWhenFalse
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
            if (!(value is FigureUnitType)) throw new ArgumentException();

            var enumValue = (FigureUnitType)value;

			switch(enumValue.ToString())
			{
				case "Auto":
					if (_isConvertBackWhenAutoSet)
					{
						return ConvertBackWhenAuto;
					}
					break;
				case "Pixel":
					if (_isConvertBackWhenPixelSet)
					{
						return ConvertBackWhenPixel;
					}
					break;
				case "Column":
					if (_isConvertBackWhenColumnSet)
					{
						return ConvertBackWhenColumn;
					}
					break;
				case "Content":
					if (_isConvertBackWhenContentSet)
					{
						return ConvertBackWhenContent;
					}
					break;
				case "Page":
					if (_isConvertBackWhenPageSet)
					{
						return ConvertBackWhenPage;
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
        /// FigureUnitTypeの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenAutoSet;
        private bool _convertBackWhenAuto;
		/// <summary>
        /// FigureUnitTypeの値がAutoの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenAuto
        {
            get
            {
                return _convertBackWhenAuto;
            }
            set
            {
                _convertBackWhenAuto = value;
                _isConvertBackWhenAutoSet = true;
            }
        }
        private bool _isConvertBackWhenPixelSet;
        private bool _convertBackWhenPixel;
		/// <summary>
        /// FigureUnitTypeの値がPixelの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
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
        private bool _isConvertBackWhenColumnSet;
        private bool _convertBackWhenColumn;
		/// <summary>
        /// FigureUnitTypeの値がColumnの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenColumn
        {
            get
            {
                return _convertBackWhenColumn;
            }
            set
            {
                _convertBackWhenColumn = value;
                _isConvertBackWhenColumnSet = true;
            }
        }
        private bool _isConvertBackWhenContentSet;
        private bool _convertBackWhenContent;
		/// <summary>
        /// FigureUnitTypeの値がContentの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenContent
        {
            get
            {
                return _convertBackWhenContent;
            }
            set
            {
                _convertBackWhenContent = value;
                _isConvertBackWhenContentSet = true;
            }
        }
        private bool _isConvertBackWhenPageSet;
        private bool _convertBackWhenPage;
		/// <summary>
        /// FigureUnitTypeの値がPageの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenPage
        {
            get
            {
                return _convertBackWhenPage;
            }
            set
            {
                _convertBackWhenPage = value;
                _isConvertBackWhenPageSet = true;
            }
        }
    }
}