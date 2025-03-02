﻿using System.ComponentModel.DataAnnotations;

namespace Client.Models;

public class Task
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Finished { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsFinished { get; set; }
}