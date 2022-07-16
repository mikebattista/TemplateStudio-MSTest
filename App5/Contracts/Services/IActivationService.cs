namespace App5.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
