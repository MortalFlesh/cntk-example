namespace MF.CNTK.Example

module CNTKCommand =
    open CNTK

    let run (consoleOutput: MF.ConsoleApplication.Output) =
        let inputDim = 2
        let outputDim = 1
        let input = Variable.InputVariable(NDShape.CreateNDShape [ inputDim ], DataType.Double, "input")
        let output = Variable.InputVariable(NDShape.CreateNDShape [ outputDim ], DataType.Double, "output")


        ()
