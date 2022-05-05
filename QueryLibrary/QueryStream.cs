using System.IO;


namespace QueryLibrary
{
    public class QueryStream
    {

        static public byte[] WriteQuery(Query query)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(memoryStream))
                {
                    writer.Write((int)query.Type);
                    writer.Write((int)query.Status);
                    writer.Write((int)query.CurrentModel);
                    writer.Write(query.Content);
                }
                return memoryStream.ToArray();
            }
        }


        static public Query ReadMessage(byte[] byteMessage)
        {
            Query query = new Query();

            using (MemoryStream memoryStream = new MemoryStream(byteMessage))
            {
                using (BinaryReader reader = new BinaryReader(memoryStream))
                {
                    query.Type = (TypeCommand)reader.ReadInt32();
                    query.Status = (StatusQuery)reader.ReadInt32();
                    query.CurrentModel = (CurrentModel)reader.ReadInt32();
                    query.Content = reader.ReadString();
                }
            }

            return query;
        }
    }
}
