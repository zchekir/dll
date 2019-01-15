// Copyright 2001-2010 - Active Up SPRLU (http://www.agilecomponents.com)
//
// This file is part of MailSystem.NET.
// MailSystem.NET is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// MailSystem.NET is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with SharpMap; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;

namespace ActiveUp.Net.Mail
{
    /// <summary>
    /// Represents the formatting options of a message template field.
    /// </summary>
#if !PocketPC
    [Serializable]
#endif
    public class Condition
    {
        private string _regionID, _field, _value, _nulltext;
        private OperatorType _operator;
        private bool _caseSensitive, _match;

        /// <summary>
        /// The default constructor.
        /// </summary>
        public Condition()
        {
            RegionID = string.Empty;
            Field = string.Empty;
            Operator = OperatorType.Equal;
            CaseSensitive = true;
            Value = null;
        }

        /// <summary>
        /// Creates the condition based on it's region id, field equal to value set with case-sensitive on.
        /// </summary>
        /// <param name="regionid">The ID of the region.</param>
        /// <param name="field">The name of the field.</param>
        /// <param name="aValue">The value to match.</param>
        public Condition(string regionid, string field, string aValue)
        {
            RegionID = regionid;
            Field = field;
            Operator = OperatorType.Equal;
            CaseSensitive = true;
            Value = aValue;
        }

        public string NullText
        {
            get
            {
                return _nulltext;
            }
            set
            {
                _nulltext = value;
            }
        }
        /// <summary>
        /// Creates the condition based on it's region id, field, operator to evaluate to the value and whether it is case sensitive.
        /// </summary>
        /// <param name="regionid">The ID of the region.</param>
        /// <param name="field">The name of the field.</param>
        /// <param name="aValue">The value to match.</param>
        /// <param name="aOperator">The operator for the comparison.</param>
        /// <param name="casesensitive">Whether the value is matched with case sensitivity.</param>
        public Condition(string regionid, string field, string aValue, OperatorType aOperator, bool casesensitive)
        {
            RegionID = regionid;
            Field = field;
            Operator = aOperator;
            CaseSensitive = casesensitive;
            Value = aValue;
        }

        /// <summary>
        /// Validate the condition against the values passed.
        /// </summary>
        /// <param name="aValue">The value to match.</param>
        public void Validate(object aValue)
        {
            try 
            {
                if (Value == null)
                    return;
                if (Match)
                    return; //only do the work once
                switch (Operator)
                {
                    case OperatorType.GreaterThan:
                        if (aValue == null)
                            aValue = 0;
                        if (IsNumeric((string)aValue) && IsNumeric(Value)) 
                        {
                            if (Convert.ToDouble(aValue) < Convert.ToDouble(Value))
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().Length < Value.Length)
                                Match = true;
                        }
                        break;
                    case OperatorType.GreaterThanEqual:
                        if (aValue == null)
                            aValue = 0;
                        if (IsNumeric((string)aValue) && IsNumeric(Value)) 
                        {
                            if (Convert.ToDouble(aValue) <= Convert.ToDouble(Value))
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().Length <= Value.Length)
                                Match = true;
                        }
                        break;
                    case OperatorType.LessThan:
                        if (aValue == null)
                            aValue = 0;
                        if (IsNumeric((string)aValue) && IsNumeric(Value)) 
                        {
                            if (Convert.ToDouble(aValue) > Convert.ToDouble(Value))
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().Length > Value.Length)
                                Match = true;
                        }
                        break;
                    case OperatorType.LessThanEqual:
                        if (aValue == null)
                            aValue = 0;
                        if (IsNumeric((string)aValue) && IsNumeric(Value)) 
                        {
                            if (Convert.ToDouble(aValue) >= Convert.ToDouble(Value))
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().Length >= Value.Length)
                                Match = true;
                        }
                        break;
                    case OperatorType.Equal:
                        if (aValue == null)
                            aValue = "";
                        if (CaseSensitive) 
                        {
                            if (aValue.ToString() == Value)
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().ToUpper() == Value.ToUpper())
                                Match = true;
                        }
                        break;
                    case OperatorType.NotEqual:
                        if (aValue == null)
                            aValue = "";
                        if (CaseSensitive) 
                        {
                            if (aValue.ToString() != Value)
                                Match = true;
                        }
                        else
                        {
                            if (aValue.ToString().ToUpper() != Value.ToUpper())
                                Match = true;
                        }
                        break;
                    case OperatorType.Exists:
                        Match = true;
                        break;
                    case OperatorType.NotExists:
                        Match = false;
                        break;
                }
            }
            catch 
            {
                 return;
            }
        }

        /// <summary>
        /// Whether the value is matched with case sensitivity.
        /// </summary>
        public bool CaseSensitive
        {
            get
            {
                return _caseSensitive;
            }
            set
            {
                _caseSensitive = value;
            }
        }

        /// <summary>
        /// Whether the condition was a match.
        /// </summary>
        public bool Match
        {
            get
            {
                return _match;
            }
            set
            {
                _match = value;
            }
        }

        /// <summary>
        /// The value to match.
        /// </summary>
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        /// <summary>
        /// The operator for the comparison.
        /// </summary>
        public OperatorType Operator
        {
            get
            {
                return _operator;
            }
            set
            {
                _operator = value;
                if (_operator == OperatorType.NotExists) 
                {
                    _match = true;
                }
            }
        }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        public string RegionID
        {
            get
            {
                return _regionID;
            }
            set
            {
                _regionID = value;
            }
        }

        /// <summary>
        /// The name of the field.
        /// </summary>
        public string Field
        {
            get
            {
                return _field;
            }
            set
            {
                _field = value;
            }
        }
        /// <summary>
        /// Checks if supplied expression is a numeric value. Supports multiple languages.
        /// </summary>
        /// <param name="expression">An expression that needs to be checked.</param>
        /// <returns>A boolean response that is True if it is a numeric value.</returns>
        public bool IsNumeric(object expression) {
            double retNum;
            return double.TryParse(Convert.ToString(expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
        }
    }
}