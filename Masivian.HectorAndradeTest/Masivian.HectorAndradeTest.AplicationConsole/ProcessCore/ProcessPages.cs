using HectorAndradeTest.AplicationConsole.Entities;
using System.Collections.Generic;

namespace HectorAndradeTest.AplicationConsole.ProcessCore
{
    public static class ProcessPages
    {
        public static List<string> PagesNumbersPrime()
        {
            List<int> filteredlist = PrimeNumberProcess.GetListNumbersPrime();
            List<string> listData = new List<string>();
            int PAGEOFFSET = 1;
            int PAGENUMBER = 1;
            int ROWOFFSET;
            string line = string.Empty;
            while (PAGEOFFSET <= ConfigurationData.ItemCount)
            {
                listData.Add(GetLineText(PAGENUMBER));
                listData.Add(" ");
                for (ROWOFFSET = PAGEOFFSET; ROWOFFSET <= PAGEOFFSET + ConfigurationData.RowsPage - 1; ROWOFFSET++)
                {
                    for (int column = 0; column <= ConfigurationData.ColumsPage - 1; column++)
                    {
                        if (ROWOFFSET + column * ConfigurationData.RowsPage <= ConfigurationData.ItemCount)
                        {
                            int position = ROWOFFSET + column * ConfigurationData.RowsPage;
                            string number = filteredlist[position - 1].ToString();
                            line += "   " + FormatString(number);
                        }
                    }
                    listData.Add(line);
                    line = string.Empty;
                }
                PAGENUMBER++;
                PAGEOFFSET += ConfigurationData.RowsPage * ConfigurationData.ColumsPage;
                listData.Add(" ");
            }
            return listData;
        }

        private static string GetLineText(int _page)
        {
            string line = "The First " + ConfigurationData.ItemCount + " Prime Numbers === Page " + _page.ToString();
            return line;
        }

        private static string FormatString(string _number)
        {
            string characters = string.Empty;
            int numberLength = _number.Length;
            int dataLength = 4;
            int travel = dataLength - numberLength;
            for (int i = 0; i < travel; i++)
            {
                characters += " ";
            }
            _number = characters + _number;
            return _number;
        }
    }
}
