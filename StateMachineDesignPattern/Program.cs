using StateMachineDesignPattern.MuzikPlayerStateMachine;
using StateMachineDesignPattern.OrderStateMachine;

OrderRun_3();


void OrderRun_1()
{
    OrderMachine orderMachine = new OrderMachine();
    orderMachine.StockReserve(500);
    orderMachine.Payment(100);
    Console.WriteLine("*******");
    orderMachine.OrderCreate();
    orderMachine.StockReserve(500);
    orderMachine.Payment(200);
    Console.WriteLine("*******");
    orderMachine.OrderCreate();
    orderMachine.StockReserve(500);
    orderMachine.Payment(200);
}

void OrderRun_2()
{
    OrderMachine orderMachine = new OrderMachine();
    orderMachine.StockReserve(500);
    orderMachine.Payment(100);
    Console.WriteLine("*******");
    orderMachine.OrderCreate();
    orderMachine.StockReserve(5000);
    Console.WriteLine("*******");
    orderMachine.Payment(200);
    Console.WriteLine("*******");
    orderMachine.StockReserve(1000);
    orderMachine.Payment(2500);
    Console.WriteLine("*******");
    orderMachine.Payment(400);
}

void OrderRun_3()
{
    OrderMachine orderMachine = new OrderMachine();
    orderMachine.StockReserve(500);
    orderMachine.Payment(100);
    Console.WriteLine("*******");
    orderMachine.OrderCreate();
    orderMachine.StockReserve(5000);
    Console.WriteLine("*******");
    orderMachine.Payment(200);
    Console.WriteLine("*******");
    orderMachine.StockReserve(753);
    orderMachine.Payment(200);
    Console.WriteLine("*******");
    orderMachine.Payment(400);
}


void MusicPlayerRun()
{
    MusicPlayerMachine musicPlayer = new MusicPlayerMachine();
    musicPlayer.Play();
    musicPlayer.Stop();
    Console.WriteLine("*******");
    musicPlayer.Stop();
    musicPlayer.Play();
    Console.WriteLine("*******");
    musicPlayer.Stop();
    Console.WriteLine("*******");
    musicPlayer.Play();
    musicPlayer.Stop();
}

void AtmRun()
{
    ATMMachine atm = new ATMMachine();
    #region ATM'ye kart takıp geri çıkarma
    atm.InsertCard();
    atm.EjectCard();
    Console.WriteLine("*********");
    #endregion
    #region Doğrulanmış pin ile para çekme ve üzerine tekrar para çekme talebinde bulunma
    atm.InsertCard();
    atm.InsertPin(123);
    atm.RequestCash(1500);
    atm.RequestCash(100);
    Console.WriteLine("*********");
    //ATM'de kalan bakiye 500
    #endregion
    #region Para çekme
    atm.InsertCard();
    atm.InsertPin(123);
    atm.RequestCash(100);
    Console.WriteLine("*********");
    //ATM'de kalan bakiye 400
    #endregion
    #region Para çekme
    atm.InsertCard();
    atm.InsertPin(123);
    atm.RequestCash(300);
    Console.WriteLine("*********");
    //ATM'de kalan bakiye 100
    #endregion
    #region Para çekme
    atm.InsertCard();
    atm.InsertPin(123);
    atm.RequestCash(100);
    Console.WriteLine("*********");
    //ATM'de kalan bakiye 0
    #endregion
    #region Para olmayan ATM'den para çekme talebi
    atm.InsertCard();
    atm.InsertPin(123);
    atm.RequestCash(100);
    //Tüm işlemlerde para yok uyarısı!
    #endregion
}