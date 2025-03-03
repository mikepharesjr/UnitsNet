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
    ///     Many different units of length have been used around the world. The main units in modern use are U.S. customary units in the United States and the Metric system elsewhere. British Imperial units are still used for some purposes in the United Kingdom and some other countries. The metric system is sub-divided into SI and non-SI units.
    /// </summary>
    public struct  Length
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public LengthUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Length(double value, LengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static LengthUnit BaseUnit { get; } = LengthUnit.Meter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Length MaxValue { get; } = new Length(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Length MinValue { get; } = new Length(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Length Zero { get; } = new Length(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Angstrom"/>
        /// </summary>
        public double Angstroms => As(LengthUnit.Angstrom);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.AstronomicalUnit"/>
        /// </summary>
        public double AstronomicalUnits => As(LengthUnit.AstronomicalUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Centimeter"/>
        /// </summary>
        public double Centimeters => As(LengthUnit.Centimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Chain"/>
        /// </summary>
        public double Chains => As(LengthUnit.Chain);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Decameter"/>
        /// </summary>
        public double Decameters => As(LengthUnit.Decameter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Decimeter"/>
        /// </summary>
        public double Decimeters => As(LengthUnit.Decimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.DtpPica"/>
        /// </summary>
        public double DtpPicas => As(LengthUnit.DtpPica);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.DtpPoint"/>
        /// </summary>
        public double DtpPoints => As(LengthUnit.DtpPoint);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Fathom"/>
        /// </summary>
        public double Fathoms => As(LengthUnit.Fathom);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Foot"/>
        /// </summary>
        public double Feet => As(LengthUnit.Foot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Hand"/>
        /// </summary>
        public double Hands => As(LengthUnit.Hand);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Hectometer"/>
        /// </summary>
        public double Hectometers => As(LengthUnit.Hectometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Inch"/>
        /// </summary>
        public double Inches => As(LengthUnit.Inch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.KilolightYear"/>
        /// </summary>
        public double KilolightYears => As(LengthUnit.KilolightYear);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Kilometer"/>
        /// </summary>
        public double Kilometers => As(LengthUnit.Kilometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Kiloparsec"/>
        /// </summary>
        public double Kiloparsecs => As(LengthUnit.Kiloparsec);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.LightYear"/>
        /// </summary>
        public double LightYears => As(LengthUnit.LightYear);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.MegalightYear"/>
        /// </summary>
        public double MegalightYears => As(LengthUnit.MegalightYear);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Megaparsec"/>
        /// </summary>
        public double Megaparsecs => As(LengthUnit.Megaparsec);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Meter"/>
        /// </summary>
        public double Meters => As(LengthUnit.Meter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Microinch"/>
        /// </summary>
        public double Microinches => As(LengthUnit.Microinch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Micrometer"/>
        /// </summary>
        public double Micrometers => As(LengthUnit.Micrometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Mil"/>
        /// </summary>
        public double Mils => As(LengthUnit.Mil);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Mile"/>
        /// </summary>
        public double Miles => As(LengthUnit.Mile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Millimeter"/>
        /// </summary>
        public double Millimeters => As(LengthUnit.Millimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Nanometer"/>
        /// </summary>
        public double Nanometers => As(LengthUnit.Nanometer);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.NauticalMile"/>
        /// </summary>
        public double NauticalMiles => As(LengthUnit.NauticalMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Parsec"/>
        /// </summary>
        public double Parsecs => As(LengthUnit.Parsec);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.PrinterPica"/>
        /// </summary>
        public double PrinterPicas => As(LengthUnit.PrinterPica);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.PrinterPoint"/>
        /// </summary>
        public double PrinterPoints => As(LengthUnit.PrinterPoint);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Shackle"/>
        /// </summary>
        public double Shackles => As(LengthUnit.Shackle);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.SolarRadius"/>
        /// </summary>
        public double SolarRadiuses => As(LengthUnit.SolarRadius);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Twip"/>
        /// </summary>
        public double Twips => As(LengthUnit.Twip);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.UsSurveyFoot"/>
        /// </summary>
        public double UsSurveyFeet => As(LengthUnit.UsSurveyFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LengthUnit.Yard"/>
        /// </summary>
        public double Yards => As(LengthUnit.Yard);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Angstrom"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromAngstroms(double angstroms) => new Length(angstroms, LengthUnit.Angstrom);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.AstronomicalUnit"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromAstronomicalUnits(double astronomicalunits) => new Length(astronomicalunits, LengthUnit.AstronomicalUnit);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Centimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromCentimeters(double centimeters) => new Length(centimeters, LengthUnit.Centimeter);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Chain"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromChains(double chains) => new Length(chains, LengthUnit.Chain);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Decameter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromDecameters(double decameters) => new Length(decameters, LengthUnit.Decameter);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Decimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromDecimeters(double decimeters) => new Length(decimeters, LengthUnit.Decimeter);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.DtpPica"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromDtpPicas(double dtppicas) => new Length(dtppicas, LengthUnit.DtpPica);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.DtpPoint"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromDtpPoints(double dtppoints) => new Length(dtppoints, LengthUnit.DtpPoint);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Fathom"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromFathoms(double fathoms) => new Length(fathoms, LengthUnit.Fathom);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Foot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromFeet(double feet) => new Length(feet, LengthUnit.Foot);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Hand"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromHands(double hands) => new Length(hands, LengthUnit.Hand);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Hectometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromHectometers(double hectometers) => new Length(hectometers, LengthUnit.Hectometer);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Inch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromInches(double inches) => new Length(inches, LengthUnit.Inch);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.KilolightYear"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromKilolightYears(double kilolightyears) => new Length(kilolightyears, LengthUnit.KilolightYear);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Kilometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromKilometers(double kilometers) => new Length(kilometers, LengthUnit.Kilometer);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Kiloparsec"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromKiloparsecs(double kiloparsecs) => new Length(kiloparsecs, LengthUnit.Kiloparsec);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.LightYear"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromLightYears(double lightyears) => new Length(lightyears, LengthUnit.LightYear);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.MegalightYear"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMegalightYears(double megalightyears) => new Length(megalightyears, LengthUnit.MegalightYear);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Megaparsec"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMegaparsecs(double megaparsecs) => new Length(megaparsecs, LengthUnit.Megaparsec);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Meter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMeters(double meters) => new Length(meters, LengthUnit.Meter);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Microinch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMicroinches(double microinches) => new Length(microinches, LengthUnit.Microinch);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Micrometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMicrometers(double micrometers) => new Length(micrometers, LengthUnit.Micrometer);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Mil"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMils(double mils) => new Length(mils, LengthUnit.Mil);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Mile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMiles(double miles) => new Length(miles, LengthUnit.Mile);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Millimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromMillimeters(double millimeters) => new Length(millimeters, LengthUnit.Millimeter);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Nanometer"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromNanometers(double nanometers) => new Length(nanometers, LengthUnit.Nanometer);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.NauticalMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromNauticalMiles(double nauticalmiles) => new Length(nauticalmiles, LengthUnit.NauticalMile);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Parsec"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromParsecs(double parsecs) => new Length(parsecs, LengthUnit.Parsec);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.PrinterPica"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromPrinterPicas(double printerpicas) => new Length(printerpicas, LengthUnit.PrinterPica);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.PrinterPoint"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromPrinterPoints(double printerpoints) => new Length(printerpoints, LengthUnit.PrinterPoint);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Shackle"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromShackles(double shackles) => new Length(shackles, LengthUnit.Shackle);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.SolarRadius"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromSolarRadiuses(double solarradiuses) => new Length(solarradiuses, LengthUnit.SolarRadius);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Twip"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromTwips(double twips) => new Length(twips, LengthUnit.Twip);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.UsSurveyFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromUsSurveyFeet(double ussurveyfeet) => new Length(ussurveyfeet, LengthUnit.UsSurveyFoot);

        /// <summary>
        ///     Creates a <see cref="Length"/> from <see cref="LengthUnit.Yard"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Length FromYards(double yards) => new Length(yards, LengthUnit.Yard);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LengthUnit" /> to <see cref="Length" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Length unit value.</returns>
        public static Length From(double value, LengthUnit fromUnit)
        {
            return new Length(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(LengthUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Length ToUnit(LengthUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Length(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                LengthUnit.Angstrom => _value * 1e-10,
                LengthUnit.AstronomicalUnit => _value * 1.4959787070e11,
                LengthUnit.Centimeter => (_value) * 1e-2d,
                LengthUnit.Chain => _value * 20.1168,
                LengthUnit.Decameter => (_value) * 1e1d,
                LengthUnit.Decimeter => (_value) * 1e-1d,
                LengthUnit.DtpPica => _value / 236.220472441,
                LengthUnit.DtpPoint => (_value / 72) * 2.54e-2,
                LengthUnit.Fathom => _value * 1.8288,
                LengthUnit.Foot => _value * 0.3048,
                LengthUnit.Hand => _value * 1.016e-1,
                LengthUnit.Hectometer => (_value) * 1e2d,
                LengthUnit.Inch => _value * 2.54e-2,
                LengthUnit.KilolightYear => (_value * 9.46073047258e15) * 1e3d,
                LengthUnit.Kilometer => (_value) * 1e3d,
                LengthUnit.Kiloparsec => (_value * 3.08567758128e16) * 1e3d,
                LengthUnit.LightYear => _value * 9.46073047258e15,
                LengthUnit.MegalightYear => (_value * 9.46073047258e15) * 1e6d,
                LengthUnit.Megaparsec => (_value * 3.08567758128e16) * 1e6d,
                LengthUnit.Meter => _value,
                LengthUnit.Microinch => _value * 2.54e-8,
                LengthUnit.Micrometer => (_value) * 1e-6d,
                LengthUnit.Mil => _value * 2.54e-5,
                LengthUnit.Mile => _value * 1609.34,
                LengthUnit.Millimeter => (_value) * 1e-3d,
                LengthUnit.Nanometer => (_value) * 1e-9d,
                LengthUnit.NauticalMile => _value * 1852,
                LengthUnit.Parsec => _value * 3.08567758128e16,
                LengthUnit.PrinterPica => _value / 237.106301584,
                LengthUnit.PrinterPoint => (_value / 72.27) * 2.54e-2,
                LengthUnit.Shackle => _value * 27.432,
                LengthUnit.SolarRadius => _value * 6.95510000E+08,
                LengthUnit.Twip => _value / 56692.913385826,
                LengthUnit.UsSurveyFoot => _value * 1200 / 3937,
                LengthUnit.Yard => _value * 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(LengthUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                LengthUnit.Angstrom => baseUnitValue / 1e-10,
                LengthUnit.AstronomicalUnit => baseUnitValue / 1.4959787070e11,
                LengthUnit.Centimeter => (baseUnitValue) / 1e-2d,
                LengthUnit.Chain => baseUnitValue / 20.1168,
                LengthUnit.Decameter => (baseUnitValue) / 1e1d,
                LengthUnit.Decimeter => (baseUnitValue) / 1e-1d,
                LengthUnit.DtpPica => baseUnitValue * 236.220472441,
                LengthUnit.DtpPoint => (baseUnitValue / 2.54e-2) * 72,
                LengthUnit.Fathom => baseUnitValue / 1.8288,
                LengthUnit.Foot => baseUnitValue / 0.3048,
                LengthUnit.Hand => baseUnitValue / 1.016e-1,
                LengthUnit.Hectometer => (baseUnitValue) / 1e2d,
                LengthUnit.Inch => baseUnitValue / 2.54e-2,
                LengthUnit.KilolightYear => (baseUnitValue / 9.46073047258e15) / 1e3d,
                LengthUnit.Kilometer => (baseUnitValue) / 1e3d,
                LengthUnit.Kiloparsec => (baseUnitValue / 3.08567758128e16) / 1e3d,
                LengthUnit.LightYear => baseUnitValue / 9.46073047258e15,
                LengthUnit.MegalightYear => (baseUnitValue / 9.46073047258e15) / 1e6d,
                LengthUnit.Megaparsec => (baseUnitValue / 3.08567758128e16) / 1e6d,
                LengthUnit.Meter => baseUnitValue,
                LengthUnit.Microinch => baseUnitValue / 2.54e-8,
                LengthUnit.Micrometer => (baseUnitValue) / 1e-6d,
                LengthUnit.Mil => baseUnitValue / 2.54e-5,
                LengthUnit.Mile => baseUnitValue / 1609.34,
                LengthUnit.Millimeter => (baseUnitValue) / 1e-3d,
                LengthUnit.Nanometer => (baseUnitValue) / 1e-9d,
                LengthUnit.NauticalMile => baseUnitValue / 1852,
                LengthUnit.Parsec => baseUnitValue / 3.08567758128e16,
                LengthUnit.PrinterPica => baseUnitValue * 237.106301584,
                LengthUnit.PrinterPoint => (baseUnitValue / 2.54e-2) * 72.27,
                LengthUnit.Shackle => baseUnitValue / 27.432,
                LengthUnit.SolarRadius => baseUnitValue / 6.95510000E+08,
                LengthUnit.Twip => baseUnitValue * 56692.913385826,
                LengthUnit.UsSurveyFoot => baseUnitValue * 3937 / 1200,
                LengthUnit.Yard => baseUnitValue / 0.9144,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

