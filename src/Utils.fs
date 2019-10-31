namespace MF.CNTK.Example

[<AutoOpen>]
module internal Utils =
    let tee f a =
        f a
        a
