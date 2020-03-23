namespace Olbrasoft.Mapping
{
    public interface IMapper : IProjector
    {
        TDestination MapTo<TDestination>(object source);
    }
}