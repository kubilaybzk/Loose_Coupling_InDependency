using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
Burası bizim Tight Coupling (Sıkı Bağlantı) Örneğimiz
Burada Her Bir mail Sender işlemimiz bizim için  sadece ve sadece bu class içinde 
oluşan class'a bağımlı olacak şekilde çalışacak .
İlerleyen aşamalarda eğer hotmail içinde bir değişiklik yada gmail
içinde bir değişiklik olduğu zaman burada da değiştirme yapmamız gerekecek.
Yada yarın öbürgün bir şey oldu diyelim mailleri başka bir servis ile yollamak istersek tekrar burada 
düzenleme yapmamız gerekecek.

    Bunu engellemek için Loose Coupled kullanmamız gerekiyor.

*/
class MailSender_BadVersion
{
    public void Send()
    {
        //Gmail_BadVersion gmail = new();
        //gmail.Send("gyildizmail@gmail.com");
        Hotmail_BadVersion hotmail = new();
        hotmail.Send("selam");
    }
}
class Gmail_BadVersion
{
    public void Send(string to)
    {
        Console.WriteLine("Work Gmail_BadVersion");
    }
}
class Hotmail_BadVersion
{
    public void Send(string to)
    {
        Console.WriteLine("Work Hotmail_BadVersion");
    }
}