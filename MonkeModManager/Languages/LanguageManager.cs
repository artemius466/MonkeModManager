using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeModManager.Languages
{
    internal class LanguageManager
    {
        int languageId = -1;
        Russian rus = new Russian();
        English eng = new English();

        public void setLanguage(int id)
        {
            languageId = id;
        }

        public Dictionary<String, String> GetLanguage()
        {
            if (languageId == 0)
            {
                return rus.GetLanguage();
            }
            else
            {
                return eng.GetLanguage();
            }
        }
    }
}
