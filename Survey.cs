using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    class Survey
    {
        public int Id { get; set; }
        public bool enviroGroup { get; set; }
        public bool performedSurveyBefore { get; set; }
        public string woodlandName { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string gridRef { get; set; }
        public double woodlandSize { get; set; }
        public string deadwoodStandingOrLying { get; set; }
        public double deadwoodDiameter { get; set; }
        public double deadwoodLenght { get; set; }
        public string deadwoodSpecies { get; set; }
        public string holesInDeadwood { get; set; }
        public string floraOnDeadwood { get; set; }
        public string faunaOnDeadwood { get; set; }
        public double pencilDepth { get; set; }
        public string deadwoodSoftness { get; set; }
        public string faunaInDeadwood { get; set; }
        public string deadwoodColour { get; set; }
        public int stateOfDecay { get; set; }
    }
}
