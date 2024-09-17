using MediatR;

namespace BuildingBlocks.CQRS
{
	public interface IQueryHandler<in TQuary, TResponse>
		: IRequestHandler<TQuary, TResponse>
		where TQuary : IQuery<TResponse>
		where TResponse : notnull
	{
	}
}
