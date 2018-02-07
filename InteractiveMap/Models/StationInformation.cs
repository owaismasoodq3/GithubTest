using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InteractiveMap.Models
{
    public class stationInformation_AllType
    {
        public List<StationInformation> stationInformation_All { get; set; }
    }


    public class StationInformationDTO
    {
        public string stationName { get; set; }
        public string CRSCode { get; set; }
        public string stationAddress { get; set; }
        public string xPos { get; set; }
        public string yPox { get; set; }
        public string status { get; set; }
        public string imageURL { get; set; }

    }
    public class StationInformation
    {
        public string stationName { get; set; }
        public string CRSCode { get; set; }
        public string stationAddress { get; set; }
        public string xPos { get; set; }
        public string yPox { get; set; }
        public string status { get; set; }
        public Sitecore.Data.Fields.DateField startDate { get; set; }
        public Sitecore.Data.Fields.DateField endDate { get; set; }

        //Status
        public Sitecore.Data.Fields.ImageField statusIcon { get; set; }
        public string imageURL { get; set; }
        public string statusTitle { get; set; }
        public string statusMessage { get; set; }

    }

    public class Legends_AllType
    {
        public List<Legends> legends_All { get; set; }
    }

    public class Legends
    {
        public Sitecore.Data.Fields.ImageField icon { get; set;}
        public string imageURL { get; set; }
        public string subtitle { get; set; }

    }
}