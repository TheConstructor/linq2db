// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.SQLiteNorthwind
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public TestDataDB(DataContextOptions<TestDataDB> options)
			: base(options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<Category>                   Categories                   => this.GetTable<Category>();
		public ITable<CustomerCustomerDemo>       CustomerCustomerDemos        => this.GetTable<CustomerCustomerDemo>();
		public ITable<CustomerDemographic>        CustomerDemographics         => this.GetTable<CustomerDemographic>();
		public ITable<Customer>                   Customers                    => this.GetTable<Customer>();
		public ITable<Employee>                   Employees                    => this.GetTable<Employee>();
		public ITable<EmployeeTerritory>          EmployeeTerritories          => this.GetTable<EmployeeTerritory>();
		public ITable<OrderDetail>                OrderDetails                 => this.GetTable<OrderDetail>();
		public ITable<Order>                      Orders                       => this.GetTable<Order>();
		public ITable<Product>                    Products                     => this.GetTable<Product>();
		public ITable<Region>                     Regions                      => this.GetTable<Region>();
		public ITable<Shipper>                    Shippers                     => this.GetTable<Shipper>();
		public ITable<Supplier>                   Suppliers                    => this.GetTable<Supplier>();
		public ITable<Territory>                  Territories                  => this.GetTable<Territory>();
		public ITable<AlphabeticalListOfProduct>  AlphabeticalListOfProducts   => this.GetTable<AlphabeticalListOfProduct>();
		public ITable<CurrentProductList>         CurrentProductLists          => this.GetTable<CurrentProductList>();
		public ITable<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities => this.GetTable<CustomerAndSuppliersByCity>();
		public ITable<OrderDetailsExtended>       OrderDetailsExtendeds        => this.GetTable<OrderDetailsExtended>();
		public ITable<OrderSubtotal>              OrderSubtotals               => this.GetTable<OrderSubtotal>();
		public ITable<SummaryOfSalesByQuarter>    SummaryOfSalesByQuarters     => this.GetTable<SummaryOfSalesByQuarter>();
		public ITable<SummaryOfSalesByYear>       SummaryOfSalesByYears        => this.GetTable<SummaryOfSalesByYear>();
		public ITable<OrdersQry>                  OrdersQries                  => this.GetTable<OrdersQry>();
		public ITable<ProductsAboveAveragePrice>  ProductsAboveAveragePrices   => this.GetTable<ProductsAboveAveragePrice>();
		public ITable<ProductsByCategory>         ProductsByCategories         => this.GetTable<ProductsByCategory>();
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static Category? Find(this ITable<Category> table, int categoryId)
		{
			return table.FirstOrDefault(e => e.CategoryId == categoryId);
		}

		public static Task<Category?> FindAsync(this ITable<Category> table, int categoryId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.CategoryId == categoryId, cancellationToken);
		}

		public static CustomerCustomerDemo? Find(this ITable<CustomerCustomerDemo> table, string customerId, string customerTypeId)
		{
			return table.FirstOrDefault(e => e.CustomerId == customerId && e.CustomerTypeId == customerTypeId);
		}

		public static Task<CustomerCustomerDemo?> FindAsync(this ITable<CustomerCustomerDemo> table, string customerId, string customerTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.CustomerId == customerId && e.CustomerTypeId == customerTypeId, cancellationToken);
		}

		public static CustomerDemographic? Find(this ITable<CustomerDemographic> table, string customerTypeId)
		{
			return table.FirstOrDefault(e => e.CustomerTypeId == customerTypeId);
		}

		public static Task<CustomerDemographic?> FindAsync(this ITable<CustomerDemographic> table, string customerTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.CustomerTypeId == customerTypeId, cancellationToken);
		}

		public static Customer? Find(this ITable<Customer> table, string customerId)
		{
			return table.FirstOrDefault(e => e.CustomerId == customerId);
		}

		public static Task<Customer?> FindAsync(this ITable<Customer> table, string customerId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.CustomerId == customerId, cancellationToken);
		}

		public static Employee? Find(this ITable<Employee> table, int employeeId)
		{
			return table.FirstOrDefault(e => e.EmployeeId == employeeId);
		}

		public static Task<Employee?> FindAsync(this ITable<Employee> table, int employeeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.EmployeeId == employeeId, cancellationToken);
		}

		public static EmployeeTerritory? Find(this ITable<EmployeeTerritory> table, int employeeId, string territoryId)
		{
			return table.FirstOrDefault(e => e.EmployeeId == employeeId && e.TerritoryId == territoryId);
		}

		public static Task<EmployeeTerritory?> FindAsync(this ITable<EmployeeTerritory> table, int employeeId, string territoryId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.EmployeeId == employeeId && e.TerritoryId == territoryId, cancellationToken);
		}

		public static OrderDetail? Find(this ITable<OrderDetail> table, int orderId, int productId)
		{
			return table.FirstOrDefault(e => e.OrderId == orderId && e.ProductId == productId);
		}

		public static Task<OrderDetail?> FindAsync(this ITable<OrderDetail> table, int orderId, int productId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.OrderId == orderId && e.ProductId == productId, cancellationToken);
		}

		public static Order? Find(this ITable<Order> table, int orderId)
		{
			return table.FirstOrDefault(e => e.OrderId == orderId);
		}

		public static Task<Order?> FindAsync(this ITable<Order> table, int orderId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.OrderId == orderId, cancellationToken);
		}

		public static Product? Find(this ITable<Product> table, int productId)
		{
			return table.FirstOrDefault(e => e.ProductId == productId);
		}

		public static Task<Product?> FindAsync(this ITable<Product> table, int productId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.ProductId == productId, cancellationToken);
		}

		public static Region? Find(this ITable<Region> table, int regionId)
		{
			return table.FirstOrDefault(e => e.RegionId == regionId);
		}

		public static Task<Region?> FindAsync(this ITable<Region> table, int regionId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.RegionId == regionId, cancellationToken);
		}

		public static Shipper? Find(this ITable<Shipper> table, int shipperId)
		{
			return table.FirstOrDefault(e => e.ShipperId == shipperId);
		}

		public static Task<Shipper?> FindAsync(this ITable<Shipper> table, int shipperId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.ShipperId == shipperId, cancellationToken);
		}

		public static Supplier? Find(this ITable<Supplier> table, int supplierId)
		{
			return table.FirstOrDefault(e => e.SupplierId == supplierId);
		}

		public static Task<Supplier?> FindAsync(this ITable<Supplier> table, int supplierId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.SupplierId == supplierId, cancellationToken);
		}

		public static Territory? Find(this ITable<Territory> table, string territoryId)
		{
			return table.FirstOrDefault(e => e.TerritoryId == territoryId);
		}

		public static Task<Territory?> FindAsync(this ITable<Territory> table, string territoryId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.TerritoryId == territoryId, cancellationToken);
		}
		#endregion
	}
}
