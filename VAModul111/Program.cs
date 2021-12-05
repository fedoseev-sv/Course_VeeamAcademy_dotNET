using VAModul111;

// See https://aka.ms/new-console-template for more information

#region Task
/* 
 * Создайте свой иммутабельный (immutable) тип. При изменении какого-либо из полей создается новый объект.  
 */
#endregion

// create new exemplar strust Coordinates and print result
var Well1 = new Coordinates(pointA: 52.2, pointB: 34.6, nameSystem: "Pulkovo-42");
Console.WriteLine(Well1.ToString());

// create new exemplar strust Coordinates and print result
var Well2 = Well1 with { PointX = 32.4, PointY = 32.7 };
Console.WriteLine(Well2.ToString());

Console.ReadKey();