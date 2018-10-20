using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GoogleARCore.Examples.CloudAnchors.Scripts
{
   // [Serializable]
    public class Id
    {
        public string stringValue { get; set; }
    }
//[Serializable]
    public class Fields
    {
        public Id id { get; set; }
    }
   // [Serializable]
    public class Document
    {
        public string name { get; set; }
        public Fields fields { get; set; }
        public DateTime createTime { get; set; }
        public DateTime updateTime { get; set; }
    }
    //[Serializable]
    public class RootObject
    {
        public List<Document> documents { get; set; }
    }
}
