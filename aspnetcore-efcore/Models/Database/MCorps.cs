﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetcore_efcore.Models.Database
{
    [Table("M_CORPs")]
    public partial class MCorps
    {
        [Column("CORP_ID", TypeName = "varchar(50)")]
        public string CorpId { get; set; }
        [Column("CORP_CODE", TypeName = "varchar(50)")]
        public string CorpCode { get; set; }
        [Column("CORP_NAME", TypeName = "varchar(50)")]
        public string CorpName { get; set; }
        [Column("DELETE_STATUS")]
        public int? DeleteStatus { get; set; }
        [Column("CREATE_BY", TypeName = "varchar(50)")]
        public string CreateBy { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("UPDATE_BY", TypeName = "varchar(50)")]
        public string UpdateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("REVISION")]
        public int? Revision { get; set; }
    }
}
