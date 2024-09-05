// Copyright and trademark notices at the end of this file.
#if true
using Microsoft.Extensions.Logging;

using SharperHacks.CoreLibs.Constraints;
using SharperHacks.CoreLibs.Interfaces;

namespace SharperHacks.CoreLibs.DelegateContainers;

/// <summary>
/// An IDisposable container of actions to perform on dispose.
/// </summary>
public class AtScopeExitAction : AtScopeExitBase
{
    private List<IInvoke>? _managedActions;
    private List<IInvoke>? _unmanagedActions;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="managedActions">
    /// An array of actions to perform in the managed actions block of the IDisposable pattern.
    /// </param>
    /// <param name="unmanagedActions">
    /// An array of action to perform in the unmanaged actions block of the IDisposable pattern.
    /// </param>
    /// <param name="logger">
    /// An ILogger to log events to, if it is not null.
    /// </param>
    public AtScopeExitAction(
        ActionParamTuple[] managedActions,
        ActionParamTuple[] unmanagedActions,
        ILogger? logger = null) : base(logger)
    {
        Verify.IsTrue(managedActions is not null || unmanagedActions is not null);

        if (managedActions is not null) _managedActions = new(managedActions);
        if (unmanagedActions is not null) _unmanagedActions = new(unmanagedActions);
    }

    private void RunActions(IEnumerable<IInvoke> tuples)
    {
        foreach (var tuple in tuples)
        {
            Logger?.LogTrace("Running: {Action}", tuple.ToString());
            tuple.Invoke();
        }
    }

    /// <inheritdoc cref="AtScopeExitBase.DisposeManaged()"/>
    protected override void DisposeManaged()
    {
        if (_managedActions is null) return;

        RunActions(_managedActions);
    }

    /// <inheritdoc cref="AtScopeExitBase.DisposeUnmanaged()"/>
    protected override void DisposeUnmanaged()
    {
        if (_unmanagedActions is null) return;

        RunActions(_unmanagedActions);
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
