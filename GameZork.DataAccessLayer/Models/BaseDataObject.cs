﻿using System.ComponentModel.DataAnnotations;

namespace GameZork.DataAccessLayer.Models
{
    public abstract class BaseDataObject
    {
        public int Id { get; set; }
    }
}
