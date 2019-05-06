using System;

namespace RTLS.Models.Device
{
    public class AnchorViewModel
    {
        public int Id { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public int Height { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}