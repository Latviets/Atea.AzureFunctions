﻿using Azure;
using Azure.Data.Tables;

namespace LogsListing
{
    public class TableEntity : ITableEntity
    {
        public TableEntity(bool success)
        {
            Success = success;
        }
        public required string PartitionKey { get; set; }
        public required string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
        public bool Success { get; set; }
    }
}
