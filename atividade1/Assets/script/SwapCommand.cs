using UnityEngine;

public class SwapCommand :  ICommand
{
    private PuzzlePiece pieceA, pieceB;

    public SwapCommand(PuzzlePiece a, PuzzlePiece b)
    {
        pieceA = a;
        pieceB = b;
    }

    public void Execute()
    {
        
    }

    public void Undo()
    {
       
    }

    private void Swap()
    {
        Vector3 tempPos = pieceA.transform.position;
        pieceA.transform.position = pieceB.transform.position;
        pieceB.transform.position = tempPos;

       
    }
        
    
}
