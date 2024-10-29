using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestExpenseJson request)
    {
        // TODO validations
        return new ResponseRegisterExpenseJson();
    }
}