using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }

        [Required(ErrorMessage = "Name cannot be empty!")]
        public string Name { get; set; }
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }
        public List<EngineerMachine> JoinEntities { get; set; }
    }
}