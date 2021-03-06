﻿// Copyright (c) Avanade. Licensed under the MIT License. See https://github.com/Avanade/Beef

using System;
using System.Threading.Tasks;

namespace Beef.Events.Subscribe
{
    /// <summary>
    /// Enables the <see cref="EventData"/> subscriber processor capabilities.
    /// </summary>
    public interface IEventSubscriber
    {
        /// <summary>
        /// Gets the <see cref="RunAsUser"/> option.
        /// </summary>
        RunAsUser RunAsUser { get; }

        /// <summary>
        /// Gets the <see cref="UnhandledExceptionHandling"/> option.
        /// </summary>
        UnhandledExceptionHandling UnhandledExceptionHandling { get; }

        /// <summary>
        /// Gets the <see cref="ResultHandling"/> for a <see cref="Result"/> with a <see cref="SubscriberStatus.InvalidEventData"/> status (overrides <see cref="EventSubscriberHostArgs.InvalidEventDataHandling"/>).
        /// </summary>
        ResultHandling? InvalidEventDataHandling { get; }

        /// <summary>
        /// Gets the <see cref="ResultHandling"/> for a <see cref="Result"/> with a <see cref="SubscriberStatus.DataNotFound"/> status (overrides <see cref="EventSubscriberHostArgs.DataNotFoundHandling"/>).
        /// </summary>
        ResultHandling? DataNotFoundHandling { get; }

        /// <summary>
        /// Gets the <see cref="ResultHandling"/> for a <see cref="Result"/> with a <see cref="SubscriberStatus.InvalidData"/> status (overrides <see cref="EventSubscriberHostArgs.InvalidDataHandling"/>).
        /// </summary>
        ResultHandling? InvalidDataHandling { get; }

        /// <summary>
        /// Gets the value <see cref="Type"/> if any.
        /// </summary>
        Type? ValueType { get; }

        /// <summary>
        /// Receive and process the subscribed <see cref="EventData"/>.
        /// </summary>
        /// <param name="eventData">The <see cref="EventData"/>.</param>
        /// <returns>The <see cref="Result"/>.</returns>
        Task<Result> ReceiveAsync(EventData eventData);
    }
}