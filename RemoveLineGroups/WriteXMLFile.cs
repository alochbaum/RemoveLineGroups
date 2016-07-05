using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RemoveLineGroups
{
    class WriteXMLFile
    {
        private List<string> myStrStart = new List<string>();
        private List<string> myStrEnd = new List<string>();
        public int iCountOfRows { get; set; }
        #region Adding Strings
        public void strStartAdd(string inStr)
        {
            myStrStart.Add(inStr);
            return;
        }
        public void strEndAdd(string inStr)
        {
            myStrEnd.Add(inStr);
            return;
        }
        #endregion
        public bool WriteDFile(string strOutFile)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(strOutFile))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("RemoveGroupOfLinesFromFileSettings");
                    foreach (string s in myStrStart)
                    {
                        writer.WriteStartElement("RemoveGroup");
                        writer.WriteElementString("StartPhrase", s);
                        writer.WriteElementString("EndPhrase", myStrEnd[myStrStart.IndexOf(s)].ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void ClearValues()
        {
            iCountOfRows = 0;
            myStrStart.Clear();
            myStrEnd.Clear();
        }
        public bool ReadDFile(string strInFile)
        {
            ClearValues();
            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create(strInFile))
            {
                while (reader.Read())
                {
                    // Only detect RemoveGroup
                    if (reader.IsStartElement())
                    {
                        if(reader.Name=="RemoveGroup")
                        {
                            // read StartPhrase add to string
                            reader.Read();
                            if(reader.Name == "StartPhrase")
                            {
                                myStrStart.Add(reader.Value.TrimStart());
                            }
                            else
                            {
                                // wasn't expecting this
                                return false;
                            }
                            // read EndPhrase add to string
                            reader.Read();
                            if (reader.Name == "EndPhrase")
                            {
                                myStrStart.Add(reader.Value.TrimStart());
                            }
                            else
                            {
                                // wasn't expecting this
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
