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
    ///     In physics, mass (from Greek μᾶζα "barley cake, lump [of dough]") is a property of a physical system or body, giving rise to the phenomena of the body's resistance to being accelerated by a force and the strength of its mutual gravitational attraction with other bodies. Instruments such as mass balances or scales use those phenomena to measure mass. The SI unit of mass is the kilogram (kg).
    /// </summary>
    public struct  Mass
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Mass(double value, MassUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MassUnit BaseUnit { get; } = MassUnit.Kilogram;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Mass MaxValue { get; } = new Mass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Mass MinValue { get; } = new Mass(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Mass Zero { get; } = new Mass(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Mass in Centigrams.
        /// </summary>
        public double Centigrams => As(MassUnit.Centigram);

        /// <summary>
        ///     Get Mass in Decagrams.
        /// </summary>
        public double Decagrams => As(MassUnit.Decagram);

        /// <summary>
        ///     Get Mass in Decigrams.
        /// </summary>
        public double Decigrams => As(MassUnit.Decigram);

        /// <summary>
        ///     Get Mass in EarthMasses.
        /// </summary>
        public double EarthMasses => As(MassUnit.EarthMass);

        /// <summary>
        ///     Get Mass in Grains.
        /// </summary>
        public double Grains => As(MassUnit.Grain);

        /// <summary>
        ///     Get Mass in Grams.
        /// </summary>
        public double Grams => As(MassUnit.Gram);

        /// <summary>
        ///     Get Mass in Hectograms.
        /// </summary>
        public double Hectograms => As(MassUnit.Hectogram);

        /// <summary>
        ///     Get Mass in Kilograms.
        /// </summary>
        public double Kilograms => As(MassUnit.Kilogram);

        /// <summary>
        ///     Get Mass in Kilopounds.
        /// </summary>
        public double Kilopounds => As(MassUnit.Kilopound);

        /// <summary>
        ///     Get Mass in Kilotonnes.
        /// </summary>
        public double Kilotonnes => As(MassUnit.Kilotonne);

        /// <summary>
        ///     Get Mass in LongHundredweight.
        /// </summary>
        public double LongHundredweight => As(MassUnit.LongHundredweight);

        /// <summary>
        ///     Get Mass in LongTons.
        /// </summary>
        public double LongTons => As(MassUnit.LongTon);

        /// <summary>
        ///     Get Mass in Megapounds.
        /// </summary>
        public double Megapounds => As(MassUnit.Megapound);

        /// <summary>
        ///     Get Mass in Megatonnes.
        /// </summary>
        public double Megatonnes => As(MassUnit.Megatonne);

        /// <summary>
        ///     Get Mass in Micrograms.
        /// </summary>
        public double Micrograms => As(MassUnit.Microgram);

        /// <summary>
        ///     Get Mass in Milligrams.
        /// </summary>
        public double Milligrams => As(MassUnit.Milligram);

        /// <summary>
        ///     Get Mass in Nanograms.
        /// </summary>
        public double Nanograms => As(MassUnit.Nanogram);

        /// <summary>
        ///     Get Mass in Ounces.
        /// </summary>
        public double Ounces => As(MassUnit.Ounce);

        /// <summary>
        ///     Get Mass in Pounds.
        /// </summary>
        public double Pounds => As(MassUnit.Pound);

        /// <summary>
        ///     Get Mass in ShortHundredweight.
        /// </summary>
        public double ShortHundredweight => As(MassUnit.ShortHundredweight);

        /// <summary>
        ///     Get Mass in ShortTons.
        /// </summary>
        public double ShortTons => As(MassUnit.ShortTon);

        /// <summary>
        ///     Get Mass in Slugs.
        /// </summary>
        public double Slugs => As(MassUnit.Slug);

        /// <summary>
        ///     Get Mass in SolarMasses.
        /// </summary>
        public double SolarMasses => As(MassUnit.SolarMass);

        /// <summary>
        ///     Get Mass in Stone.
        /// </summary>
        public double Stone => As(MassUnit.Stone);

        /// <summary>
        ///     Get Mass in Tonnes.
        /// </summary>
        public double Tonnes => As(MassUnit.Tonne);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Mass from Centigrams.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromCentigrams(double centigrams) => new Mass(centigrams, MassUnit.Centigram);

        /// <summary>
        ///     Get Mass from Decagrams.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromDecagrams(double decagrams) => new Mass(decagrams, MassUnit.Decagram);

        /// <summary>
        ///     Get Mass from Decigrams.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromDecigrams(double decigrams) => new Mass(decigrams, MassUnit.Decigram);

        /// <summary>
        ///     Get Mass from EarthMasses.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromEarthMasses(double earthmasses) => new Mass(earthmasses, MassUnit.EarthMass);

        /// <summary>
        ///     Get Mass from Grains.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromGrains(double grains) => new Mass(grains, MassUnit.Grain);

        /// <summary>
        ///     Get Mass from Grams.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromGrams(double grams) => new Mass(grams, MassUnit.Gram);

        /// <summary>
        ///     Get Mass from Hectograms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromHectograms(double hectograms) => new Mass(hectograms, MassUnit.Hectogram);

        /// <summary>
        ///     Get Mass from Kilograms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilograms(double kilograms) => new Mass(kilograms, MassUnit.Kilogram);

        /// <summary>
        ///     Get Mass from Kilopounds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilopounds(double kilopounds) => new Mass(kilopounds, MassUnit.Kilopound);

        /// <summary>
        ///     Get Mass from Kilotonnes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilotonnes(double kilotonnes) => new Mass(kilotonnes, MassUnit.Kilotonne);

        /// <summary>
        ///     Get Mass from LongHundredweight.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromLongHundredweight(double longhundredweight) => new Mass(longhundredweight, MassUnit.LongHundredweight);

        /// <summary>
        ///     Get Mass from LongTons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromLongTons(double longtons) => new Mass(longtons, MassUnit.LongTon);

        /// <summary>
        ///     Get Mass from Megapounds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMegapounds(double megapounds) => new Mass(megapounds, MassUnit.Megapound);

        /// <summary>
        ///     Get Mass from Megatonnes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMegatonnes(double megatonnes) => new Mass(megatonnes, MassUnit.Megatonne);

        /// <summary>
        ///     Get Mass from Micrograms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMicrograms(double micrograms) => new Mass(micrograms, MassUnit.Microgram);

        /// <summary>
        ///     Get Mass from Milligrams.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMilligrams(double milligrams) => new Mass(milligrams, MassUnit.Milligram);

        /// <summary>
        ///     Get Mass from Nanograms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromNanograms(double nanograms) => new Mass(nanograms, MassUnit.Nanogram);

        /// <summary>
        ///     Get Mass from Ounces.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromOunces(double ounces) => new Mass(ounces, MassUnit.Ounce);

        /// <summary>
        ///     Get Mass from Pounds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromPounds(double pounds) => new Mass(pounds, MassUnit.Pound);

        /// <summary>
        ///     Get Mass from ShortHundredweight.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromShortHundredweight(double shorthundredweight) => new Mass(shorthundredweight, MassUnit.ShortHundredweight);

        /// <summary>
        ///     Get Mass from ShortTons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromShortTons(double shorttons) => new Mass(shorttons, MassUnit.ShortTon);

        /// <summary>
        ///     Get Mass from Slugs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromSlugs(double slugs) => new Mass(slugs, MassUnit.Slug);

        /// <summary>
        ///     Get Mass from SolarMasses.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromSolarMasses(double solarmasses) => new Mass(solarmasses, MassUnit.SolarMass);

        /// <summary>
        ///     Get Mass from Stone.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromStone(double stone) => new Mass(stone, MassUnit.Stone);

        /// <summary>
        ///     Get Mass from Tonnes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromTonnes(double tonnes) => new Mass(tonnes, MassUnit.Tonne);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassUnit" /> to <see cref="Mass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Mass unit value.</returns>
        public static Mass From(double value, MassUnit fromUnit)
        {
            return new Mass(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Mass ToUnit(MassUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Mass(convertedValue, unit);
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
                case MassUnit.Centigram: return (_value/1e3) * 1e-2d;
                case MassUnit.Decagram: return (_value/1e3) * 1e1d;
                case MassUnit.Decigram: return (_value/1e3) * 1e-1d;
                case MassUnit.EarthMass: return _value * 5.9722E+24;
                case MassUnit.Grain: return _value/15432.358352941431;
                case MassUnit.Gram: return _value/1e3;
                case MassUnit.Hectogram: return (_value/1e3) * 1e2d;
                case MassUnit.Kilogram: return (_value/1e3) * 1e3d;
                case MassUnit.Kilopound: return (_value*0.45359237) * 1e3d;
                case MassUnit.Kilotonne: return (_value*1e3) * 1e3d;
                case MassUnit.LongHundredweight: return _value/0.01968413055222121;
                case MassUnit.LongTon: return _value*1.0160469088e3;
                case MassUnit.Megapound: return (_value*0.45359237) * 1e6d;
                case MassUnit.Megatonne: return (_value*1e3) * 1e6d;
                case MassUnit.Microgram: return (_value/1e3) * 1e-6d;
                case MassUnit.Milligram: return (_value/1e3) * 1e-3d;
                case MassUnit.Nanogram: return (_value/1e3) * 1e-9d;
                case MassUnit.Ounce: return _value/35.2739619;
                case MassUnit.Pound: return _value*0.45359237;
                case MassUnit.ShortHundredweight: return _value/0.022046226218487758;
                case MassUnit.ShortTon: return _value*9.0718474e2;
                case MassUnit.Slug: return _value/6.852176556196105e-2;
                case MassUnit.SolarMass: return _value * 1.98947e30;
                case MassUnit.Stone: return _value/0.1574731728702698;
                case MassUnit.Tonne: return _value*1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(MassUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case MassUnit.Centigram: return (baseUnitValue*1e3) / 1e-2d;
                case MassUnit.Decagram: return (baseUnitValue*1e3) / 1e1d;
                case MassUnit.Decigram: return (baseUnitValue*1e3) / 1e-1d;
                case MassUnit.EarthMass: return baseUnitValue / 5.9722E+24;
                case MassUnit.Grain: return baseUnitValue*15432.358352941431;
                case MassUnit.Gram: return baseUnitValue*1e3;
                case MassUnit.Hectogram: return (baseUnitValue*1e3) / 1e2d;
                case MassUnit.Kilogram: return (baseUnitValue*1e3) / 1e3d;
                case MassUnit.Kilopound: return (baseUnitValue/0.45359237) / 1e3d;
                case MassUnit.Kilotonne: return (baseUnitValue/1e3) / 1e3d;
                case MassUnit.LongHundredweight: return baseUnitValue*0.01968413055222121;
                case MassUnit.LongTon: return baseUnitValue/1.0160469088e3;
                case MassUnit.Megapound: return (baseUnitValue/0.45359237) / 1e6d;
                case MassUnit.Megatonne: return (baseUnitValue/1e3) / 1e6d;
                case MassUnit.Microgram: return (baseUnitValue*1e3) / 1e-6d;
                case MassUnit.Milligram: return (baseUnitValue*1e3) / 1e-3d;
                case MassUnit.Nanogram: return (baseUnitValue*1e3) / 1e-9d;
                case MassUnit.Ounce: return baseUnitValue*35.2739619;
                case MassUnit.Pound: return baseUnitValue/0.45359237;
                case MassUnit.ShortHundredweight: return baseUnitValue*0.022046226218487758;
                case MassUnit.ShortTon: return baseUnitValue/9.0718474e2;
                case MassUnit.Slug: return baseUnitValue*6.852176556196105e-2;
                case MassUnit.SolarMass: return baseUnitValue / 1.98947e30;
                case MassUnit.Stone: return baseUnitValue*0.1574731728702698;
                case MassUnit.Tonne: return baseUnitValue/1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

