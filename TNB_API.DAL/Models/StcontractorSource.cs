using System;
using System.Collections.Generic;

#nullable disable

namespace TNB_API.DAL.Models
{
    public partial class StcontractorSource
    {
        public long StcontractorId { get; set; }
        public long? SyarikatKey { get; set; }
        public string NoDaftar { get; set; }
        public string Nama { get; set; }
        public string Alamat1D { get; set; }
        public string Alamat2D { get; set; }
        public string Alamat3D { get; set; }
        public string PoskodD { get; set; }
        public int? KodBandarD { get; set; }
        public int? KodNegeriD { get; set; }
        public string KodNegaraD { get; set; }
        public string TelefonD { get; set; }
        public string FaxD { get; set; }
        public string Email { get; set; }
        public string Alamat1S { get; set; }
        public string Alamat2S { get; set; }
        public string Alamat3S { get; set; }
        public string PoskodS { get; set; }
        public int? KodBandarS { get; set; }
        public int? KodNegeriS { get; set; }
        public string KodNegaraS { get; set; }
        public string TelefonS { get; set; }
        public string FaxS { get; set; }
        public string KodKategori { get; set; }
        public DateTime? TarikhMula { get; set; }
        public DateTime? TarikhTamat { get; set; }
        public DateTime? TarikhJana { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public long? EcibscontractorId { get; set; }
        public int? EcibssyncStatus { get; set; }
        public DateTime? TarikhCetak { get; set; }
    }
}
