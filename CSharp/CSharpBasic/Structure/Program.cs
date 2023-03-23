using Structure;

SwordMan swordMan = new SwordMan();
swordMan.Name = "기사";
swordMan Lv = 104;
swordMan.Slash();

int a;
Stats stats;

Wizard wizard = new Wizard();
wizard.Stats.STR = 10;
wizard.Stats.DEX = 10;
wizard.Stats.INT = 10;
wizard.Stats.LUK = 10;
Console.WriteLine($"마법사의 전투력 {wizard.Stats.GetCombotPower()}");