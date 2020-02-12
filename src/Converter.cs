using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Converter
    {
        private static IEnumerable<IEnumerable<MarkType>> CreateChunksFrom(IList<MarkType> state, int chunkSize)
        {
            return state.Select((value, index) => new { value, index })
                .GroupBy(x => x.index / chunkSize)
                .Select(g => g.Select(x => x.value));
        }

        private static StringBuilder DiscernMark(MarkType mark, StringBuilder sb)
        {
            switch (mark)
            {
                case MarkType.Circle:
                    sb.Append(" @ |");
                    break;
                case MarkType.Cross:
                    sb.Append(" X |");
                    break;
                case MarkType.None:
                    sb.Append("   |");
                    break;
            }

            return sb;
        }
        private static StringBuilder BuildMarkAndDecoration(StringBuilder sb, IEnumerable<MarkType> marks)
        {
            foreach (var mark in marks)
            {
                sb = DiscernMark(mark, sb);
            }
            //行の区切り文字を生成
            sb.Append("\n  +---+---+---+\n");

            return sb;
        }

        private static StringBuilder buildBoard(StringBuilder sb, IEnumerable<IEnumerable<MarkType>> chunks)
        {
            //上辺を描写
            sb.Append("  +---+---+---+\n");

            foreach (var chunk in chunks.Select((marks, index) => new { Marks = marks, Index = index }))
            {
                //COLUMN位置目印を生成
                sb.Append($"{chunk.Index + 1} |");
                //ボード本体生成
                sb = BuildMarkAndDecoration(sb, chunk.Marks);
            }
            //ROW位置目印を生成
            sb.Append("    1   2   3  ");

            return sb;
        }
        public static string ConvertToStringFrom(IList<MarkType> state)
        {
            var boardBuilder = new StringBuilder();
            //stateを３個ずつに分けて配列にする
            var chunkSize = 3;
            var chunks = CreateChunksFrom(state, chunkSize);

            //ボードの文字列表現生成
            boardBuilder = buildBoard(boardBuilder, chunks);

            return boardBuilder.ToString();
        }
    }
}