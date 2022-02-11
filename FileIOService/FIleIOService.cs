using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eos_Macros
{
    public abstract class FIleIOService
    {
        public StreamReader Reader;
        public StreamWriter Writter;

        public FIleIOService()
        {

        }

        public virtual void Write(string path)
        {
            Writter = new StreamWriter(path);
        }

        public virtual string Read(string path)
        {
            Reader = new StreamReader(path);

            string content = Reader.ReadToEnd();
            
            return content;
        }

        public abstract void Parse(string content);
    }

    
}
