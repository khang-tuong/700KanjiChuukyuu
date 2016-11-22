using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CoreService.Model;

namespace CoreService
{
    public class FileManager
    {
        public static string ReadWordFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.WORD_FILE_PATH, FileMode.Open, FileAccess.Read);
                if (stream.Length != 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    DataManager.WordList = (List<Word>)formatter.Deserialize(stream);
                    stream.Dispose();
                    stream.Close();
                    return null;
                }
                return "File không có dữ liệu";
            }
            catch (FileNotFoundException)
            {
                return "Không tìm thấy word.dat";
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return "File bị hỏng format!";
            }
        }

        public static void WriteWordFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.WORD_FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, DataManager.WordList);
                stream.Dispose();
                stream.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void WritePhraseFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.PHRASE_FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, DataManager.Phrases);
                stream.Dispose();
                stream.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static string ReadPhraseFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.PHRASE_FILE_PATH, FileMode.Open, FileAccess.Read);
                if (stream.Length != 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    DataManager.Phrases = (List<Phrase>)formatter.Deserialize(stream);
                    stream.Dispose();
                    stream.Close();
                    return null;
                }
                return "File không có dữ liệu";
            }
            catch (FileNotFoundException)
            {
                return "Không tìm thấy word.dat";
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return "File bị hỏng format!";
            }
        }

        public static string ReadSentenceFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.SENTENCE_FILE_PATH, FileMode.Open, FileAccess.Read);
                if (stream.Length != 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    DataManager.Sentences = (List<Sentence>)formatter.Deserialize(stream);
                    stream.Dispose();
                    stream.Close();
                    return null;
                }
                return "File không có dữ liệu";
            }
            catch (FileNotFoundException)
            {
                return "Không tìm thấy sentence.dat";
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return "File bị hỏng format!";
            }
        }

        public static void WriteSentenceFile()
        {
            try
            {
                FileStream stream = new FileStream(Config.SENTENCE_FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, DataManager.Sentences);
                stream.Dispose();
                stream.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
