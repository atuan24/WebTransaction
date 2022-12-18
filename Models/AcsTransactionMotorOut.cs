using System;
using System.Collections.Generic;

namespace WebTransaction.Models
{
    public partial class AcsTransactionMotorOut
    {
        public string Id { get; set; } = null!;
        public string? CardId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? CardTypeId { get; set; }
        public string? VehicleTypeId { get; set; }
        public string? UserId { get; set; }
        public string? ShiftId { get; set; }
        public string? LaneId { get; set; }
        public string? StationId { get; set; }
        public string? Plate { get; set; }
        public string? LaneImage { get; set; }
        public string? PlateImage { get; set; }
        public string? Note { get; set; }
        public DateTime ProcessDate { get; set; }
        public string? PartnerId { get; set; }
        public string? TransactionIdIn { get; set; }
        public string? StationIdIn { get; set; }
        public string? LaneIdIn { get; set; }
        public DateTime TransactionDateIn { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }
        public long Minutes { get; set; }
        public string? Barcode { get; set; }
        public string? SerialNo { get; set; }
        public string? InvoiceNo { get; set; }
        public string? FormNo { get; set; }
        public string? Serial { get; set; }
        public short F0 { get; set; }
        public short F1 { get; set; }
        public short F2 { get; set; }
        public short F3 { get; set; }
        public string? PlateHk { get; set; }
        public string? PlateO { get; set; }
        public string? Code { get; set; }
        public string? CreateUid { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? WriteUid { get; set; }
        public DateTime? WriteDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
