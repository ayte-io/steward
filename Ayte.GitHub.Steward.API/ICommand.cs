namespace Ayte.GitHub.Steward.API
{
    public interface ICommand
    {
        void Execute(IExecutionContext executionContext);
    }
}