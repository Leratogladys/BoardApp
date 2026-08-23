namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();
        public static IEnumerable<Board> Boards { get { return boards; } }


        public static void AddBoard(Board board)
        {
            boards.Add(board);
        }
    }
}
