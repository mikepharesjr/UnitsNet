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
    ///     Mass flow is the ratio of the mass change to the time during which the change occurred (value of mass changes per unit time).
    /// </summary>
    public struct  MassFlow
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassFlowUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassFlowUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MassFlow(double value, MassFlowUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MassFlowUnit BaseUnit { get; } = MassFlowUnit.GramPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MassFlow MaxValue { get; } = new MassFlow(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MassFlow MinValue { get; } = new MassFlow(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MassFlow Zero { get; } = new MassFlow(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get MassFlow in CentigramsPerDay.
        /// </summary>
        public double CentigramsPerDay => As(MassFlowUnit.CentigramPerDay);

        /// <summary>
        ///     Get MassFlow in CentigramsPerSecond.
        /// </summary>
        public double CentigramsPerSecond => As(MassFlowUnit.CentigramPerSecond);

        /// <summary>
        ///     Get MassFlow in DecagramsPerDay.
        /// </summary>
        public double DecagramsPerDay => As(MassFlowUnit.DecagramPerDay);

        /// <summary>
        ///     Get MassFlow in DecagramsPerSecond.
        /// </summary>
        public double DecagramsPerSecond => As(MassFlowUnit.DecagramPerSecond);

        /// <summary>
        ///     Get MassFlow in DecigramsPerDay.
        /// </summary>
        public double DecigramsPerDay => As(MassFlowUnit.DecigramPerDay);

        /// <summary>
        ///     Get MassFlow in DecigramsPerSecond.
        /// </summary>
        public double DecigramsPerSecond => As(MassFlowUnit.DecigramPerSecond);

        /// <summary>
        ///     Get MassFlow in GramsPerDay.
        /// </summary>
        public double GramsPerDay => As(MassFlowUnit.GramPerDay);

        /// <summary>
        ///     Get MassFlow in GramsPerHour.
        /// </summary>
        public double GramsPerHour => As(MassFlowUnit.GramPerHour);

        /// <summary>
        ///     Get MassFlow in GramsPerSecond.
        /// </summary>
        public double GramsPerSecond => As(MassFlowUnit.GramPerSecond);

        /// <summary>
        ///     Get MassFlow in HectogramsPerDay.
        /// </summary>
        public double HectogramsPerDay => As(MassFlowUnit.HectogramPerDay);

        /// <summary>
        ///     Get MassFlow in HectogramsPerSecond.
        /// </summary>
        public double HectogramsPerSecond => As(MassFlowUnit.HectogramPerSecond);

        /// <summary>
        ///     Get MassFlow in KilogramsPerDay.
        /// </summary>
        public double KilogramsPerDay => As(MassFlowUnit.KilogramPerDay);

        /// <summary>
        ///     Get MassFlow in KilogramsPerHour.
        /// </summary>
        public double KilogramsPerHour => As(MassFlowUnit.KilogramPerHour);

        /// <summary>
        ///     Get MassFlow in KilogramsPerMinute.
        /// </summary>
        public double KilogramsPerMinute => As(MassFlowUnit.KilogramPerMinute);

        /// <summary>
        ///     Get MassFlow in KilogramsPerSecond.
        /// </summary>
        public double KilogramsPerSecond => As(MassFlowUnit.KilogramPerSecond);

        /// <summary>
        ///     Get MassFlow in MegagramsPerDay.
        /// </summary>
        public double MegagramsPerDay => As(MassFlowUnit.MegagramPerDay);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerDay.
        /// </summary>
        public double MegapoundsPerDay => As(MassFlowUnit.MegapoundPerDay);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerHour.
        /// </summary>
        public double MegapoundsPerHour => As(MassFlowUnit.MegapoundPerHour);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerMinute.
        /// </summary>
        public double MegapoundsPerMinute => As(MassFlowUnit.MegapoundPerMinute);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerSecond.
        /// </summary>
        public double MegapoundsPerSecond => As(MassFlowUnit.MegapoundPerSecond);

        /// <summary>
        ///     Get MassFlow in MicrogramsPerDay.
        /// </summary>
        public double MicrogramsPerDay => As(MassFlowUnit.MicrogramPerDay);

        /// <summary>
        ///     Get MassFlow in MicrogramsPerSecond.
        /// </summary>
        public double MicrogramsPerSecond => As(MassFlowUnit.MicrogramPerSecond);

        /// <summary>
        ///     Get MassFlow in MilligramsPerDay.
        /// </summary>
        public double MilligramsPerDay => As(MassFlowUnit.MilligramPerDay);

        /// <summary>
        ///     Get MassFlow in MilligramsPerSecond.
        /// </summary>
        public double MilligramsPerSecond => As(MassFlowUnit.MilligramPerSecond);

        /// <summary>
        ///     Get MassFlow in NanogramsPerDay.
        /// </summary>
        public double NanogramsPerDay => As(MassFlowUnit.NanogramPerDay);

        /// <summary>
        ///     Get MassFlow in NanogramsPerSecond.
        /// </summary>
        public double NanogramsPerSecond => As(MassFlowUnit.NanogramPerSecond);

        /// <summary>
        ///     Get MassFlow in PoundsPerDay.
        /// </summary>
        public double PoundsPerDay => As(MassFlowUnit.PoundPerDay);

        /// <summary>
        ///     Get MassFlow in PoundsPerHour.
        /// </summary>
        public double PoundsPerHour => As(MassFlowUnit.PoundPerHour);

        /// <summary>
        ///     Get MassFlow in PoundsPerMinute.
        /// </summary>
        public double PoundsPerMinute => As(MassFlowUnit.PoundPerMinute);

        /// <summary>
        ///     Get MassFlow in PoundsPerSecond.
        /// </summary>
        public double PoundsPerSecond => As(MassFlowUnit.PoundPerSecond);

        /// <summary>
        ///     Get MassFlow in ShortTonsPerHour.
        /// </summary>
        public double ShortTonsPerHour => As(MassFlowUnit.ShortTonPerHour);

        /// <summary>
        ///     Get MassFlow in TonnesPerDay.
        /// </summary>
        public double TonnesPerDay => As(MassFlowUnit.TonnePerDay);

        /// <summary>
        ///     Get MassFlow in TonnesPerHour.
        /// </summary>
        public double TonnesPerHour => As(MassFlowUnit.TonnePerHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get MassFlow from CentigramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromCentigramsPerDay(double centigramsperday) => new MassFlow(centigramsperday, MassFlowUnit.CentigramPerDay);

        /// <summary>
        ///     Get MassFlow from CentigramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromCentigramsPerSecond(double centigramspersecond) => new MassFlow(centigramspersecond, MassFlowUnit.CentigramPerSecond);

        /// <summary>
        ///     Get MassFlow from DecagramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecagramsPerDay(double decagramsperday) => new MassFlow(decagramsperday, MassFlowUnit.DecagramPerDay);

        /// <summary>
        ///     Get MassFlow from DecagramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecagramsPerSecond(double decagramspersecond) => new MassFlow(decagramspersecond, MassFlowUnit.DecagramPerSecond);

        /// <summary>
        ///     Get MassFlow from DecigramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecigramsPerDay(double decigramsperday) => new MassFlow(decigramsperday, MassFlowUnit.DecigramPerDay);

        /// <summary>
        ///     Get MassFlow from DecigramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromDecigramsPerSecond(double decigramspersecond) => new MassFlow(decigramspersecond, MassFlowUnit.DecigramPerSecond);

        /// <summary>
        ///     Get MassFlow from GramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerDay(double gramsperday) => new MassFlow(gramsperday, MassFlowUnit.GramPerDay);

        /// <summary>
        ///     Get MassFlow from GramsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerHour(double gramsperhour) => new MassFlow(gramsperhour, MassFlowUnit.GramPerHour);

        /// <summary>
        ///     Get MassFlow from GramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromGramsPerSecond(double gramspersecond) => new MassFlow(gramspersecond, MassFlowUnit.GramPerSecond);

        /// <summary>
        ///     Get MassFlow from HectogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromHectogramsPerDay(double hectogramsperday) => new MassFlow(hectogramsperday, MassFlowUnit.HectogramPerDay);

        /// <summary>
        ///     Get MassFlow from HectogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromHectogramsPerSecond(double hectogramspersecond) => new MassFlow(hectogramspersecond, MassFlowUnit.HectogramPerSecond);

        /// <summary>
        ///     Get MassFlow from KilogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerDay(double kilogramsperday) => new MassFlow(kilogramsperday, MassFlowUnit.KilogramPerDay);

        /// <summary>
        ///     Get MassFlow from KilogramsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerHour(double kilogramsperhour) => new MassFlow(kilogramsperhour, MassFlowUnit.KilogramPerHour);

        /// <summary>
        ///     Get MassFlow from KilogramsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerMinute(double kilogramsperminute) => new MassFlow(kilogramsperminute, MassFlowUnit.KilogramPerMinute);

        /// <summary>
        ///     Get MassFlow from KilogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromKilogramsPerSecond(double kilogramspersecond) => new MassFlow(kilogramspersecond, MassFlowUnit.KilogramPerSecond);

        /// <summary>
        ///     Get MassFlow from MegagramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegagramsPerDay(double megagramsperday) => new MassFlow(megagramsperday, MassFlowUnit.MegagramPerDay);

        /// <summary>
        ///     Get MassFlow from MegapoundsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerDay(double megapoundsperday) => new MassFlow(megapoundsperday, MassFlowUnit.MegapoundPerDay);

        /// <summary>
        ///     Get MassFlow from MegapoundsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerHour(double megapoundsperhour) => new MassFlow(megapoundsperhour, MassFlowUnit.MegapoundPerHour);

        /// <summary>
        ///     Get MassFlow from MegapoundsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerMinute(double megapoundsperminute) => new MassFlow(megapoundsperminute, MassFlowUnit.MegapoundPerMinute);

        /// <summary>
        ///     Get MassFlow from MegapoundsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMegapoundsPerSecond(double megapoundspersecond) => new MassFlow(megapoundspersecond, MassFlowUnit.MegapoundPerSecond);

        /// <summary>
        ///     Get MassFlow from MicrogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMicrogramsPerDay(double microgramsperday) => new MassFlow(microgramsperday, MassFlowUnit.MicrogramPerDay);

        /// <summary>
        ///     Get MassFlow from MicrogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMicrogramsPerSecond(double microgramspersecond) => new MassFlow(microgramspersecond, MassFlowUnit.MicrogramPerSecond);

        /// <summary>
        ///     Get MassFlow from MilligramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMilligramsPerDay(double milligramsperday) => new MassFlow(milligramsperday, MassFlowUnit.MilligramPerDay);

        /// <summary>
        ///     Get MassFlow from MilligramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromMilligramsPerSecond(double milligramspersecond) => new MassFlow(milligramspersecond, MassFlowUnit.MilligramPerSecond);

        /// <summary>
        ///     Get MassFlow from NanogramsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromNanogramsPerDay(double nanogramsperday) => new MassFlow(nanogramsperday, MassFlowUnit.NanogramPerDay);

        /// <summary>
        ///     Get MassFlow from NanogramsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromNanogramsPerSecond(double nanogramspersecond) => new MassFlow(nanogramspersecond, MassFlowUnit.NanogramPerSecond);

        /// <summary>
        ///     Get MassFlow from PoundsPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerDay(double poundsperday) => new MassFlow(poundsperday, MassFlowUnit.PoundPerDay);

        /// <summary>
        ///     Get MassFlow from PoundsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerHour(double poundsperhour) => new MassFlow(poundsperhour, MassFlowUnit.PoundPerHour);

        /// <summary>
        ///     Get MassFlow from PoundsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerMinute(double poundsperminute) => new MassFlow(poundsperminute, MassFlowUnit.PoundPerMinute);

        /// <summary>
        ///     Get MassFlow from PoundsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromPoundsPerSecond(double poundspersecond) => new MassFlow(poundspersecond, MassFlowUnit.PoundPerSecond);

        /// <summary>
        ///     Get MassFlow from ShortTonsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromShortTonsPerHour(double shorttonsperhour) => new MassFlow(shorttonsperhour, MassFlowUnit.ShortTonPerHour);

        /// <summary>
        ///     Get MassFlow from TonnesPerDay.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromTonnesPerDay(double tonnesperday) => new MassFlow(tonnesperday, MassFlowUnit.TonnePerDay);

        /// <summary>
        ///     Get MassFlow from TonnesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassFlow FromTonnesPerHour(double tonnesperhour) => new MassFlow(tonnesperhour, MassFlowUnit.TonnePerHour);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassFlowUnit" /> to <see cref="MassFlow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MassFlow unit value.</returns>
        public static MassFlow From(double value, MassFlowUnit fromUnit)
        {
            return new MassFlow(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassFlowUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public MassFlow ToUnit(MassFlowUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new MassFlow(convertedValue, unit);
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
                case MassFlowUnit.CentigramPerDay: return (_value/86400) * 1e-2d;
                case MassFlowUnit.CentigramPerSecond: return (_value) * 1e-2d;
                case MassFlowUnit.DecagramPerDay: return (_value/86400) * 1e1d;
                case MassFlowUnit.DecagramPerSecond: return (_value) * 1e1d;
                case MassFlowUnit.DecigramPerDay: return (_value/86400) * 1e-1d;
                case MassFlowUnit.DecigramPerSecond: return (_value) * 1e-1d;
                case MassFlowUnit.GramPerDay: return _value/86400;
                case MassFlowUnit.GramPerHour: return _value/3600;
                case MassFlowUnit.GramPerSecond: return _value;
                case MassFlowUnit.HectogramPerDay: return (_value/86400) * 1e2d;
                case MassFlowUnit.HectogramPerSecond: return (_value) * 1e2d;
                case MassFlowUnit.KilogramPerDay: return (_value/86400) * 1e3d;
                case MassFlowUnit.KilogramPerHour: return _value/3.6;
                case MassFlowUnit.KilogramPerMinute: return _value/0.06;
                case MassFlowUnit.KilogramPerSecond: return (_value) * 1e3d;
                case MassFlowUnit.MegagramPerDay: return (_value/86400) * 1e6d;
                case MassFlowUnit.MegapoundPerDay: return (_value/190.47936) * 1e6d;
                case MassFlowUnit.MegapoundPerHour: return (_value/7.93664) * 1e6d;
                case MassFlowUnit.MegapoundPerMinute: return (_value/0.132277) * 1e6d;
                case MassFlowUnit.MegapoundPerSecond: return (_value * 453.59237) * 1e6d;
                case MassFlowUnit.MicrogramPerDay: return (_value/86400) * 1e-6d;
                case MassFlowUnit.MicrogramPerSecond: return (_value) * 1e-6d;
                case MassFlowUnit.MilligramPerDay: return (_value/86400) * 1e-3d;
                case MassFlowUnit.MilligramPerSecond: return (_value) * 1e-3d;
                case MassFlowUnit.NanogramPerDay: return (_value/86400) * 1e-9d;
                case MassFlowUnit.NanogramPerSecond: return (_value) * 1e-9d;
                case MassFlowUnit.PoundPerDay: return _value/190.47936;
                case MassFlowUnit.PoundPerHour: return _value/7.93664;
                case MassFlowUnit.PoundPerMinute: return _value/0.132277;
                case MassFlowUnit.PoundPerSecond: return _value * 453.59237;
                case MassFlowUnit.ShortTonPerHour: return _value*251.9957611;
                case MassFlowUnit.TonnePerDay: return _value/0.0864000;
                case MassFlowUnit.TonnePerHour: return 1000*_value/3.6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(MassFlowUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case MassFlowUnit.CentigramPerDay: return (baseUnitValue*86400) / 1e-2d;
                case MassFlowUnit.CentigramPerSecond: return (baseUnitValue) / 1e-2d;
                case MassFlowUnit.DecagramPerDay: return (baseUnitValue*86400) / 1e1d;
                case MassFlowUnit.DecagramPerSecond: return (baseUnitValue) / 1e1d;
                case MassFlowUnit.DecigramPerDay: return (baseUnitValue*86400) / 1e-1d;
                case MassFlowUnit.DecigramPerSecond: return (baseUnitValue) / 1e-1d;
                case MassFlowUnit.GramPerDay: return baseUnitValue*86400;
                case MassFlowUnit.GramPerHour: return baseUnitValue*3600;
                case MassFlowUnit.GramPerSecond: return baseUnitValue;
                case MassFlowUnit.HectogramPerDay: return (baseUnitValue*86400) / 1e2d;
                case MassFlowUnit.HectogramPerSecond: return (baseUnitValue) / 1e2d;
                case MassFlowUnit.KilogramPerDay: return (baseUnitValue*86400) / 1e3d;
                case MassFlowUnit.KilogramPerHour: return baseUnitValue*3.6;
                case MassFlowUnit.KilogramPerMinute: return baseUnitValue*0.06;
                case MassFlowUnit.KilogramPerSecond: return (baseUnitValue) / 1e3d;
                case MassFlowUnit.MegagramPerDay: return (baseUnitValue*86400) / 1e6d;
                case MassFlowUnit.MegapoundPerDay: return (baseUnitValue*190.47936) / 1e6d;
                case MassFlowUnit.MegapoundPerHour: return (baseUnitValue*7.93664) / 1e6d;
                case MassFlowUnit.MegapoundPerMinute: return (baseUnitValue*0.132277) / 1e6d;
                case MassFlowUnit.MegapoundPerSecond: return (baseUnitValue / 453.59237) / 1e6d;
                case MassFlowUnit.MicrogramPerDay: return (baseUnitValue*86400) / 1e-6d;
                case MassFlowUnit.MicrogramPerSecond: return (baseUnitValue) / 1e-6d;
                case MassFlowUnit.MilligramPerDay: return (baseUnitValue*86400) / 1e-3d;
                case MassFlowUnit.MilligramPerSecond: return (baseUnitValue) / 1e-3d;
                case MassFlowUnit.NanogramPerDay: return (baseUnitValue*86400) / 1e-9d;
                case MassFlowUnit.NanogramPerSecond: return (baseUnitValue) / 1e-9d;
                case MassFlowUnit.PoundPerDay: return baseUnitValue*190.47936;
                case MassFlowUnit.PoundPerHour: return baseUnitValue*7.93664;
                case MassFlowUnit.PoundPerMinute: return baseUnitValue*0.132277;
                case MassFlowUnit.PoundPerSecond: return baseUnitValue / 453.59237;
                case MassFlowUnit.ShortTonPerHour: return baseUnitValue/251.9957611;
                case MassFlowUnit.TonnePerDay: return baseUnitValue*0.0864000;
                case MassFlowUnit.TonnePerHour: return baseUnitValue*3.6/1000;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

