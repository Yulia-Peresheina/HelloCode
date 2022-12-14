// Прохождение по дирректориям

string path = "D:/Учеба/Курс по C#/Examples/Example012_method";
DirectoryInfo di = new DirectoryInfo (path);
System.Console.WriteLine(di.CreationTime);
FileInfo [] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}