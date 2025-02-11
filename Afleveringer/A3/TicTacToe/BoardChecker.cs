namespace TicTacToe;

using System;
using TicTacToe.Interfaces;


/// <summary>
/// A basic board checker that will determine if for a given row, diagonal or column, if all of
/// the elements is equal to eachother and not equal to null. It will also determine if the board
/// is in a tied position.
/// </summary>
public class BoardChecker : IBoardChecker {

    /// <summary>
    /// Method that is used to check if all elements in a row is equal to eachother and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the row is equal else false.
    /// </returns>
    private bool IsRowWin(Board board) {
        // Using for-loop to check a board with indeterminate size
        // j increase by 1 means moving down 1 row
        for(int j = 0; j <= (board.Size - 1); j++ ) {    
            var x = 0;
            var o = 0;
            // i increase by 1 means moving 1 column to the right
            for(int i = 0; i <= (board.Size - 1); i++ ) {
                // Checks for PlayerIdentifier.Cross, increase variable x by 1
                if(board.Get(i,j) == PlayerIdentifier.Cross){
                    x++;
                }
                // Checks for PlayerIdentifier.Naught, increase variable o by 1
                else if(board.Get(i,j) == PlayerIdentifier.Naught){
                    o++;
                }
            }
            // return true when the coresponding variable for a non null PlayerIdentifier 
            // have the same value as board.Size
            if (board.Size==x || board.Size==o) {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Method that is used to check if all elements in a column is equal to eachother and is not
    /// equal to null.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the column is equal else false.
    /// </returns>
    private bool IsColWin(Board board) {
        // Using for-loop to check a board with indeterminate size
        // i increase by 1 means moving 1 column to the right
        for(int i = 0; i <= (board.Size - 1); i++ ) {    
            var x = 0;
            var o = 0;
            // j increase by 1 means moving down 1 row
            for(int j = 0; j <= (board.Size - 1); j++ ) {
                // Checks for PlayerIdentifier.Cross, increase variable x by 1
                if(board.Get(i,j) == PlayerIdentifier.Cross){
                    x++;
                }
                // Checks for PlayerIdentifier.Naught, increase variable o by 1
                else if(board.Get(i,j) == PlayerIdentifier.Naught){
                    o++;
                }
            }
            // return true when the coresponding variable for a non null PlayerIdentifier 
            // have the same value as board.Size
            if (board.Size==x || board.Size==o) {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Method that is used to check if all elements in a diagonal is equal to eachother and is not
    /// equal to null. This diagonal will always be the two longest in a square.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns>
    /// True if there is a win where all identifiers in the diagonal is equal else false.
    /// </returns>
    private bool IsDiagWin(Board board) {
        // 4 variables for 2 different pairs of cross and naught
        var x1 = 0;
        var o1 = 0;
        var x2 = 0;
        var o2 = 0;
        for(int j = 0; j <= (board.Size - 1); j++ ) {    
            // there are 2 possible diagonal line, this for-loop checks the line that starts from top left
            for(int i = 0; i <= (board.Size - 1); i++ ) {
                if(i == j){
                    // Checks for PlayerIdentifier.Cross, increase variable x by 1
                    if(board.Get(i,j) == PlayerIdentifier.Cross) {
                        x1++;
                    }
                    // Checks for PlayerIdentifier.Naught, increase variable o by 1
                    else if(board.Get(i,j) == PlayerIdentifier.Naught) {
                        o1++;
                    }
                }
                // return true when the coresponding variable for a non null PlayerIdentifier 
                // have the same value as board.Size
                if (x1 == board.Size || o1 == board.Size) {
                    return true;
                }
            }
        }
        // this for-loop checks the diagonal line that starts from top right
        for(int j = 0; j <= (board.Size - 1); j++ ) {    
            for(int i = 0; i <= (board.Size - 1); i++ ) {
                if(i + j == board.Size - 1){
                    if(board.Get(i,j) == PlayerIdentifier.Cross) {
                        x2++;
                    }
                    else if(board.Get(i,j) == PlayerIdentifier.Naught) {
                        o2++;
                    }
                }
                if (x2 == board.Size || o2 == board.Size) {
                    return true;
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Method that will determine what the state of the board is. If there is a winner, a tied or
    /// the game is still inconclusive.
    /// </summary>
    /// <param name="board">A given board.</param>
    /// <returns> The state of the board.</returns>
    public BoardState CheckBoardState(Board board) {
        if(IsRowWin(board) || IsColWin(board) || IsDiagWin(board)) {
            // there is a winner
            return BoardState.Winner;
        }
        else if(board.IsFull()) {
            // the board is full without a winner
            return BoardState.Tied;
        }
        else {
            // the game is not finished
            return BoardState.Inconclusive;
        }
    }
}