// See https://aka.ms/new-console-template for more information

#region Ex2
Console.WriteLine("-------Ex2-------");
for ( int i=0; i<=10; i++)
{
    Console.WriteLine( i );
}

List<int> valores = new List<int>();

valores.Add( 20 );
valores.Add( 30 );
valores.Add( 40 );

foreach (var item in valores)
{
    Console.WriteLine ( item );
}
#endregion Ex2

#region Ex3
Console.WriteLine("-------Ex3-------");

valores.ForEach(Console.WriteLine);
#endregion Ex3