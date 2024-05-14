using Bank;

void VeriGoster<T>(List<T> items)
{
    Console.WriteLine();
    foreach (T item in items)
        Console.WriteLine(item);
}

Banka banka = new Banka();

VeriGoster(banka.Musteriler.Listele());

VeriGoster(banka.Personeller.Listele());

VeriGoster(banka.Vezneler.Listele());

Console.WriteLine("-----------");
//banka.MusaitVeznelereMusteriAta();
VeriGoster(banka.Vezneler.Listele());
VeriGoster(banka.Musteriler.Listele());

Console.WriteLine("-----------");
banka.Vezneler.IslemYap();

VeriGoster(banka.Vezneler.Listele());
VeriGoster(banka.Musteriler.Listele());

