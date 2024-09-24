using FluentValidation;

namespace Ordering.Application.Orders.Commands.DeleteOrder;

public record DeleteOrderCommand(Guid OrderId)
    : ICommand<DeleteOrderResult>;

public record DeleteOrderResult(bool IsSuccess);

public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderResult>
{
    public DeleteOrderCommandValidator()
    {
        RuleFor(x => x.IsSuccess).NotEmpty().WithMessage("OrderId is required");
    }
}
