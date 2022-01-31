namespace Distribt.Shared.Communication.RabbitMQ;

public class RabbitMQSettings
{
    public string Hostname { get; init; } = null!;
    public RabbitMQCredentials? Credentials { get; set; }
    public PublisherSettings? Publisher { get; init; }
    public ConsumerSettings? Consumer { get; init; }
}

public record RabbitMQCredentials
{
    public string username { get; init; } = null!;
    public string password { get; init; } = null!;
}

public record PublisherSettings
{
    public string? IntegrationExchange { get; init; }
    public string? DomainExchange { get; init; }
}

public record ConsumerSettings
{
    public string? IntegrationQueue { get; init; }
    public string? DomainQueue { get; init; }
}