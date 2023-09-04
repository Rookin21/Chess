using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        string Fen;

        /// <summary>
        /// Стандартное расположение фигур на доске
        /// </summary>
        /// <param name="fen">стандартная нотация записи шахматных диаграмм</param>
        public Chess(string Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") // 
        {
            this.Fen = Fen;
        }

        /// <summary>
        /// Движение фигур
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public Chess Move (string Move) 
        {
            // При движении шахмат, меняется не расположение фигуры, а меняется карта расположения фигур
            Chess NextChess = new Chess(Fen);
            return NextChess;
        }

        /// <summary>
        /// Расположение фигур на доске
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public char GetFigureAt(int X, int Y)
        {
            return '.';
        }
    }
}
