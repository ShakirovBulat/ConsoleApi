using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeather
{
    public class ChiefPhone
    {
        public string ChiefPhones { get; set; }
    }

    public class OrgInfo
    {
        public List<ChiefPhone> ChiefPhone { get; set; }
        public string FullName { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string OGRN { get; set; }
        public string LegalAddress { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
    }

    public class AvailableElement
    {
        public string Group_mgn { get; set; }
        public string Area_mgn { get; set; }
        public string Element_mgn { get; set; }
        public string available_degree { get; set; }
        public string available_index { get; set; }
    }

    public class Availability
    {
        public string available_k { get; set; }
        public string available_o { get; set; }
        public string available_z { get; set; }
        public string available_s { get; set; }
        public List<AvailableElement> available_element { get; set; }
    }

    public class ObjectAddress
    {
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public List<Availability> Availability { get; set; }
    }

    public class PublicPhone
    {
        public string PublicPhones { get; set; }
    }

    public class Fax
    {
        public string Faxs { get; set; }
    }

    public class Email
    {
        public string Emails { get; set; }
    }

    public class WorkingHour
    {
        public string DayWeek { get; set; }
        public string WorkHours { get; set; }
    }

    public class GeoData
    {
        public List<List<double>> coordinates { get; set; }
        public string type { get; set; }
    }

    public class GeodataCenter
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Root
    {
        public string Category { get; set; }
        public string CommonName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public List<OrgInfo> OrgInfo { get; set; }
        public List<ObjectAddress> ObjectAddress { get; set; }
        public string ChiefName { get; set; }
        public string ChiefPosition { get; set; }
        public List<PublicPhone> PublicPhones { get; set; }
        public List<Fax> Faxs { get; set; }
        public List<Email> Emails { get; set; }
        public List<WorkingHour> WorkingHours { get; set; }
        public string ClarificationOfWorkingHours { get; set; }
        public string WebSite { get; set; }
        public int MainHallCapacity { get; set; }
        public int global_id { get; set; }
        public GeoData geoData { get; set; }
        public GeodataCenter geodata_center { get; set; }
        public int? AdditionalHallCapacity { get; set; }
    }


}
