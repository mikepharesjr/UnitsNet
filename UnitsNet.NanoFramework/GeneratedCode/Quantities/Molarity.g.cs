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
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume. 
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molar_concentration
    /// </remarks>
    public struct  Molarity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MolarityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Molarity(double value, MolarityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MolarityUnit BaseUnit { get; } = MolarityUnit.MolesPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Molarity MaxValue { get; } = new Molarity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Molarity MinValue { get; } = new Molarity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Molarity Zero { get; } = new Molarity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Molarity in CentimolesPerLiter.
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolesPerLiter);

        /// <summary>
        ///     Get Molarity in DecimolesPerLiter.
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MicromolesPerLiter.
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolesPerLiter);

        /// <summary>
        ///     Get Molarity in MillimolesPerLiter.
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MolesPerCubicMeter.
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolesPerCubicMeter);

        /// <summary>
        ///     Get Molarity in MolesPerLiter.
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolesPerLiter);

        /// <summary>
        ///     Get Molarity in NanomolesPerLiter.
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolesPerLiter);

        /// <summary>
        ///     Get Molarity in PicomolesPerLiter.
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolesPerLiter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Molarity from CentimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromCentimolesPerLiter(double centimolesperliter) => new Molarity(centimolesperliter, MolarityUnit.CentimolesPerLiter);

        /// <summary>
        ///     Get Molarity from DecimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromDecimolesPerLiter(double decimolesperliter) => new Molarity(decimolesperliter, MolarityUnit.DecimolesPerLiter);

        /// <summary>
        ///     Get Molarity from MicromolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMicromolesPerLiter(double micromolesperliter) => new Molarity(micromolesperliter, MolarityUnit.MicromolesPerLiter);

        /// <summary>
        ///     Get Molarity from MillimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMillimolesPerLiter(double millimolesperliter) => new Molarity(millimolesperliter, MolarityUnit.MillimolesPerLiter);

        /// <summary>
        ///     Get Molarity from MolesPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter) => new Molarity(molespercubicmeter, MolarityUnit.MolesPerCubicMeter);

        /// <summary>
        ///     Get Molarity from MolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerLiter(double molesperliter) => new Molarity(molesperliter, MolarityUnit.MolesPerLiter);

        /// <summary>
        ///     Get Molarity from NanomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter) => new Molarity(nanomolesperliter, MolarityUnit.NanomolesPerLiter);

        /// <summary>
        ///     Get Molarity from PicomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromPicomolesPerLiter(double picomolesperliter) => new Molarity(picomolesperliter, MolarityUnit.PicomolesPerLiter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        public static Molarity From(double value, MolarityUnit fromUnit)
        {
            return new Molarity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Molarity ToUnit(MolarityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Molarity(convertedValue, unit);
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
                case MolarityUnit.CentimolesPerLiter: return (_value/1e-3) * 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (_value/1e-3) * 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (_value/1e-3) * 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (_value/1e-3) * 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return _value;
                case MolarityUnit.MolesPerLiter: return _value/1e-3;
                case MolarityUnit.NanomolesPerLiter: return (_value/1e-3) * 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (_value/1e-3) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(MolarityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case MolarityUnit.CentimolesPerLiter: return (baseUnitValue*1e-3) / 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (baseUnitValue*1e-3) / 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (baseUnitValue*1e-3) / 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (baseUnitValue*1e-3) / 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return baseUnitValue;
                case MolarityUnit.MolesPerLiter: return baseUnitValue*1e-3;
                case MolarityUnit.NanomolesPerLiter: return (baseUnitValue*1e-3) / 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (baseUnitValue*1e-3) / 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

