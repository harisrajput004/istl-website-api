﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Response
{
    public class JobTagNameDTO
    {
        public int Id { get; set; }

        public int TagId { get; set; }

        public string TagName { get; set; } = null!;
    }
}
