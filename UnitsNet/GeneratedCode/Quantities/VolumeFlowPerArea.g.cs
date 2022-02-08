//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     
    /// </summary>
    [DataContract]
    public partial struct VolumeFlowPerArea : IQuantity<VolumeFlowPerAreaUnit>, IComparable, IComparable<VolumeFlowPerArea>, IConvertible, IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Value", Order = 0)]
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        [DataMember(Name = "Unit", Order = 1)]
        private readonly VolumeFlowPerAreaUnit? _unit;

        static VolumeFlowPerArea()
        {
            BaseDimensions = new BaseDimensions(1, 0, -1, 0, 0, 0, 0);
            BaseUnit = VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter;
            MaxValue = new VolumeFlowPerArea(double.MaxValue, BaseUnit);
            MinValue = new VolumeFlowPerArea(double.MinValue, BaseUnit);
            QuantityType = QuantityType.VolumeFlowPerArea;
            Units = Enum.GetValues(typeof(VolumeFlowPerAreaUnit)).Cast<VolumeFlowPerAreaUnit>().Except(new VolumeFlowPerAreaUnit[]{ VolumeFlowPerAreaUnit.Undefined }).ToArray();
            Zero = new VolumeFlowPerArea(0, BaseUnit);
            Info = new QuantityInfo<VolumeFlowPerAreaUnit>("VolumeFlowPerArea",
                new UnitInfo<VolumeFlowPerAreaUnit>[]
                {
                    new UnitInfo<VolumeFlowPerAreaUnit>(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, "CubicFeetPerMinutePerSquareFoot", new BaseUnits(length: LengthUnit.Foot, time: DurationUnit.Minute)),
                    new UnitInfo<VolumeFlowPerAreaUnit>(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, "CubicMetersPerSecondPerSquareMeter", new BaseUnits(length: LengthUnit.Meter, time: DurationUnit.Second)),
                },
                BaseUnit, Zero, BaseDimensions);

            RegisterDefaultConversions(DefaultConversionFunctions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public VolumeFlowPerArea(double value, VolumeFlowPerAreaUnit unit)
        {
            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        /// <summary>
        /// Creates an instance of the quantity with the given numeric value in units compatible with the given <see cref="UnitSystem"/>.
        /// If multiple compatible units were found, the first match is used.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unitSystem">The unit system to create the quantity with.</param>
        /// <exception cref="ArgumentNullException">The given <see cref="UnitSystem"/> is null.</exception>
        /// <exception cref="ArgumentException">No unit was found for the given <see cref="UnitSystem"/>.</exception>
        public VolumeFlowPerArea(double value, UnitSystem unitSystem)
        {
            if(unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="UnitConverter" /> containing the default generated conversion functions for <see cref="VolumeFlowPerArea" /> instances.
        /// </summary>
        public static UnitConverter DefaultConversionFunctions { get; } = new UnitConverter();

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<VolumeFlowPerAreaUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of VolumeFlowPerArea, which is CubicMeterPerSecondPerSquareMeter. All conversions go via this value.
        /// </summary>
        public static VolumeFlowPerAreaUnit BaseUnit { get; }

        /// <summary>
        ///     All units of measurement for the VolumeFlowPerArea quantity.
        /// </summary>
        public static VolumeFlowPerAreaUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit CubicMeterPerSecondPerSquareMeter.
        /// </summary>
        public static VolumeFlowPerArea Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public VolumeFlowPerAreaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<VolumeFlowPerAreaUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => VolumeFlowPerArea.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get VolumeFlowPerArea in CubicFeetPerMinutePerSquareFoot.
        /// </summary>
        public double CubicFeetPerMinutePerSquareFoot => As(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot);

        /// <summary>
        ///     Get VolumeFlowPerArea in CubicMetersPerSecondPerSquareMeter.
        /// </summary>
        public double CubicMetersPerSecondPerSquareMeter => As(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);

        #endregion

        #region Static Methods

        /// <summary>
        /// Registers the default conversion functions in the given <see cref="UnitConverter"/> instance.
        /// </summary>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to register the default conversion functions in.</param>
        internal static void RegisterDefaultConversions(UnitConverter unitConverter)
        {
            // Register in unit converter: BaseUnit -> VolumeFlowPerAreaUnit
            unitConverter.SetConversionFunction<VolumeFlowPerArea>(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, quantity => new VolumeFlowPerArea(quantity.Value*196.850394, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot));
            // Register in unit converter: BaseUnit <-> BaseUnit
            unitConverter.SetConversionFunction<VolumeFlowPerArea>(VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, quantity => quantity);

            // Register in unit converter: VolumeFlowPerAreaUnit -> BaseUnit
            unitConverter.SetConversionFunction<VolumeFlowPerArea>(VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter, quantity => new VolumeFlowPerArea(quantity.Value/196.850394, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter));
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(VolumeFlowPerAreaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static string GetAbbreviation(VolumeFlowPerAreaUnit unit, IFormatProvider? provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get VolumeFlowPerArea from CubicFeetPerMinutePerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlowPerArea FromCubicFeetPerMinutePerSquareFoot(QuantityValue cubicfeetperminutepersquarefoot)
        {
            double value = (double) cubicfeetperminutepersquarefoot;
            return new VolumeFlowPerArea(value, VolumeFlowPerAreaUnit.CubicFootPerMinutePerSquareFoot);
        }
        /// <summary>
        ///     Get VolumeFlowPerArea from CubicMetersPerSecondPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumeFlowPerArea FromCubicMetersPerSecondPerSquareMeter(QuantityValue cubicmeterspersecondpersquaremeter)
        {
            double value = (double) cubicmeterspersecondpersquaremeter;
            return new VolumeFlowPerArea(value, VolumeFlowPerAreaUnit.CubicMeterPerSecondPerSquareMeter);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeFlowPerAreaUnit" /> to <see cref="VolumeFlowPerArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumeFlowPerArea unit value.</returns>
        public static VolumeFlowPerArea From(QuantityValue value, VolumeFlowPerAreaUnit fromUnit)
        {
            return new VolumeFlowPerArea((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static VolumeFlowPerArea Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static VolumeFlowPerArea Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<VolumeFlowPerArea, VolumeFlowPerAreaUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse(string? str, out VolumeFlowPerArea result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParse(string? str, IFormatProvider? provider, out VolumeFlowPerArea result)
        {
            return QuantityParser.Default.TryParse<VolumeFlowPerArea, VolumeFlowPerAreaUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static VolumeFlowPerAreaUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static VolumeFlowPerAreaUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse<VolumeFlowPerAreaUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.VolumeFlowPerAreaUnit)"/>
        public static bool TryParseUnit(string str, out VolumeFlowPerAreaUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out VolumeFlowPerAreaUnit unit)
        {
            return UnitParser.Default.TryParse<VolumeFlowPerAreaUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static VolumeFlowPerArea operator -(VolumeFlowPerArea right)
        {
            return new VolumeFlowPerArea(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="VolumeFlowPerArea"/> from adding two <see cref="VolumeFlowPerArea"/>.</summary>
        public static VolumeFlowPerArea operator +(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return new VolumeFlowPerArea(left.Value + right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="VolumeFlowPerArea"/> from subtracting two <see cref="VolumeFlowPerArea"/>.</summary>
        public static VolumeFlowPerArea operator -(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return new VolumeFlowPerArea(left.Value - right.GetValueAs(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="VolumeFlowPerArea"/> from multiplying value and <see cref="VolumeFlowPerArea"/>.</summary>
        public static VolumeFlowPerArea operator *(double left, VolumeFlowPerArea right)
        {
            return new VolumeFlowPerArea(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="VolumeFlowPerArea"/> from multiplying value and <see cref="VolumeFlowPerArea"/>.</summary>
        public static VolumeFlowPerArea operator *(VolumeFlowPerArea left, double right)
        {
            return new VolumeFlowPerArea(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="VolumeFlowPerArea"/> from dividing <see cref="VolumeFlowPerArea"/> by value.</summary>
        public static VolumeFlowPerArea operator /(VolumeFlowPerArea left, double right)
        {
            return new VolumeFlowPerArea(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="VolumeFlowPerArea"/> by <see cref="VolumeFlowPerArea"/>.</summary>
        public static double operator /(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return left.CubicMetersPerSecondPerSquareMeter / right.CubicMetersPerSecondPerSquareMeter;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return left.Value <= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return left.Value >= right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return left.Value < right.GetValueAs(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(VolumeFlowPerArea left, VolumeFlowPerArea right)
        {
            return left.Value > right.GetValueAs(left.Unit);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is VolumeFlowPerArea objVolumeFlowPerArea)) throw new ArgumentException("Expected type VolumeFlowPerArea.", nameof(obj));

            return CompareTo(objVolumeFlowPerArea);
        }

        /// <inheritdoc />
        public int CompareTo(VolumeFlowPerArea other)
        {
            return _value.CompareTo(other.GetValueAs(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another VolumeFlowPerArea within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(VolumeFlowPerArea other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current VolumeFlowPerArea.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumeFlowPerAreaUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = GetValueAs(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public double As(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        double IQuantity.As(Enum unit)
        {
            if(!(unit is VolumeFlowPerAreaUnit unitAsVolumeFlowPerAreaUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(VolumeFlowPerAreaUnit)} is supported.", nameof(unit));

            return As(unitAsVolumeFlowPerAreaUnit);
        }

        /// <summary>
        ///     Converts this VolumeFlowPerArea to another VolumeFlowPerArea with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <returns>A VolumeFlowPerArea with the specified unit.</returns>
        public VolumeFlowPerArea ToUnit(VolumeFlowPerAreaUnit unit)
        {
            return ToUnit(unit, DefaultConversionFunctions);
        }

        /// <summary>
        ///     Converts this VolumeFlowPerArea to another VolumeFlowPerArea using the given <paramref name="unitConverter"/> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <param name="unit">The unit to convert to.</param>
        /// <param name="unitConverter">The <see cref="UnitConverter"/> to use for the conversion.</param>
        /// <returns>A VolumeFlowPerArea with the specified unit.</returns>
        public VolumeFlowPerArea ToUnit(VolumeFlowPerAreaUnit unit, UnitConverter unitConverter)
        {
            if(Unit == unit)
            {
                // Already in requested units.
                return this;
            }
            else if(unitConverter.TryGetConversionFunction((typeof(VolumeFlowPerArea), Unit, typeof(VolumeFlowPerArea), unit), out var conversionFunction))
            {
                // Direct conversion to requested unit found. Return the converted quantity.
                var converted = conversionFunction(this);
                return (VolumeFlowPerArea)converted;
            }
            else if(Unit != BaseUnit)
            {
                // Direct conversion to requested unit NOT found. Convert to BaseUnit, and then from BaseUnit to requested unit.
                var inBaseUnits = ToUnit(BaseUnit);
                return inBaseUnits.ToUnit(unit);
            }
            else
            {
                throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if(!(unit is VolumeFlowPerAreaUnit unitAsVolumeFlowPerAreaUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(VolumeFlowPerAreaUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsVolumeFlowPerAreaUnit, DefaultConversionFunctions);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit, UnitConverter unitConverter)
        {
            if(!(unit is VolumeFlowPerAreaUnit unitAsVolumeFlowPerAreaUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(VolumeFlowPerAreaUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsVolumeFlowPerAreaUnit, unitConverter);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public VolumeFlowPerArea ToUnit(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<VolumeFlowPerAreaUnit> IQuantity<VolumeFlowPerAreaUnit>.ToUnit(VolumeFlowPerAreaUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<VolumeFlowPerAreaUnit> IQuantity<VolumeFlowPerAreaUnit>.ToUnit(VolumeFlowPerAreaUnit unit, UnitConverter unitConverter) => ToUnit(unit, unitConverter);

        /// <inheritdoc />
        IQuantity<VolumeFlowPerAreaUnit> IQuantity<VolumeFlowPerAreaUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        private double GetValueAs(VolumeFlowPerAreaUnit unit)
        {
            var converted = ToUnit(unit);
            return (double)converted.Value;
            }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentCulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentCulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<VolumeFlowPerAreaUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(VolumeFlowPerArea)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(VolumeFlowPerArea)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(VolumeFlowPerArea)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(VolumeFlowPerArea))
                return this;
            else if(conversionType == typeof(VolumeFlowPerAreaUnit))
                return Unit;
            else if(conversionType == typeof(QuantityInfo))
                return VolumeFlowPerArea.Info;
            else if(conversionType == typeof(BaseDimensions))
                return VolumeFlowPerArea.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(VolumeFlowPerArea)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
