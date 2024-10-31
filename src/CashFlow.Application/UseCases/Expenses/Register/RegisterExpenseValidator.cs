using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator: AbstractValidator<RequestRegisterExpenseJson>
{
   public RegisterExpenseValidator()
   {
      RuleFor(expense => expense.Title).NotEmpty().WithMessage("Title is required");
      RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
      RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Expense date cannot be in the future");
      RuleFor(expense => expense.PaymentMethod).IsInEnum().WithMessage("Payment method is not valid");
   } 
}