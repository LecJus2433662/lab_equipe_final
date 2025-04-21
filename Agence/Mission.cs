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

        public Mission()
        {
            status = StatutMission.Planifie;
        }
    }
}
