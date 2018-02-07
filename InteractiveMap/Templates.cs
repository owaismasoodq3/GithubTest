using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InteractiveMap
{
    using Sitecore.Data;
    public struct Templates
    {

        public struct Footer
        {
            public static readonly ID ContactUs = new ID("{F08E2BC9-8234-449E-A399-294FDCD7EE8B}");
            public const string ContactUs_FieldName = "ContactUs";
            public static readonly ID ContactUs_Link = new ID("{15B0FF26-773D-477D-89A3-651B39989579}");
            public const string ContactUs_Link_FieldName = "ContactUs_Link";
            public static readonly ID TrainTicketsExplained = new ID("{A3603073-FD86-4257-9FD6-246A08F705D7}");
            public const string TrainTicketsExplained_FieldName = "TrainTicketsExplained";
            public static readonly ID TrainTicketsExplained_Link = new ID("{D5CD0878-CA29-4693-A928-E22735D9D531}");
            public const string TrainTicketsExplained_Link_FieldName = "TrainTicketsExplained_Link";
            public static readonly ID HowToGetYourTickets = new ID("{8E6746AD-90B7-40BC-84AA-593A2B59487D}");
            public const string HowToGetYourTickets_FieldName = "HowToGetYourTickets";
            public static readonly ID HowToGetYourTickets_Link = new ID("{52395BEA-A324-4B22-A741-59CB5FFA3BEA}");
            public const string HowToGetYourTickets_Link_FieldName = "HowToGetYourTickets_Link";
            public static readonly ID LiveTrainTimes = new ID("{7F72D134-2367-4060-9B75-93E36273ECD3}");
            public const string LiveTrainTimes_FieldName = "LiveTrainTimes";
            public static readonly ID LiveTrainTimes_Link = new ID("{0BF398BA-7862-41F0-A475-F38A69BDF68B}");
            public const string LiveTrainTimes_Link_FieldName = "LiveTrainTimes_Link";
            public static readonly ID RefundsAndCompensation = new ID("{EFFD752E-5F61-4CCC-8E15-77888233514C}");
            public const string RefundsAndCompensation_FieldName = "LiveTrainTimes";
            public static readonly ID RefundsAndCompensation_Link = new ID("{224DF0C1-DA80-4538-A562-CDB0453A0054}");
            public const string RefundsAndCompensation_Link_FieldName = "RefundsAndCompensation_Link";
            public static readonly ID DelayRepay = new ID("{237CAB8B-BBB4-4042-B8D8-F4761D2CB260}");
            public const string DelayRepay_FieldName = "LiveTrainTimes";
            public static readonly ID DelayRepay_Link = new ID("{CB72558B-FE6C-47B6-A420-D4CB6E10ACD9}");
            public const string DelayRepay_Link_FieldName = "DelayRepay_Link";
            public static readonly ID OurPlan = new ID("{53E0FAC1-5346-4F39-8509-F4A223EF313B}");
            public const string OurPlan_FieldName = "OurPlan";
            public static readonly ID OurPlan_Link = new ID("{7588F6F7-A747-45FF-BF6D-77697818513B}");
            public const string OurPlan_Link_FieldName = "OurPlan_Link";
            public static readonly ID Careers = new ID("{037EA929-7394-4805-86E5-2FEA003CBAE9}");
            public const string Careers_FieldName = "Careers";
            public static readonly ID Careers_Link = new ID("{F0513296-AD33-43AF-9C8E-3F7BFD2E029F}");
            public const string Careers_Link_FieldName = "Careers_Link";
            public static readonly ID PassengerCharter = new ID("{B320E86E-AB29-46AA-934B-BBC2E5EDE7AF}");
            public const string PassengerCharter_FieldName = "PassengerCharter";
            public static readonly ID PassengerCharter_Link = new ID("{A27BD6A6-5AE5-43D7-9E65-29A8DB626BCD}");
            public const string PassengerCharter_Link_FieldName = "PassengerCharter_Link";
            public static readonly ID OurPerformance = new ID("{27FFC562-75DB-4021-8E82-942C2AA9B4EC}");
            public const string OurPerformance_FieldName = "OurPerformance";
            public static readonly ID OurPerformance_Link = new ID("{E38496C3-B54C-4E15-909B-F293367B30DC}");
            public const string OurPerformance_Link_FieldName = "OurPerformance_Link";
            public static readonly ID FirstGroupAndMTRCompany = new ID("{8E274947-8C32-43EA-9229-80D0ADA09621}");
            public const string FirstGroupAndMTRCompany_FieldName = "FirstGroupAndMTRCompany";
            public static readonly ID FirstGroupAndMTRCompany_Link = new ID("{4BB79B54-A587-436A-918D-7A47521771A6}");
            public const string FirstGroupAndMTRCompany_Link_FieldName = "FirstGroupAndMTRCompany_Link";
            public static readonly ID TrainsToLondonWaterloo = new ID("{1CA368F7-B76F-4196-903F-F9F9E8EE4F1B}");
            public const string TrainsToLondonWaterloo_FieldName = "TrainsToLondonWaterloo";
            public static readonly ID TrainsToLondonWaterloo_Link = new ID("{8D4B9B4F-F5D9-4CA9-A705-EDCB162015B0}");
            public const string TrainsToLondonWaterloo_Link_FieldName = "TrainsToLondonWaterloo_Link";
            public static readonly ID TrainsToBournemouth = new ID("{126C2B3E-3356-429B-AC8C-42B4947C1432}");
            public const string TrainsToBournemouth_FieldName = "TrainsToBournemouth";
            public static readonly ID TrainsToBournemouth_Link = new ID("{DD460CF8-BE20-4333-BF39-D74BC19D8EC2}");
            public const string TrainsToBournemouth_Link_FieldName = "TrainsToBournemouth_Link";
            public static readonly ID TrainsToExeter = new ID("{05636553-2BC6-4935-ACF3-34CE7908940A}");
            public const string TrainsToExeter_FieldName = "TrainsToExeter";
            public static readonly ID TrainsToExeter_Link = new ID("{07359C61-73DA-4C03-9576-7300C5800257}");
            public const string TrainsToExeter_Link_FieldName = "TrainsToExeter_Link";
            public static readonly ID TrainsToSouthAmpton = new ID("{D44EA798-B56D-413F-939E-02740942690F}");
            public const string TrainsToSouthAmpton_FieldName = "TrainsToSouthAmpton";
            public static readonly ID TrainsToSouthAmpton_Link = new ID("{59AA0E49-0D20-4F66-A1D1-D46208739B16}");
            public const string TrainsToSouthAmpton_Link_FieldName = "TrainsToSouthAmpton_Link";
            public static readonly ID SeeAllDestinations = new ID("{3B56D8A3-82F3-4DCC-87F2-F3C352DC6093}");
            public const string SeeAllDestinations_FieldName = "SeeAllDestinations";
            public static readonly ID SeeAllDestinations_Link = new ID("{C2C4595C-4FC4-40F7-8096-100F0D27B573}");
            public const string SeeAllDestinations_Link_FieldName = "SeeAllDestinations_Link";
        }
        public struct LegendInformation
        {
            public static readonly ID LegendIcon = new ID("{9E882860-62F7-4348-823B-05EF9BEF9EF5}");
            public const string LegendIcon_FieldName = "LegendIcon";
            public static readonly ID LegendSubtitle = new ID("{B25B2027-0254-4C37-96D2-C82EC4897730}");
            public const string LegendSubtitle_FieldName = "LegendSubtitle";
        }

        public struct NetworkInformation
        {
            public static readonly ID NetworkTitle = new ID("{14781A89-7B79-41DF-8F1C-C79C0662F5E2}");
            public const string NetworkTitle_FieldName = "NetworkTitle";
            public static readonly ID NetworkSubtitle = new ID("{1B8FDC79-BA80-41DD-8AB7-635CB5A795DC}");
            public const string NetworkSubtitle_FieldName = "NetworkSubtitle";
        }

        public struct NetworkPage
        {
            public static readonly ID PageTitle = new ID("{027EA27F-4EC8-4E36-98F3-C903C2149471}");
            public const string PageTitle_FieldName = "PageTitle";
         }

        public struct PrimaryNavigation
        {
            public static readonly ID TrainTickets = new ID("{6E0E5458-5751-4973-A429-53AA62418A64}");
            public const string TrainTickets_FieldName = "TrainTickets";
            public static readonly ID TrainTickets_Link = new ID("{83BAC8E4-0369-4E2B-84BF-A9DA535DD5B2}");
            public const string TrainTickets_Link_FieldName = "TrainTickets_Link";
            public static readonly ID PlanMyJourney = new ID("{149DDC36-C221-4239-B327-4C1E7894C90E}");
            public const string PlanMyJourney_FieldName = "PlanMyJourney";
            public static readonly ID PlanMyJourney_Link = new ID("{645B2CF7-3CD9-4518-B5AB-D75043783785}");
            public const string PlanMyJourney_Link_FieldName = "PlanMyJourney_Link";
            public static readonly ID TravellingWithUs = new ID("{D4E40226-DF84-43C1-9773-9861751903FA}");
            public const string TravellingWithUs_FieldName = "TravellingWithUs";
            public static readonly ID TravellingWithUs_Link = new ID("{40B064EE-4F70-4DE8-9925-BC9EE7524517}");
            public const string TravellingWithUs_Link_FieldName = "TravellingWithUs_Link";
            public static readonly ID DestinationsAndOffers = new ID("{AE0C1C6B-534E-4D50-9246-E36ADDF0C52A}");
            public const string DestinationsAndOffers_FieldName = "DestinationsAndOffers";
            public static readonly ID DestinationsAndOffers_Link = new ID("{83BE1B26-0FCC-4B3E-B857-A746252C09F0}");
            public const string DestinationsAndOffers_Link_FieldName = "DestinationsAndOffers_Link";
            public static readonly ID HelpAndSupport = new ID("{E6CC3C10-B02F-4B9D-8DD6-1EE3C4158E18}");
            public const string HelpAndSupport_FieldName = "HelpAndSupport";
            public static readonly ID HelpAndSupport_Link = new ID("{A49FE68B-87B1-4149-8593-00BF7076A814}");
            public const string HelpAndSupport_Link_FieldName = "HelpAndSupport_Link";
        }

        public struct StationInformation
        {
            public static readonly ID StationName = new ID("{2FA507D0-A3B0-4135-8071-F830EBC1ECEC}");
            public const string StationName_FieldName = "StationName";
            public static readonly ID CRSCode = new ID("{27A8853E-CAFB-4729-AE16-417E84658F34}");
            public const string CRSCode_FieldName = "CRSCode";
            public static readonly ID StationAddress = new ID("{76717F32-715B-4F22-9394-87E3ED57DFC7}");
            public const string StationAddress_FieldName = "StationAddress";
            public static readonly ID XPox = new ID("{1D9109B2-D166-4D8C-B20D-F48600CB9A48}");
            public const string XPox_FieldName = "XPox";
            public static readonly ID YPos = new ID("{E524D823-F4FE-498B-86D8-DF2E16D40F7F}");
            public const string YPos_FieldName = "YPos";

        //Station Validity
            public static readonly ID StationStatus = new ID("{F12170E6-50DE-4CD0-B823-91BF98C822F5}");
            public const string StationStatus_FieldName = "StationStatus";
            public static readonly ID ValidFrom = new ID("{6A3E5FF2-5ACC-4829-9BF7-FBE18B6A5417}");
            public const string ValidFrom_FieldName = "ValidFrom";
            public static readonly ID ValidTo = new ID("{D85D3A9E-1599-4F84-9E32-444CDE18D429}");
            public const string ValidTo_FieldName = "ValidTo";

        }

        public struct StationStatus
        {
            public static readonly ID StationStatusIcon = new ID("{F1A524B2-A298-4BEA-9337-F35CC71CF838}");
            public const string StationStatusIcon_FieldName = "StationStatusIcon";
            public static readonly ID StationStatusTitle = new ID("{9EA6F999-14A7-49A6-A324-22DC8691BE77}");
            public const string StationStatusTitle_FieldName = "StationStatusTitle";
            public static readonly ID StationStatusDetails = new ID("{875EBE1B-E7E0-4B81-A031-2698CC826156}");
            public const string StationStatusDetails_FieldName = "StationStatusDetails";

        }

    }
}