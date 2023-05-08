﻿using ExecFile; using System.Reflection.Metadata.Ecma335; using System.Threading.Tasks; using Wrapper; using System; using System.Runtime.InteropServices;  namespace Test {  public static class CurrentOperatingSystem 	{     /// <summary>     /// Returns true id current OS is Windows     /// </summary>     ///       public static bool IsWindows() => IsOSPlatform(OSPlatform.Windows);      /// <summary>     /// Returns true id current OS is Linux     /// </summary>     public static bool IsLinux() => IsOSPlatform(OSPlatform.Linux);      /// <summary>     /// Returns true id current OS is OSX     /// </summary>     public static bool IsMacOS() => IsOSPlatform(OSPlatform.OSX);      /// <summary>     /// Returns true id current OS matches OSPlatform     /// </summary>     /// <param name="os">OS Platform to check for</param>     public static bool IsOSPlatform(OSPlatform osPlatform) =>       RuntimeInformation.IsOSPlatform(osPlatform);   }      public class Exec     {         static void Main(string[] args)         {             var tets = new ExecWrapper();             var result = tets.UseWrapperMethod();             Console.WriteLine(result);         }     } }