using Factory.Interfaces;

namespace Factory.Entities;

public class Email : IEntity
{
    public uint Id { get; set; }

    public User? Sender { get; set; }

    public User? Recipient { get; set; }

    public string? Message { get; set; }
}