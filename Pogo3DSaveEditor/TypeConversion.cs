namespace Pogo3DSaveEditor
{
    internal static class TypeConversion
    {
        public static string intToDifficulty(int index)
        {
            string difficulty = "Normal";

            switch (index)
            {
                case 1:
                    difficulty = "Assist";
                    break;

                case 0:
                    difficulty = "Normal";
                    break;

                case 2:
                    difficulty = "Hard";
                    break;
            }

            return difficulty;
        }

        public static int difficultyToInt(string difficulty)
        {
            int index = 0;

            switch (difficulty)
            {
                case "Assist":
                    index = 1;
                    break;

                case "Normal":
                    index = 0;
                    break;

                case "Hard":
                    index = 2;
                    break;
            }

            return index;
        }

        public static string intToChapter(int index)
        {
            string chapter = "Swamp";

            switch (index)
            {
                case 0:
                    chapter = "Swamp";
                    break;
                case 1:
                    chapter = "Fortress";
                    break; 

                case 2:
                    chapter = "Storm Drain"; 
                    break;

                case 3:
                    chapter = "Yard"; 
                    break;

                case 4:
                    chapter = "Temple";
                    break;

                case 5:
                    chapter = "Internet";
                    break;

                case 6:
                    chapter = "Docks";
                    break;

                case 7:
                    chapter = "Hollow";
                    break;

                case 8:
                    chapter = "Skullrock";
                    break;

                case 9:
                    chapter = "Delusion";
                    break;

                case 10:
                    chapter = "Pit Of Despair";
                    break;

                case 11:
                    chapter = "Acropolis";
                    break;
            }

            return chapter; 
        }

        public static int chapterToInt(string chapter)
        {
            int index = -1;

            switch (chapter)
            {
                case "Swamp":
                    index = 0;
                    break;
                case "Fortress":
                    index = 1;
                    break;
                case "Storm Drain":
                    index = 2;
                    break;
                case "Yard":
                    index = 3;
                    break;
                case "Temple":
                    index = 4;
                    break;
                case "Internet":
                    index = 5;
                    break;
                case "Docks":
                    index = 6;
                    break;
                case "Hollow":
                    index = 7;
                    break;
                case "Skullrock":
                    index = 8;
                    break;
                case "Delusion":
                    index = 9;
                    break;
                case "Pit Of Despair":
                    index = 10;
                    break;
                case "Acropolis":
                    index = 11;
                    break;
            }

            return index;
        }
    }
}