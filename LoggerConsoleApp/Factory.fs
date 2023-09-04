namespace LoggerConsoleApp

open LoggerLib
open System.IO

module Factory =
    let GetLogger = BetterLogger()
//let GetLogger = BetterLogger(new StreamWriter "log.txt")
