// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

/// <summary>
/// Base class for FuncParamTuple{TResult, T1..Tn}
/// </summary>
public abstract partial record FuncParamTuple<TResult> : IInvoke<TResult>
{
    /// <inheritdoc cref="IInvoke{T}.Invoke()"/>
    public abstract TResult Invoke();
}

/// <summary>
/// Single parameter Func Tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
public record FuncParamTuple<T1, TResult>(Func<T1, TResult> Func, T1 Arg1) 
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1);
}

/// <summary>
/// Two parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
public record FuncParamTuple<T1, T2, TResult>(Func<T1, T2, TResult> Func,
    T1 Arg1, T2 Arg2)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2);
}

/// <summary>
/// Three parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
public record FuncParamTuple<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3);
}

/// <summary>
/// Four parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
public record FuncParamTuple<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4);
}

/// <summary>
/// Five parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5);
}

/// <summary>
/// Six parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, TResult>(
    Func<T1, T2, T3, T4, T5, T6, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
}

/// <summary>
/// Seven parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
}

/// <summary>
/// Eight parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
}

/// <summary>
/// Ten parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
}

/// <summary>
/// Elleven parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11);
}

/// <summary>
/// Twelve parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12);
}

/// <summary>
/// Thirteen parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13);
}

/// <summary>
/// Fourteen parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14);
}

/// <summary>
/// Fifteen parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <typeparam name="T15"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
/// <param name="Arg15"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, T15, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14, Arg15);
}

/// <summary>
/// Sixteen parameter Func tuple.
/// </summary>
/// <typeparam name="T1"></typeparam>
/// <typeparam name="T2"></typeparam>
/// <typeparam name="T3"></typeparam>
/// <typeparam name="T4"></typeparam>
/// <typeparam name="T5"></typeparam>
/// <typeparam name="T6"></typeparam>
/// <typeparam name="T7"></typeparam>
/// <typeparam name="T8"></typeparam>
/// <typeparam name="T9"></typeparam>
/// <typeparam name="T10"></typeparam>
/// <typeparam name="T11"></typeparam>
/// <typeparam name="T12"></typeparam>
/// <typeparam name="T13"></typeparam>
/// <typeparam name="T14"></typeparam>
/// <typeparam name="T15"></typeparam>
/// <typeparam name="T16"></typeparam>
/// <typeparam name="TResult"></typeparam>
/// <param name="Func"></param>
/// <param name="Arg1"></param>
/// <param name="Arg2"></param>
/// <param name="Arg3"></param>
/// <param name="Arg4"></param>
/// <param name="Arg5"></param>
/// <param name="Arg6"></param>
/// <param name="Arg7"></param>
/// <param name="Arg8"></param>
/// <param name="Arg9"></param>
/// <param name="Arg10"></param>
/// <param name="Arg11"></param>
/// <param name="Arg12"></param>
/// <param name="Arg13"></param>
/// <param name="Arg14"></param>
/// <param name="Arg15"></param>
/// <param name="Arg16"></param>
public record FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,
    T12, T13, T14, T15, T16, TResult>(
    Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Func,
    T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8, T9 Arg9, T10 Arg10,
    T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15, T16 Arg16)
    : FuncParamTuple<TResult>
{
    /// <inheritdoc cref="IInvoke{TResult}.Invoke()"/>
    public override TResult Invoke() => Func(Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10,
            Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);
}

// Copyright Joseph W Donahue and Sharper Hacks LLC (US-WA)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SharperHacks is a trademark of Sharper Hacks LLC (US-Wa), and may not be
// applied to distributions of derivative works, without the express written
// permission of a registered officer of Sharper Hacks LLC (US-WA).
