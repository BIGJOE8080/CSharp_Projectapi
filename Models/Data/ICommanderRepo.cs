using Commander.Models;

namespace Commander.Data
{
    public interface   CommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}