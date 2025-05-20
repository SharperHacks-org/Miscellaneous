// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.IO;

using System.Diagnostics.CodeAnalysis;

namespace SharperHacks.CoreLibs.DelegateContainers.UnitTests;

[TestClass]
[ExcludeFromCodeCoverage]
public class FuncRunnerUT
{
    const string Arg1 = "Arg1";
    const string Arg2 = "Arg2";
    const string Arg3 = "Arg3";

    private readonly static FuncParamTuple<string>[] _tuples = new FuncParamTuple<string>[]
    {
        FuncParamTuple.Create((a) => Write(a), Arg1),
        FuncParamTuple.Create((a, b) => Write(a + b), Arg1, Arg2),
        FuncParamTuple.Create((a, b, c) => Write(a + b + c), Arg1, Arg2, Arg3),
    };

    private static string Write(string str)
    {
        Console.Write(str);
        return str;
    }

    private FuncRunner<string> _runner = new(_tuples);

    [TestMethod]
    public void Run()
    {
        var expected = Arg1 + Arg1 + Arg2 + Arg1 + Arg2 + Arg3;

        string output;

        using (var captured = new CaptureConsoleOutput())
        {
            _runner.Run();
            output = captured.StdOut;
        }

        Assert.AreEqual(expected, output);
    }

    private static int _i = 1;

    private static bool Eval(string str) => 0 == _i++ % 2 || string.IsNullOrEmpty(str);

    [TestMethod]
    public void RunWithEval()
    {
        var result = _runner.Run(Eval);

        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void RunWithResultListAndRunWithIdx()
    {
        var resultList = _runner.Run(new List<string>());

        var idx = 0;

        foreach (var listResult in resultList)
        {
            Assert.AreEqual(listResult, _runner.Run(idx++));
        }
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

