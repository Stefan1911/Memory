using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Memory
{
    public class Settings
    {
        int rows;
        int columns;
        int pears;
        int pictures;

        public Settings(int rows,int columns,int pears,int pictures)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Pears = pears;
            this.Pictures = pictures;
        }

        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }
        public int Pears { get => pears; set => pears = value; }
        public int Pictures { get => pictures; set => pictures = value; }


        public static Settings loadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            int rows = Int32.Parse(reader.ReadLine());
            int columns = Int32.Parse(reader.ReadLine());
            int pears = Int32.Parse(reader.ReadLine());
            int pictures = Int32.Parse(reader.ReadLine());
            reader.Close();
            return new Settings(rows, columns, pears, pictures);
        }

        public static void saveToFile(Settings settings,string path)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(settings.rows);
            writer.WriteLine(settings.columns);
            writer.WriteLine(settings.pears);
            writer.WriteLine(settings.pictures);
            writer.Close();
        }
    }
}
