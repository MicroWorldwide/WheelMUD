//-----------------------------------------------------------------------------
// <copyright file="ValidationResult.cs" company="http://rulesengine.codeplex.com">
//   Copyright (c) athoma13. See RulesEngine_License.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   Created by: athoma13
//   Date      : Fri Sep 30 2011
//   Purpose   : Rule Engine
// </summary>
// <history>
//   Sat Jan 28 2012 by Fastalanasa - Added to WheelMUD.Rules
// </history>
//-----------------------------------------------------------------------------

namespace WheelMUD.Rules
{
    public struct ValidationResult
    {
        private static readonly ValidationResult _valid = new ValidationResult(true, null);

        private bool _isValid;
        private object[] _arguments;

        public ValidationResult(bool isValid, object[] arguments)
        {
            this._isValid = isValid;
            this._arguments = arguments;
        }

        /// <summary>Gets the success result for a validation.</summary>
        public static ValidationResult Success
        {
            get { return _valid; }
        }

        /// <summary>Gets a value indicating whether the result is valid.</summary>
        public bool IsValid
        {
            get { return this._isValid; }
        }

        /// <summary>Gets Arguments.</summary>
        public object[] Arguments
        {
            get { return this._arguments; }
        }

        public static ValidationResult Fail(params object[] arguments)
        {
            return new ValidationResult(false, arguments);
        }

        public static ValidationResult Fail()
        {
            return new ValidationResult(false, new object[0]);
        }
    }
}