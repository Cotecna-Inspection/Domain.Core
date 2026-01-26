using System;

namespace Cotecna.Domain.Core;

/// <summary>
/// Represents a Serializable <see cref="ContractException"/> for a contract invariant that has not been complied. Inherits from <see cref="Exception"/>
/// </summary>
[Serializable]
public class ContractException : Exception
{

    /// <summary>
    /// Initializes a <see cref="ContractException"/> to raise for a contract invariant not met
    /// </summary>
    public ContractException() { }

    /// <summary>
    ///Initializes a <see cref="ContractException"/> to raise for a contract invariant not met
    /// </summary>
    /// <param name="message">Message about the invariant not met</param>
    public ContractException(string message)
        : base(message)
    { }

    /// <summary>
    /// Initializes a <see cref="ContractException"/> to raise for a contract invariant not met
    /// </summary>
    /// <param name="message">Message about the invariant not met</param>
    /// <param name="inner">Inner <see cref="Exception"/></param>
    public ContractException(string message,
                             Exception inner)
        : base(message, inner)
    { }
}
