using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System;

namespace Data { 
    [Serializable]
    public static class XMLSerializer {
        
        public static void serializer(object item, String path) {
            XmlSerializer serializer = new XmlSerializer(typeof(Recurso));
            StreamWriter writer = new StreamWriter(path);
            serializer.Serialize(writer.BaseStream, item);
            writer.Close();
        }

            
    }
}