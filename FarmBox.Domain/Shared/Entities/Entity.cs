namespace FarmBox.Domain.Shared.Entities;

public abstract class Entity(Guid id) : IEquatable<Guid>
{
    #region MyRegion

    public Guid Id { get; init; } = id;

    #endregion
    
    #region Equatable Implementations
    public bool Equals(Guid id) => Id == id;

    override public int GetHashCode() => Id.GetHashCode();
    #endregion
    
    #region Domain Events
    
    #endregion
}
    