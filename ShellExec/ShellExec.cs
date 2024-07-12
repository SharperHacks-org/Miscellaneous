// Copyright and trademark notices at the end of this file.

using Microsoft.Extensions.Logging;

using SharperHacks.CoreLibs.Constraints;

using System.Diagnostics;
using System.Runtime.CompilerServices;


// WIP: This class is incomplete in design and implementation.

namespace SharperHacks.CoreLibs.Miscellaneous;

/// <summary>
/// Wrapper class for running separate processes, and capturing their output.
/// </summary>
public class ShellExec
{
    #region public

    /// <summary>
    /// The args to run Cmd with.
    /// </summary>
    public string Args { get; set; }

    /// <summary>
    /// The command to execute.
    /// </summary>
    public string Cmd { get; set; }

    /// <summary>
    /// The ProcessStartInfo used to execute the command.
    /// </summary>
    /// <remarks>
    /// Initialized by the constructors. Can be modified before calling
    /// RunSync() or RunAsync().
    /// </remarks>
    public ProcessStartInfo ProcessStartInfo { get; set; }

    /// <summary>
    /// The Process object used to execute the command.
    /// </summary>
    /// <remarks>
    /// Initialized by the constructors. Can be modified before calling
    /// RunSync() or RunAsync().
    /// </remarks>
    public Process Process { get; set; }

    /// <summary>
    /// The captured output from the last command execution.
    /// </summary>
    public string Result { get; private set; }

    /// <summary>
    /// Run Cmd with Args, synchronously.
    /// </summary>
    /// <returns></returns>
    public int RunSync()
    {
        TraceStart();

        _ = Process.Start();
        Result = Process.StandardOutput.ReadToEnd();

        TraceStop();

        return Process.ExitCode;
    }

    #region Constructors

    /// <summary>
    /// Simple constructor, uses default ProcessStartInfo settings and adds cmd and args.
    /// </summary>
    /// <param name="cmd"></param>
    /// <param name="args"></param>
    /// <param name="logger"></param>
    public ShellExec(string cmd, string args, ILogger? logger = null)
    {
        _log = logger;

        Verify.IsNotNull(cmd);
        Verify.IsNotNull(args);

        Cmd = cmd;
        Args = args;

        var psi = new ProcessStartInfo(Cmd, Args)
        {
            RedirectStandardOutput = true, // Capture output.
            UseShellExecute = false, // No graphical shell.
            CreateNoWindow = true,
            FileName = Cmd,
            Arguments = Args // Execute in background (no window).
        };

        ProcessStartInfo = psi;

        Process = new Process
        {
            StartInfo = ProcessStartInfo
        };

        Result = string.Empty;

    }

    /// <summary>
    /// Construct an instance from an initialized ProcessStartInfo object.
    /// </summary>
    /// <param name="psi"></param>
    /// <param name="logger"></param>
    public ShellExec(ProcessStartInfo psi, ILogger? logger = null)
    {
        _log = logger;

        Verify.IsNotNull(psi);

        Cmd = psi.FileName;
        Args = psi.Arguments;
        ProcessStartInfo = psi;

        Process = new Process
        {
            StartInfo = ProcessStartInfo
        };

        Result = string.Empty;
    }

    #endregion Constructors

    #endregion public

    #region private

    private readonly ILogger? _log;
    
    private Stopwatch _stopwatch = new();

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "It only changes if the code is recompiled.")]
    private void TraceStart(
        [CallerMemberName] in string memberName = "",
        [CallerFilePath] in string fileName = "",
        [CallerLineNumber] in int lineNumber = 0)
    {
        if (_log is null) return;

        var sourceLineInfo = $"{fileName}({lineNumber})";
        var classMemberInfo = $"{nameof(ShellExec)}.{memberName}";
        var msgFormat = $"Trace entry: {classMemberInfo}('{{Cmd}} {{Args}}') @ {{sourceLineInfo}}";

        _log.LogTrace(msgFormat, Cmd, Args, sourceLineInfo);

        _stopwatch.Start();
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "It only changes if the code is recompiled.")]
    private void TraceStop(
        [CallerMemberName] in string memberName = "",
        [CallerFilePath] in string fileName = "",
        [CallerLineNumber] in int lineNumber = 0)
    {
        if (_log is null) return;

        var sourceLineInfo = $"{fileName}({lineNumber})";
        var classMemberInfo = $"{nameof(ShellExec)}.{memberName}";
        var msgFormat = $"Trace exit: {classMemberInfo}('{{Cmd}} {{Args}}') @ {{sourceLineInfo}}, Elapsed:{{elapsed}}";

        _stopwatch.Stop();
        _log.LogTrace(msgFormat, Cmd, Args, sourceLineInfo, _stopwatch.Elapsed);
    }

    #endregion private
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

