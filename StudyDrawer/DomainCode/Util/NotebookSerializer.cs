using MessagePack;
using StudyDrawer.DomainCode.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace StudyDrawer.DomainCode.Util
{
    public class NotebookSerializer
    {
        private NotebookSerializer() { }
        private const string DATA_PATH = "data.msgpack";
        private static List<string> filesPath;
        private const string FILES_PATH = "PATHS.txt";

        static NotebookSerializer()
        {
            if (!File.Exists(FILES_PATH))
            {
                File.Create(FILES_PATH).Close();
                filesPath = new List<string>();
                return;
            }
            filesPath = File.ReadAllLines(FILES_PATH).ToList();
        }

        public static void SaveNotebook(Notebook notebook)
        {
            if (!filesPath.Contains($"{notebook.Name}.msgpack"))
            {
                filesPath.Add($"{notebook.Name}.msgpack");
            }
            byte[] binaryData = MessagePackSerializer.Serialize(notebook);
            File.WriteAllBytes($"{notebook.Name}.msgpack", binaryData);
        }

        public static ListObserver<Notebook> LoadNotebooks()
        {
            ListObserver<Notebook> notebooks = new ListObserver<Notebook>();
            foreach (string path in filesPath)
            {
                notebooks.Add(LoadNotebook(path));
            }
            return notebooks;
        } 

        private static Notebook LoadNotebook(string path)
        {
            if (File.Exists(path))
            {
                throw new Exception($"Файла по пути {path} не существует");
            }
            byte[] dataFromFile = File.ReadAllBytes(path);
            Notebook deserializedObj = MessagePackSerializer.Deserialize<Notebook>(dataFromFile);
            return deserializedObj;
        }
    }
}
