﻿namespace Excavators.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CurrentSensor
    {
        public CurrentSensor()
        {
            this.CurrentSensorDatas = new HashSet<CurrentSensorData>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        // Current of the Motor - Phase 2

        [StringLength(50)]
        public string Type { get; set; }
        // 0..5 A -> 4..20 mA

        [StringLength(250)]
        public string Description { get; set; }

        public float? WarningHighCurrent { get; set; }
        public float? WarningEmergencyHighCurrent { get; set; }


        [Required]
        public int MotorId { get; set; }
        public virtual Motor Motor { get; set; }

        public virtual ICollection<CurrentSensorData> CurrentSensorDatas { get; set; }

    }
}