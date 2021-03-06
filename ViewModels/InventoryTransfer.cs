﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MixERP.Inventory.ViewModels
{
    public sealed class InventoryTransfer
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public long LoginId { get; set; }


        [Required]
        public DateTime ValueDate { get; set; }

        [Required]
        public DateTime BookDate { get; set; }

        public string ReferenceNumber { get; set; }
        public string StatementReference { get; set; }
        public List<TransferType> Details { get; set; }
    }
}