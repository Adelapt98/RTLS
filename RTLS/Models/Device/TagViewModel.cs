using System;

namespace RTLS.Models.Device
{
    public class TagViewModel
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}