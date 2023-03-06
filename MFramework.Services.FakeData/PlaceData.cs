using System.Collections.Generic;

namespace MFramework.Services.FakeData
{
    public static class PlaceData
    {
        public static string GetAddress()
        {
            string str = string.Concat(PlaceData.GetStreetNumber(), " ", PlaceData.GetStreetName());
            return str;
        }

        public static string GetCity()
        {
            string[] strArrays = new string[] { "New York", "Los Angeles", "Chicago", "Houston", "Philadelphia", "Phoenix", "San Antonio", "San Diego", "Dallas", "San Jose", "Austin", "Jacksonville", "Indianapolis", "San Francisco[11]", "Columbus", "Fort Worth", "Charlotte", "Detroit", "El Paso", "Memphis", "Boston", "Seattle", "Denver", "Washington", "Nashville", "Baltimore", "Louisville", "Portland", "Oklahoma City", "Milwaukee", "Las Vegas", "Albuquerque", "Tucson", "Fresno", "Sacramento", "Long Beach", "Kansas City", "Mesa", "Atlanta", "Colorado Springs", "Raleigh", "Omaha", "Miami", "Oakland", "Tulsa", "Minneapolis", "Cleveland", "Wichita", "Arlington", "Bakersfield", "Tampa", "Anaheim", "Aurora", "Santa Ana", "Riverside", "Corpus Christi", "Pittsburgh", "Stockton", "Cincinnati", "Saint Paul", "Toledo", "Newark", "Greensboro", "Plano", "Henderson", "Lincoln", "Buffalo", "Fort Wayne", "Jersey City", "Chula Vista", "Orlando", "St. Petersburg", "Chandler", "Laredo", "Madison", "Durham", "Lubbock", "Winston–Salem", "Garland", "Glendale", "Hialeah", "Reno", "Irvine", "Irving", "Scottsdale", "North Las Vegas", "Fremont", "Auckland", "Wellington", "Christchurch", "Hamilton", "Napier-Hastings", "Tauranga", "Dunedin", "Palmerston North", "Nelson", "Rotorua", "New Plymouth", "Whangarei", "Invercargill", "Whanganui (Wanganui)", "Gisborne", "Bath", "Birmingham", "Bradford", "Brighton & Hove", "Bristol", "Carlisle", "Cambridge", "Canterbury", "Chester", "Chichester", "Coventry", "Derby", "Durham", "Ely", "Exeter", "Gloucester", "Hereford", "Kingston-upon-Hull", "Lancaster", "Leeds", "Leicester", "Lichfield", "Lincoln", "Liverpool", "London", "Bangor", "Cardiff", "Newport", "St Davids", "Swansea", "Armagh", "Belfast", "Lisburn", "Londonderry", "Newry.", "Manchester", "Newcastle-upon-Tyne", "Norwich", "Nottingham", "Oxford", "Peterborough", "Plymouth", "Portsmouth", "Preston", "Ripon", "Salford", "Salisbury", "Sheffield", "Southampton", "St Albans", "Stoke-on-Trent", "Sunderland", "Truro", "Wakefield", "Wells", "Westminster", "Winchester", "Wolverhampton", "Worcester", "York", "Aberdeen", "Dundee", "Edinburgh", "Glasgow", "Inverness", "Stirling","Istanbul","Izmir" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetCountry()
        {
            string[] strArrays = new string[] { "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Channel Islands", "Chile", "China", "Colombia", "Comoros", "Congo, Dem. Rep.", "Congo, Rep.", "Costa Rica", "Côte dIvoire", "Croatia", "Crimea", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt, Arab Rep.", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Faeroe Islands", "Fiji", "Finland", "France", "French Polynesia", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Greenland", "Grenada", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong, China", "Hungary", "Iceland", "India", "Indonesia", "Iran, Islamic Rep.", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Dem. Rep.", "Korea, Rep.", "Kuwait", "Kyrgyz Republic", "Lao PDR", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macao, China", "Macedonia, FYR", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia, Fed. Sts.", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Romania", "Russian Federation", "Rwanda", "Samoa", "San Marino", "São Tomé and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovak Republic", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St. Kitts and Nevis", "St. Lucia", "St. Vincent and the Grenadines", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Virgin Islands", "West Bank and Gaza", "Yemen, Rep.", "Zambia", "Zimbabwe" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetCounty()
        {
            string[] strArrays = new string[] { "Avon", "Bedfordshire", "Berkshire", "City of Bristol", "Buckinghamshire", "Cambridgeshire", "Cambridgeshire", "Cheshire", "Cleveland", "Cornwall", "Cumberland", "Cumbria", "Derbyshire", "Devon", "Dorset", "Durham", "East Suffolk", "East Sussex", "Essex", "Gloucestershire", "Greater London", "Greater Manchester", "Hampshire", "Worcester", "Herefordshire", "Hertfordshire", "Humberside", "Huntingdon", "Huntingdonshire", "Isle of Ely", "Isle of Wight", "Kent", "Lancashire", "Leicestershire", "Lincolnshire", "London", "City of London", "Merseyside", "Middlesex", "Norfolk", "Northamptonshire", "Northumberland", "North Humberside", "North Yorkshire", "Nottinghamshire", "Oxfordshire", "Soke of Peterborough", "Rutland", "Shropshire", "Somerset", "South Humberside", "South Yorkshire", "Staffordshire", "Suffolk", "Surrey", "Sussex", "Tyne and Wear", "Warwickshire", "West Midlands", "Westmorland", "West Suffolk", "West Sussex", "West Yorkshire", "Wiltshire", "Worcestershire", "Yorkshire", "East Riding", "North Riding", "West Riding", "Antrim", "Armagh", "City of Belfast", "Down", "Fermanagh", "Londonderry", "City of Londonderry", "Tyrone", "City of Aberdeen", "Aberdeenshire", "Angus", "Argyll", "Ayrshire", "Banffshire", "Berwickshire", "Bute", "Caithness", "Clackmannanshire", "Cromartyshire", "Dumfriesshire", "Dunbartonshire", "City of Dundee", "East Lothian", "City of Edinburgh", "Fife", "City of Glasgow", "Inverness-shire", "Kincardineshire", "Kinross-shire", "Kirkcudbrightshire", "Lanarkshire", "Midlothian", "Moray", "Nairnshire", "Orkney", "Peeblesshire", "Perthshire", "Renfrewshire", "Ross and Cromarty", "Ross-shire", "Roxburghshire", "Selkirkshire", "Shetland", "Stirlingshire", "Sutherland", "West Lothian", "Wigtownshire", "Anglesey", "Brecknockshire", "Caernarfonshire", "Cardiganshire", "Carmarthenshire", "Clwyd", "Denbighshire", "Dyfed", "Flintshire", "Glamorgan", "Gwent", "Gwynedd", "Merionethshire", "Mid Glamorgan", "Monmouthshire", "Montgomeryshire", "Pembrokeshire", "Powys", "Radnorshire", "South Glamorgan", "West Glamorgan","Yenişehir","Çamlık" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetPostCode()
        {
            return TextData.GetPatternString("??## #??").ToUpper();
        }

        public static string GetState()
        {
            string[] strArrays = new string[] { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetStreetName()
        {
            HashSet<string> strs = new HashSet<string>();
            strs.Add("Gate");
            strs.Add("Avenue");
            strs.Add("Street");
            strs.Add("Way");
            strs.Add("Cul de sac");
            strs.Add("Hill");
            strs.Add("Highland");
            strs.Add("Park");
            strs.Add("Road");
            strs.Add("Place");
            strs.Add("Grove");
            strs.Add("Cottages");
            strs.Add("Mews");
            strs.Add("Terrace");
            strs.Add("Valley");
            strs.Add("Close");
            strs.Add("Square");
            strs.Add("Walk");
            strs.Add("Lane");
            strs.Add("Rise");
            strs.Add("Yard");
            strs.Add("Court");
            strs.Add("Crescent");
            HashSet<string> ending = strs;
            string str = string.Concat(NameData.GetSurname(), " ", CollectionData.GetElement<string>(ending));
            return str;
        }

        public static int GetStreetNumber()
        {
            return NumberData.GetNumber(900);
        }

        public static string GetZipCode()
        {
            return TextData.GetNumeric(5);
        }
    }
}