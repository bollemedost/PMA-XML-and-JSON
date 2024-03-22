using UnityEngine;
using System.IO;

public class DirectoryCreator : MonoBehaviour
{
    void Start()
    {
        // Define the path where you want to create the directory
        string directoryPath = Application.persistentDataPath + "/MyDirectory";

        // Check if the directory doesn't exist yet
        if (!Directory.Exists(directoryPath))
        {
            // Create the directory
            Directory.CreateDirectory(directoryPath);
            Debug.Log("Directory created at: " + directoryPath);
        }
        else
        {
            Debug.Log("Directory already exists at: " + directoryPath);
        }
    }
}
