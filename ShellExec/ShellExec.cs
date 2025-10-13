// Copyright and trademark notices at the end of this file.

using Microsoft.Extensions.Logging;

using SharperHacks.CoreLibs.Constraints;

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
    /// The captured  stdout from the last command execution.
    /// </summary>
    public string StdOutput { get; private set; }

    /// <summary>
    /// The captured stderr from the last command execution.
    /// </summary>
    public string StdError { get; private set; }

    /// <summary>
    /// Run Cmd with Args, synchronously.
    /// </summary>
    /// <returns></returns>
    public int RunSync()
    {
        TraceStart();

        _ = Process.Start();
        StdOutput = Process.StandardOutput.ReadToEnd();
        StdError = Process.StandardError.ReadToEnd();
        Process.WaitForExit();

        TraceStop();

        return Process.ExitCode;
    }

    #region Constructors

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="cmd"></param>
    /// <param name="args"></param>
    /// <param name="workingDir"></param>
    /// <param name="useShellExecute"></param>
    /// <param name="logger"></param>
    public ShellExec(
        string cmd,
        string args,
        string? workingDir = null,
        bool useShellExecute = false,
        ILogger? logger = null)
    {
        Initialize(cmd, args, workingDir ?? string.Empty, useShellExecute, logger);
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

        StdOutput = string.Empty;
        StdError = string.Empty;
    }

    #endregion Constructors

    #endregion public

    #region private

    private ILogger? _log;
    private Stopwatch _stopwatch = new();

    [MemberNotNull(
        nameof(Args),
        nameof(Cmd),
        nameof(Process),
        nameof(ProcessStartInfo),
        nameof(StdOutput),
        nameof(StdError)
    )]
    private void Initialize(
        string cmd,
        string args,
        string workingDir,
        bool useShellExecute,
        ILogger? logger = null)
    {
        _log = logger;

        Verify.IsNotNull(cmd);
        Verify.IsNotNull(args);

        Cmd = cmd;
        Args = args;

        var psi = new ProcessStartInfo(Cmd, Args)
        {
            Arguments = Args,
            CreateNoWindow = true, // Execute in background (no window).
            WorkingDirectory = workingDir,
            FileName = Cmd,
            RedirectStandardOutput = true, // Capture output.
            RedirectStandardError = true,
            RedirectStandardInput = true, // Allow input.
            UseShellExecute = useShellExecute, // No graphical shell.
        };

        ProcessStartInfo = psi;

        Process = new Process
        {
            StartInfo = ProcessStartInfo
        };

        StdOutput = string.Empty;
        StdError = string.Empty;
    }


    [SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "It only changes if the code is recompiled.")]
    [SuppressMessage("Performance", "CA1848:Use LoggerMessage delegates", Justification = "Performance gain not required")]
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

    [SuppressMessage("Usage", "CA2254:Template should be a static expression", Justification = "It only changes if the code is recompiled.")]
    [SuppressMessage("Performance", "CA1848:Use LoggerMessage delegates", Justification = "Performance gain not required")]
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

