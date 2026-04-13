// File.WriteAllText("myfile.txt", "Hi Muste");
// Console.WriteLine("Your file has been created.");

// var desktopPath = @"C:\Users\ZAYNAB\Desktop";
// var aFileFilePath = $"{desktopPath}aFile.txt";
// Console.WriteLine("Your file has been created");

// var myNewFile = $"{desktopPath}myNewFolder";
// File.Create($"{desktopPath}testing");



//Assignment
//Write a code in your program.cs that.....
//Create a file called MGQSFile.txt in desktop
//Create a folder called MGQSFIle.txt from your desktop into MGQSFolder
//Delete MGQSFolder
//Type your full name in 10 different rows inside of MGQSFile.txt in desktop and copy the content of MGQSFile.txt into a new file MGQSFile.docx in desktop
string desktopPath = @"C:\Users\Mustakim\OneDrive\Desktop";
string fileName = "MGQSFile.txt";
string folderName = "MGQSFolder";
string docxFileName = "MGQSFile.docx";
string fullName = "OLOWOYO MUSTAKIM ABIODUN"
// Create file
File.WriteAllText(Path.Combine(desktopPath, fileName), fullName);

// Create folder
Directory.CreateDirectory(Path.Combine(desktopPath, folderName));

// Delete folder
Directory.Delete(Path.Combine(desktopPath, folderName));

// Write full name 10 times to file
for (int i = 0; i < 10; i++)
{
    File.AppendAllText(Path.Combine(desktopPath, fileName), fullName + Environment.NewLine);
}

// Copy content to new file
File.Copy(Path.Combine(desktopPath, fileName), Path.Combine(desktopPath, docxFileName));
