Console.Write("Precio por consumo: ");
float consum = float.Parse(Console.ReadLine());
float descuento;
if (consum > 100) {
    descuento = consum * 0.20f;
} else {
    descuento = consum * 0.10f;
}
Console.WriteLine("monto del descuento: " + descuento);
float subtotal = consum - descuento;
Console.WriteLine("subtotal: " + subtotal);
float impuesto = (consum - descuento) * 0.18f;
Console.WriteLine("monto del impuesto: " + impuesto);
float aPagar = consum - descuento + impuesto;
Console.WriteLine("importe final a pagar: " + aPagar);