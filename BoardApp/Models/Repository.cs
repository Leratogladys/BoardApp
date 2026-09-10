// Programmer name : BoardApp Group
// Student nr      : 222049725;223022994;225007032;220024412;225004492
// Assignment nr   : Practical Assessment 1
// Purpose         : Static in-memory repository storing Board objects,
//                  providing lookup, add, update and remove operations

namespace BoardApp.Models
{
    public static class Repository
    {
        private static List<Board> boards = new List<Board>();

        static Repository()
        {
            //
            //Name              : static Repository()
            //Purpose           : Static constructor that seeds boards with
            //                  ten predefined Board objects when the
            //                  Repository class is first used
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : None
            //
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
                new Board("1010", "CUTfree", "CV32-BFN-01", 128, 49.00m)
            };
        } // end method

        public static IEnumerable<Board> Boards
        {
            //
            //Name              : property IEnumerable<Board> Boards
            //Purpose           : Public read-only property giving access
            //                  to the private boards field, without
            //                  exposing the ability to mutate the
            //                  underlying list directly
            //Re-use            : None
            //Input Parameter   : None
            //Output Type       : IEnumerable<Board>
            //                  - the current collection of Board objects
            //                  stored in boards
            //
            get { return boards; } // end get
        } // end property

        public static void AddBoard(Board board)
        {
            //
            //Name              : void AddBoard(Board board)
            //Purpose           : Adds the given Board object to boards
            //Re-use            : None
            //Method Parameters : Board board
            //                  - the board object to add to the
            //                  repository
            //Output Type       : None
            //
            boards.Add(board);
        } // end method

        public static Board? GetByBoardCode(string boardCode)
        {
            //
            //Name              : Board? GetByBoardCode(string boardCode)
            //Purpose           : Finds and returns the board matching the
            //                  given board code
            //Re-use            : None
            //Method Parameters : string boardCode
            //                  - the board code to search for
            //Output Type       : Board?
            //                  - the matching Board object if found,
            //                  otherwise null
            //
            return boards.FirstOrDefault(b => b.BoardCode == boardCode);
        } // end method

        public static void RemoveBoard(string boardCode)
        {
            //
            //Name              : void RemoveBoard(string boardCode)
            //Purpose           : Removes the board matching the given
            //                  board code from boards, if found
            //Re-use            : GetByBoardCode()
            //Method Parameters : string boardCode
            //                  - the board code of the board to remove
            //Output Type       : None
            //
            Board? board = GetByBoardCode(boardCode);
            if (board != null)
            {
                boards.Remove(board);
            } // end if
        } // end method

        public static void UpdateBoard(Board updateBoard)
        {
            //
            //Name              : void UpdateBoard(Board updateBoard)
            //Purpose           : Finds the board matching updateBoard's
            //                  board code and updates its Make, Model,
            //                  FlashKb and Price properties; the board
            //                  code itself is never changed, to preserve
            //                  the object's identity
            //Re-use            : GetByBoardCode()
            //Method Parameters : Board updateBoard
            //                  - a board object containing the updated
            //                  values
            //Output Type       : None
            //
            Board? board = GetByBoardCode(updateBoard.BoardCode);
            if (board != null)
            {
                board.Make = updateBoard.Make;
                board.Model = updateBoard.Model;
                board.FlashKb = updateBoard.FlashKb;
                board.Price = updateBoard.Price;
            } // end if
        } // end method
    } // end class Repository
} // end namespace BoardApp.Models