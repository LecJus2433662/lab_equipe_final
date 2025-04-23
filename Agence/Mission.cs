using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public enum StatutMission
    {
        Planifie,
        EnCours,
        Terminee
    }
    public partial class Mission
    {
        public string NomMission {  get; set; }
        public string Destination {  get; set; }
        public DateTime DateDepart {  get; set; }
        public DateTime DateArriver { get; set; }
        public StatutMission Status { get; set; }


        //test
        public Mission(string nomMission, string destination, DateTime dateDepart, DateTime dateArriver)
        {
            this.NomMission = nomMission;
            this.Destination = destination;
            this.DateDepart = dateDepart;
            this.DateArriver = dateArriver;
            Status = StatutMission.Planifie;
        }
    }
}
