
using System;
using System.Collections.Generic;
using System.Text;


namespace T4Templates
{
    public static partial class Test
    {
      public static bool IsBetween(this double x, double min, double max)
      {
        return x < min ? false : (x > max ? false : true);
      }

      public static double Clamp(this double x, double min, double max)
      {
        return x < min ? min : (x > max ? max :  x);
      }

      public static double Lerp(this double t, double a, double b)
      {
        return t.Clamp(0, 1)*(b - a) + a;
      }

      public static double Saturate(this double t)
      {
        return t.Clamp(0, 1);
      }      
      public static bool IsBetween(this float x, float min, float max)
      {
        return x < min ? false : (x > max ? false : true);
      }

      public static float Clamp(this float x, float min, float max)
      {
        return x < min ? min : (x > max ? max :  x);
      }

      public static float Lerp(this float t, float a, float b)
      {
        return t.Clamp(0, 1)*(b - a) + a;
      }

      public static float Saturate(this float t)
      {
        return t.Clamp(0, 1);
      }      
      public static bool IsBetween(this decimal x, decimal min, decimal max)
      {
        return x < min ? false : (x > max ? false : true);
      }

      public static decimal Clamp(this decimal x, decimal min, decimal max)
      {
        return x < min ? min : (x > max ? max :  x);
      }

      public static decimal Lerp(this decimal t, decimal a, decimal b)
      {
        return t.Clamp(0, 1)*(b - a) + a;
      }

      public static decimal Saturate(this decimal t)
      {
        return t.Clamp(0, 1);
      }      
    }
}
