// Create a product list & display 

let product =
    [
        {
            id: 1,
            name: "laptop",
            price: 100000
        },
        {
            id: 2,
            name: "mobile",
            price: 50000
        },
        {
            id: 3,
            name: "tv",
            price: 60000
        }
    ];

for (var i = 0; i < product.length; i++) {
    console.log(product[i].id);
    console.log(product[i].name);
    console.log(product[i].price);
    console.log();
}
