// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.IO;

using System.Diagnostics.CodeAnalysis;

namespace SharperHacks.CoreLibs.DelegateContainers.UnitTests;

[TestClass]
[ExcludeFromCodeCoverage]
public class ActionParamTuplesUT
{
    const string arg1 = "1";
    const string arg2 = "2";
    const string arg3 = "3";
    const string arg4 = "4";
    const string arg5 = "5";
    const string arg6 = "6";
    const string arg7 = "7";
    const string arg8 = "8";
    const string arg9 = "9";
    const string arg10 = "10";
    const string arg11 = "11";
    const string arg12 = "12";
    const string arg13 = "13";
    const string arg14 = "14";
    const string arg15 = "15";
    const string arg16 = "16";

    private readonly ActionParamTuple[] _tuples = new ActionParamTuple[]
    {
        ActionParamTuple.Create((a) => Console.WriteLine(a), arg1),
        ActionParamTuple.Create((a, b) => Console.WriteLine(a + b), arg1, arg2),
        ActionParamTuple.Create((a, b, c) => Console.WriteLine(a + b + c), arg1, arg2, arg3),
        ActionParamTuple.Create((a, b, c, d) 
            => Console.WriteLine(a + b + c + d),
            arg1, arg2, arg3, arg4),
        ActionParamTuple.Create((a, b, c, d, e) 
            => Console.WriteLine(a + b + c + d + e), 
            arg1, arg2, arg3, arg4, arg5),
        ActionParamTuple.Create((a, b, c, d, e, f)
            => Console.WriteLine(a + b + c + d + e + f),
            arg1, arg2, arg3, arg4, arg5, arg6),
        ActionParamTuple.Create((a, b, c, d, e, f, g) 
            => Console.WriteLine(a + b + c + d + e + f + g),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h) 
            => Console.WriteLine(a + b + c + d + e + f + g + h),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k, l)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k, l, m)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l + m),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k, l, m, n)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l + m + n),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o)
            => Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l + m + n + o),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15),
        ActionParamTuple.Create((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p)
            => Console.WriteLine(
                a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p),
            arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13,
            arg14, arg15, arg16),
    };

    [DataTestMethod]
    [DataRow(0, arg1, arg1)]
    [DataRow(1, arg1, arg2)]
    [DataRow(2, arg1, arg3)]
    [DataRow(3, arg1, arg4)]
    [DataRow(4, arg1, arg5)]
    [DataRow(5, arg1, arg6)]
    [DataRow(6, arg1, arg7)]
    [DataRow(7, arg1, arg8)]
    [DataRow(8, arg1, arg9)]
    [DataRow(9, arg1, arg10)]
    [DataRow(10, arg1, arg11)]
    [DataRow(11, arg1, arg12)]
    [DataRow(12, arg1, arg13)]
    [DataRow(13, arg1, arg14)]
    [DataRow(14, arg1, arg15)]
    [DataRow(15, arg1, arg16)]
    public void SmokeIt(int idx, string startsWith, string endsWith)
    {
        var output = string.Empty;

        using (var captured = new CaptureConsoleOutput())
        {
            _tuples[idx].Invoke();
            output = captured.StdOut;
        }

        Console.WriteLine(output);
        Assert.IsTrue(output.StartsWith(startsWith));
        Assert.IsTrue(output.TrimEnd().EndsWith(endsWith));
    }
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
