// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.CommandLineInterface;

var optService = new OptionServices();

var codeToReturnOptionDescriptor = new OptionDescriptor(
    name: "ReturnCode",
    optionType: typeof(int),
    isRequired: false,
    aliases: ["rc", "RC"],
    shortDescription: "Status code to resturn.");

var codeToReturn = new Option<int>(
    optService,
    codeToReturnOptionDescriptor,
    0);

var errorSpewOptionDescriptor = new OptionDescriptor(
    name: "ErrorSpew",
    optionType: typeof(string),
    isRequired: false,
    aliases: ["es", "stderr"],
    shortDescription: "Message to display on stderr stream.");

var errorSpew = new Option<string>(
    optService,
    errorSpewOptionDescriptor,
    string.Empty);

_ = optService.ParseArgs();

Console.Error.WriteLine(errorSpew);
Console.Error.Flush();
Console.WriteLine($"Hello, this is {AppConfig.ProductName}!");
Console.Out.Flush();

return codeToReturn;
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
