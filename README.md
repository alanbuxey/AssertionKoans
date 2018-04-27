# AssertionKoans

The Assertions Koans walk you along the path to enlightenment in order to learn how to write better assertions in unit tests. 

### The Structure

The koans are broken out into areas by file, they are presented in order in the `PathToEnlightenment.cs` file.

Each koan builds up your knowledge of how to write good assertions and builds upon itself. It will stop at the first place you need to correct.

Some koans simply need to have an incorrect answer substituted for the correct one. Some, however, require you to supply your own answer. If you see the object FILL_ME_IN listed, it is a hint to you to supply your own code in order to make it work correctly.

### Getting Started

1. Install [.NET Core SDK 2.0](https://www.microsoft.com/net/core).
2. Install [Visual Studio Code](https://code.visualstudio.com/)
3. Clone the repository: `git clone https://github.com/timbarker/AssertionKoans.git`.
4. Change directory into the cloned repository `cd AssertionKoans`.
5. Restore packages: `dotnet restore`.
6. Open the project in VSCode `code .`
7. Run the koans in watch mode: `dotnet watch --quiet run`.
    - **Note:** The `--quiet` flag is used here to suppress mesages from the watch framework.
8. Follow along with the instructions printed to your console. Each time you save a *.cs file, the project will be built and run again for you automatically.
9. This is designed to help you get familiar with Fluent Assertions. If you're stuck, the answer is probably found in their documentation. https://fluentassertions.com/documentation

### About
Based off of https://github.com/NotMyself/DotNetCoreKoans
