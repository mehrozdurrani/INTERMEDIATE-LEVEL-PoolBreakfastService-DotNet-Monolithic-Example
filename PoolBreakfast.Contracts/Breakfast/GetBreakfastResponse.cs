namespace PoolBreakfast.Contracts.Breakfast
{
    public record GetBreakfastResponse(
        Guid Id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}
