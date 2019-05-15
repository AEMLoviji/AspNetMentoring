// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Moldule4.Tests.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Products
    {
        /// <summary>
        /// Initializes a new instance of the Products class.
        /// </summary>
        public Products()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Products class.
        /// </summary>
        public Products(string productName, double unitPrice, int? productId = default(int?), int? supplierId = default(int?), int? categoryId = default(int?), string quantityPerUnit = default(string), int? unitsInStock = default(int?), int? unitsOnOrder = default(int?), int? reorderLevel = default(int?), bool? discontinued = default(bool?), Categories category = default(Categories), Suppliers supplier = default(Suppliers), IList<OrderDetails> orderDetails = default(IList<OrderDetails>))
        {
            ProductId = productId;
            ProductName = productName;
            SupplierId = supplierId;
            CategoryId = categoryId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
            Category = category;
            Supplier = supplier;
            OrderDetails = orderDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productId")]
        public int? ProductId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplierId")]
        public int? SupplierId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categoryId")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantityPerUnit")]
        public string QuantityPerUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitPrice")]
        public double UnitPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitsInStock")]
        public int? UnitsInStock { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unitsOnOrder")]
        public int? UnitsOnOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reorderLevel")]
        public int? ReorderLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discontinued")]
        public bool? Discontinued { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public Categories Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supplier")]
        public Suppliers Supplier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderDetails")]
        public IList<OrderDetails> OrderDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProductName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProductName");
            }
            if (ProductName != null)
            {
                if (ProductName.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ProductName", 25);
                }
                if (ProductName.Length < 3)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ProductName", 3);
                }
            }
            if (UnitPrice > 99.99)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "UnitPrice", 99.99);
            }
            if (UnitPrice < 0.01)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "UnitPrice", 0.01);
            }
            if (OrderDetails != null)
            {
                foreach (var element in OrderDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}