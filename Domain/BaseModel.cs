﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public bool IsDeleted { get; set; }
        public void DeleteMe()
        {
            IsDeleted = true;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
