module Json


type Json =
    | Null
    | Bool of bool
    | Number of decimal
    | String of string
    | Array of Json list
    | Object of Map<string,Json>
