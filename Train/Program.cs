using System;

namespace Train
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Person lenkaKozakova = new Person("Lenka", "Kozáková");
                Person karelNovak = new Person("Karel", "Novak");

                //Vytvořte 3 osobní vagony (jeden z toho bude Business, stewardka Lenka Kozáková), , jeden spací a  jeden Hopper.
                Economy vagon1 = new Economy(40);
                Economy vagon2 = new Economy(40);
                Business vagon3 = new Business(lenkaKozakova, 20);
                NightWagon vagon4 = new NightWagon(10, 10);
                Hopper vagon5 = new Hopper(100);

                //Vytvořte lokomotivu (diesel se strojvedoucím Karlem Novákem). 
                Locomotive lokomotiva = new Locomotive(karelNovak, EngineType.Diesel);
                Locomotive lokomotiva2 = new Locomotive(karelNovak, EngineType.Steam);

                Train train = new Train(lokomotiva);
                Train train2 = new Train(lokomotiva2);

                //Udělejte z toho vlak, vytvořte mu další vagon (ještě jeden Hopper) a připojte.  
                train.ConnectWagon(vagon1);
                train.ConnectWagon(vagon2);
                train.ConnectWagon(vagon3);
                vagon4.ConnectToTrain(train);
                train.ConnectWagon(vagon5);
                //vytvořte mu další vagon (ještě jeden Hopper) a připojte.  
                train.ConnectWagon(new Hopper(150));

                //Vytvořte parní lokomotivu s 5 vagony. Zkuste vytvořit a připojit další. Ověřte, že program  protestuje.  
                train2.ConnectWagon(vagon1);
                train2.ConnectWagon(vagon2);
                train2.ConnectWagon(vagon3);
                vagon4.ConnectToTrain(train2);
                train2.ConnectWagon(vagon5);
                train2.ConnectWagon(vagon5);

                //Rezervujte sedadlo v třetím vagonu.
                train.ReserveChair(2, 41);
                train.ReserveChair(8, 53);

                //Zkuste jinému cestovateli rezervovat sedadlo v Hopperu.
                train.ReserveChair(4, 53);

                //Zkuste taky rezervovat už jednou rezervované sedadlo, opět ověřte, že to nejde a že program nespadne na výjimku. 
                train.ReserveChair(2, 41);

                //Vypište rezervovaná sedadla. 
                train.ListReservedChairs();

                //Nakonec vypište informace o obou vlacích pomocí ToString().
                Console.WriteLine(train.ToString());
                Console.WriteLine(train2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
