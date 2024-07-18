using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;

        // Marten UPSERT will cater for existing records
        session.Store<Product>(GetPreconfiguredProduct());
        await session.SaveChangesAsync();
    }

    private static IEnumerable<Product> GetPreconfiguredProduct() => new List<Product>()
    {
         new Product()
        {
            Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
            Name = "IPhone X",
            Description = "This phone is the company's biggest change to its design in years.",
            ImageFile = "product-1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("b91e86c5-9d3e-4e4c-9f77-1edab8fb55fb"),
            Name = "Samsung Galaxy S20",
            Description = "The Samsung Galaxy S20 is a powerful smartphone with advanced features.",
            ImageFile = "product-2.png",
            Price = 850.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("e303a0a5-d5e1-4ddf-9ae8-524c8a0b958d"),
            Name = "Google Pixel 4",
            Description = "The Google Pixel 4 is known for its outstanding camera quality.",
            ImageFile = "product-3.png",
            Price = 800.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("7f74b68b-4f98-4a2e-8e50-5bdb2b69a1ff"),
            Name = "OnePlus 8",
            Description = "The OnePlus 8 offers a great balance of performance and price.",
            ImageFile = "product-4.png",
            Price = 700.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("e1a7e5d4-8b8e-4e21-8f35-3c649d3a6f0b"),
            Name = "Sony Xperia 1 II",
            Description = "The Sony Xperia 1 II is designed for professional photographers.",
            ImageFile = "product-5.png",
            Price = 1200.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("4dfcbe48-bb2b-4e44-80a3-3eb8d7a7f3e6"),
            Name = "Huawei P40 Pro",
            Description = "The Huawei P40 Pro is a high-end smartphone with excellent camera capabilities.",
            ImageFile = "product-6.png",
            Price = 900.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("5f7e8a6a-bc23-441b-bde3-4edc1f9d6a6b"),
            Name = "Xiaomi Mi 10",
            Description = "The Xiaomi Mi 10 offers high performance and great value for money.",
            ImageFile = "product-7.png",
            Price = 650.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("f2a8c7c2-8a7e-4d1e-8b74-2f9e8a9d6b6a"),
            Name = "Oppo Find X2",
            Description = "The Oppo Find X2 is a flagship phone with impressive display and camera.",
            ImageFile = "product-8.png",
            Price = 800.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("d2b3e4c5-f4c7-4a2f-9c6d-3e7f8a1b6c6d"),
            Name = "LG V60 ThinQ",
            Description = "The LG V60 ThinQ is known for its dual screen accessory and powerful performance.",
            ImageFile = "product-9.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone" }
        },
        new Product()
        {
            Id = new Guid("a7f8c6d5-7c4a-4d1e-8e9b-1f2a3b5c6d7e"),
            Name = "Motorola Edge+",
            Description = "The Motorola Edge+ features a stunning display and high-end specs.",
            ImageFile = "product-10.png",
            Price = 1000.00M,
            Category = new List<string> { "Smart Phone" }
        }
    };
}
