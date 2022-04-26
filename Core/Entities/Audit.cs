using System;

namespace Core.Entities
{
    public abstract class Audit
    {
        public int Id { get; set; }
        public int? CUserId { get; set; }
        public DateTime? CDate { get; set; }  = DateTime.Now;
        public int? MUserId { get; set; }
        public DateTime? MDate { get; set; }

    }
}