using DataAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAL.SeedData
{

    public static partial class SeedData
    {
        #region Master Seed

        //public static List<BloodGroup> BloodGroups
        //{
        //    get
        //    {
        //        List<BloodGroup> items = new List<BloodGroup>();

        //        items.Add(new BloodGroup { BloodGroupId = 1, IsPublished = true, Name = "A+" });
        //        items.Add(new BloodGroup { BloodGroupId = 2, IsPublished = true, Name = "A-" });
        //        items.Add(new BloodGroup { BloodGroupId = 3, IsPublished = true, Name = "B+" });
        //        items.Add(new BloodGroup { BloodGroupId = 4, IsPublished = true, Name = "B-" });
        //        items.Add(new BloodGroup { BloodGroupId = 5, IsPublished = true, Name = "AB+" });
        //        items.Add(new BloodGroup { BloodGroupId = 6, IsPublished = true, Name = "AB-" });
        //        items.Add(new BloodGroup { BloodGroupId = 7, IsPublished = true, Name = "0+" });
        //        items.Add(new BloodGroup { BloodGroupId = 8, IsPublished = true, Name = "0-" });
        //        return items;
        //    }
        //}

        public static List<Gender> Genders
        {
            get
            {
                List<Gender> items = new List<Gender>();
                items.Add(new Gender { GenderId = 1, IsPublished = true, Name = "পুরুষ" });
                items.Add(new Gender { GenderId = 2, IsPublished = true, Name = "মহিলা" });
                return items;
            }
        }

        //public static List<Religion> Religions
        //{
        //    get
        //    {
        //        List<Religion> items = new List<Religion>();

        //        items.Add(new Religion { ReligionId = 1, Name = "ইসলাম", IsPublished = true });
        //        items.Add(new Religion { ReligionId = 2, Name = "খ্রিষ্টান", IsPublished = true });
        //        items.Add(new Religion { ReligionId = 3, Name = "হিন্দু", IsPublished = true });
        //        items.Add(new Religion { ReligionId = 4, Name = "যীশু", IsPublished = true });
        //        items.Add(new Religion { ReligionId = 5, Name = "বৌদ্ধ", IsPublished = true });

        //        return items;
        //    }
        //}

        //public static List<MaritalStatus> MaritalStatus
        //{
        //    get
        //    {
        //        List<MaritalStatus> items = new List<MaritalStatus>();

        //        items.Add(new MaritalStatus { MaritalStatusId = 1, Name = "অবিবাহিত", IsPublished = true });
        //        items.Add(new MaritalStatus { MaritalStatusId = 2, Name = "বিবাহিত", IsPublished = true });
        //        items.Add(new MaritalStatus { MaritalStatusId = 3, Name = "তালাকপ্রাপ্ত", IsPublished = true });
        //        items.Add(new MaritalStatus { MaritalStatusId = 4, Name = "বিছিন্ন", IsPublished = true });
        //        items.Add(new MaritalStatus { MaritalStatusId = 5, Name = "বিধবা", IsPublished = true });

        //        return items;
        //    }
        //}

        public static List<Country> Countries
        {
            get
            {
                List<Country> items = new List<Country>();
                items.Add(new Country { CountryId = 1, IsPublished = true, Name = "বাংলাদেশ", CountryTicker = "BD" });
                items.Add(new Country { CountryId = 2, IsPublished = true, Name = "United Kingdom", CountryTicker = "GB" });
                items.Add(new Country { CountryId = 3, IsPublished = true, Name = "United Arab Emirates", CountryTicker = "AE" });
                items.Add(new Country { CountryId = 4, IsPublished = true, Name = "Swaziland", CountryTicker = "SZ" });
                items.Add(new Country { CountryId = 5, IsPublished = true, Name = "India", CountryTicker = "IN" });
                items.Add(new Country { CountryId = 6, IsPublished = true, Name = "France", CountryTicker = "FR" });
                items.Add(new Country { CountryId = 7, IsPublished = true, Name = "Canada", CountryTicker = "CA" });
                items.Add(new Country { CountryId = 8, IsPublished = true, Name = "Australia", CountryTicker = "AU" });
                items.Add(new Country { CountryId = 9, IsPublished = true, Name = "China", CountryTicker = "CN" });
                items.Add(new Country { CountryId = 10, IsPublished = true, Name = "Germany", CountryTicker = "DE" });
                items.Add(new Country { CountryId = 11, IsPublished = true, Name = "Austria", CountryTicker = "AT" });
                items.Add(new Country { CountryId = 12, IsPublished = true, Name = "Azerbaijan", CountryTicker = "AZ" });
                items.Add(new Country { CountryId = 13, IsPublished = true, Name = "Bahamas", CountryTicker = "BS" });
                items.Add(new Country { CountryId = 14, IsPublished = true, Name = "Bahrain", CountryTicker = "BH" });
                items.Add(new Country { CountryId = 15, IsPublished = true, Name = "United States", CountryTicker = "US" });
                items.Add(new Country { CountryId = 16, IsPublished = true, Name = "Barbados", CountryTicker = "BB" });
                items.Add(new Country { CountryId = 17, IsPublished = true, Name = "Belarus", CountryTicker = "BY" });
                items.Add(new Country { CountryId = 18, IsPublished = true, Name = "Belgium", CountryTicker = "BE" });
                items.Add(new Country { CountryId = 19, IsPublished = true, Name = "Belize", CountryTicker = "BZ" });
                items.Add(new Country { CountryId = 20, IsPublished = true, Name = "Benin", CountryTicker = "BJ" });
                items.Add(new Country { CountryId = 21, IsPublished = true, Name = "Bermuda", CountryTicker = "BM" });
                items.Add(new Country { CountryId = 22, IsPublished = true, Name = "Bhutan", CountryTicker = "BT" });
                items.Add(new Country { CountryId = 23, IsPublished = true, Name = "Bolivia", CountryTicker = "BO" });
                items.Add(new Country { CountryId = 24, IsPublished = true, Name = "Bosnia and Herzegovina", CountryTicker = "BA" });
                items.Add(new Country { CountryId = 25, IsPublished = true, Name = "Botswana", CountryTicker = "BW" });
                items.Add(new Country { CountryId = 26, IsPublished = true, Name = "Bouvet Island", CountryTicker = "BV" });
                items.Add(new Country { CountryId = 27, IsPublished = true, Name = "Brazil", CountryTicker = "BR" });
                items.Add(new Country { CountryId = 28, IsPublished = true, Name = "British Virgin Islands", CountryTicker = "VG" });
                items.Add(new Country { CountryId = 29, IsPublished = true, Name = "Brunei Darussalam", CountryTicker = "BN" });
                items.Add(new Country { CountryId = 30, IsPublished = true, Name = "Bulgaria", CountryTicker = "BG" });
                items.Add(new Country { CountryId = 31, IsPublished = true, Name = "Burkina Faso", CountryTicker = "BF" });
                items.Add(new Country { CountryId = 32, IsPublished = true, Name = "Burundi", CountryTicker = "BI" });
                items.Add(new Country { CountryId = 33, IsPublished = true, Name = "Cambodia", CountryTicker = "KH" });
                items.Add(new Country { CountryId = 34, IsPublished = true, Name = "Cameroon", CountryTicker = "CM" });
                items.Add(new Country { CountryId = 35, IsPublished = true, Name = "Cape Verde", CountryTicker = "CV" });
                items.Add(new Country { CountryId = 36, IsPublished = true, Name = "Cayman Islands", CountryTicker = "KY" });
                items.Add(new Country { CountryId = 37, IsPublished = true, Name = "Central African Republic", CountryTicker = "CF" });
                items.Add(new Country { CountryId = 38, IsPublished = true, Name = "Chad", CountryTicker = "TD" });
                items.Add(new Country { CountryId = 39, IsPublished = true, Name = "Chile", CountryTicker = "CL" });
                items.Add(new Country { CountryId = 40, IsPublished = true, Name = "Colombia", CountryTicker = "CO" });
                items.Add(new Country { CountryId = 41, IsPublished = true, Name = "Comoros", CountryTicker = "KM" });
                items.Add(new Country { CountryId = 42, IsPublished = true, Name = "Congo", CountryTicker = "CG" });
                items.Add(new Country { CountryId = 43, IsPublished = true, Name = "Cook Islands", CountryTicker = "CK" });
                items.Add(new Country { CountryId = 44, IsPublished = true, Name = "Costa Rica", CountryTicker = "CR" });
                items.Add(new Country { CountryId = 45, IsPublished = true, Name = "Cote d'Ivoire", CountryTicker = "CI" });
                items.Add(new Country { CountryId = 46, IsPublished = true, Name = "Croatia", CountryTicker = "HR" });
                items.Add(new Country { CountryId = 47, IsPublished = true, Name = "Cuba", CountryTicker = "CU" });
                items.Add(new Country { CountryId = 48, IsPublished = true, Name = "Cyprus", CountryTicker = "CY" });
                items.Add(new Country { CountryId = 49, IsPublished = true, Name = "Czech Republic", CountryTicker = "CZ" });
                items.Add(new Country { CountryId = 50, IsPublished = true, Name = "Denmark", CountryTicker = "DK" });
                items.Add(new Country { CountryId = 51, IsPublished = true, Name = "Djibouti", CountryTicker = "DJ" });
                items.Add(new Country { CountryId = 52, IsPublished = true, Name = "Dominica", CountryTicker = "DM" });
                items.Add(new Country { CountryId = 53, IsPublished = true, Name = "Dominican Republic", CountryTicker = "DO" });
                items.Add(new Country { CountryId = 54, IsPublished = true, Name = "East Timor", CountryTicker = "TL" });
                items.Add(new Country { CountryId = 55, IsPublished = true, Name = "Ecuador", CountryTicker = "EC" });
                items.Add(new Country { CountryId = 56, IsPublished = true, Name = "Egypt", CountryTicker = "EG" });
                items.Add(new Country { CountryId = 57, IsPublished = true, Name = "El Salvador", CountryTicker = "SV" });
                items.Add(new Country { CountryId = 58, IsPublished = true, Name = "Equatorial Guinea", CountryTicker = "GQ" });
                items.Add(new Country { CountryId = 59, IsPublished = true, Name = "Eritrea", CountryTicker = "ER" });
                items.Add(new Country { CountryId = 60, IsPublished = true, Name = "Estonia", CountryTicker = "EE" });
                items.Add(new Country { CountryId = 61, IsPublished = true, Name = "Ethiopia", CountryTicker = "ET" });
                items.Add(new Country { CountryId = 62, IsPublished = true, Name = "Europe	Kosovo", CountryTicker = "EKV" });
                items.Add(new Country { CountryId = 63, IsPublished = true, Name = "Faeroe Islands", CountryTicker = "FO" });
                items.Add(new Country { CountryId = 64, IsPublished = true, Name = "Fiji", CountryTicker = "FJ" });
                items.Add(new Country { CountryId = 65, IsPublished = true, Name = "Finland", CountryTicker = "FI" });
                items.Add(new Country { CountryId = 66, IsPublished = true, Name = "France Metropolitan", CountryTicker = "FX" });
                items.Add(new Country { CountryId = 67, IsPublished = true, Name = "French Guiana", CountryTicker = "GF" });
                items.Add(new Country { CountryId = 68, IsPublished = true, Name = "French Polynesia", CountryTicker = "PF" });
                items.Add(new Country { CountryId = 69, IsPublished = true, Name = "Gabon", CountryTicker = "GA" });
                items.Add(new Country { CountryId = 70, IsPublished = true, Name = "Gambia", CountryTicker = "GM" });
                items.Add(new Country { CountryId = 71, IsPublished = true, Name = "Haiti", CountryTicker = "HT" });
                items.Add(new Country { CountryId = 72, IsPublished = true, Name = "Honduras", CountryTicker = "HN" });
                items.Add(new Country { CountryId = 73, IsPublished = true, Name = "Hong Kong", CountryTicker = "HK" });
                items.Add(new Country { CountryId = 74, IsPublished = true, Name = "Hungary", CountryTicker = "HU" });
                items.Add(new Country { CountryId = 75, IsPublished = true, Name = "Iceland", CountryTicker = "IS" });
                items.Add(new Country { CountryId = 76, IsPublished = true, Name = "Indonesia", CountryTicker = "ID" });
                items.Add(new Country { CountryId = 77, IsPublished = true, Name = "Iran", CountryTicker = "IR" });
                items.Add(new Country { CountryId = 78, IsPublished = true, Name = "Iraq", CountryTicker = "IQ" });
                items.Add(new Country { CountryId = 79, IsPublished = true, Name = "Ireland", CountryTicker = "IE" });
                items.Add(new Country { CountryId = 80, IsPublished = true, Name = "Israel", CountryTicker = "IL" });
                items.Add(new Country { CountryId = 81, IsPublished = true, Name = "Italy", CountryTicker = "IT" });
                items.Add(new Country { CountryId = 82, IsPublished = true, Name = "Jamaica", CountryTicker = "JM" });
                items.Add(new Country { CountryId = 83, IsPublished = true, Name = "Japan", CountryTicker = "JP" });
                items.Add(new Country { CountryId = 84, IsPublished = true, Name = "Jordan", CountryTicker = "JO" });
                items.Add(new Country { CountryId = 85, IsPublished = true, Name = "Kazakhstan", CountryTicker = "KZ" });
                items.Add(new Country { CountryId = 86, IsPublished = true, Name = "Kenya", CountryTicker = "KE" });
                items.Add(new Country { CountryId = 87, IsPublished = true, Name = "Kiribati", CountryTicker = "KI" });
                items.Add(new Country { CountryId = 88, IsPublished = true, Name = "Kuwait", CountryTicker = "KW" });
                items.Add(new Country { CountryId = 89, IsPublished = true, Name = "Kyrgyzstan", CountryTicker = "KG" });
                items.Add(new Country { CountryId = 90, IsPublished = true, Name = "Laos", CountryTicker = "LO" });
                items.Add(new Country { CountryId = 91, IsPublished = true, Name = "Latvia", CountryTicker = "LV" });
                items.Add(new Country { CountryId = 92, IsPublished = true, Name = "Lebanon", CountryTicker = "LB" });
                items.Add(new Country { CountryId = 93, IsPublished = true, Name = "Lesotho", CountryTicker = "LS" });
                items.Add(new Country { CountryId = 94, IsPublished = true, Name = "Liberia", CountryTicker = "LR" });
                items.Add(new Country { CountryId = 95, IsPublished = true, Name = "Libya", CountryTicker = "LY" });
                items.Add(new Country { CountryId = 96, IsPublished = true, Name = "Liechtenstein", CountryTicker = "LI" });
                items.Add(new Country { CountryId = 97, IsPublished = true, Name = "Lithuania", CountryTicker = "LT" });
                items.Add(new Country { CountryId = 98, IsPublished = true, Name = "Luxembourg", CountryTicker = "LU" });
                items.Add(new Country { CountryId = 99, IsPublished = true, Name = "Macao", CountryTicker = "MO" });
                items.Add(new Country { CountryId = 100, IsPublished = true, Name = "Macedonia", CountryTicker = "MK" });
                items.Add(new Country { CountryId = 101, IsPublished = true, Name = "Madagascar", CountryTicker = "MG" });
                items.Add(new Country { CountryId = 102, IsPublished = true, Name = "Malawi", CountryTicker = "MW" });
                items.Add(new Country { CountryId = 103, IsPublished = true, Name = "Malaysia", CountryTicker = "MY" });
                items.Add(new Country { CountryId = 104, IsPublished = true, Name = "Maldives", CountryTicker = "MV" });
                items.Add(new Country { CountryId = 105, IsPublished = true, Name = "Mali", CountryTicker = "ML" });
                items.Add(new Country { CountryId = 106, IsPublished = true, Name = "Malta", CountryTicker = "MT" });
                items.Add(new Country { CountryId = 107, IsPublished = true, Name = "Marshall Islands", CountryTicker = "MH" });
                items.Add(new Country { CountryId = 108, IsPublished = true, Name = "Martinique", CountryTicker = "MQ" });
                items.Add(new Country { CountryId = 109, IsPublished = true, Name = "Mauritania", CountryTicker = "MR" });
                items.Add(new Country { CountryId = 110, IsPublished = true, Name = "Mauritius", CountryTicker = "MU" });
                items.Add(new Country { CountryId = 111, IsPublished = true, Name = "Mayotte", CountryTicker = "YT" });
                items.Add(new Country { CountryId = 112, IsPublished = true, Name = "Mexico", CountryTicker = "MX" });
                items.Add(new Country { CountryId = 113, IsPublished = true, Name = "Micronesia", CountryTicker = "FM" });
                items.Add(new Country { CountryId = 114, IsPublished = true, Name = "Moldova", CountryTicker = "MD" });
                items.Add(new Country { CountryId = 115, IsPublished = true, Name = "Monaco", CountryTicker = "MC" });
                items.Add(new Country { CountryId = 116, IsPublished = true, Name = "Mongolia", CountryTicker = "MN" });
                items.Add(new Country { CountryId = 117, IsPublished = true, Name = "Montenegro", CountryTicker = "ME" });
                items.Add(new Country { CountryId = 118, IsPublished = true, Name = "Montserrat", CountryTicker = "MS" });
                items.Add(new Country { CountryId = 119, IsPublished = true, Name = "Morocco", CountryTicker = "MA" });
                items.Add(new Country { CountryId = 120, IsPublished = true, Name = "Mozambique", CountryTicker = "MZ" });
                items.Add(new Country { CountryId = 121, IsPublished = true, Name = "Myanmar", CountryTicker = "MM" });
                items.Add(new Country { CountryId = 122, IsPublished = true, Name = "Namibia", CountryTicker = "NA" });
                items.Add(new Country { CountryId = 123, IsPublished = true, Name = "Nauru", CountryTicker = "NR" });
                items.Add(new Country { CountryId = 124, IsPublished = true, Name = "Nepal", CountryTicker = "NP" });
                items.Add(new Country { CountryId = 125, IsPublished = true, Name = "Netherlands", CountryTicker = "NL" });
                items.Add(new Country { CountryId = 126, IsPublished = true, Name = "Netherlands Antilles", CountryTicker = "AN" });
                items.Add(new Country { CountryId = 127, IsPublished = true, Name = "New Caledonia", CountryTicker = "NC" });
                items.Add(new Country { CountryId = 128, IsPublished = true, Name = "New Zealand", CountryTicker = "NZ" });
                items.Add(new Country { CountryId = 129, IsPublished = true, Name = "Nicaragua", CountryTicker = "NI" });
                items.Add(new Country { CountryId = 130, IsPublished = true, Name = "Niger", CountryTicker = "NE" });
                items.Add(new Country { CountryId = 131, IsPublished = true, Name = "Nigeria", CountryTicker = "NG" });
                items.Add(new Country { CountryId = 132, IsPublished = true, Name = "Niue", CountryTicker = "NU" });
                items.Add(new Country { CountryId = 133, IsPublished = true, Name = "Norfolk Island", CountryTicker = "NF" });
                items.Add(new Country { CountryId = 134, IsPublished = true, Name = "North Korea", CountryTicker = "KP" });
                items.Add(new Country { CountryId = 135, IsPublished = true, Name = "Northern Mariana Islands", CountryTicker = "MP" });
                items.Add(new Country { CountryId = 136, IsPublished = true, Name = "Portugal", CountryTicker = "PT" });
                items.Add(new Country { CountryId = 137, IsPublished = true, Name = "Puerto Rico", CountryTicker = "PR" });
                items.Add(new Country { CountryId = 138, IsPublished = true, Name = "Qatar", CountryTicker = "QA" });
                items.Add(new Country { CountryId = 139, IsPublished = true, Name = "Republic of Georgia", CountryTicker = "GEO" });
                items.Add(new Country { CountryId = 140, IsPublished = true, Name = "Reunion", CountryTicker = "RE" });
                items.Add(new Country { CountryId = 141, IsPublished = true, Name = "Romania", CountryTicker = "RO" });
                items.Add(new Country { CountryId = 142, IsPublished = true, Name = "Russia", CountryTicker = "RU" });
                items.Add(new Country { CountryId = 143, IsPublished = true, Name = "Rwanda", CountryTicker = "RW" });
                items.Add(new Country { CountryId = 144, IsPublished = true, Name = "Samoa", CountryTicker = "WS" });
                items.Add(new Country { CountryId = 145, IsPublished = true, Name = "San Marino", CountryTicker = "SM" });
                items.Add(new Country { CountryId = 146, IsPublished = true, Name = "Saudi Arabia", CountryTicker = "SA" });
                items.Add(new Country { CountryId = 147, IsPublished = true, Name = "Senegal", CountryTicker = "SN" });
                items.Add(new Country { CountryId = 148, IsPublished = true, Name = "Serbia", CountryTicker = "RS" });
                items.Add(new Country { CountryId = 149, IsPublished = true, Name = "Seychelles", CountryTicker = "SC" });
                items.Add(new Country { CountryId = 150, IsPublished = true, Name = "Sierra Leone", CountryTicker = "SL" });
                items.Add(new Country { CountryId = 151, IsPublished = true, Name = "Singapore", CountryTicker = "SG" });
                items.Add(new Country { CountryId = 152, IsPublished = true, Name = "Slovakia", CountryTicker = "SK" });
                items.Add(new Country { CountryId = 153, IsPublished = true, Name = "Slovenia", CountryTicker = "SI" });
                items.Add(new Country { CountryId = 154, IsPublished = true, Name = "Solomon Islands", CountryTicker = "SB" });
                items.Add(new Country { CountryId = 155, IsPublished = true, Name = "Somalia", CountryTicker = "SO" });
                items.Add(new Country { CountryId = 156, IsPublished = true, Name = "South Africa", CountryTicker = "ZA" });
                items.Add(new Country { CountryId = 157, IsPublished = true, Name = "South Georgia", CountryTicker = "GS" });
                items.Add(new Country { CountryId = 158, IsPublished = true, Name = "South Korea", CountryTicker = "KR" });
                items.Add(new Country { CountryId = 159, IsPublished = true, Name = "Spain", CountryTicker = "ES" });
                items.Add(new Country { CountryId = 160, IsPublished = true, Name = "Sri Lanka", CountryTicker = "LK" });
                items.Add(new Country { CountryId = 161, IsPublished = true, Name = "St. Helena", CountryTicker = "SH" });
                items.Add(new Country { CountryId = 162, IsPublished = true, Name = "St. Kitts and Nevis", CountryTicker = "KN" });
                items.Add(new Country { CountryId = 163, IsPublished = true, Name = "St. Lucia", CountryTicker = "LC" });
                items.Add(new Country { CountryId = 164, IsPublished = true, Name = "Sudan", CountryTicker = "SD" });
                items.Add(new Country { CountryId = 165, IsPublished = true, Name = "Suriname", CountryTicker = "SR" });
                items.Add(new Country { CountryId = 166, IsPublished = true, Name = "Sweden", CountryTicker = "SE" });
                items.Add(new Country { CountryId = 167, IsPublished = true, Name = "Switzerland", CountryTicker = "CH" });
                items.Add(new Country { CountryId = 168, IsPublished = true, Name = "Syria", CountryTicker = "SY" });
                items.Add(new Country { CountryId = 169, IsPublished = true, Name = "Taiwan", CountryTicker = "TW" });
                items.Add(new Country { CountryId = 170, IsPublished = true, Name = "Tajikistan", CountryTicker = "TJ" });
                items.Add(new Country { CountryId = 171, IsPublished = true, Name = "Tanzania", CountryTicker = "TZ" });
                items.Add(new Country { CountryId = 172, IsPublished = true, Name = "Thailand", CountryTicker = "TH" });
                items.Add(new Country { CountryId = 173, IsPublished = true, Name = "Togo", CountryTicker = "TG" });
                items.Add(new Country { CountryId = 174, IsPublished = true, Name = "Tokelau", CountryTicker = "TK" });
                items.Add(new Country { CountryId = 175, IsPublished = true, Name = "Tonga", CountryTicker = "TO" });
                items.Add(new Country { CountryId = 176, IsPublished = true, Name = "Trinidad and Tobago", CountryTicker = "TT" });
                items.Add(new Country { CountryId = 177, IsPublished = true, Name = "Tunisia", CountryTicker = "TN" });
                items.Add(new Country { CountryId = 178, IsPublished = true, Name = "Turkey", CountryTicker = "TR" });
                items.Add(new Country { CountryId = 179, IsPublished = true, Name = "Turkmenistan", CountryTicker = "TM" });
                items.Add(new Country { CountryId = 180, IsPublished = true, Name = "Tuvalu", CountryTicker = "TV" });
                items.Add(new Country { CountryId = 181, IsPublished = true, Name = "U.S. Virgin Islands", CountryTicker = "VI" });
                items.Add(new Country { CountryId = 182, IsPublished = true, Name = "Uganda", CountryTicker = "UG" });
                items.Add(new Country { CountryId = 183, IsPublished = true, Name = "Ukraine", CountryTicker = "UA" });
                items.Add(new Country { CountryId = 184, IsPublished = true, Name = "Uruguay", CountryTicker = "UY" });
                items.Add(new Country { CountryId = 185, IsPublished = true, Name = "Uzbekistan", CountryTicker = "UZ" });
                items.Add(new Country { CountryId = 186, IsPublished = true, Name = "Vanuatu", CountryTicker = "VU" });
                items.Add(new Country { CountryId = 187, IsPublished = true, Name = "Vatican City", CountryTicker = "VA" });
                items.Add(new Country { CountryId = 188, IsPublished = true, Name = "Venezuela", CountryTicker = "VE" });
                items.Add(new Country { CountryId = 189, IsPublished = true, Name = "Vietnam", CountryTicker = "VN" });
                items.Add(new Country { CountryId = 190, IsPublished = true, Name = "Western Sahara", CountryTicker = "EH" });
                items.Add(new Country { CountryId = 191, IsPublished = true, Name = "Yemen", CountryTicker = "YE" });
                items.Add(new Country { CountryId = 192, IsPublished = true, Name = "Yugoslavia", CountryTicker = "YU" });
                items.Add(new Country { CountryId = 193, IsPublished = true, Name = "Zambia", CountryTicker = "ZM" });
                items.Add(new Country { CountryId = 194, IsPublished = true, Name = "Zimbabwe", CountryTicker = "ZW" });
                items.Add(new Country { CountryId = 195, IsPublished = true, Name = "Philippines", CountryTicker = "PH" });

                return items;
            }

        }

        //Division
        public static List<State> States
        {
            get
            {
                List<State> items = new List<State>();
                items.Add(new State { StateId = 1, Name = "বরিশাল", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 2, Name = "চট্টগ্রাম", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 3, Name = "ঢাকা", CountryId = 1, IsPublished = true, IsDefault = true });
                items.Add(new State { StateId = 4, Name = "খুলনা", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 5, Name = "রাজশাহী", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 6, Name = "রংপুর", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 7, Name = "সিলেট", CountryId = 1, IsPublished = true });
                items.Add(new State { StateId = 8, Name = "ময়মনসিংহ", CountryId = 1, IsPublished = true });
                return items;
            }
        }

        //District
        public static List<City> Cities
        {
            get
            {
                List<City> items = new List<City>();

                items.Add(new City { CityId = 1, Name = "বরিশাল", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 2, Name = "বরগুনা", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 3, Name = "ভোলা", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 4, Name = "ঝালকাঠি", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 5, Name = "পটুয়াখালী", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 6, Name = "পিরোজপুর", StateId = 1, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 7, Name = "বান্দরবান", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 8, Name = "ব্রাহ্মণবাড়ীয়া", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 9, Name = "চাঁদপুর", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 10, Name = "চট্টগ্রাম", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 11, Name = "কুমিল্লা", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 12, Name = "কক্সবাজার", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 13, Name = "ফেনী", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 14, Name = "খাগড়াছড়ি", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 15, Name = "লক্ষীপুর", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 16, Name = "নোয়াখালী", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 17, Name = "রাঙ্গামাটি", StateId = 2, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 18, Name = "ঢাকা", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 19, Name = "ফরিদপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 20, Name = "গাজীপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 21, Name = "গোপালগঞ্জ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 22, Name = "কিশোরগঞ্জ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 23, Name = "মাদারীপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 24, Name = "মানিকগঞ্জ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 25, Name = "মুন্সীগঞ্জ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 26, Name = "নারায়ণগঞ্জ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 27, Name = "নরসিংদী", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 28, Name = "রাজবাড়ী", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 29, Name = "শরীয়তপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 30, Name = "টাঙ্গাইল", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 31, Name = "বাগেরহাট", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 32, Name = "চুয়াডাঙ্গা", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 33, Name = "যশোর", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 34, Name = "ঝিনাইদহ", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 35, Name = "খুলনা", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 36, Name = "কুষ্টিয়া", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 37, Name = "মাগুরা", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 38, Name = "মেহেরপুর", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 39, Name = "নড়াইল", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 40, Name = "সাতক্ষিরা", StateId = 4, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 41, Name = "জামালপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 42, Name = "ময়মনসিংহ", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 43, Name = "নেত্রকোনা", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 44, Name = "শেরপুর", StateId = 3, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 45, Name = "বগুড়া", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 46, Name = "জয়পুরহাট", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 47, Name = "নওগাঁ", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 48, Name = "নাটোর", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 49, Name = "নওয়াবগঞ্জ", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 50, Name = "পাবনা", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 51, Name = "রাজশাহী", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 52, Name = "সিরাজগঞ্জ", StateId = 5, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 53, Name = "দিনাজপুর", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 54, Name = "গাইবান্ধা", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 55, Name = "কুড়িগ্রাম", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 56, Name = "লালমনিরহাট", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 57, Name = "নীলফামারী", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 58, Name = "পঞ্চগড়", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 59, Name = "রংপুর", StateId = 6, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 60, Name = "ঠাকুরগাঁও", StateId = 7, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 61, Name = "হবিগঞ্জ", StateId = 7, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 62, Name = "মৌলভীবাজার", StateId = 7, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 63, Name = "সুনামগঞ্জ", StateId = 7, CountryId = 1, IsPublished = true });
                items.Add(new City { CityId = 64, Name = "সিলেট", StateId = 7, CountryId = 1, IsPublished = true });

                return items;
            }
        }

        #endregion


        //public static List<Role> Roles
        //{
        //    get
        //    {
        //        List<Role> items = new List<Role>();
        //        items.Add(new Role { RoleId = 1, RoleName = "Admin", IsPublished = true, CreatedByUserId = 1, CreatedDate = DateTime.Now, ModifiedById = 1, ModificationDate = DateTime.Now });
        //        items.Add(new Role { RoleId = 2, RoleName = "User", IsPublished = true, CreatedByUserId = 1, CreatedDate = DateTime.Now, ModifiedById = 1, ModificationDate = DateTime.Now });
        //        //items.Add(new Role { RoleId = 4, RoleName = "Authority", IsPublished = true, CreatedByUserId = 1, CreatedDate = DateTime.Now, ModifiedById = 1, ModificationDate = DateTime.Now });
        //        return items;
        //    }
        //}

        //public static List<Office> Offices
        //{
        //    get
        //    {
        //        List<Office> items = new List<Office>();
        //        items.Add(new Office { OfficeId = 1, Name = "মৎস্য ও প্রাণিসম্পদ মন্ত্রণালয়", Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/logo.png", IsPublished = true, LiveUrl = "http://www.mofl.gov.bd", IsCurrentOffice = true, CreatedByUserId = 1, ModifiedById = 1, CreatedDate = DateTime.Now, ModificationDate = DateTime.Now, Address = string.Empty });
        //        return items;
        //    }
        //}

        public static List<ApplicationUser> Users
        {
            get
            {
                List<ApplicationUser> items = new List<ApplicationUser>();
                items.Add(new ApplicationUser { Name = "Elias Hossain", IsPublished = true, CreatedByUserId = 1, ModifiedById = 1, CreatedDate = DateTime.Now, ModificationDate = DateTime.Now, LastLoginDate = DateTime.Now });
                //items.Add(new User { UserId = 2, Name = "Pds Admin", EmailAddress = "pds@mofl.gov.bd", Password = "12345678", IsActive = true, CreatedByUserId = 1, ModifiedById = 1, CreatedDate = DateTime.Now, ModificationDate = DateTime.Now, LastLoginDate = DateTime.Now });
                return items;
            }
        }

        public static List<Designation> Designations
        {
            get
            {
                List<Designation> items = new List<Designation>();
                items.Add(new Designation { DesignationId = 1, Name = "সচিব", IsPublished = true, Order = 1 });
                items.Add(new Designation { DesignationId = 2, Name = "অতিরিক্ত সচিব", IsPublished = true, Order = 2 });
                items.Add(new Designation { DesignationId = 3, Name = "যুগ্ম সচিব", IsPublished = true, Order = 3 });
                items.Add(new Designation { DesignationId = 4, Name = "উপসচিব", IsPublished = true, Order = 4 });
                items.Add(new Designation { DesignationId = 5, Name = "সিস্টেম এনালিস্ট", IsPublished = true, Order = 5 });
                items.Add(new Designation { DesignationId = 6, Name = "সিনিয়র সহকারি সচিব", IsPublished = true, Order = 6 });
                items.Add(new Designation { DesignationId = 7, Name = "প্রোগ্রামার", IsPublished = true, Order = 7 });
                items.Add(new Designation { DesignationId = 8, Name = "সহকারি সচিব", IsPublished = true, Order = 8 });
                items.Add(new Designation { DesignationId = 9, Name = "সহকারি প্রোগ্রামার", IsPublished = true, Order = 9 });
                items.Add(new Designation { DesignationId = 10, Name = "হিসাব রক্ষণ কর্মকর্তা", IsPublished = true, Order = 10 });
                return items;
            }
        }

        #region Application / App / Portal Related

        public static List<Section> Sections
        {
            get
            {
                List<Section> items = new List<Section>();

                items.Add(new Section { SectionId = 1, Name = "মন্ত্রীর দপ্তর", IsPublished = true, Order = 1 });
                items.Add(new Section { SectionId = 2, Name = "প্রতিমন্ত্রীর দপ্তর", IsPublished = true, Order = 2 });
                items.Add(new Section { SectionId = 3, Name = "সচিবের দপ্তর", IsPublished = true, Order = 3 });
                items.Add(new Section { SectionId = 4, Name = "অতিরিক্ত সচিব (অধিগ্রহণ)", IsPublished = true, Order = 4 });
                items.Add(new Section { SectionId = 5, Name = "অতিরিক্ত সচিব (আইন-১)", IsPublished = true, Order = 5 });
                items.Add(new Section { SectionId = 6, Name = "অতিরিক্ত সচিব (উন্নয়ন)", IsPublished = true, Order = 6 });
                items.Add(new Section { SectionId = 7, Name = "অতিরিক্ত সচিব (জরিপ)", IsPublished = true, Order = 7 });
                items.Add(new Section { SectionId = 8, Name = "অতিরিক্ত সচিব (আইন-২)", IsPublished = true, Order = 8 });
                items.Add(new Section { SectionId = 9, Name = "অতিরিক্ত সচিব (সায়রাত)", IsPublished = true, Order = 9 });
                items.Add(new Section { SectionId = 10, Name = "অতিরিক্ত সচিব (মাঠ প্রশাসন)", IsPublished = true, Order = 10 });
                items.Add(new Section { SectionId = 11, Name = "অতিরিক্ত সচিব (বাজেট ও অডিট)", IsPublished = true, Order = 11 });
                items.Add(new Section { SectionId = 12, Name = "যুগ্মসচিব (প্রশাসন)", IsPublished = true, Order = 12 });
                items.Add(new Section { SectionId = 13, Name = "যুগ্মসচিব (অধিগ্রহণ-১)", IsPublished = true, Order = 13 });
                items.Add(new Section { SectionId = 14, Name = "যুগ্মসচিব (আইন-১)", IsPublished = true, Order = 14 });
                items.Add(new Section { SectionId = 15, Name = "যুগ্মসচিব (সায়রাত)", IsPublished = true, Order = 15 });
                items.Add(new Section { SectionId = 16, Name = "যুগ্মসচিব (জরিপ-২)", IsPublished = true, Order = 16 });
                items.Add(new Section { SectionId = 17, Name = "যুগ্মসচিব (খাসজমি-২)", IsPublished = true, Order = 17 });
                items.Add(new Section { SectionId = 18, Name = "যুগ্মসচিব (কাউন্সিল ও সমন্বয়)", IsPublished = true, Order = 18 });
                items.Add(new Section { SectionId = 19, Name = "উপসচিব (আইন-১)", IsPublished = true, Order = 19 });
                items.Add(new Section { SectionId = 20, Name = "উপসচিব (আইন-২)", IsPublished = true, Order = 20 });
                items.Add(new Section { SectionId = 21, Name = "উপসচিব (আইন-৩)", IsPublished = true, Order = 21 });
                items.Add(new Section { SectionId = 22, Name = "উপসচিব (আইন-৪)", IsPublished = true, Order = 22 });
                items.Add(new Section { SectionId = 23, Name = "উপসচিব (প্রশাসন-১)", IsPublished = true, Order = 23 });
                items.Add(new Section { SectionId = 24, Name = "উপসচিব (প্রশিক্ষণ ও শৃঙ্খল)", IsPublished = true, Order = 24 });
                items.Add(new Section { SectionId = 25, Name = "উপসচিব (প্রশাসন-২)", IsPublished = true, Order = 25 });
                items.Add(new Section { SectionId = 26, Name = "উপসচিব (অধিগ্রহণ-১)", IsPublished = true, Order = 26 });
                items.Add(new Section { SectionId = 27, Name = "উপসচিব (সায়রাত-১)", IsPublished = true, Order = 27 });
                items.Add(new Section { SectionId = 28, Name = "উপসচিব (খসজমি-২)", IsPublished = true, Order = 28 });
                items.Add(new Section { SectionId = 29, Name = "উপপ্রধান", IsPublished = true, Order = 29 });
                items.Add(new Section { SectionId = 30, Name = "সিনিয়র সহকারী সচিব (খাসজমি-১)", IsPublished = true, Order = 30 });
                items.Add(new Section { SectionId = 31, Name = "হিসাব রক্ষণ কর্মকর্তা", IsPublished = true, Order = 31 });
                items.Add(new Section { SectionId = 32, Name = "সিনিয়র সহকারী সচিব (জরিপ-১)", IsPublished = true, Order = 32 });
                items.Add(new Section { SectionId = 33, Name = "আইসিটি", IsPublished = true, Order = 33 });
                items.Add(new Section { SectionId = 34, Name = "প্লানিং-১", IsPublished = true, Order = 34 });
                items.Add(new Section { SectionId = 35, Name = "প্লানিং-২", IsPublished = true, Order = 35 });
                items.Add(new Section { SectionId = 36, Name = "প্লানিং-৩", IsPublished = true, Order = 36 });
                items.Add(new Section { SectionId = 37, Name = "প্লানিং-৪", IsPublished = true, Order = 37 });
                items.Add(new Section { SectionId = 38, Name = "সহকারী সচিব (সায়রাত-২)", IsPublished = true, Order = 38 });
                items.Add(new Section { SectionId = 39, Name = "সহকারী সচিব (অধিগ্রহণ-২)", IsPublished = true, Order = 39 });
                items.Add(new Section { SectionId = 40, Name = "সহকারী সচিব (বাজেট ও অডিট)", IsPublished = true, Order = 40 });
                return items;
            }
        }

        //public static List<SalaryGrade> SalaryGrades
        //{
        //    get
        //    {
        //        List<SalaryGrade> items = new List<SalaryGrade>();

        //        items.Add(new SalaryGrade { SalaryGradeId = 1, Name = "গ্রেড-১", IsPublished = true, Order = 1 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 2, Name = "গ্রেড-২", IsPublished = true, Order = 2 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 3, Name = "গ্রেড-৩", IsPublished = true, Order = 3 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 4, Name = "গ্রেড-৪", IsPublished = true, Order = 4 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 5, Name = "গ্রেড-৫", IsPublished = true, Order = 5 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 6, Name = "গ্রেড-৬", IsPublished = true, Order = 6 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 7, Name = "গ্রেড-৭", IsPublished = true, Order = 7 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 8, Name = "গ্রেড-৮", IsPublished = true, Order = 8 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 9, Name = "গ্রেড-৯", IsPublished = true, Order = 9 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 10, Name = "গ্রেড-১০", IsPublished = true, Order = 10 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 11, Name = "গ্রেড-১১", IsPublished = true, Order = 11 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 12, Name = "গ্রেড-১২", IsPublished = true, Order = 12 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 13, Name = "গ্রেড-১৩", IsPublished = true, Order = 13 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 14, Name = "গ্রেড-১৪", IsPublished = true, Order = 14 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 15, Name = "গ্রেড-১৫", IsPublished = true, Order = 15 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 16, Name = "গ্রেড-১৬", IsPublished = true, Order = 16 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 17, Name = "গ্রেড-১৭", IsPublished = true, Order = 17 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 18, Name = "গ্রেড-১৮", IsPublished = true, Order = 18 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 19, Name = "গ্রেড-১৯", IsPublished = true, Order = 19 });
        //        items.Add(new SalaryGrade { SalaryGradeId = 20, Name = "গ্রেড-২০", IsPublished = true, Order = 20 });
        //        return items;
        //    }
        //}

        //public static List<DivisionOrClass> DivisionOrClasss
        //{
        //    get
        //    {
        //        List<DivisionOrClass> items = new List<DivisionOrClass>();

        //        items.Add(new DivisionOrClass { DivisionOrClassId = 1, Name = "প্রথম", Order = 1, IsPublished = true });
        //        items.Add(new DivisionOrClass { DivisionOrClassId = 2, Name = "দ্বিতীয়", Order = 2, IsPublished = true });
        //        items.Add(new DivisionOrClass { DivisionOrClassId = 3, Name = "তৃতীয়", Order = 3, IsPublished = true });
        //        items.Add(new DivisionOrClass { DivisionOrClassId = 4, Name = "চতুর্থ", Order = 4, IsPublished = true });
        //        return items;
        //    }
        //}

        //public static List<Language> Languages
        //{
        //    get
        //    {
        //        List<Language> items = new List<Language>();

        //        items.Add(new Language { LanguageId = 1, Name = "বাংলা", Order = 1, IsPublished = true });
        //        items.Add(new Language { LanguageId = 2, Name = "ইংরেজি", Order = 2, IsPublished = true });
        //        items.Add(new Language { LanguageId = 3, Name = "হিন্দি", Order = 3, IsPublished = true });
        //        items.Add(new Language { LanguageId = 4, Name = "আরবি", Order = 4, IsPublished = true });
        //        items.Add(new Language { LanguageId = 5, Name = "উর্দু", Order = 5, IsPublished = true });
        //        return items;
        //    }
        //}

        public static List<Degree> Degrees
        {
            get
            {
                List<Degree> items = new List<Degree>();

                items.Add(new Degree { DegreeId = 1, Name = "পঞ্চম শ্রেনী ", IsPublished = true });
                items.Add(new Degree { DegreeId = 2, Name = "অষ্টম শ্রেনী ", IsPublished = true });
                items.Add(new Degree { DegreeId = 3, Name = "এস এস সি", IsPublished = true });
                items.Add(new Degree { DegreeId = 4, Name = "এ লেভেল", IsPublished = true });
                items.Add(new Degree { DegreeId = 5, Name = "ডিপ্লোমা ", IsPublished = true });
                items.Add(new Degree { DegreeId = 6, Name = "এইচ এস সি", IsPublished = true });
                items.Add(new Degree { DegreeId = 7, Name = "ও লেভেল", IsPublished = true });
                items.Add(new Degree { DegreeId = 8, Name = "স্নাতক / অনার্স", IsPublished = true });
                items.Add(new Degree { DegreeId = 9, Name = "স্নাতকোত্তর", IsPublished = true });
                return items;
            }
        }

        public static List<Office> Offices
        {
            get
            {
                List<Office> items = new List<Office>();
                items.Add(new Office { OfficeId = 1, IsCurrentOffice = true, LiveUrl = "https://www.mofl.gov.bd", ParentOfficeId = null, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 1, Name = "মৎস্য ও প্রাণিসম্পদ মন্ত্রণালয়", IsPublished = true });
                items.Add(new Office { OfficeId = 2, IsCurrentOffice = true, LiveUrl = "https://www.fisheries.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 2, Name = "মৎস্য অধিদপ্তর", IsPublished = true });
                items.Add(new Office { OfficeId = 3, IsCurrentOffice = true, LiveUrl = "https://www.dls.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 3, Name = "প্রাণিসম্পদ অধিদপ্তর", IsPublished = true });
                items.Add(new Office { OfficeId = 4, IsCurrentOffice = true, LiveUrl = "https://www.fri.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 4, Name = "বাংলাদেশ মৎস্য গবেষণা ইন্সটিটিউট", IsPublished = true });
                items.Add(new Office { OfficeId = 5, IsCurrentOffice = true, LiveUrl = "https://www.blri.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 5, Name = "বাংলাদেশ প্রাণিসম্পদ গবেষণা ইন্সটিটিউট", IsPublished = true });
                items.Add(new Office { OfficeId = 6, IsCurrentOffice = true, LiveUrl = "https://www.bfdc.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 6, Name = "বাংলাদেশ মৎস্য উন্নয়ন কর্পোরেশন", IsPublished = true });
                items.Add(new Office { OfficeId = 7, IsCurrentOffice = true, LiveUrl = "https://www.flid.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 7, Name = "মৎস্য ও প্রাণিসম্পদ তথ্য দপ্তর", IsPublished = true });
                items.Add(new Office { OfficeId = 8, IsCurrentOffice = true, LiveUrl = "https://www.mfa.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 8, Name = "মেরিন ফিশারিজ একাডেমি", IsPublished = true });
                items.Add(new Office { OfficeId = 9, IsCurrentOffice = true, LiveUrl = "https://www.bvc.gov.bd", ParentOfficeId = 1, Moto = "গণপ্রজাতন্ত্রী বাংলাদেশ সরকার", LogoUrl = "~/images/bd-logo.png", Address = "", Order = 9, Name = "বাংলাদেশ ভেটেরিনারি কাউন্সিল", IsPublished = true });
                return items;
            }
        }



        #endregion

    }
}
