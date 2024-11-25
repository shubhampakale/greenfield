$(document).ready
        (
            function ()
            {

                var product = [
                    { ProductId: 1, Name: 'Mac', Description: 'Costly', Quantity: 10, Price :150000},
                    { ProductId: 2, Name: 'Iphone', Description: 'Moderate', Quantity: 100, Price: 100000 },
                    { ProductId: 3, Name: 'Mac Mini', Description: 'Expensive', Quantity: 1000, Price: 200000}
                ];

                $.each(product, function (index, item) {
                    var row = '<tr>' +
                        '<td>' + item.ProductId + '</td>' +
                        '<td>' + item.Name + '</td>' +
                        '<td>' + item.Description + '</td>' +
                        '<td>' + item.Quantity + '</td>' +
                        '<td>' + item.Price + '</td>' +
                        '</tr>';

                    $('#product tbody').append(row);
                });

            }
    );