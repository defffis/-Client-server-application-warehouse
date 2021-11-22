using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FastReport;
using FastReport.Data;
using FastReport.Dialog;
using FastReport.Barcode;
using FastReport.Table;
using FastReport.Utils;

namespace FastReport
{
  public class report : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.DataBand Data1;
    public FastReport.LineObject Line1;
    public FastReport.LineObject Line11;
    public FastReport.LineObject Line12;
    public FastReport.LineObject Line13;
    public FastReport.LineObject Line14;
    public FastReport.LineObject Line15;
    public FastReport.LineObject Line16;
    public FastReport.LineObject Line17;
    public FastReport.LineObject Line18;
    public FastReport.LineObject Line19;
    public FastReport.LineObject Line20;
    public FastReport.LineObject Line21;
    public FastReport.LineObject Line22;
    public FastReport.LineObject Line23;
    public FastReport.LineObject Line4;
    public FastReport.LineObject Line5;
    public FastReport.LineObject Line6;
    public FastReport.LineObject Line7;
    public FastReport.LineObject Line8;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      return null;
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWordsIn(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value);
    }

    private String ToWordsIn(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, currencyName);
    }

    private String ToWordsIn(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, one, many);
    }

    private String ToWordsIn(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value);
    }

    private String ToWordsIn(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, currencyName);
    }

    private String ToWordsIn(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, one, many);
    }

    private String ToWordsDe(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value);
    }

    private String ToWordsDe(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, currencyName);
    }

    private String ToWordsDe(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, one, many);
    }

    private String ToWordsDe(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value);
    }

    private String ToWordsDe(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, currencyName);
    }

    private String ToWordsDe(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, one, many);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsFr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value);
    }

    private String ToWordsFr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, currencyName);
    }

    private String ToWordsFr(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, one, many);
    }

    private String ToWordsFr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value);
    }

    private String ToWordsFr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, currencyName);
    }

    private String ToWordsFr(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, one, many);
    }

    private String ToWordsNl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value);
    }

    private String ToWordsNl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, currencyName);
    }

    private String ToWordsNl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, one, many);
    }

    private String ToWordsNl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value);
    }

    private String ToWordsNl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, currencyName);
    }

    private String ToWordsNl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, one, many);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private String ToWordsUkr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value);
    }

    private String ToWordsUkr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, currencyName);
    }

    private String ToWordsUkr(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, male, one, two, many);
    }

    private String ToWordsUkr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value);
    }

    private String ToWordsUkr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, currencyName);
    }

    private String ToWordsUkr(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, male, one, two, many);
    }

    private String ToWordsSp(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, currencyName);
    }

    private String ToWordsSp(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value);
    }

    private String ToWordsSp(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, one, many);
    }

    private String ToWordsSp(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, currencyName);
    }

    private String ToWordsSp(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value);
    }

    private String ToWordsSp(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, one, many);
    }

    private String ToWordsPersian(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, currencyName);
    }

    private String ToWordsPersian(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value);
    }

    private String ToWordsPersian(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, one, many);
    }

    private String ToWordsPersian(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, currencyName);
    }

    private String ToWordsPersian(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value);
    }

    private String ToWordsPersian(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, one, many);
    }

    private String ToLetters(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value);
    }

    private String ToLetters(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value, isUpper);
    }

    private String ToLetters(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value);
    }

    private String ToLetters(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value, isUpper);
    }

    private String ToLettersRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value);
    }

    private String ToLettersRu(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value, isUpper);
    }

    private String ToLettersRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value);
    }

    private String ToLettersRu(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value, isUpper);
    }

    private String ToWordsPl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, currencyName);
    }

    private String ToWordsPl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value);
    }

    private String ToWordsPl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, one, many);
    }

    private String ToWordsPl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, currencyName);
    }

    private String ToWordsPl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value);
    }

    private String ToWordsPl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, one, many);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private void InitializeComponent()
    {
      string reportString = 
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" ReportI" +
        "nfo.Created=\"11/08/2021 09:50:40\" ReportInfo.Modified=\"11/08/2021 10:44:52\" Repo" +
        "rtInfo.CreatorVersion=\"2021.4.12.0\">\r\n  <Dictionary>\r\n    <MySqlDataConnection N" +
        "ame=\"Connection\" ConnectionString=\"rijcmlqAxB5REKUT+dukMQH3sU+xeoocOuNBfV3teaWbP" +
        "40Cc3MpnJys7qn010N2EOxLUIv/c9q5Z7PxU4PIUKeNXG5S7taUeRNUVjyY1NvNWCQCvA=\">\r\n      " +
        "<TableDataSource Name=\"client_help\" DataType=\"System.Int32\" Enabled=\"true\" Table" +
        "Name=\"client_help\">\r\n        <Column Name=\"id_client\" DataType=\"System.UInt32\"/>" +
        "\r\n        <Column Name=\"name_client\" DataType=\"System.String\"/>\r\n        <Column" +
        " Name=\"id_country\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"address_cli" +
        "ent\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n      <TableDataSourc" +
        "e Name=\"country\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"country\">\r\n  " +
        "      <Column Name=\"id_country\" DataType=\"System.UInt32\"/>\r\n        <Column Name" +
        "=\"country_name_min\" DataType=\"System.String\"/>\r\n        <Column Name=\"country_na";
      reportString += "me_max\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n      <TableDataSo" +
        "urce Name=\"ksu_one\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"ksu_one\">\r" +
        "\n        <Column Name=\"id_ksu\" DataType=\"System.UInt32\"/>\r\n        <Column Name=" +
        "\"id_produkt\" DataType=\"System.UInt32\"/>\r\n      </TableDataSource>\r\n      <TableD" +
        "ataSource Name=\"ksu_two\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"ksu_t" +
        "wo\">\r\n        <Column Name=\"id_ntn\" DataType=\"System.Int32\"/>\r\n        <Column N" +
        "ame=\"id_input_order\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"ksu_date\" " +
        "DataType=\"System.DateTime\"/>\r\n        <Column Name=\"id_client\" DataType=\"System." +
        "Int32\"/>\r\n        <Column Name=\"id_provider\" DataType=\"System.Int32\"/>\r\n        " +
        "<Column Name=\"id_worker\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"coming" +
        "\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"consumption\" DataType=\"System" +
        ".Int32\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"ntn_one\" DataT";
      reportString += "ype=\"System.Int32\" Enabled=\"true\" TableName=\"ntn_one\">\r\n        <Column Name=\"id" +
        "_ntn\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"ntn_date\" DataType=\"Syst" +
        "em.DateTime\"/>\r\n        <Column Name=\"id_client\" DataType=\"System.UInt32\"/>\r\n   " +
        "     <Column Name=\"about_ntn\" DataType=\"System.String\"/>\r\n      </TableDataSourc" +
        "e>\r\n      <TableDataSource Name=\"ntn_two\" DataType=\"System.Int32\" Enabled=\"true\"" +
        " TableName=\"ntn_two\">\r\n        <Column Name=\"id_ntn\" DataType=\"System.UInt32\"/>\r" +
        "\n        <Column Name=\"id_produkt\" DataType=\"System.UInt32\"/>\r\n        <Column N" +
        "ame=\"id_ksu\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"id_worker\" DataTy" +
        "pe=\"System.UInt32\"/>\r\n        <Column Name=\"requested\" DataType=\"System.Int32\"/>" +
        "\r\n        <Column Name=\"released\" DataType=\"System.Int32\"/>\r\n      </TableDataSo" +
        "urce>\r\n      <TableDataSource Name=\"produkt_help\" DataType=\"System.Int32\" Enable" +
        "d=\"true\" TableName=\"produkt_help\">\r\n        <Column Name=\"id_produkt\" DataType=\"";
      reportString += "System.UInt32\"/>\r\n        <Column Name=\"name_produkt\" DataType=\"System.String\"/>" +
        "\r\n        <Column Name=\"id_unit_produkt\" DataType=\"System.UInt32\"/>\r\n        <Co" +
        "lumn Name=\"unit_price_produkt\" DataType=\"System.Decimal\"/>\r\n      </TableDataSou" +
        "rce>\r\n      <TableDataSource Name=\"provider_help\" DataType=\"System.Int32\" Enable" +
        "d=\"true\" TableName=\"provider_help\">\r\n        <Column Name=\"id_provider\" DataType" +
        "=\"System.UInt32\"/>\r\n        <Column Name=\"name_provider\" DataType=\"System.String" +
        "\"/>\r\n        <Column Name=\"id_country\" DataType=\"System.UInt32\"/>\r\n      </Table" +
        "DataSource>\r\n      <TableDataSource Name=\"ttn\" DataType=\"System.Int32\" Enabled=\"" +
        "true\" TableName=\"ttn\">\r\n        <Column Name=\"id_input_order\" DataType=\"System.U" +
        "Int32\"/>\r\n        <Column Name=\"date_ttn\" DataType=\"System.DateTime\"/>\r\n        " +
        "<Column Name=\"id_produkt\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"inpu" +
        "t_produkt\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"id_provider\" DataTyp";
      reportString += "e=\"System.UInt32\"/>\r\n        <Column Name=\"id_ksu\" DataType=\"System.UInt32\"/>\r\n " +
        "       <Column Name=\"id_worker\" DataType=\"System.UInt32\"/>\r\n      </TableDataSou" +
        "rce>\r\n      <TableDataSource Name=\"unit_produkt\" DataType=\"System.Int32\" Enabled" +
        "=\"true\" TableName=\"unit_produkt\">\r\n        <Column Name=\"id_unit_produkt\" DataTy" +
        "pe=\"System.UInt32\"/>\r\n        <Column Name=\"unit_produkt\" DataType=\"System.Strin" +
        "g\"/>\r\n        <Column Name=\"unit_produkt_full\" DataType=\"System.String\"/>\r\n     " +
        " </TableDataSource>\r\n      <TableDataSource Name=\"users\" DataType=\"System.Int32\"" +
        " Enabled=\"true\" TableName=\"users\">\r\n        <Column Name=\"idusers\" DataType=\"Sys" +
        "tem.UInt32\"/>\r\n        <Column Name=\"users_name\" DataType=\"System.String\"/>\r\n   " +
        "     <Column Name=\"users_pass\" DataType=\"System.String\"/>\r\n        <Column Name=" +
        "\"users_primary\" DataType=\"System.SByte\"/>\r\n      </TableDataSource>\r\n      <Tabl" +
        "eDataSource Name=\"worker_help\" DataType=\"System.Int32\" Enabled=\"true\" TableName=";
      reportString += "\"worker_help\">\r\n        <Column Name=\"id_worker\" DataType=\"System.UInt32\"/>\r\n   " +
        "     <Column Name=\"fio_worker\" DataType=\"System.String\"/>\r\n        <Column Name=" +
        "\"post_worker\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n      <Table" +
        "DataSource Name=\"worker_terminated\" DataType=\"System.Int32\" Enabled=\"true\" Table" +
        "Name=\"worker_terminated\">\r\n        <Column Name=\"id_worker\" DataType=\"System.Int" +
        "32\"/>\r\n        <Column Name=\"fio_worker\" DataType=\"System.String\"/>\r\n        <Co" +
        "lumn Name=\"post_worker\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n  " +
        "    <TableDataSource Name=\"view_client_help\" DataType=\"System.Int32\" Enabled=\"tr" +
        "ue\" TableName=\"view_client_help\">\r\n        <Column Name=\"id_client\" DataType=\"Sy" +
        "stem.UInt32\"/>\r\n        <Column Name=\"name_client\" DataType=\"System.String\"/>\r\n " +
        "       <Column Name=\"country_name_min\" DataType=\"System.String\"/>\r\n        <Colu" +
        "mn Name=\"address_client\" DataType=\"System.String\"/>\r\n      </TableDataSource>\r\n ";
      reportString += "     <TableDataSource Name=\"view_provider_help\" DataType=\"System.Int32\" Enabled=" +
        "\"true\" TableName=\"view_provider_help\">\r\n        <Column Name=\"id_provider\" DataT" +
        "ype=\"System.UInt32\"/>\r\n        <Column Name=\"name_provider\" DataType=\"System.Str" +
        "ing\"/>\r\n        <Column Name=\"country_name_max\" DataType=\"System.String\"/>\r\n    " +
        "  </TableDataSource>\r\n      <TableDataSource Name=\"view_produkt_help\" DataType=\"" +
        "System.Int32\" Enabled=\"true\" TableName=\"view_produkt_help\">\r\n        <Column Nam" +
        "e=\"id_produkt\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"name_produkt\" D" +
        "ataType=\"System.String\"/>\r\n        <Column Name=\"unit_price_produkt\" DataType=\"S" +
        "ystem.Decimal\"/>\r\n        <Column Name=\"unit_produkt\" DataType=\"System.String\"/>" +
        "\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_ttn\" DataType=\"Sys" +
        "tem.Int32\" Enabled=\"true\" TableName=\"view_ttn\">\r\n        <Column Name=\"id_input_" +
        "order\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"date_ttn\" DataType=\"Sys";
      reportString += "tem.DateTime\"/>\r\n        <Column Name=\"name_produkt\" DataType=\"System.String\"/>\r" +
        "\n        <Column Name=\"input_produkt\" DataType=\"System.Int32\"/>\r\n        <Column" +
        " Name=\"name_provider\" DataType=\"System.String\"/>\r\n        <Column Name=\"id_ksu\" " +
        "DataType=\"System.UInt32\"/>\r\n        <Column Name=\"fio_worker\" DataType=\"System.S" +
        "tring\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_ntn_one\" D" +
        "ataType=\"System.Int32\" Enabled=\"true\" TableName=\"view_ntn_one\">\r\n        <Column" +
        " Name=\"id_ntn\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"ntn_date\" DataT" +
        "ype=\"System.DateTime\"/>\r\n        <Column Name=\"name_client\" DataType=\"System.Str" +
        "ing\"/>\r\n        <Column Name=\"about_ntn\" DataType=\"System.String\"/>\r\n      </Tab" +
        "leDataSource>\r\n      <TableDataSource Name=\"view_ntn_two\" DataType=\"System.Int32" +
        "\" Enabled=\"true\" TableName=\"view_ntn_two\">\r\n        <Column Name=\"id_ntn\" DataTy" +
        "pe=\"System.UInt32\"/>\r\n        <Column Name=\"name_produkt\" DataType=\"System.Strin";
      reportString += "g\"/>\r\n        <Column Name=\"id_ksu\" DataType=\"System.UInt32\"/>\r\n        <Column " +
        "Name=\"requested\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"released\" Data" +
        "Type=\"System.Int32\"/>\r\n        <Column Name=\"fio_worker\" DataType=\"System.String" +
        "\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_input\" DataType" +
        "=\"System.Int32\" Enabled=\"true\" TableName=\"view_input\">\r\n        <Column Name=\"id" +
        "_produkt\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"sum_input_produkt\" D" +
        "ataType=\"System.Decimal\"/>\r\n        <Column Name=\"id_ksu\" DataType=\"System.UInt3" +
        "2\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_relesed\" DataT" +
        "ype=\"System.Int32\" Enabled=\"true\" TableName=\"view_relesed\">\r\n        <Column Nam" +
        "e=\"id_produkt\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"sum_released\" D" +
        "ataType=\"System.Decimal\"/>\r\n        <Column Name=\"id_ksu\" DataType=\"System.UInt3" +
        "2\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_balance\" DataT";
      reportString += "ype=\"System.Int32\" Enabled=\"true\" TableName=\"view_balance\">\r\n        <Column Nam" +
        "e=\"bid_ksu\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"name_produkt\" Data" +
        "Type=\"System.String\"/>\r\n        <Column Name=\"input_produkt\" DataType=\"System.De" +
        "cimal\"/>\r\n        <Column Name=\"released\" DataType=\"System.Decimal\"/>\r\n        <" +
        "Column Name=\"balance\" DataType=\"System.Decimal\"/>\r\n        <Column Name=\"unit_pr" +
        "odukt\" DataType=\"System.String\"/>\r\n        <Column Name=\"total_price\" DataType=\"" +
        "System.Decimal\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"view_k" +
        "su_one\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"view_ksu_one\">\r\n      " +
        "  <Column Name=\"id_ksu\" DataType=\"System.UInt32\"/>\r\n        <Column Name=\"name_p" +
        "rodukt\" DataType=\"System.String\"/>\r\n        <Column Name=\"id_produkt\" DataType=\"" +
        "System.UInt32\"/>\r\n        <Column Name=\"unit_produkt\" DataType=\"System.String\"/>" +
        "\r\n        <Column Name=\"unit_price_produkt\" DataType=\"System.Decimal\"/>\r\n      <";
      reportString += "/TableDataSource>\r\n      <TableDataSource Name=\"view_ksu_two\" DataType=\"System.I" +
        "nt32\" Enabled=\"true\" TableName=\"view_ksu_two\">\r\n        <Column Name=\"ntn_date\" " +
        "DataType=\"System.DateTime\"/>\r\n        <Column Name=\"id_input_order\" DataType=\"Sy" +
        "stem.UInt32\"/>\r\n        <Column Name=\"id_ntn\" DataType=\"System.UInt32\"/>\r\n      " +
        "  <Column Name=\"aaa\" DataType=\"System.String\"/>\r\n        <Column Name=\"name_clie" +
        "nt\" DataType=\"System.String\"/>\r\n        <Column Name=\"input_produkt\" DataType=\"S" +
        "ystem.Decimal\"/>\r\n        <Column Name=\"released\" DataType=\"System.Decimal\"/>\r\n " +
        "       <Column Name=\"balance\" DataType=\"System.Decimal\"/>\r\n        <Column Name=" +
        "\"total_price\" DataType=\"System.Decimal\"/>\r\n        <Column Name=\"bid_ksu\" DataTy" +
        "pe=\"System.UInt32\"/>\r\n      </TableDataSource>\r\n      <TableDataSource Name=\"vie" +
        "w_slaves\" DataType=\"System.Int32\" Enabled=\"true\" TableName=\"view_slaves\">\r\n     " +
        "   <Column Name=\"Заведующий\" DataType=\"System.String\"/>\r\n        <Column Name=\"К";
      reportString += "ладовщик\" DataType=\"System.String\"/>\r\n        <Column Name=\"Грузчик\" DataType=\"S" +
        "ystem.String\"/>\r\n      </TableDataSource>\r\n    </MySqlDataConnection>\r\n  </Dicti" +
        "onary>\r\n  <ReportPage Name=\"Page1\" Watermark.Font=\"Arial, 60pt\">\r\n    <ReportTit" +
        "leBand Name=\"ReportTitle1\" Width=\"718.2\" Height=\"37.8\">\r\n      <TextObject Name=" +
        "\"Text15\" Width=\"718.2\" Height=\"37.8\" Text=\"Ведомость движения материалов на скла" +
        "де\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Times New Roman, 16pt\"/>\r\n    </" +
        "ReportTitleBand>\r\n    <PageHeaderBand Name=\"PageHeader1\" Top=\"41.14\" Width=\"718." +
        "2\" Height=\"18.9\">\r\n      <TextObject Name=\"Text2\" Left=\"28.35\" Width=\"94.5\" Heig" +
        "ht=\"18.9\" Text=\"КСУ\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r" +
        "\n      <TextObject Name=\"Text4\" Left=\"122.85\" Width=\"94.5\" Height=\"18.9\" Text=\"Н" +
        "азвание\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <Text" +
        "Object Name=\"Text6\" Left=\"217.35\" Width=\"94.5\" Height=\"18.9\" Text=\"Поступило\" Ho";
      reportString += "rzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name" +
        "=\"Text8\" Left=\"311.85\" Width=\"94.5\" Height=\"18.9\" Text=\"Реализовано\" HorzAlign=\"" +
        "Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text10\"" +
        " Left=\"406.35\" Width=\"94.5\" Height=\"18.9\" Text=\"Осталось\" HorzAlign=\"Center\" Ver" +
        "tAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text12\" Left=\"500." +
        "85\" Width=\"94.5\" Height=\"18.9\" Text=\"Единица\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text14\" Left=\"595.35\" Width=\"9" +
        "4.5\" Height=\"18.9\" Text=\"Стоймость\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"" +
        "Arial, 10pt\"/>\r\n      <LineObject Name=\"Line1\" Left=\"28.35\" Width=\"661.5\"/>\r\n   " +
        "   <LineObject Name=\"Line7\" Left=\"28.35\" Height=\"18.9\"/>\r\n      <LineObject Name" +
        "=\"Line8\" Left=\"689.85\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line12\" Left=\"12" +
        "2.85\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line14\" Left=\"217.35\" Height=\"18.";
      reportString += "9\"/>\r\n      <LineObject Name=\"Line16\" Left=\"311.85\" Height=\"18.9\"/>\r\n      <Line" +
        "Object Name=\"Line18\" Left=\"406.35\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line" +
        "20\" Left=\"500.85\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line22\" Left=\"595.35\"" +
        " Height=\"18.9\"/>\r\n    </PageHeaderBand>\r\n    <DataBand Name=\"Data1\" Top=\"63.38\" " +
        "Width=\"718.2\" Height=\"18.9\" DataSource=\"view_balance\">\r\n      <TextObject Name=\"" +
        "Text1\" Left=\"28.35\" Width=\"94.5\" Height=\"18.9\" Text=\"[view_balance.bid_ksu]\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=" +
        "\"Text3\" Left=\"122.85\" Width=\"94.5\" Height=\"18.9\" Text=\"[view_balance.name_produk" +
        "t]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font=\"Arial, 10pt\"/>\r\n      <TextObjec" +
        "t Name=\"Text5\" Left=\"217.35\" Width=\"94.5\" Height=\"18.9\" Text=\"[view_balance.inpu" +
        "t_produkt]\" Format=\"Number\" Format.UseLocale=\"true\" Format.DecimalDigits=\"0\" Hor" +
        "zAlign=\"Center\" VertAlign=\"Center\" WordWrap=\"false\" Font=\"Arial, 10pt\" Trimming=";
      reportString += "\"EllipsisCharacter\"/>\r\n      <TextObject Name=\"Text7\" Left=\"311.85\" Width=\"94.5\"" +
        " Height=\"18.9\" Text=\"[view_balance.released]\" Format=\"Number\" Format.UseLocale=\"" +
        "true\" Format.DecimalDigits=\"0\" HorzAlign=\"Center\" VertAlign=\"Center\" WordWrap=\"f" +
        "alse\" Font=\"Arial, 10pt\" Trimming=\"EllipsisCharacter\"/>\r\n      <TextObject Name=" +
        "\"Text9\" Left=\"406.35\" Width=\"94.5\" Height=\"18.9\" Text=\"[view_balance.balance]\" F" +
        "ormat=\"Number\" Format.UseLocale=\"true\" Format.DecimalDigits=\"0\" HorzAlign=\"Cente" +
        "r\" VertAlign=\"Center\" WordWrap=\"false\" Font=\"Arial, 10pt\" Trimming=\"EllipsisChar" +
        "acter\"/>\r\n      <TextObject Name=\"Text11\" Left=\"500.85\" Width=\"94.5\" Height=\"18." +
        "9\" Text=\"[view_balance.unit_produkt]\" HorzAlign=\"Center\" VertAlign=\"Center\" Font" +
        "=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text13\" Left=\"595.35\" Width=\"94.5\" Hei" +
        "ght=\"18.9\" Text=\"[view_balance.total_price]\" Format=\"Currency\" Format.UseLocale=" +
        "\"true\" Format.DecimalDigits=\"2\" HorzAlign=\"Center\" VertAlign=\"Center\" WordWrap=\"";
      reportString += "false\" Font=\"Arial, 10pt\" Trimming=\"EllipsisCharacter\"/>\r\n      <LineObject Name" +
        "=\"Line4\" Left=\"689.85\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line5\" Left=\"689" +
        ".85\" Width=\"-661.5\"/>\r\n      <LineObject Name=\"Line6\" Left=\"28.35\" Height=\"18.9\"" +
        "/>\r\n      <LineObject Name=\"Line11\" Left=\"28.35\" Top=\"18.9\" Width=\"661.5\"/>\r\n   " +
        "   <LineObject Name=\"Line13\" Left=\"122.85\" Height=\"18.9\"/>\r\n      <LineObject Na" +
        "me=\"Line15\" Left=\"217.35\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line17\" Left=" +
        "\"311.85\" Height=\"18.9\"/>\r\n      <LineObject Name=\"Line19\" Left=\"406.35\" Height=\"" +
        "18.9\"/>\r\n      <LineObject Name=\"Line21\" Left=\"500.85\" Height=\"18.9\"/>\r\n      <L" +
        "ineObject Name=\"Line23\" Left=\"595.35\" Height=\"18.9\"/>\r\n    </DataBand>\r\n    <Pag" +
        "eFooterBand Name=\"PageFooter1\" Top=\"85.62\" Width=\"718.2\" Height=\"18.9\"/>\r\n  </Re" +
        "portPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public report()
    {
      InitializeComponent();
    }
  }
}
