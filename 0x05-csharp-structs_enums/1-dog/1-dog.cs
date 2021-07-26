using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}


public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}