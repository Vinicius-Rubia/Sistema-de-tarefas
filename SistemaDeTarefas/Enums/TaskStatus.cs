using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum TaskStatus
    {
        [Description("ToDo")]
        ToDo = 1,
        [Description("Pending")]
        Pending = 2,
        [Description("Finished")]
        Finished = 3,
    }
}
