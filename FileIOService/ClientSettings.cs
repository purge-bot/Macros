using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros.FileIOService
{
    public class ClientSettings : FIleIOService
    {
        public Dictionary<string, int> AddrConst;

        private const int LINE_SPLIT_NUMBER = 2;
        private readonly char[] separatorComment = { '/' };

        public override void Parse(string content)
        {
            AddrConst = new Dictionary<string, int>();

            int currentLine = 0;

            content = content.ToLower().Replace("\t", String.Empty).Replace(" ", String.Empty).Replace("\r", String.Empty);

            string[] lines = content.Split('\n');

            foreach (string line in lines)
            {
                if (line.Contains('/'))
                {
                    lines[currentLine] = line.Split(separatorComment, LINE_SPLIT_NUMBER)[0];
                }

                string[] keyValue = line.Split(':', ';');
                AddrConst.Add(keyValue[0], Convert.ToInt32(keyValue[1]));

                currentLine++;
            }
        }
    }
}
