// ***********************************************************************
// Assembly         : DotNetTips.Spargine.5
// Author           : David McCarter
// Created          : 02-21-2021
//
// Last Modified By : David McCarter
// Last Modified On : 11-22-2024
// ***********************************************************************
// <copyright file="WIPTests.cs" company="David McCarter - dotNetTips.com">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Loggers;

//`![Spargine 8 -  #RockYourCode](6219C891F6330C65927FA249E739AC1F.png;https://www.spargine.net )

namespace DotNetTips.Spargine.Core.BenchmarkTests;

/// <summary>
/// Class WIPTests.
/// </summary>
public static class WIPTests
{
	private const string MessageFailed = "Failed";

	public static void InTest01(Exception ex)
	{
		var result = $"{ex?.Message}";

		ConsoleLogger.Default.WriteLine(result);
	}

	public static void InTest02(Exception ex)
	{
		var result = $"{ex?.Message}";

		ConsoleLogger.Default.WriteLine(result);
	}
	public static bool TryValidateNull(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool TryValidateNullAgressive(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryValidateNullNoInlining(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

	/// <summary>
	/// Calculates the percent no optimization.
	/// </summary>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns>System.Double.</returns>
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool TryValidateNullNoOptimization(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

	/// <summary>
	/// Calculates the percent preserve sig.
	/// </summary>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns>System.Double.</returns>
	[MethodImpl(MethodImplOptions.PreserveSig)]
	public static bool TryValidateNullPreserveSig(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

	/// <summary>
	/// Calculates the percent synchronized.
	/// </summary>
	/// <param name="first">The first.</param>
	/// <param name="second">The second.</param>
	/// <returns>System.Double.</returns>
	[MethodImpl(MethodImplOptions.Synchronized)]
	public static bool TryValidateNullSynchronized(object value, bool throwException = false)
	{
		var result = value is null;

		if (result && throwException)
		{
			ExceptionThrower.ThrowInvalidValueException(MessageFailed, value);
		}

		return result;
	}

}
