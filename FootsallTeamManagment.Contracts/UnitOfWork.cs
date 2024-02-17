namespace FootsallTeamManagment.Contracts
{
    public interface UnitOfWork
    {
        Task Begin();
        Task Complete();
        Task Commit();
        Task Rollback();
    }
}
