namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrder(int customerId)
{
    public Guid Id { get; } = Guid.NewGuid(); // Guid sirve para generar claves aleatorias
    public int CustomerId { get; } = customerId;
}