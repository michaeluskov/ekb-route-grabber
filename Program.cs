var client = new EkbTransportClient();
var transTypes = await client.GetTransTypes();
foreach (var transType in transTypes)
{
    Console.WriteLine(transType.Tt_Title);
    foreach (var route in transType.Routes)
    {
        Console.WriteLine($"{route.Mr_Num} {route.Mr_Title}");
    }
}
