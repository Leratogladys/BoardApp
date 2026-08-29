namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();

        static Repository()
        {
            boards = new List<Board>()
            {
                new Board("1001", "Espressif", "ESP32-WROOM-32", 4096, 129.00m),
                new Board("1002", "Espressif", "ESP32-C3-MINI-1", 4096, 99.00m),
                new Board("1003", "STMicroelectronics", "STM32F103C8T6", 64, 75.00m),
                new Board("1004", "STMicroelectronics", "STM32F411CEU6", 512, 145.00m),
                new Board("1005", "Microchip", "ATmega328P", 32, 89.00m),
                new Board("1006", "Microchip", "ATmega2560", 256, 199.00m),
                new Board("1007", "WCH", "CH32V003F4P6", 16, 29.00m),
                new Board("1008", "Raspberry Pi", "Pico", 2048, 89.00m),
                new Board("1009", "Espressif", "ESP-01S", 1024, 65.00m),
                new Board("1010", "CUTfree", "CV32-BFN-01", 128, 49.00m),
         
            };
        }
        public static IEnumerable<Board> Boards { get { return boards; } }


        public static void AddBoard(Board board)
        {
            boards.Add(board);
        }

        public static Board? GetByBoardCode(string boardCode)
        {
            return boards.FirstOrDefault(b => b.BoardCode == boardCode);
        }

        public static void RemoveBoard(string boardCode)
        {
            Board? board = GetByBoardCode(boardCode);
            if (board != null)
            {
                boards.Remove(board);
            }

        }

        public static void UpdateBoard(Board updateBoard)
        {
            Board? board = GetByBoardCode(updateBoard.BoardCode);
            if (board != null)
            {
                board.Make = updateBoard.Make;
                board.Model = updateBoard.Model;
                board.FlashKb = updateBoard.FlashKb;
                board.Price = updateBoard.Price;
            }
        }
    }
}
