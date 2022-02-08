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
    ///     ElectricPotential change rate is the ratio of the electric potential change to the time during which the change occurred (value of electric potential changes per unit time).
    /// </summary>
    public struct  ElectricPotentialChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricPotentialChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricPotentialChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricPotentialChangeRate(double value, ElectricPotentialChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricPotentialChangeRateUnit BaseUnit { get; } = ElectricPotentialChangeRateUnit.VoltPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricPotentialChangeRate MaxValue { get; } = new ElectricPotentialChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricPotentialChangeRate MinValue { get; } = new ElectricPotentialChangeRate(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricPotentialChangeRate Zero { get; } = new ElectricPotentialChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ElectricPotentialChangeRate in KilovoltsPerHours.
        /// </summary>
        public double KilovoltsPerHours => As(ElectricPotentialChangeRateUnit.KilovoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in KilovoltsPerMicroseconds.
        /// </summary>
        public double KilovoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in KilovoltsPerMinutes.
        /// </summary>
        public double KilovoltsPerMinutes => As(ElectricPotentialChangeRateUnit.KilovoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in KilovoltsPerSeconds.
        /// </summary>
        public double KilovoltsPerSeconds => As(ElectricPotentialChangeRateUnit.KilovoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MegavoltsPerHours.
        /// </summary>
        public double MegavoltsPerHours => As(ElectricPotentialChangeRateUnit.MegavoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MegavoltsPerMicroseconds.
        /// </summary>
        public double MegavoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MegavoltsPerMinutes.
        /// </summary>
        public double MegavoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MegavoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MegavoltsPerSeconds.
        /// </summary>
        public double MegavoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MegavoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MicrovoltsPerHours.
        /// </summary>
        public double MicrovoltsPerHours => As(ElectricPotentialChangeRateUnit.MicrovoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MicrovoltsPerMicroseconds.
        /// </summary>
        public double MicrovoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MicrovoltsPerMinutes.
        /// </summary>
        public double MicrovoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MicrovoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MicrovoltsPerSeconds.
        /// </summary>
        public double MicrovoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MicrovoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MillivoltsPerHours.
        /// </summary>
        public double MillivoltsPerHours => As(ElectricPotentialChangeRateUnit.MillivoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MillivoltsPerMicroseconds.
        /// </summary>
        public double MillivoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MillivoltsPerMinutes.
        /// </summary>
        public double MillivoltsPerMinutes => As(ElectricPotentialChangeRateUnit.MillivoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in MillivoltsPerSeconds.
        /// </summary>
        public double MillivoltsPerSeconds => As(ElectricPotentialChangeRateUnit.MillivoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in VoltsPerHours.
        /// </summary>
        public double VoltsPerHours => As(ElectricPotentialChangeRateUnit.VoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in VoltsPerMicroseconds.
        /// </summary>
        public double VoltsPerMicroseconds => As(ElectricPotentialChangeRateUnit.VoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in VoltsPerMinutes.
        /// </summary>
        public double VoltsPerMinutes => As(ElectricPotentialChangeRateUnit.VoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate in VoltsPerSeconds.
        /// </summary>
        public double VoltsPerSeconds => As(ElectricPotentialChangeRateUnit.VoltPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerHours(double kilovoltsperhours) => new ElectricPotentialChangeRate(kilovoltsperhours, ElectricPotentialChangeRateUnit.KilovoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerMicroseconds(double kilovoltspermicroseconds) => new ElectricPotentialChangeRate(kilovoltspermicroseconds, ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerMinutes(double kilovoltsperminutes) => new ElectricPotentialChangeRate(kilovoltsperminutes, ElectricPotentialChangeRateUnit.KilovoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from KilovoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromKilovoltsPerSeconds(double kilovoltsperseconds) => new ElectricPotentialChangeRate(kilovoltsperseconds, ElectricPotentialChangeRateUnit.KilovoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerHours(double megavoltsperhours) => new ElectricPotentialChangeRate(megavoltsperhours, ElectricPotentialChangeRateUnit.MegavoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerMicroseconds(double megavoltspermicroseconds) => new ElectricPotentialChangeRate(megavoltspermicroseconds, ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerMinutes(double megavoltsperminutes) => new ElectricPotentialChangeRate(megavoltsperminutes, ElectricPotentialChangeRateUnit.MegavoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MegavoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMegavoltsPerSeconds(double megavoltsperseconds) => new ElectricPotentialChangeRate(megavoltsperseconds, ElectricPotentialChangeRateUnit.MegavoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerHours(double microvoltsperhours) => new ElectricPotentialChangeRate(microvoltsperhours, ElectricPotentialChangeRateUnit.MicrovoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerMicroseconds(double microvoltspermicroseconds) => new ElectricPotentialChangeRate(microvoltspermicroseconds, ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerMinutes(double microvoltsperminutes) => new ElectricPotentialChangeRate(microvoltsperminutes, ElectricPotentialChangeRateUnit.MicrovoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MicrovoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMicrovoltsPerSeconds(double microvoltsperseconds) => new ElectricPotentialChangeRate(microvoltsperseconds, ElectricPotentialChangeRateUnit.MicrovoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerHours(double millivoltsperhours) => new ElectricPotentialChangeRate(millivoltsperhours, ElectricPotentialChangeRateUnit.MillivoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerMicroseconds(double millivoltspermicroseconds) => new ElectricPotentialChangeRate(millivoltspermicroseconds, ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerMinutes(double millivoltsperminutes) => new ElectricPotentialChangeRate(millivoltsperminutes, ElectricPotentialChangeRateUnit.MillivoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from MillivoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromMillivoltsPerSeconds(double millivoltsperseconds) => new ElectricPotentialChangeRate(millivoltsperseconds, ElectricPotentialChangeRateUnit.MillivoltPerSecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerHours(double voltsperhours) => new ElectricPotentialChangeRate(voltsperhours, ElectricPotentialChangeRateUnit.VoltPerHour);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerMicroseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerMicroseconds(double voltspermicroseconds) => new ElectricPotentialChangeRate(voltspermicroseconds, ElectricPotentialChangeRateUnit.VoltPerMicrosecond);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerMinutes(double voltsperminutes) => new ElectricPotentialChangeRate(voltsperminutes, ElectricPotentialChangeRateUnit.VoltPerMinute);

        /// <summary>
        ///     Get ElectricPotentialChangeRate from VoltsPerSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotentialChangeRate FromVoltsPerSeconds(double voltsperseconds) => new ElectricPotentialChangeRate(voltsperseconds, ElectricPotentialChangeRateUnit.VoltPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricPotentialChangeRateUnit" /> to <see cref="ElectricPotentialChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricPotentialChangeRate unit value.</returns>
        public static ElectricPotentialChangeRate From(double value, ElectricPotentialChangeRateUnit fromUnit)
        {
            return new ElectricPotentialChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricPotentialChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricPotentialChangeRate ToUnit(ElectricPotentialChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricPotentialChangeRate(convertedValue, unit);
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
                case ElectricPotentialChangeRateUnit.KilovoltPerHour: return (_value/3600) * 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond: return (_value*1E6) * 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerMinute: return (_value/60) * 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerSecond: return (_value) * 1e3d;
                case ElectricPotentialChangeRateUnit.MegavoltPerHour: return (_value/3600) * 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond: return (_value*1E6) * 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerMinute: return (_value/60) * 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerSecond: return (_value) * 1e6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerHour: return (_value/3600) * 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond: return (_value*1E6) * 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerMinute: return (_value/60) * 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerSecond: return (_value) * 1e-6d;
                case ElectricPotentialChangeRateUnit.MillivoltPerHour: return (_value/3600) * 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond: return (_value*1E6) * 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerMinute: return (_value/60) * 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerSecond: return (_value) * 1e-3d;
                case ElectricPotentialChangeRateUnit.VoltPerHour: return _value/3600;
                case ElectricPotentialChangeRateUnit.VoltPerMicrosecond: return _value*1E6;
                case ElectricPotentialChangeRateUnit.VoltPerMinute: return _value/60;
                case ElectricPotentialChangeRateUnit.VoltPerSecond: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ElectricPotentialChangeRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ElectricPotentialChangeRateUnit.KilovoltPerHour: return (baseUnitValue*3600) / 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerMicrosecond: return (baseUnitValue/1E6) / 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerMinute: return (baseUnitValue*60) / 1e3d;
                case ElectricPotentialChangeRateUnit.KilovoltPerSecond: return (baseUnitValue) / 1e3d;
                case ElectricPotentialChangeRateUnit.MegavoltPerHour: return (baseUnitValue*3600) / 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerMicrosecond: return (baseUnitValue/1E6) / 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerMinute: return (baseUnitValue*60) / 1e6d;
                case ElectricPotentialChangeRateUnit.MegavoltPerSecond: return (baseUnitValue) / 1e6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerHour: return (baseUnitValue*3600) / 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerMicrosecond: return (baseUnitValue/1E6) / 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerMinute: return (baseUnitValue*60) / 1e-6d;
                case ElectricPotentialChangeRateUnit.MicrovoltPerSecond: return (baseUnitValue) / 1e-6d;
                case ElectricPotentialChangeRateUnit.MillivoltPerHour: return (baseUnitValue*3600) / 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerMicrosecond: return (baseUnitValue/1E6) / 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerMinute: return (baseUnitValue*60) / 1e-3d;
                case ElectricPotentialChangeRateUnit.MillivoltPerSecond: return (baseUnitValue) / 1e-3d;
                case ElectricPotentialChangeRateUnit.VoltPerHour: return baseUnitValue*3600;
                case ElectricPotentialChangeRateUnit.VoltPerMicrosecond: return baseUnitValue/1E6;
                case ElectricPotentialChangeRateUnit.VoltPerMinute: return baseUnitValue*60;
                case ElectricPotentialChangeRateUnit.VoltPerSecond: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

