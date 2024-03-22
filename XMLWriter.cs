using UnityEngine;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting.FullSerializer;

public class XMLWriter : MonoBehaviour
{
    void Start()
    {
        // Create a new XML document
        XmlDocument xmlDoc = new XmlDocument();

        // Create the root element
        XmlElement rootElement = xmlDoc.CreateElement("People");
        xmlDoc.AppendChild(rootElement);

        // Data to be written
        string[] names = { "Tibor", "Markus", "Emil", "Ivana", "Sigurd", "Sofie" };
        int[] yearsOfBirth = { 1994, 2000, 1998, 1999, 2001, 2003 }; // Adjusted for 6 elements
        string[] favoriteColors = { "blue", "blue", "blue", "red", "yellow", "orange" };

        // Add each person's data as a child element to the root
        for (int i = 0; i < names.Length; i++)
        {
            XmlElement personElement = xmlDoc.CreateElement("Person");
            rootElement.AppendChild(personElement);

            XmlElement nameElement = xmlDoc.CreateElement("Name");
            nameElement.InnerText = names[i];
            personElement.AppendChild(nameElement);

            XmlElement yearOfBirthElement = xmlDoc.CreateElement("YearOfBirth");
            yearOfBirthElement.InnerText = yearsOfBirth[i].ToString();
            personElement.AppendChild(yearOfBirthElement);

            XmlElement favoriteColorElement = xmlDoc.CreateElement("FavoriteColor");
            favoriteColorElement.InnerText = favoriteColors[i];
            personElement.AppendChild(favoriteColorElement);
        }

        // Save the XML document
        string filePath = Application.persistentDataPath + "/people_data.xml";
        xmlDoc.Save(filePath);

        Debug.Log("XML file saved at: " + filePath);
    }
}