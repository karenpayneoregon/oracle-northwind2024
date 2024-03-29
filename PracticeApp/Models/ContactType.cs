﻿using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace PracticeApp.Models;
// note there is no table for this model
public class ContactType
{
    [Key]
    public int ContactTypeIdentifier { get; set; }
    public string ContactTitle { get; set; }
    public override string ToString() => ContactTitle;

}
