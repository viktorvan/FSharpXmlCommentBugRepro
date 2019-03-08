namespace FSharpProject
open System.Runtime.InteropServices //for OutAttribute

/// <summary>
/// This is my type
/// </summary>
type MyType() =

    /// <summary>
    /// This is a method with an out parameter
    /// </summary>
    /// <param name="s">An input string</param>
    /// <param name="result">An output string</param>
    static member StaticOutParam((s : string), [<Out>] result : string byref) =
        result <- "test"