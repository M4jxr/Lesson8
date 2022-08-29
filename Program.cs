using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Linq;


Console.OutputEncoding = System.Text.Encoding.UTF8;
//string s = "Бик тупогуб, тупогубенький бичок, у бика губа біла була тупа";
////Regex regex = new Regex(@"туп(\w*)", RegexOptions.IgnoreCase);
//string s = "456-435-2318";

//Regex regex = new Regex("[0-9]{3}-[0-9]{3}-[0-9]{4}");

////Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");
////Regex regex = new Regex(@"туп(\w*)");
//MatchCollection matches = regex.Matches(s);
//if (matches.Count > 0)
//{
//    foreach (Match match in matches)
//        Console.WriteLine(match.Value);
//}
//else
//{
//    Console.WriteLine("Співпадінь не знайдено");
//}
//string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
//                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
//var data = new string[]
//{
//    "tom@gmail.com",
//    "+12345678999",
//    "bob@yahoo.com",
//    "+13435465566",
//    "sam@yandex.ru",
//    "+43743989393"
//};
//Console.WriteLine("Email List");
//for (int i = 0; i < data.Length; i++)
//{
//    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
//    {
//        Console.WriteLine(data[i]);
//    }
//}

//string text = "Мама  мила  раму.      ";
//string pattern = @"\s+";
//string target = " ";
//Regex regex = new Regex(pattern);
//string result = regex.Replace(text, target);
//Console.WriteLine(result);

//string unicodeString = "This string contains the unicode character Pi (\u03a0)";

//// Create two different encodings.
//Encoding ascii = Encoding.ASCII;
//Encoding unicode = Encoding.Unicode;

//// Convert the string into a byte array.
//byte[] unicodeBytes = unicode.GetBytes(unicodeString);

//// Perform the conversion from one encoding to the other.
//byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

//// Convert the new byte[] into a char[] and then into a string.
//char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
//ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
//string asciiString = new string(asciiChars);

//// Display the strings created before and after the conversion.
//Console.WriteLine("Original string: {0}", unicodeString);
//Console.WriteLine("Ascii converted string: {0}", asciiString);



//Compiled: при установке этого значения регулярное выражение компилируется в сборку, что обеспечивает более быстрое выполнение
//CultureInvariant: при установке этого значения будут игнорироваться региональные различия
//IgnoreCase: при установке этого значения будет игнорироваться регистр
//IgnorePatternWhitespace: удаляет из строки пробелы и разрешает комментарии, начинающиеся со знака #
//Multiline: указывает, что текст надо рассматривать в многострочном режиме. При таком режиме символы "^" и "$" совпадают, соответственно, с началом и концом любой строки, а не с началом и концом всего текста
//RightToLeft: приписывает читать строку справа налево
//Singleline: при данном режиме символ "." соответствует любому символу, в том числе последовательности "\n", которая осуществляет переход на следующую строку

//DriveInfo[] drives = DriveInfo.GetDrives();
//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine($"Название: {drive.Name}");
//    Console.WriteLine($"Тип: {drive.DriveType}");
//    if (drive.IsReady)
//    {
//        Console.WriteLine($"Объем диска: {drive.TotalSize}");
//        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
//        Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
//    }
//    Console.WriteLine();
//}


//string dirName = "C:\\";
//// если папка существует
//if (Directory.Exists(dirName))
//{
//    Console.WriteLine("Подкаталоги:");
//    string[] dirs = Directory.GetDirectories(dirName);
//    foreach (string s in dirs)
//    {
//        Console.WriteLine(s);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string s in files)
//    {
//        Console.WriteLine(s);
//    }
//}
//string dirName = @"C:\";
//var directory = new DirectoryInfo(dirName);
//if (directory.Exists)
//{
//    Console.WriteLine("Подкаталоги:");
//    DirectoryInfo[] dirs = Directory.GetDirectories();
//    foreach (DirectoryInfo dir in dirs)
//    {
//        Console.WriteLine(dir.FullName);
//    }
//    Console.WriteLine();
//    Console.WriteLine("Файлы:");
//    FileInfo[] files = directory.GetFiles();
//    foreach (FileInfo file in files)
//    {
//        Console.WriteLine(file.FullName);
//    }
//}


//// класс Directory
//string[] dirs = Directory.GetDirectories(dirName, "books*.");
//// класс DirectoryInfo
//var directory = new DirectoryInfo(dirName);
//DirectoryInfo[] dirs1= directory.GetDirectories("books*.");

