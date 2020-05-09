/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Beef;
using Beef.Entities;
using Beef.WebApi;
using Newtonsoft.Json.Linq;
using Cdr.Banking.Common.Entities;
using Cdr.Banking.Common.Agents.ServiceAgents;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Agents
{
    /// <summary>
    /// Provides the Transaction Web API agent.
    /// </summary>
    public partial class TransactionAgent : WebApiAgentBase, ITransactionServiceAgent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionAgent"/> class.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> (where overridding the default value).</param>
        /// <param name="beforeRequest">The <see cref="Action{HttpRequestMessage}"/> to invoke before the <see cref="HttpRequestMessage">Http Request</see> is made (see <see cref="WebApiServiceAgentBase.BeforeRequest"/>).</param>
        public TransactionAgent(HttpClient? httpClient = null, Action<HttpRequestMessage>? beforeRequest = null)
        {
            TransactionServiceAgent = Beef.Factory.Create<ITransactionServiceAgent>(httpClient, beforeRequest);
        }
        
        /// <summary>
        /// Gets the underlyng <see cref="ITransactionServiceAgent"/> instance.
        /// </summary>
        public ITransactionServiceAgent TransactionServiceAgent { get; private set; }

        /// <summary>
        /// Get transaction for account.
        /// </summary>
        /// <param name="accountId">The Account Id.</param>
        /// <param name="args">The Args (see <see cref="TransactionArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <param name="requestOptions">The optional <see cref="WebApiRequestOptions"/>.</param>
        /// <returns>A <see cref="WebApiAgentResult"/>.</returns>
        public Task<WebApiAgentResult<TransactionCollectionResult>> GetTransactionsAsync(string? accountId, TransactionArgs? args, PagingArgs? paging = null, WebApiRequestOptions? requestOptions = null)
            => TransactionServiceAgent.GetTransactionsAsync(accountId, args, paging, requestOptions);
    }
}

#nullable restore