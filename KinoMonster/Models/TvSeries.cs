﻿namespace KinoMonster.Models;

public class TvSeries
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Producer { get; set; }
    public double? Rating { get; set; }
    public DateTime Date { get; set; }
    public string? ImageTitle { get; set; }
    public string? TrailerUrl { get; set; }


    public TvSeries(string title, double rating, string imageTitle)
    {
        Title = title;
        Rating = rating;
        ImageTitle = imageTitle;
    }
}
