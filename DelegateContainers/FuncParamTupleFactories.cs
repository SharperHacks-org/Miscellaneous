// Copyright and trademark notices at the end of this file.

namespace SharperHacks.CoreLibs.DelegateContainers;

/// <summary>
/// Defines FuncParamTuple{TResult} factories.
/// </summary>
public record FuncParamTuple
{
    /// <summary>
    /// Create method, taking one arg.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, TResult>(
        Func<T1, TResult> func,
        T1 Arg1) =>
        new FuncParamTuple<T1, TResult>(func, Arg1);

    /// <summary>
    /// Creat method, taking two args.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, TResult>(
        Func<T1, T2, TResult> func,
        T1 Arg1, T2 Arg2) =>
        new FuncParamTuple<T1, T2, TResult>(func, Arg1, Arg2);

    /// <summary>
    ///  Creat method, taking three args
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, TResult>(
        Func<T1, T2, T3, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3) =>
        new FuncParamTuple<T1, T2, T3, TResult>(func, Arg1, Arg2, Arg3);

    /// <summary>
    /// Creat method, taking four args.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, TResult>(
        Func<T1, T2, T3, T4, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4) =>
        new FuncParamTuple<T1, T2, T3, T4, TResult>(func, Arg1, Arg2, Arg3, Arg4);

    /// <summary>
    /// Creat method, taking five args.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <param name="Arg5"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, TResult>(
        Func<T1, T2, T3, T4, T5, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5);

    /// <summary>
    /// Creat method, taking six args.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <param name="Arg5"></param>
    /// <param name="Arg6"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6,
        TResult>(
        Func<T1, T2, T3, T4, T5, T6, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);

    /// <summary>
    /// Creat method, taking seven args.
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    /// <typeparam name="T7"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <param name="Arg5"></param>
    /// <param name="Arg6"></param>
    /// <param name="Arg7"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7,
        TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);

    /// <summary>
    /// Creat method, taking eight args.
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
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <param name="Arg5"></param>
    /// <param name="Arg6"></param>
    /// <param name="Arg7"></param>
    /// <param name="Arg8"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);

    /// <summary>
    /// Creat method, taking nine args.
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
    /// <param name="func"></param>
    /// <param name="Arg1"></param>
    /// <param name="Arg2"></param>
    /// <param name="Arg3"></param>
    /// <param name="Arg4"></param>
    /// <param name="Arg5"></param>
    /// <param name="Arg6"></param>
    /// <param name="Arg7"></param>
    /// <param name="Arg8"></param>
    /// <param name="Arg9"></param>
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);

    /// <summary>
    /// Creat method, taking ten args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);

    /// <summary>
    /// Creat method, taking elleven args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, 
            Arg10, Arg11);

    /// <summary>
    /// Creat method, taking twelve args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, T12, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11, T12 Arg12) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9,
            Arg10, Arg11, Arg12);

    /// <summary>
    /// Creat method, taking thirteen args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, T12, T13, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11, T12 Arg12, T13 Arg13) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9,
            Arg10, Arg11, Arg12, Arg13);

    /// <summary>
    /// Creat method, taking fourteen args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, T12, T13, T14, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9,
            Arg10, Arg11, Arg12, Arg13, Arg14);

    /// <summary>
    /// Creat method, taking fifteen args.
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, T12, T13, T14, T15, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9,
            Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

    /// <summary>
    /// Creat method, taking sixteen args
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
    /// <param name="func"></param>
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
    /// <returns></returns>
    public static FuncParamTuple<TResult> Create<T1, T2, T3, T4, T5, T6, T7, T8,
        T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func,
        T1 Arg1, T2 Arg2, T3 Arg3, T4 Arg4, T5 Arg5, T6 Arg6, T7 Arg7, T8 Arg8,
        T9 Arg9, T10 Arg10, T11 Arg11, T12 Arg12, T13 Arg13, T14 Arg14, T15 Arg15, T16 Arg16) =>
        new FuncParamTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,
            T13, T14, T15, T16, TResult>(
            func, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9,
            Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);
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
