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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The Linear Density, or more precisely, the linear mass density, of a substance is its mass per unit length.  The term linear density is most often used when describing the characteristics of one-dimensional objects, although linear density can also be used to describe the density of a three-dimensional quantity along one particular dimension.
    /// </summary>
    /// <remarks>
    ///     http://en.wikipedia.org/wiki/Linear_density
    /// </remarks>
    public struct  LinearDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LinearDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public LinearDensityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public LinearDensity(double value, LinearDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static LinearDensityUnit BaseUnit { get; } = LinearDensityUnit.KilogramPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static LinearDensity MaxValue { get; } = new LinearDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static LinearDensity MinValue { get; } = new LinearDensity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static LinearDensity Zero { get; } = new LinearDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get LinearDensity in GramsPerCentimeter.
        /// </summary>
        public double GramsPerCentimeter => As(LinearDensityUnit.GramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in GramsPerMeter.
        /// </summary>
        public double GramsPerMeter => As(LinearDensityUnit.GramPerMeter);

        /// <summary>
        ///     Get LinearDensity in GramsPerMillimeter.
        /// </summary>
        public double GramsPerMillimeter => As(LinearDensityUnit.GramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerCentimeter.
        /// </summary>
        public double KilogramsPerCentimeter => As(LinearDensityUnit.KilogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerMeter.
        /// </summary>
        public double KilogramsPerMeter => As(LinearDensityUnit.KilogramPerMeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerMillimeter.
        /// </summary>
        public double KilogramsPerMillimeter => As(LinearDensityUnit.KilogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerCentimeter.
        /// </summary>
        public double MicrogramsPerCentimeter => As(LinearDensityUnit.MicrogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerMeter.
        /// </summary>
        public double MicrogramsPerMeter => As(LinearDensityUnit.MicrogramPerMeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerMillimeter.
        /// </summary>
        public double MicrogramsPerMillimeter => As(LinearDensityUnit.MicrogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerCentimeter.
        /// </summary>
        public double MilligramsPerCentimeter => As(LinearDensityUnit.MilligramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerMeter.
        /// </summary>
        public double MilligramsPerMeter => As(LinearDensityUnit.MilligramPerMeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerMillimeter.
        /// </summary>
        public double MilligramsPerMillimeter => As(LinearDensityUnit.MilligramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in PoundsPerFoot.
        /// </summary>
        public double PoundsPerFoot => As(LinearDensityUnit.PoundPerFoot);

        /// <summary>
        ///     Get LinearDensity in PoundsPerInch.
        /// </summary>
        public double PoundsPerInch => As(LinearDensityUnit.PoundPerInch);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get LinearDensity from GramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromGramsPerCentimeter(double gramspercentimeter) => new LinearDensity(gramspercentimeter, LinearDensityUnit.GramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity from GramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromGramsPerMeter(double gramspermeter) => new LinearDensity(gramspermeter, LinearDensityUnit.GramPerMeter);

        /// <summary>
        ///     Get LinearDensity from GramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromGramsPerMillimeter(double gramspermillimeter) => new LinearDensity(gramspermillimeter, LinearDensityUnit.GramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity from KilogramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromKilogramsPerCentimeter(double kilogramspercentimeter) => new LinearDensity(kilogramspercentimeter, LinearDensityUnit.KilogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity from KilogramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromKilogramsPerMeter(double kilogramspermeter) => new LinearDensity(kilogramspermeter, LinearDensityUnit.KilogramPerMeter);

        /// <summary>
        ///     Get LinearDensity from KilogramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromKilogramsPerMillimeter(double kilogramspermillimeter) => new LinearDensity(kilogramspermillimeter, LinearDensityUnit.KilogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity from MicrogramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMicrogramsPerCentimeter(double microgramspercentimeter) => new LinearDensity(microgramspercentimeter, LinearDensityUnit.MicrogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity from MicrogramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMicrogramsPerMeter(double microgramspermeter) => new LinearDensity(microgramspermeter, LinearDensityUnit.MicrogramPerMeter);

        /// <summary>
        ///     Get LinearDensity from MicrogramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMicrogramsPerMillimeter(double microgramspermillimeter) => new LinearDensity(microgramspermillimeter, LinearDensityUnit.MicrogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity from MilligramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMilligramsPerCentimeter(double milligramspercentimeter) => new LinearDensity(milligramspercentimeter, LinearDensityUnit.MilligramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity from MilligramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMilligramsPerMeter(double milligramspermeter) => new LinearDensity(milligramspermeter, LinearDensityUnit.MilligramPerMeter);

        /// <summary>
        ///     Get LinearDensity from MilligramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromMilligramsPerMillimeter(double milligramspermillimeter) => new LinearDensity(milligramspermillimeter, LinearDensityUnit.MilligramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity from PoundsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromPoundsPerFoot(double poundsperfoot) => new LinearDensity(poundsperfoot, LinearDensityUnit.PoundPerFoot);

        /// <summary>
        ///     Get LinearDensity from PoundsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LinearDensity FromPoundsPerInch(double poundsperinch) => new LinearDensity(poundsperinch, LinearDensityUnit.PoundPerInch);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LinearDensityUnit" /> to <see cref="LinearDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LinearDensity unit value.</returns>
        public static LinearDensity From(double value, LinearDensityUnit fromUnit)
        {
            return new LinearDensity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(LinearDensityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public LinearDensity ToUnit(LinearDensityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new LinearDensity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case LinearDensityUnit.GramPerCentimeter: return _value*1e-1;
                case LinearDensityUnit.GramPerMeter: return _value*1e-3;
                case LinearDensityUnit.GramPerMillimeter: return _value;
                case LinearDensityUnit.KilogramPerCentimeter: return (_value*1e-1) * 1e3d;
                case LinearDensityUnit.KilogramPerMeter: return (_value*1e-3) * 1e3d;
                case LinearDensityUnit.KilogramPerMillimeter: return (_value) * 1e3d;
                case LinearDensityUnit.MicrogramPerCentimeter: return (_value*1e-1) * 1e-6d;
                case LinearDensityUnit.MicrogramPerMeter: return (_value*1e-3) * 1e-6d;
                case LinearDensityUnit.MicrogramPerMillimeter: return (_value) * 1e-6d;
                case LinearDensityUnit.MilligramPerCentimeter: return (_value*1e-1) * 1e-3d;
                case LinearDensityUnit.MilligramPerMeter: return (_value*1e-3) * 1e-3d;
                case LinearDensityUnit.MilligramPerMillimeter: return (_value) * 1e-3d;
                case LinearDensityUnit.PoundPerFoot: return _value*1.48816394;
                case LinearDensityUnit.PoundPerInch: return _value/5.5997415e-2;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(LinearDensityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case LinearDensityUnit.GramPerCentimeter: return baseUnitValue/1e-1;
                case LinearDensityUnit.GramPerMeter: return baseUnitValue/1e-3;
                case LinearDensityUnit.GramPerMillimeter: return baseUnitValue;
                case LinearDensityUnit.KilogramPerCentimeter: return (baseUnitValue/1e-1) / 1e3d;
                case LinearDensityUnit.KilogramPerMeter: return (baseUnitValue/1e-3) / 1e3d;
                case LinearDensityUnit.KilogramPerMillimeter: return (baseUnitValue) / 1e3d;
                case LinearDensityUnit.MicrogramPerCentimeter: return (baseUnitValue/1e-1) / 1e-6d;
                case LinearDensityUnit.MicrogramPerMeter: return (baseUnitValue/1e-3) / 1e-6d;
                case LinearDensityUnit.MicrogramPerMillimeter: return (baseUnitValue) / 1e-6d;
                case LinearDensityUnit.MilligramPerCentimeter: return (baseUnitValue/1e-1) / 1e-3d;
                case LinearDensityUnit.MilligramPerMeter: return (baseUnitValue/1e-3) / 1e-3d;
                case LinearDensityUnit.MilligramPerMillimeter: return (baseUnitValue) / 1e-3d;
                case LinearDensityUnit.PoundPerFoot: return baseUnitValue/1.48816394;
                case LinearDensityUnit.PoundPerInch: return baseUnitValue*5.5997415e-2;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

