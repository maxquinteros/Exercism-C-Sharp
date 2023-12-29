using Exercise.QuestLogic;

// Task 1: Check if a fast attack can be made
var knightIsAwake = true;
Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));

// Task 2: Check if the group can be spied upon
knightIsAwake = false;
var archerIsAwake = true;
var prisonerIsAwake = false;
Console.WriteLine(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

// Task 3: Check if the prisioner can be signalled
archerIsAwake = false;
prisonerIsAwake = true;
Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

// Task 4: Check if the prisoner can be freed
knightIsAwake = false;
archerIsAwake = true;
prisonerIsAwake = false;
var petDogIsPresent = false;
Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake,archerIsAwake,prisonerIsAwake, petDogIsPresent));