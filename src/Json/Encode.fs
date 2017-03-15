module Encode

open Json


let comaJoin list =
    match list with
        | [] -> ""
        | l -> List.reduce (sprintf "%s,%s") l


let rec encode json =
    match json with
        | Null -> "null"
        | Bool b -> match b with | false -> "false" | true -> "true"
        | Number d -> string d

        | String s ->
            String.collect
                (function
                    | '"' -> "\\\""
                    | '\\' -> "\\\\"
                    | a -> string a
                )
                s
                |> sprintf "\"%s\""

        | Array a -> List.map encode a |> comaJoin |> sprintf "[%s]"

        | Object m ->
            Map.toList m
                |> List.map
                    (fun (k, v) ->
                        let key = String k |> encode
                        encode v |> sprintf "%s:%s" key
                    )
                |> comaJoin
                |> sprintf "{%s}"
