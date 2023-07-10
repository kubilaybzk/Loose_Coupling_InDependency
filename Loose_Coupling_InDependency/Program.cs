using Loose_Coupling_InDependency;

/*
 
1-)Dependency kısmını inceleyelim.
2-)Burada sıkı bağımlılık ile ilgili bir örnek yapalım
 
 */

MailSender_BadVersion badVersion = new MailSender_BadVersion();
badVersion.Send();


/* 
 
 Üst tarafta olduğu gibi burada bizim Gmail yada Hotmail olarak seçim yapma şansımız yok ,
    Bunun için  MailSender_BadVersion içine gidip orada new Gmail() yada new Hotmail() 
kısımlarını güncellememiz gerekecek bu istenmeyen bir durum .
 */

/*
 
3-)Bunu engellemek için Loose Coupled ilkesinden yaralanıyoruz.
    Bunun için bir aracı tutuyoruz bu aracı sayesinde istenen yerde istenen servisleri çağırabiliyor
        ve değişim yapabiliyoruz.

Bu sıkı bağımlılıkların azaltılması için yapısal değişikliklerle abstract sınıflar ya da interfaceler
kullanacağız.
    Bu sayede bizim MailSender classımız Gmail Hotmail vs ile muhattap olmayacak
        aracı olan sınıf ile muhattap olacak :)
   
Öncelikle İnterface tasarımımızı yapalım bunun için öncelikle ;

      interface IMailServer
      {
        void Send(string to, string body);
      }  

    Burada biz kısaca diyoruz ki kardeşim senden türeyecek olan bütün Servisler(Gmail, hotmail vs )
            Send adında  bir fonksiyona sahip olacak ve bu fonksiyon 
            boddy ve to adında iki değişkean alacak 


    Şimdi main Class'ımız içinde bir adet Method ekleyeceğiz bu method ;

class MailSender
{
    public void SendMail(IMailServer mailServer)
    {
        mailServer.Send("filanca@falanca.com", "LayyHn");
    }
}


SendMail' Methodumuz bir IMailServer değişkenine sahip olacak bu değişken Gmail olabilir Hotmail olabilir
Kısacası IMailServer'den kalıtım alan ondan türemiş olan herhangi bir sınıf olabilir.

Bu çalışacak olan bütün türemiş olan classların Send adında  bir methodu mecburen olması gerketiği
    için burada istenen her servis için istenen yerde çağırma yapabileceğiz.
      

Şimdi Test edelim .




 
 */


MailSender mailSenderProgres = new MailSender();

//Burada 3 farklı servis ile çağırma yapabildik. 

mailSenderProgres.SendMail(new Gmail());
mailSenderProgres.SendMail(new Hotmail());
mailSenderProgres.SendMail(new Yandex());