//// класс Directory
//string[] files = Directory.GetFiles(dirName, "*.exe");
//// класс DirectoryInfo
//var directory = new DirectoryInfo(dirName);
//FileInfo[] files1= directory.GetFiles("*.exe");


//string path = @"C:\SomeDir";
//string subpath = @"program\avalon";
//DirectoryInfo dirInfo = new DirectoryInfo(path);
//if (!dirInfo.Exists)
//{
//    dirInfo.Create();
//}
//dirInfo.CreateSubdirectory(subpath);


//string dirName = @"C:\SomeDir";
//DirectoryInfo dirInfo = new DirectoryInfo(dirName);
//if (dirInfo.Exists)
//{
//    dirInfo.Delete(true);
//    Console.WriteLine("Каталог удален");
//}
//else
//{
//    Console.WriteLine("Каталог не существует");
//}

//string path = @"C:\Users\eugene\Documents\content.txt";
//string path = "/Users/eugene/Documents/content.txt";  // для MacOS/Linux
//FileInfo fileInfo = new FileInfo(path);
//if (fileInfo.Exists)
//{
//    Console.WriteLine($"Имя файла: {fileInfo.Name}");
//    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
//    Console.WriteLine($"Размер: {fileInfo.Length}");
//}

//string path = @"C:\OldDir\content.txt";
//string newPath = @"C:\NewDir\index.txt";
//FileInfo fileInf = new FileInfo(path);
//if (fileInf.Exists)
//{
//    fileInf.MoveTo(newPath);
//    альтернатива с помощью класса File
//     File.Move(path, newPath);
//}

//string path = @"C:\OldDir\content.txt";
//string newPath = @"C:\NewDir\index2.txt";
//FileInfo fileInf = new FileInfo(path);
//if (fileInf.Exists)
//{
//    fileInf.CopyTo(newPath, true);
//    альтернатива с помощью класса File
//     File.Copy(path, newPath, true);
//}
//string path = @"C:\app\content.txt";
//FileInfo fileInf = new FileInfo(path);
//if (fileInf.Exists)
//{
//    fileInf.Delete();
//    альтернатива с помощью класса File
//     File.Delete(path);
//}



//FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);
//Console.WriteLine("File opened");

//f.WriteByte(70);
//Console.WriteLine("Data written into file");

//f.Close();
//Console.WriteLine("File Stream closed");

//FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

//Console.WriteLine("File opened");

//char a = (char)f.ReadByte();

//Console.WriteLine("Data read from file is: " + a);

//f.Close();

//Console.WriteLine("File Stream closed");

//Console.ReadLine();


//FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

//Console.WriteLine("File opened");

////declared stream writer
//StreamWriter s = new StreamWriter(f);

//Console.WriteLine("Writing data to file");

//s.WriteLine("Writing data into file using stream writer");

////closing stream writer
//s.Close();
//f.Close();

//Console.WriteLine("File Stream closed");

//Console.ReadLine();

//FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

//Console.WriteLine("File opened");

////declared stream reader
//StreamReader sr = new StreamReader(f);
//Console.WriteLine("Reading data from the file");

//string line = sr.ReadLine();

//Console.WriteLine("The data from the file is : " + line);

////closing stream writer
//sr.Close();
//f.Close();

//Console.WriteLine("File Stream closed");

//Console.ReadLine();

//string path = "d:\\person.dat";
//using (BinaryReader reader = new BinaryReader(File.Open("person.dat", FileMode.Open)))
//{
//    // считываем из файла строку
//    string name = reader.ReadString();
//    // считываем из файла число 
//    int age = reader.ReadInt32();
//    Console.WriteLine($"Name: {name}  Age: {age}");



// создаем объект BinaryWriter
//using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
//{
//    // записываем в файл строку
//    writer.Write("Tom");
//    // записываем в файл число int
//    writer.Write(37);
//    Console.WriteLine("File has been written");
//}

string[] phoneBook = new[] { "099150027, 575316978, 0950234593"};
List <string> result = new();

string? numbers = Console.ReadLine();
Regex regex = new(numbers);

foreach (var number in phoneBook)
{
    MatchCollection matches = regex.Matches(number);
    if (matches.Count > 0)
    {
        result.Add(number);
    }
}

if (result.Count > 0)
{
    Console.WriteLine("Совпадения" );
    foreach (var person in result)
    {
        Console.WriteLine(person);
    }
}
else
{
    Console.WriteLine("Ничего не найдено");
}