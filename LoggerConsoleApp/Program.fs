namespace LoggerConsoleApp

open LoggerLib

module Program =

    [<EntryPoint>]
    let main args =
        let _logger = Factory.GetLogger
        _logger.Level <- LogLevel.INFO
        _logger.Warning <| if args.Length > 0 then args[0] else "Hello"
        0
