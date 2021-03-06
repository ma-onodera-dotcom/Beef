/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Validation;
using Beef.Demo.Common.Entities;
using Beef.Demo.Business.DataSvc;
using Beef.Demo.Business.Validation;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business
{
    /// <summary>
    /// Provides the <see cref="Product"/> business functionality.
    /// </summary>
    public partial class ProductManager : IProductManager
    {
        private readonly IProductDataSvc _dataService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductManager"/> class.
        /// </summary>
        /// <param name="dataService">The <see cref="IProductDataSvc"/>.</param>
        public ProductManager(IProductDataSvc dataService)
            { _dataService = Check.NotNull(dataService, nameof(dataService)); ProductManagerCtor(); }

        partial void ProductManagerCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The <see cref="Product"/> identifier.</param>
        /// <returns>The selected <see cref="Product"/> where found.</returns>
        public Task<Product?> GetAsync(int id)
        {
            return ManagerInvoker.Current.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                Cleaner.CleanUp(id);
                id.Validate(nameof(id)).Mandatory().Run().ThrowOnError();
                return Cleaner.Clean(await _dataService.GetAsync(id).ConfigureAwait(false));
            });
        }

        /// <summary>
        /// Gets the <see cref="ProductCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Common.Entities.ProductArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="ProductCollectionResult"/>.</returns>
        public Task<ProductCollectionResult> GetByArgsAsync(ProductArgs? args, PagingArgs? paging)
        {
            return ManagerInvoker.Current.InvokeAsync(this, async () =>
            {
                ExecutionContext.Current.OperationType = OperationType.Read;
                Cleaner.CleanUp(args);
                args.Validate(nameof(args)).Entity(ProductArgsValidator.Default).Run().ThrowOnError();
                return Cleaner.Clean(await _dataService.GetByArgsAsync(args, paging).ConfigureAwait(false));
            });
        }
    }
}

#pragma warning restore IDE0005
#nullable restore