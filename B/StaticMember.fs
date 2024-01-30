namespace B

open C

type Lorem =
    static member Ipsum (foo:C.Foo) : string =
        let res =
            match foo with
            | Bar i -> sprintf "%i" i
            | Baz s -> s
        res
