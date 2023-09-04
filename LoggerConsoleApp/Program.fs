namespace LoggerConsoleApp

open LoggerLib

module Program =

    [<EntryPoint>]
    let main args =
        let _logger = Factory.GetLogger
        _logger.Level <- LogLevel.ERROR
        _logger.Error <| if args.Length > 0 then args[0] else "Hello"
        0
