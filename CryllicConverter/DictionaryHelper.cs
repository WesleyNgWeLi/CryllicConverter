using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryllicConverter
{

    public class DictionaryHelper
    {
        public ConsoleHelper CH;
        public DictionaryModel DM;
        public void DoEncode()
        {
            string input;
            CH = new ConsoleHelper();
            input = CH.GetInput();
            string convertedResult = CryllicConvert(input);
            CH.PrintOutput(convertedResult);
        }

        public string CryllicConvert(string n)
        {
            DM = new DictionaryModel();
            return string.Concat(n.Select(c => DM.cryllicMap[c]));
        }
    }
}
