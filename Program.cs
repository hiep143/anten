
using UnitsNet;
using UnitsNet.Units;



Console.Write("Nhap vao gia tri Er: ");
double Er = double.Parse(Console.ReadLine());

Console.Write("Nhap vao gia tri h: ");
Length h = Length.FromMillimeters(double.Parse(Console.ReadLine()));

Console.Write("Nhap vao gia tri f(GHz): ");
Frequency f = Frequency.FromGigahertz(double.Parse(Console.ReadLine()));

Speed Vo = Speed.FromKilometersPerSecond(300000);
double Co = Vo.MetersPerSecond;





    // Thực hiện các tính toán

    Length W = Length.FromMeters(Vo.MetersPerSecond/(2*f.Hertz) * (Math.Sqrt(2/(Er+1))));
    double Ereff = (Er+1)/2 + ((Er-1)/2)/Math.Sqrt(1+12*h.Meters/W.Meters);
    Length delta_L = Length.FromMeters(h.Meters*0.412 * ((Ereff+0.3)*(W.Meters/h.Meters+0.264)) / ((Ereff-0.258)*(W.Meters/h.Meters+0.8)));
    Length L = Length.FromMeters(Vo.MetersPerSecond/(2*f.Hertz*Math.Sqrt(Ereff)) - 2*delta_L.Meters);





    // In kết quả
    Console.WriteLine($"W: {W.Millimeters}mm");
    Console.WriteLine($"L: {L.Millimeters}mm");
