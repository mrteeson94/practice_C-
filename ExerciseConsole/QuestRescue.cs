static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake? false : true;
    

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake ? true : false;
    

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => archerIsAwake == false && prisonerIsAwake? true : false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        // To free prisoner True - 2 conditions:
        //1.hasDog = arch sleep | 
        //2.NoDog =
    }
}