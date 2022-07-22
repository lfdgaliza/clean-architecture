namespace UseCases.Presenters.Vos;

public interface IPresenterRequest
{
    bool IsValid(out RequestValidationError[] requestValidationErrors);
}