using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace EmailSerializerBL
{
    public class JsonPersister : PersistanceService
    {
        public void Persist(Email email)
        {
            //MemoryStream memStream = new MemoryStream();
            Guid guid = Guid.NewGuid();
            FileStream fileStream = new FileStream("E:\\GitHub\\EmailSerialize\\Data\\" + guid + ".txt", FileMode.CreateNew);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Email));
            ser.WriteObject(fileStream, email);
        }
    }
}