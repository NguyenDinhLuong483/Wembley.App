﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEMBLEY.App.Core.Domain.Dtos
{
    public class CreateLotDto
    {
        public string LotId { get; set; }
        public int LotSize { get; set; }
        public CreateLotDto(string lotId, int lotSize)
        {
            LotId = lotId;
            LotSize = lotSize;
        }
    }
}
