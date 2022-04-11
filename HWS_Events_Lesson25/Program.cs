using HWS_Events_Lesson25;
using System.Diagnostics;

SpaceQuestGameManager spaceQuestGameManager = new SpaceQuestGameManager(100, 500, 500, 3);//Logic Layer

GameViewer gameViewer = new GameViewer();//GUI Layer
spaceQuestGameManager.HpChanged += gameViewer.GoodSpaceShipHpChangedEventHandler;
spaceQuestGameManager.LocationChanged += gameViewer.GoodSpaceShipLocationChangedEventHandler;

NewGameViewer newGameViewer = new NewGameViewer();
spaceQuestGameManager.HpChanged += newGameViewer.GoodSpaceShipHpChangedEventHandler;
spaceQuestGameManager.LocationChanged += newGameViewer.GoodSpaceShipLocationChangedEventHandler;


//spaceQuestGameManager.Move(13, 25);
//Thread.Sleep(500);
//spaceQuestGameManager.ShipGotDamaged(-33);
//Thread.Sleep(500);
//spaceQuestGameManager.ShipGotExtraHP(50);
//Thread.Sleep(500);
//spaceQuestGameManager.Move(50,122);
//Thread.Sleep(500);

Timer timer = new Timer(intervalEventHandler,null, 0,1000);


while (true)
{

}

void intervalEventHandler(object state)
{
    Random rand = new Random();
    int num = rand.Next(1, 4);
    switch (num)
    {
        case 1:
            spaceQuestGameManager.Move(15, 50);
            break;
        case 2:
            spaceQuestGameManager.ShipGotDamaged(-13);
            break;
        default:
            spaceQuestGameManager.ShipGotExtraHP(23);
            break;
    }
}
