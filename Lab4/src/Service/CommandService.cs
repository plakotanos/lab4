using Lab3.Commands;
using Lab3.Data;
using Lab3.Models;
using Lab3.Models.Commands;

namespace Lab4.Service;

public class CommandService : ICommandService
{
    private readonly CommandExecutor _executor = new CommandExecutor();


    public void Execute(Turtle turtle, string name, params string[] args)
    {
        _executor.AddCommands(
            new AngleCommand(turtle),
            new ColorCommand(turtle),
            new ListCommand(turtle),
            new MoveCommand(turtle),
            new PenDownCommand(turtle),
            new PenUpCommand(turtle)
        );

        _executor.TryExecuteCommand(name, args);
    }
}