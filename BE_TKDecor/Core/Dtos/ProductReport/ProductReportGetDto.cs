﻿using BusinessObject;

namespace BE_TKDecor.Core.Dtos.ProductReport
{
    public class ProductReportGetDto
    {
        public long ProductReportId { get; set; }

        //public int ProductReportedId { get; set; }

        public string ProductName { get; set; } = null!;

        public string UserReportName { get; set; } = null!;

        //public int ReportStatusId { get; set; }

        public string ReportStatusName { get; set; } = null!;

        public string Reason { get; set; } = null!;

        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
