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
        #region Get Strings At Locations
        public string GetStart(int iLocation)
        {
            if (iLocation > (myStrStart.Count - 1) || iLocation < 0) return "Error: Getting Start";
            return myStrStart.ElementAt(iLocation);
        }
        public string GetEnd(int iLocation)
        {
            if (iLocation > (myStrEnd.Count - 1) || iLocation < 0) return "Error: Getting Start";
            return myStrEnd.ElementAt(iLocation);
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
                    // Get all the elements but only act on 2
                    if (reader.IsStartElement())
                    {
                        switch(reader.Name.ToString())
                        {
                            case "StartPhrase":
                                myStrStart.Add(reader.ReadElementContentAsString());  // this moves to next node so check if next node is EndPhrase
                                if(reader.Name.ToString()=="EndPhrase")
                                    myStrEnd.Add(reader.ReadElementContentAsString());
                            break;
                            case "EndPhrase":
                                myStrEnd.Add(reader.ReadElementContentAsString());
                            break;
                            default:
                            break;
                        }
                    }
                }
                reader.Close();
            }
            iCountOfRows = myStrEnd.Count;
            // check if their empty
            if (iCountOfRows < 1) return false;
            // check if the counts are not equal
            if (myStrStart.Count != iCountOfRows) return false;
            return true;
        }
    }
}
