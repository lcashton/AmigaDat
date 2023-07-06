using System.Xml.Serialization;

[XmlRoot("datafile")]
public class Amiga
{
    [XmlElement("header")]
    public Header Header { get; set; } = new();

    [XmlElement("machine")]
    public List<Machine> Machines { get; set; } = new();
}

public class Header
{
    public string name { get; set; } = string.Empty;
    public string description { get; set; } = string.Empty;
    public string version { get; set; } = string.Empty;
    public string author { get; set; } = string.Empty;
    public string homepage { get; set; } = string.Empty;
    public string comment { get; set; } = string.Empty;
    public Clrmamepro clrmamepro { get; set; } = new();
}

public class Clrmamepro
{
    [XmlAttribute()]
    public string forcepacking { get; set; } = "zip";
}

public class Machine
{
    [XmlElement("description")]
    public string Description { get; set; } = string.Empty;

    [XmlElement("rom")]
    public List<Rom> Roms { get; set; } = new();

    [XmlAttribute("name")]
    public string Name { get; set; } = string.Empty;
}

public class Rom
{
    [XmlAttribute("name")]
    public string Name { get; set; } = string.Empty;

    [XmlAttribute("size")]
    public uint Size { get; set; } = 0;

    [XmlAttribute("crc")]
    public string CRC { get; set; } = string.Empty;

    [XmlAttribute("md5")]
    public string MD5 { get; set; } = string.Empty;

    [XmlAttribute("sha1")]
    public string SHA1 { get; set; } = string.Empty;
}

