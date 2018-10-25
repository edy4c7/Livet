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
    /// ValidationStep列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class ValidationStepAndBooleanConverter : IValueConverter
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
        private ValidationStep _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのValidationStep列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ValidationStep ConvertWhenTrue
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
        private ValidationStep _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのValidationStep列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public ValidationStep ConvertWhenFalse
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
            if (!(value is ValidationStep)) throw new ArgumentException();

            var enumValue = (ValidationStep)value;

			switch(enumValue.ToString())
			{
				case "RawProposedValue":
					if (_isConvertBackWhenRawProposedValueSet)
					{
						return ConvertBackWhenRawProposedValue;
					}
					break;
				case "ConvertedProposedValue":
					if (_isConvertBackWhenConvertedProposedValueSet)
					{
						return ConvertBackWhenConvertedProposedValue;
					}
					break;
				case "UpdatedValue":
					if (_isConvertBackWhenUpdatedValueSet)
					{
						return ConvertBackWhenUpdatedValue;
					}
					break;
				case "CommittedValue":
					if (_isConvertBackWhenCommittedValueSet)
					{
						return ConvertBackWhenCommittedValue;
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
        /// ValidationStepの値をbool値に変換する際のデフォルト値を指定、または取得します。
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

        private bool _isConvertBackWhenRawProposedValueSet;
        private bool _convertBackWhenRawProposedValue;
		/// <summary>
        /// ValidationStepの値がRawProposedValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRawProposedValue
        {
            get
            {
                return _convertBackWhenRawProposedValue;
            }
            set
            {
                _convertBackWhenRawProposedValue = value;
                _isConvertBackWhenRawProposedValueSet = true;
            }
        }
        private bool _isConvertBackWhenConvertedProposedValueSet;
        private bool _convertBackWhenConvertedProposedValue;
		/// <summary>
        /// ValidationStepの値がConvertedProposedValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenConvertedProposedValue
        {
            get
            {
                return _convertBackWhenConvertedProposedValue;
            }
            set
            {
                _convertBackWhenConvertedProposedValue = value;
                _isConvertBackWhenConvertedProposedValueSet = true;
            }
        }
        private bool _isConvertBackWhenUpdatedValueSet;
        private bool _convertBackWhenUpdatedValue;
		/// <summary>
        /// ValidationStepの値がUpdatedValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenUpdatedValue
        {
            get
            {
                return _convertBackWhenUpdatedValue;
            }
            set
            {
                _convertBackWhenUpdatedValue = value;
                _isConvertBackWhenUpdatedValueSet = true;
            }
        }
        private bool _isConvertBackWhenCommittedValueSet;
        private bool _convertBackWhenCommittedValue;
		/// <summary>
        /// ValidationStepの値がCommittedValueの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenCommittedValue
        {
            get
            {
                return _convertBackWhenCommittedValue;
            }
            set
            {
                _convertBackWhenCommittedValue = value;
                _isConvertBackWhenCommittedValueSet = true;
            }
        }
    }
}