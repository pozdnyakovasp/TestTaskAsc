namespace Domain.BackgroundWorkers
{
    public enum UpdateTaskStatus : int
    {
        Undefined = 0,
        Uploaded = 1,
        Processing = 2,
        Successfully = 3,
        Failed = 4
    }
}
