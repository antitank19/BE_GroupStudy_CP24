﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs
{
    public class ReportedAccountDto : AccountProfileDto
    {
        public virtual ICollection<ReportGetListDto> ReportedReports { get; set; } = new Collection<ReportGetListDto>();

    }
}
