namespace TicTacToeTest;

using NUnit.Framework;
using TicTacToe;
using TicTacToe.IO;


public class CursorTest {
    private Cursor cursor;

    [SetUp]
    public void Setup() {
        var keyToMoveMap = new KeyToMoveMap('i', 'k', 'j', 'l', 'q', ' ');
        cursor = new Cursor(3, keyToMoveMap);
        cursor.MoveDown();
        cursor.MoveRight();
    }

    [Test]
    public void CursorCenterTest() {
        Assert.True(cursor.position.X == 1 && cursor.position.Y == 1);
    }

    [Test]
    public void MoveUpTest() {
        Setup();
        cursor.MoveUp();
        var curPos = cursor.position;
        cursor.MoveUp();
        Assert.True(cursor.position.X == curPos.X && cursor.position.Y == curPos.Y);
    }

    [Test]
    public void MoveDownTest() {
        Setup();
        cursor.MoveDown();
        var curPos = cursor.position;
        cursor.MoveDown();
        Assert.True(cursor.position.X == curPos.X && cursor.position.Y == curPos.Y);
    }
    
    [Test]
    public void MoveLeftTest() {
        Setup();
        cursor.MoveLeft();
        var curPos = cursor.position;
        cursor.MoveLeft();
        Assert.True(cursor.position.X == curPos.X && cursor.position.Y == curPos.Y);
    }

    [Test]
    public void MoveRightTest() {
        Setup();
        cursor.MoveRight();
        var curPos = cursor.position;
        cursor.MoveRight();
        Assert.True(cursor.position.X == curPos.X && cursor.position.Y == curPos.Y);
    }   
}
