// Copyright and trademark notices at the end of this file.
#if true
using Microsoft.Extensions.Logging;

using SharperHacks.CoreLibs.DelegateContainers;
using SharperHacks.CoreLibs.IO;
using SharperHacks.CoreLibs.LogWrappers;

namespace SharperHacks.CoreLibs.Miscellaneous.AtScopeExitUT;

[TestClass]
public class AtScopeExitUT
{
    private Telemetry _telemetry = new(logToConsole: true, shareFile: true);
    private ILogger _logger => _telemetry.Logger;

    [TestMethod]
    public void SmokeIt()
    {
        const string action1Str = "Managed action 1.";
        const string action2Str = "Managed action 2.";
        const string action3Str = "Unmanaged action 1.";
        const string action4Str = "Unmanaged action 2.";

        var output = string.Empty;

        using (var captured = new CaptureConsoleOutput())
        {
            using (var t = new AtScopeExitAction(
                new[]
                {
                    new ActionParamTuple<string>(Console.WriteLine, action1Str),
                    new ActionParamTuple<string>(Console.WriteLine, action2Str),
                },
                new[]
                {
                    new ActionParamTuple<string>(Console.WriteLine, action3Str),
                    new ActionParamTuple<string>(Console.WriteLine, action4Str),
                }))
            {
                Assert.AreEqual(captured.CapturedOutput, string.Empty);
            }
            output = captured.CapturedOutput;
        }

        Console.WriteLine(output);

        Assert.IsTrue(output.Contains(action1Str));
        Assert.IsTrue(output.Contains(action2Str));
        Assert.IsTrue(output.Contains(action3Str));
        Assert.IsTrue(output.Contains(action4Str));
    }
}
#endif
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
