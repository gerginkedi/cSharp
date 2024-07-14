using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul
{
    internal class fileCheckerFixer
    {
        public fileCheckerFixer(string filePath)
        {
            if (File.Exists(filePath))
            {
                
            }
            else 
            {
                File.WriteAllText(filePath, string.Empty);
            }
        }
    }
}
