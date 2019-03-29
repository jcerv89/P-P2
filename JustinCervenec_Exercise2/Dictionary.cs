using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise2
{
    class Dictionary
    {
        public IDictionary<string, string> Dict = new Dictionary<string, string>();
        public IDictionary<string, string> Hint = new Dictionary<string, string>();

        public Dictionary()//Constructor
        {

        }

        public void addAnsClue(string ans, string clue)//Method for user answer based on clue given
        {
            Dict.Add(ans, clue);
        }

        public void addHint(string clue, string hint)//Gets and stores hints and clues
        {
            if (Dict.Values.Contains(clue))
            {
                Hint.Add(clue, hint);
            }
        }
    }
}
