using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data;
using InteractiveMap.Models;
using System.Web.Configuration;
using System.Configuration;

namespace InteractiveMap.Controllers
{

    public class InteractiveController : Controller
    {
        //Use As 
        public ActionResult StationInformation(string cityName)
        {
            StationInformation stationInfo = GetStationInformation(cityName);
            JsonResult result = new JsonResult();
            result = Json(stationInfo, JsonRequestBehavior.AllowGet);
            result.MaxJsonLength = int.MaxValue;
            result.RecursionLimit = int.MaxValue;
            return Json(new { result = result }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Getinfo()
        {
            List<Models.StationInformationDTO> stationList = GetAllStationInformation();
            JsonResult result = new JsonResult();
            result = Json(stationList, JsonRequestBehavior.AllowGet);
            result.MaxJsonLength = int.MaxValue;
            result.RecursionLimit = int.MaxValue;
            return Json(new { result = result }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            try
            {
                // /*stationInformation_AllType*/
                // List<Models.StationInformation> modelFull = GetAllStationInformation();
                // //  return View(modelFull);
                // JsonResult result = new JsonResult();
                // result = Json(modelFull, JsonRequestBehavior.AllowGet);
                // result.MaxJsonLength = int.MaxValue;
                // result.RecursionLimit = int.MaxValue;
                //// string result = "hi";
                // return Json(result);
                return View("../Renderings/Map");
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        public ActionResult Legends()
        {
            Legends_AllType modelFull = GetAllLegends("/sitecore/content/Home/iMap/Configuration/Legends/");
            return View(modelFull);
        }

        public ActionResult SubLegends()
        {
            Legends_AllType modelFull = GetAllLegends("/sitecore/content/Home/iMap/Configuration/SubLegends/");
            return View(modelFull);
        }

        public ActionResult TrainPosition()
        {
            Legends_AllType modelFull = GetAllLegends("/sitecore/content/Home/iMap/Configuration/TrainPosition/");
            return View(modelFull);
        }

        public Legends_AllType GetAllLegends(string path)
        {
            Legends_AllType allType = new Legends_AllType();
            allType.legends_All = new List<Models.Legends>();
            Database DB = Sitecore.Context.Database;
            Sitecore.Data.Items.Item legendsItem = DB.GetItem(path);
            foreach (Sitecore.Data.Items.Item child in legendsItem.Children)
            {

                Legends legendInfoAll = new Legends();
                legendInfoAll.icon = child.Fields[Templates.LegendInformation.LegendIcon];
                if (legendInfoAll.icon.MediaItem != null)
                {
                    legendInfoAll.imageURL = Sitecore.Resources.Media.MediaManager.GetMediaUrl(legendInfoAll.icon.MediaItem);
                }
                legendInfoAll.subtitle = child.Fields[Templates.LegendInformation.LegendSubtitle].ToString() != null ? child.Fields[Templates.LegendInformation.LegendSubtitle].ToString() : "";

                allType.legends_All.Add(legendInfoAll);

            }

            return allType;
        }
        public StationInformation GetStationInformation(string city)
        {
            StationInformation stationInfo = new StationInformation();
            Database DB = Sitecore.Context.Database;
            Sitecore.Data.Items.Item stationInfo_Item = DB.GetItem("/sitecore/content/Home/iMap/Configuration/Station Information/" + city);
            if (stationInfo_Item != null)
            {
                stationInfo.stationName = stationInfo_Item.Fields[Templates.StationInformation.StationName].ToString();
                stationInfo.CRSCode = stationInfo_Item.Fields[Templates.StationInformation.CRSCode].ToString();
                if (stationInfo_Item.Fields[Templates.StationInformation.StationAddress].ToString() != null || stationInfo_Item.Fields[Templates.StationInformation.StationAddress].ToString() != "")
                {
                    stationInfo.stationAddress = stationInfo_Item.Fields[Templates.StationInformation.StationAddress].ToString();
                }

                stationInfo.xPos = stationInfo_Item.Fields[Templates.StationInformation.XPox].ToString();
                stationInfo.yPox = stationInfo_Item.Fields[Templates.StationInformation.YPos].ToString();
                stationInfo.status = stationInfo_Item.Fields[Templates.StationInformation.StationStatus].ToString();
                Sitecore.Data.Fields.DateField startDate = stationInfo_Item.Fields[Templates.StationInformation.ValidFrom];
                Sitecore.Data.Fields.DateField endDate = stationInfo_Item.Fields[Templates.StationInformation.ValidTo];
                //remove when deployed
                DateTime startd = startDate.DateTime;
                DateTime endd = endDate.DateTime;

                var start = TimeZoneInfo.ConvertTimeFromUtc(startd, TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["StartDate"]));
                var end = TimeZoneInfo.ConvertTimeFromUtc(endd, TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["StartDate"]));

                //string userName = ConfigurationManager.AppSettings["StartDate"];
                //station status
                if (stationInfo.status == null || stationInfo.status == "" || StartValid(start) || EndValid(end) )
                {
                    //default status
                    //stationInfo.statusIcon = null;
                    //stationInfo.statusTitle = null;
                    //stationInfo.statusMessage = null;

                    

                }
                else
                {
                    Sitecore.Data.Items.Item stationStatusDetails = DB.GetItem("/sitecore/content/Home/iMap/Configuration/Station Status/" + stationInfo.status);
                    //stationInfo.statusIcon = stationStatusDetails.Fields[Templates.StationStatus.StationStatusIcon];
                    Sitecore.Data.Fields.ImageField statusIcon = stationStatusDetails.Fields[Templates.StationStatus.StationStatusIcon];
                    if (statusIcon.MediaItem != null)
                        stationInfo.imageURL = Sitecore.Resources.Media.MediaManager.GetMediaUrl(statusIcon.MediaItem);

                    stationInfo.statusTitle = stationStatusDetails.Fields[Templates.StationStatus.StationStatusTitle].ToString();
                    stationInfo.statusMessage = stationStatusDetails.Fields[Templates.StationStatus.StationStatusDetails].ToString();
                    stationInfo.statusMessage = stationStatusDetails.Fields[Templates.StationStatus.StationStatusDetails].Value.Replace("startDate", start.ToString());
                    stationInfo.statusMessage = stationInfo.statusMessage.Replace("endDate", end.ToString());

                }
            }

            return stationInfo;
        }

        [HttpPost]
        public ActionResult GetAllStationInformationNew()
        {
            try
            {
                /*stationInformation_AllType*/
                List<Models.StationInformationDTO> modelFull = GetAllStationInformation();
                return Json(new { response = modelFull }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        public List<Models.StationInformationDTO> GetAllStationInformation()
        {
            List<Models.StationInformationDTO> allType = new List<Models.StationInformationDTO>();
            Database DB = Sitecore.Context.Database;
            Sitecore.Data.Items.Item stationInfo_Item = DB.GetItem("/sitecore/content/Home/iMap/Configuration/Station Information/");
            foreach (Sitecore.Data.Items.Item child in stationInfo_Item.Children)
            {

                Sitecore.Data.Fields.Field temp = child.Fields[Templates.StationInformation.StationName];

                StationInformationDTO stationInfoAll = new StationInformationDTO();
                stationInfoAll.stationName = child.Fields[Templates.StationInformation.StationName].ToString();
                stationInfoAll.CRSCode = child.Fields[Templates.StationInformation.CRSCode].ToString();
                if (child.Fields[Templates.StationInformation.StationAddress].ToString() != null || child.Fields[Templates.StationInformation.StationAddress].ToString() != "")
                {
                    stationInfoAll.stationAddress = child.Fields[Templates.StationInformation.StationAddress].ToString();
                }
                stationInfoAll.stationAddress = child.Fields[Templates.StationInformation.StationAddress].ToString();
                stationInfoAll.xPos = child.Fields[Templates.StationInformation.XPox].ToString();
                stationInfoAll.yPox = child.Fields[Templates.StationInformation.YPos].ToString();
                stationInfoAll.status = child.Fields[Templates.StationInformation.StationStatus].ToString();
                Sitecore.Data.Fields.DateField startDate = child.Fields[Templates.StationInformation.ValidFrom];
                Sitecore.Data.Fields.DateField endDate = child.Fields[Templates.StationInformation.ValidTo];
                //DateTime start = startDate.DateTime.AddHours(5).AddMinutes(30);
                //DateTime end = endDate.DateTime.AddHours(5).AddMinutes(30);
                DateTime startd = startDate.DateTime;
                DateTime endd = endDate.DateTime;

                var start = TimeZoneInfo.ConvertTimeFromUtc(startd, TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["StartDate"]));
                var end = TimeZoneInfo.ConvertTimeFromUtc(endd, TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["StartDate"]));

                if (stationInfoAll.status == null || stationInfoAll.status == ""  || StartValid(start) || EndValid(end))
                {
                        //default status
                        //stationInfo.statusIcon = null;
                        //stationInfo.statusTitle = null;
                        //stationInfo.statusMessage = null;
                }
                else
                {
                    Sitecore.Data.Items.Item stationStatusDetails = DB.GetItem("/sitecore/content/Home/iMap/Configuration/Station Status/" + stationInfoAll.status);
                    Sitecore.Data.Fields.ImageField statusIcon = stationStatusDetails.Fields[Templates.StationStatus.StationStatusIcon];
                    stationInfoAll.imageURL = Sitecore.Resources.Media.MediaManager.GetMediaUrl(statusIcon.MediaItem);
                }
                allType.Add(stationInfoAll);
            }

            return allType;
        }

        private bool StartValid(DateTime startDate)
        {
            if (DateTime.Compare(DateTime.Now, startDate) < 1)
                return true;
            else
                return false;
        }
        private bool EndValid(DateTime endDate)
        {
            if (DateTime.Compare(endDate, DateTime.Now) < 1)
                return true;
            else
                return false;

        }

       
    }
}