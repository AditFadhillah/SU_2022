namespace TicTacToeTest;

using NUnit.Framework;
using TicTacToe;

public class BoardCheckerTest {

    public Board board;
    public BoardChecker boardChecker;

    [SetUp]
    public void Setup() {
        board = new Board(3);
        boardChecker = new BoardChecker();
    }

    [Test]
    // Tests:
    // +---+
    // |o  |
    // | o |
    // |  o|
    // +---+
    public void DiagonalWinTest() {
        Setup();
        board.TryInsert(0, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 1, PlayerIdentifier.Naught);
        board.TryInsert(2, 2, PlayerIdentifier.Naught);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }
    [Test]
    // Tests:
    // +---+
    // |  x|
    // | x |
    // |x  |
    // +---+
    public void DiagonalWinTest1() {
        Setup();
        board.TryInsert(2, 0, PlayerIdentifier.Cross);
        board.TryInsert(1, 1, PlayerIdentifier.Cross);
        board.TryInsert(0, 2, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }

    [Test]
    // Tests:
    // +---+
    // |   |
    // |xxx|
    // |   |
    // +---+
    public void RowWinTest() {
        Setup();
        board.TryInsert(0, 1, PlayerIdentifier.Cross);
        board.TryInsert(1, 1, PlayerIdentifier.Cross);
        board.TryInsert(2, 1, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }

    [Test]
    // Tests:
    // +---+
    // |   |
    // |   |
    // |ooo|
    // +---+
    public void RowWinTest1() {
        Setup();
        board.TryInsert(0, 2, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Naught);
        board.TryInsert(2, 2, PlayerIdentifier.Naught);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }

    [Test]
    // Tests:
    // +---+
    // | x |
    // | x |
    // | x |
    // +---+
    public void ColumnWinTest() {
        Setup();
        board.TryInsert(1, 0, PlayerIdentifier.Cross);
        board.TryInsert(1, 1, PlayerIdentifier.Cross);
        board.TryInsert(1, 2, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }

    [Test]
    // Tests:
    // +---+
    // |o  |
    // |o  |
    // |o  |
    // +---+
    public void ColumnWinTest1() {
        Setup();
        board.TryInsert(0, 0, PlayerIdentifier.Naught);
        board.TryInsert(0, 1, PlayerIdentifier.Naught);
        board.TryInsert(0, 2, PlayerIdentifier.Naught);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Winner);
    }

    [Test]
    // Tests:
    // +---+
    // |oox|
    // |   |
    // |   |
    // +---+
    public void InconclusiveTest() {
        Setup();
        board.TryInsert(0, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(2, 0, PlayerIdentifier.Cross);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Inconclusive);
    }

    [Test]
    // Tests:
    // +---+
    // |oox|
    // |xxo|
    // |oxo|
    // +---+
    public void TiedTest() {
        Setup();
        board.TryInsert(0, 0, PlayerIdentifier.Naught);
        board.TryInsert(1, 0, PlayerIdentifier.Naught);
        board.TryInsert(2, 0, PlayerIdentifier.Cross);

        board.TryInsert(0, 1, PlayerIdentifier.Cross);
        board.TryInsert(1, 1, PlayerIdentifier.Cross);
        board.TryInsert(2, 1, PlayerIdentifier.Naught);

        board.TryInsert(0, 2, PlayerIdentifier.Naught);
        board.TryInsert(1, 2, PlayerIdentifier.Cross);
        board.TryInsert(2, 2, PlayerIdentifier.Naught);
        Assert.AreEqual(boardChecker.CheckBoardState(board), BoardState.Tied);
    }
}
