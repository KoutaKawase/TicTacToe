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
            var sb = new StringBuilder("");
            foreach (var(value, index) in state.Select((item, index) => (item, index)))
            {

            }
            return "mock";
        }
    }
}
