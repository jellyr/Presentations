﻿
//   _____                            _        _   _             
//  / ____|                          | |      | | (_)            
// | |     ___  _ __ ___  _ __  _   _| |_ __ _| |_ _  ___  _ __  
// | |    / _ \| '_ ` _ \| '_ \| | | | __/ _` | __| |/ _ \| '_ \ 
// | |___| (_) | | | | | | |_) | |_| | || (_| | |_| | (_) | | | |
//  \_____\___/|_| |_| |_| .__/ \__,_|\__\__,_|\__|_|\___/|_| |_|
// |  ____|              | |           (_)                       
// | |__  __  ___ __  _ _|_|__  ___ ___ _  ___  _ __  ___        
// |  __| \ \/ / '_ \| '__/ _ \/ __/ __| |/ _ \| '_ \/ __|       
// | |____ >  <| |_) | | |  __/\__ \__ \ | (_) | | | \__ \       
// |______/_/\_\ .__/|_|  \___||___/___/_|\___/|_| |_|___/       
//             | |                                               
//             |_|                                               

let a = seq {
    yield "a"
    yield "b"
}



type LoggingBuilder() =
    let log x =
        printfn "%i" x

    member this.Bind(x,f) =
        log x
        f x

    member this.Return(x) =
        x

let log = LoggingBuilder ()





log {
    let! a = 5
    return a
}

