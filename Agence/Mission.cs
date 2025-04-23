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
        public string nomMission {  get; set; }
        public string destination {  get; set; }
        public DateTime dateDepart {  get; set; }
        public DateTime dateArriver { get; set; }
        public StatutMission status { get; set; }

       
        //test
        public Mission(string nomMission, string destination, DateTime dateDepart, DateTime dateArriver)
        {
            this.nomMission = nomMission;
            this.destination = destination;
            this.dateDepart = dateDepart;
            this.dateArriver = dateArriver;
            status = StatutMission.Planifie;
        }
    }
}
