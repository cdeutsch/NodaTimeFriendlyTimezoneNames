using NodaTime.TimeZones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodaTimeFriendlyTimezoneNames
{
    public static class NodaTimeExtensions
    {
        /// <summary>
        /// Joda Timezone Keys to Rails ActiveRecord names.
        /// http://joda-time.sourceforge.net/timezones.html
        /// http://api.rubyonrails.org/classes/ActiveSupport/TimeZone.html
        /// </summary>
        public static Dictionary<string, string> NodaToFriendlyTimezoneMap = new Dictionary<string, string>() {
            { "Pacific/Midway", "International Date Line West" },
            { "Pacific/Midway", "Midway Island" },
            { "Pacific/Pago_Pago", "American Samoa" },
            { "Pacific/Honolulu", "Hawaii" },
            { "America/Juneau", "Alaska" },
            { "America/Los_Angeles", "Pacific Time (US & Canada)" },
            { "America/Tijuana", "Tijuana" },
            { "America/Denver", "Mountain Time (US & Canada)" },
            { "America/Phoenix", "Arizona" },
            { "America/Chihuahua", "Chihuahua" },
            { "America/Mazatlan", "Mazatlan" },
            { "America/Chicago", "Central Time (US & Canada)" },
            { "America/Regina", "Saskatchewan" },
            { "America/Mexico_City", "Guadalajara" },
            { "America/Mexico_City", "Mexico City" },
            { "America/Monterrey", "Monterrey" },
            { "America/Guatemala", "Central America" },
            { "America/New_York", "Eastern Time (US & Canada)" },
            { "America/Indiana/Indianapolis", "Indiana (East)" },
            { "America/Bogota", "Bogota" },
            { "America/Lima", "Lima" },
            { "America/Lima", "Quito" },
            { "America/Halifax", "Atlantic Time (Canada)" },
            { "America/Caracas", "Caracas" },
            { "America/La_Paz", "La Paz" },
            { "America/Santiago", "Santiago" },
            { "America/St_Johns", "Newfoundland" },
            { "America/Sao_Paulo", "Brasilia" },
            { "America/Argentina/Buenos_Aires", "Buenos Aires" },
            { "America/Montevideo", "Montevideo" },
            { "America/Guyana", "Georgetown" },
            { "America/Godthab", "Greenland" },
            { "Atlantic/South_Georgia", "Mid-Atlantic" },
            { "Atlantic/Azores", "Azores" },
            { "Atlantic/Cape_Verde", "Cape Verde Is." },
            { "Europe/Dublin", "Dublin" },
            { "Europe/London", "Edinburgh" },
            { "Europe/Lisbon", "Lisbon" },
            { "Europe/London", "London" },
            { "Africa/Casablanca", "Casablanca" },
            { "Africa/Monrovia", "Monrovia" },
            { "Etc/UTC", "UTC" },
            { "Europe/Belgrade", "Belgrade" },
            { "Europe/Bratislava", "Bratislava" },
            { "Europe/Budapest", "Budapest" },
            { "Europe/Ljubljana", "Ljubljana" },
            { "Europe/Prague", "Prague" },
            { "Europe/Sarajevo", "Sarajevo" },
            { "Europe/Skopje", "Skopje" },
            { "Europe/Warsaw", "Warsaw" },
            { "Europe/Zagreb", "Zagreb" },
            { "Europe/Brussels", "Brussels" },
            { "Europe/Copenhagen", "Copenhagen" },
            { "Europe/Madrid", "Madrid" },
            { "Europe/Paris", "Paris" },
            { "Europe/Amsterdam", "Amsterdam" },
            { "Europe/Berlin", "Berlin" },
            { "Europe/Berlin", "Bern" },
            { "Europe/Rome", "Rome" },
            { "Europe/Stockholm", "Stockholm" },
            { "Europe/Vienna", "Vienna" },
            { "Africa/Algiers", "West Central Africa" },
            { "Europe/Bucharest", "Bucharest" },
            { "Africa/Cairo", "Cairo" },
            { "Europe/Helsinki", "Helsinki" },
            { "Europe/Kiev", "Kyiv" },
            { "Europe/Riga", "Riga" },
            { "Europe/Sofia", "Sofia" },
            { "Europe/Tallinn", "Tallinn" },
            { "Europe/Vilnius", "Vilnius" },
            { "Europe/Athens", "Athens" },
            { "Europe/Istanbul", "Istanbul" },
            { "Europe/Minsk", "Minsk" },
            { "Asia/Jerusalem", "Jerusalem" },
            { "Africa/Harare", "Harare" },
            { "Africa/Johannesburg", "Pretoria" },
            { "Europe/Moscow", "Moscow" },
            { "Europe/Moscow", "St. Petersburg" },
            { "Europe/Moscow", "Volgograd" },
            { "Asia/Kuwait", "Kuwait" },
            { "Asia/Riyadh", "Riyadh" },
            { "Africa/Nairobi", "Nairobi" },
            { "Asia/Baghdad", "Baghdad" },
            { "Asia/Tehran", "Tehran" },
            { "Asia/Muscat", "Abu Dhabi" },
            { "Asia/Muscat", "Muscat" },
            { "Asia/Baku", "Baku" },
            { "Asia/Tbilisi", "Tbilisi" },
            { "Asia/Yerevan", "Yerevan" },
            { "Asia/Kabul", "Kabul" },
            { "Asia/Yekaterinburg", "Ekaterinburg" },
            { "Asia/Karachi", "Islamabad" },
            { "Asia/Karachi", "Karachi" },
            { "Asia/Tashkent", "Tashkent" },
            { "Asia/Kolkata", "Chennai" },
            { "Asia/Kolkata", "Kolkata" },
            { "Asia/Kolkata", "Mumbai" },
            { "Asia/Kolkata", "New Delhi" },
            { "Asia/Kathmandu", "Kathmandu" },
            { "Asia/Dhaka", "Astana" },
            { "Asia/Dhaka", "Dhaka" },
            { "Asia/Colombo", "Sri Jayawardenepura" },
            { "Asia/Almaty", "Almaty" },
            { "Asia/Novosibirsk", "Novosibirsk" },
            { "Asia/Rangoon", "Rangoon" },
            { "Asia/Bangkok", "Bangkok" },
            { "Asia/Bangkok", "Hanoi" },
            { "Asia/Jakarta", "Jakarta" },
            { "Asia/Krasnoyarsk", "Krasnoyarsk" },
            { "Asia/Shanghai", "Beijing" },
            { "Asia/Chongqing", "Chongqing" },
            { "Asia/Hong_Kong", "Hong Kong" },
            { "Asia/Urumqi", "Urumqi" },
            { "Asia/Kuala_Lumpur", "Kuala Lumpur" },
            { "Asia/Singapore", "Singapore" },
            { "Asia/Taipei", "Taipei" },
            { "Australia/Perth", "Perth" },
            { "Asia/Irkutsk", "Irkutsk" },
            { "Asia/Ulaanbaatar", "Ulaanbaatar" },
            { "Asia/Seoul", "Seoul" },
            { "Asia/Tokyo", "Osaka" },
            { "Asia/Tokyo", "Sapporo" },
            { "Asia/Tokyo", "Tokyo" },
            { "Asia/Yakutsk", "Yakutsk" },
            { "Australia/Darwin", "Darwin" },
            { "Australia/Adelaide", "Adelaide" },
            { "Australia/Melbourne", "Canberra" },
            { "Australia/Melbourne", "Melbourne" },
            { "Australia/Sydney", "Sydney" },
            { "Australia/Brisbane", "Brisbane" },
            { "Australia/Hobart", "Hobart" },
            { "Asia/Vladivostok", "Vladivostok" },
            { "Pacific/Guam", "Guam" },
            { "Pacific/Port_Moresby", "Port Moresby" },
            { "Asia/Magadan", "Magadan" },
            { "Pacific/Guadalcanal", "Solomon Is." },
            { "Pacific/Noumea", "New Caledonia" },
            { "Pacific/Fiji", "Fiji" },
            { "Asia/Kamchatka", "Kamchatka" },
            { "Pacific/Majuro", "Marshall Is." },
            { "Pacific/Auckland", "Auckland" },
            { "Pacific/Auckland", "Wellington" },
            { "Pacific/Tongatapu", "Nuku'alofa" },
            { "Pacific/Fakaofo", "Tokelau Is." },
            { "Pacific/Chatham", "Chatham Is." },
            { "Pacific/Apia", "Samoa" }
        };

        public static Dictionary<string, string> ToFriendlyTimezones(this IList<TzdbZoneLocation> zoneLocations)
        {
            return ( from zone in zoneLocations
                     join map in NodaToFriendlyTimezoneMap on zone.ZoneId equals map.Key into friendly
                     from submap in friendly.DefaultIfEmpty()
                     select new {
                         key = zone.ZoneId,
                         value = ( !string.IsNullOrWhiteSpace(submap.Key) ? submap.Value : zone.ZoneId.Replace("_", " ") )
                     } ).ToDictionary(oo => oo.key, oo => oo.value);
        }

        public static Dictionary<string, string> FilterToOnlyFriendlyTimezones(this IList<TzdbZoneLocation> zoneLocations)
        {
            return ( from zone in zoneLocations
                     join map in NodaToFriendlyTimezoneMap on zone.ZoneId equals map.Key
                     select new {
                         key = zone.ZoneId,
                         value = map.Value
                     } ).ToDictionary(oo => oo.key, oo => oo.value);
        }

    }
}
