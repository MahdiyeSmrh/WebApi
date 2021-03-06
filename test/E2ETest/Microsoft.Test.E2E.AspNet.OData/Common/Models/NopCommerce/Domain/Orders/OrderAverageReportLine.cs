// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Nop.Core.Domain.Orders
{
    /// <summary>
    /// Represents an order average report line
    /// </summary>
    public partial class OrderAverageReportLine
    {
        /// <summary>
        /// Gets or sets the tax summary
        /// </summary>
        public decimal SumTax { get; set; }

        /// <summary>
        /// Gets or sets the order total summary
        /// </summary>
        public decimal SumOrders { get; set; }

        /// <summary>
        /// Gets or sets the count
        /// </summary>
        public int CountOrders { get; set; }
    }
}
