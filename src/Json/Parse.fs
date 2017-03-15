module Parse

open Json

let json = "\"abba\""

// {
//     "glossary": {
//         "title": "example glossary",
// 		"GlossDiv": {
//             "title": "S",
// 			"GlossList": {
//                 "GlossEntry": {
//                     "ID": "SGML",
// 					"SortAs": "SGML",
// 					"GlossTerm": "Standard Generalized Markup Language",
// 					"Acronym": "SGML",
// 					"Abbrev": "ISO 8879:1986",
// 					"GlossDef": {
//                         "para": "A meta-markup language, used to create markup languages such as DocBook.",
// 						"GlossSeeAlso": ["GML", "XML"]
//                     },
// 					"GlossSee": "markup"
//                 }
//             }
//         }
//     }
// }
let value =
    Object
        (Map.ofList
            [   "sdsds", Number 34m
                "sdsdsds", Array [String "aaa"; Number 343m]
                "bfbf", String "Dfdff"
                "sdsdsd",
                    Array
                        [   Number 23m
                            Number 232334m
                            Number 4342m
                            Number 234m
                        ]
                "asas", Null
                "sds", Bool true
            ]
        )

[<EntryPoint>]
let main argv =
    printfn "%A" value
    0 // return an integer exit code
