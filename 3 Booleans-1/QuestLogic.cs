namespace Exercise.QuestLogic
{
    public static class QuestLogic
    {
        // Task 1: Check if a fast attack can be made
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Task 2: Check if the group can be spied upon
        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            int guardiansAwaken = 0;

            guardiansAwaken += knightIsAwake == true ? 1 : 0;
            guardiansAwaken += archerIsAwake == true ? 1 : 0;
            guardiansAwaken += prisonerIsAwake == true ? 1 : 0;

            return(guardiansAwaken != 0 ? true : false);
        }

        // Task 3: Check if the prisioner can be signalled
        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Task 4: Check if the prisoner can be freed
        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (knightIsAwake == false &&
                archerIsAwake == false &&
                prisonerIsAwake == false &&
                petDogIsPresent == true)
                return true;

            else if (knightIsAwake == false &&
                     archerIsAwake == false &&
                     prisonerIsAwake == true)
                return true;

            else if (knightIsAwake == true &&
                     archerIsAwake == false &&
                     prisonerIsAwake == false &&
                     petDogIsPresent == true)
                return true;

            else if (knightIsAwake == true &&
                     archerIsAwake == false &&
                     prisonerIsAwake == true &&
                     petDogIsPresent == true)
                return true;

            else
                return false;
        }
    }
}
