using System;

namespace RepairSystem.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Model { get; set; }
        public string FaultDescription { get; set; }
        public string WorkRecord { get; set; }
        public string HardwareSpecs { get; set; }
        public string Engineer { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class RepairType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class FaultType
    {
        public int Id { get; set; }
        public string FaultName { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class SystemConfig
    {
        public int Id { get; set; }
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}