﻿namespace Backend.Models;

public class Projekt
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Beschreibung { get; set; } = "";
    public string Status { get; set; } = "ToDo";
    public DateTime Startdatum { get; set; } = DateTime.UtcNow;
    public DateTime Enddatum { get; set; } = DateTime.UtcNow.AddDays(30);
    public int KundeId { get; set; }
    public int DauerGeschaetztStunden { get; set; }
    public int DauerBerechnetStunden { get; set; }
}