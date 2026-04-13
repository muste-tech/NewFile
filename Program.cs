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
