using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Converter
    {
        public static string ConvertToStringFrom(IList<MarkType> state)
        {
            var boardBuilder = new StringBuilder("  +---+---+---+\n");
            var chunkSize = 3;
            var chunks = state.Select((value, index) => new { value, index })
                .GroupBy(x => x.index / chunkSize)
                .Select(g => g.Select(x => x.value));

            foreach (var chunk in chunks.Select((value, index) => new { Value = value, Index = index }))
            {
                boardBuilder.Append($"{chunk.Index + 1} |");
                foreach (var item in chunk.Value)
                {
                    switch (item)
                    {
                        case MarkType.Circle:
                            boardBuilder.Append(" @ |");
                            break;
                    }
                }
                boardBuilder.Append("\n  +---+---+---+\n");
            }
            boardBuilder.Append("    A   B   C  ");

            return boardBuilder.ToString();
        }
    }
}
