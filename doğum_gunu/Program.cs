
Console.WriteLine("Doğum tarihinizi giriniz: ");
DateTime dogumtarihi = Convert.ToDateTime(Console.ReadLine());
DateTime buguntarih = DateTime.Now;
TimeSpan zamanaraligi = buguntarih.Subtract(dogumtarihi);
Console.WriteLine(zamanaraligi.TotalDays / 365);
Console.ReadKey();