using CarBuilder.Models;


List<PaintColor> paintcolors = new List<PaintColor>
{
new PaintColor()
{
    Id = 1,
    Price = 250.25M,
    Color = "Silver"
},
new PaintColor()
{
    Id = 2,
    Price = 350.25M,
    Color = "Midnight Blue"
},
new PaintColor()
{
    Id = 3,
    Price = 450.25M,
    Color = "Firebrick Red"
},
new PaintColor()
{
    Id = 4,
    Price = 550.25M,
    Color = "Spring Green"
},
};

List<Interior> interiors = new List<Interior>
{
    new Interior()
    {
        Id = 1,
        Price = 650.25M,
        Material = "Beige Fabric"
    },
    new Interior()
    {
        Id = 2,
        Price = 750.25M,
        Material = "Charcoal Fabric"
    },
    new Interior()
    {
        Id = 3,
        Price = 850.25M,
        Material = "White Leather"
    },
    new Interior()
    {
        Id = 4,
        Price = 950.25M,
        Material = "Black Leather"
    },
};

List<Technology> technologies = new List<Technology>
{
new Technology()
{
    Id = 1,
    Price = 1050.25M,
    Package = "Basic Package"
},
new Technology()
{
    Id = 2,
    Price = 1150.25M,
    Package = "Navigation Package"
},
new Technology()
{
    Id = 3,
    Price = 1250.25M,
    Package = "Visibility Package"
},
new Technology()
{
    Id = 3,
    Price = 1350.25M,
    Package = "Ultra Package"
},
};

List<Wheels> wheels = new List<Wheels>
{
new Wheels()
{
    Id = 1,
    Price = 700.50M,
    Style = "17-inch Pair Radial"
},
new Wheels()
{
    Id = 2,
    Price = 800.50M,
    Style = "17-inch Pair Radial Black"
},
new Wheels()
{
    Id = 3,
    Price = 900.50M,
    Style = "18-inch Pair Spoke Silver"
},
new Wheels()
{
    Id = 4,
    Price = 1000.50M,
    Style = "18-inch Pair Spoke Black"
}
};

List<Order> orders = new List<Order>
{

};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/paintcolors", () =>
{
    return paintcolors;
});

app.MapGet("/interiors", () =>
{
    return interiors;
});

app.MapGet("/technologies", () =>
{
    return technologies;
});
app.MapGet("/wheels", () =>
{
    return wheels;
});

app.MapGet("/orders", () =>
{

    return orders;
});

app.MapPost("/orders", (Order order) =>
{
    order.Id = orders.Count > 0 ? orders.Max(o => o.Id) + 1 : 1;
    orders.Add(order);
    return order;
}
);


app.Run();

