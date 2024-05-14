using System.Security.AccessControl;

namespace Bank
{
    //Soru : Bir bankada musteriler sırayla işlemlerini yapmaktadırlar...Musterilere hizmet veren bankolar vardır(2-3). Musteriler 3 farkı işlem yapabilmektedirler ve her işlemin ayrı bir suresi olacaktır... Rastgele her musteri bir islem ile gelecektir...Veznedeki çalışanların durumu boş yada dolu olabilir.. Boş olduğunda yeni müşteri vezneye gitmeli...Vezneye gitiğinde vezne durumu meşgul olacak...

    //Bu sistemi gerçekleştirecek sınıfları tasarlayınız....
    //Havale  5 dak.
    //Para Çekme 7 dak.
    //Para yatırma 2 dak.
    public class Banka
    {
        public Banka()
        {
            BankaIceriginiOlustur();
        }
        public MusteriManager Musteriler { get; set; }
        public VezneManager Vezneler { get; set; }
        public PersonelManager Personeller { get; set; }

        private void BankaIceriginiOlustur()
        { 
            Musteriler=new MusteriManager();
            Vezneler=new VezneManager();
            Personeller=new PersonelManager();
            //Initialize....

            int tekrarSayisi = new Random().Next(1, 10);
            for(int i=0;i<tekrarSayisi;i++)
            Musteriler.Ekle(BankaUtility.MusteriOlustur());


            //personelleri olustur
            for (int i = 0; i <6; i++)
                Personeller.Ekle(BankaUtility.PersonelOlustur());

            //vezneleri olustur...
            for (int i = 0; i < 5; i++)
            {
                Vezne vezne = BankaUtility.VezneOlustur(Personeller.Listele()[i]);
                vezne.VezneMusait += VezneyeMusteriAl;
                vezne.VezneDurumu = vezne.VezneDurumu;
               
                Vezneler.Ekle(vezne);
            }
          
        }

        private void VezneyeMusteriAl(object sender, EventArgs e)
        {
            Vezne vezne = sender as Vezne;
            vezne.VezneDurumu = VezneDurumu.Mesgul;

            vezne.Musteri = Musteriler.Cikar();
        }

        public void MusaitVeznelereMusteriAta()
        {
            //tum musait veznelere musteri ata...
            foreach (Vezne vezne in Vezneler.Listele())
            {
                if (vezne.VezneDurumu == VezneDurumu.Musait)
                {
                    vezne.Musteri = Musteriler.Cikar();
                    vezne.VezneDurumu = VezneDurumu.Mesgul;
                }
            }
        }
    }
}