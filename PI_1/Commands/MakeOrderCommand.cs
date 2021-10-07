using System;

namespace PI_1.Commands
{
    public record MakeOrderCommand
    {
        public Guid CarId { get; init; }
        public string ClientName { get; init; }
        public string Address { get; init; }
    }
}
