open MF.ConsoleApplication
open MF.CNTK.Example

[<EntryPoint>]
let main argv =
    consoleApplication {
        title "CNTK.Example"
        info ApplicationInfo.MainTitle

        command "run" {
            Description = "Run the example."
            Help = None
            Arguments = []
            Options = []
            Initialize = None
            Interact = None
            Execute = fun (input, output) ->

                output.Success "Done"
                ExitCode.Success
        }
    }
    |> run argv
