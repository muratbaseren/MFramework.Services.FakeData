namespace MFramework.Services.FakeData
{
    public static class NameData
    {
        public static string GetCompanyName()
        {
            string surname = NameData.GetSurname();
            string[] strArrays = new string[] { "Inc", "Incorporated", "LLC", "Ltd", "Group", "and Sons", "and Partners", "CIC", "CIO", "Co-Operative", "Society", "LP", "LLP", "General Partnership", "PLC", "Cyf", "Ccc", "Corp.", "Corporation" };
            string str = string.Concat(surname, " ", ArrayData.GetElement<string>(strArrays));
            return str;
        }

        public static string GetFemaleFirstName()
        {
            string[] strArrays = new string[] { "Sophia", "Emma", "Isabella", "Olivia", "Ava", "Emily", "Abigail", "Mia", "Madison", "Elizabeth", "Chloe", "Ella", "Avery", "Addison", "Aubrey", "Lily", "Natalie", "Sofia", "Charlotte", "Zoey", "Grace", "Hannah", "Amelia", "Harper", "Lillian", "Samantha", "Evelyn", "Victoria", "Brooklyn", "Zoe", "Layla", "Hailey", "Leah", "Kaylee", "Anna", "Aaliyah", "Gabriella", "Allison", "Nevaeh", "Alexis", "Audrey", "Savannah", "Sarah", "Alyssa", "Claire", "Taylor", "Riley", "Camila", "Arianna", "Ashley", "Brianna", "Sophie", "Peyton", "Bella", "Khloe", "Genesis", "Alexa", "Serenity", "Kylie", "Aubree", "Scarlett", "Stella", "Maya", "Katherine", "Julia", "Lucy", "Madelyn", "Autumn", "Makayla", "Kayla", "Mackenzie", "Lauren", "Gianna", "Ariana", "Faith", "Alexandra", "Melanie", "Sydney", "Bailey", "Caroline", "Naomi", "Morgan", "Kennedy", "Ellie", "Jasmine", "Eva", "Skylar", "Kimberly", "Violet", "Molly", "Aria", "Jocelyn", "Trinity", "London", "Lydia", "Madeline", "Reagan", "Piper", "Andrea", "Annabelle", "Murat", "Kadir Murat", "K. Murat", "Şükran", "Belinay", "Yiğit" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetFirstName()
        {
            return (BooleanData.GetBoolean() ? NameData.GetMaleFirstName() : NameData.GetFemaleFirstName());
        }

        public static string GetFullName()
        {
            string str = string.Concat(NameData.GetFirstName(), " ", NameData.GetSurname());
            return str;
        }

        public static string GetMaleFirstName()
        {
            string[] strArrays = new string[] { "Jacob", "Mason", "Ethan", "Noah", "William", "Liam", "Jayden", "Michael", "Alexander", "Aiden", "Daniel", "Matthew", "Elijah", "James", "Anthony", "Benjamin", "Joshua", "Andrew", "David", "Joseph", "Logan", "Jackson", "Christopher", "Gabriel", "Samuel", "Ryan", "Lucas", "John", "Nathan", "Isaac", "Dylan", "Caleb", "Christian", "Landon", "Jonathan", "Carter", "Luke", "Owen", "Brayden", "Gavin", "Wyatt", "Isaiah", "Henry", "Eli", "Hunter", "Jack", "Evan", "Jordan", "Nicholas", "Tyler", "Aaron", "Jeremiah", "Julian", "Cameron", "Levi", "Brandon", "Angel", "Austin", "Connor", "Adrian", "Robert", "Charles", "Thomas", "Sebastian", "Colton", "Jaxon", "Kevin", "Zachary", "Ayden", "Dominic", "Blake", "Jose", "Oliver", "Justin", "Bentley", "Jason", "Chase", "Ian", "Josiah", "Parker", "Xavier", "Adam", "Cooper", "Nathaniel", "Grayson", "Jace", "Carson", "Nolan", "Tristan", "Luis", "Brody", "Juan", "Hudson", "Bryson", "Carlos", "Easton", "Damian", "Alex", "Kayden", "Ryder", "Scott", "Paul", "Isaac", "Mark" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetSurname()
        {
            string[] strArrays = new string[] { "Smith", "Jones", "Taylor", "Williams", "Brown", "Davies", "Evans", "Riddick", "Wilson", "Thomas", "Roberts", "Johnson", "Lewis", "Walker", "Robinson", "Wood", "Thompson", "White", "Watson", "Jackson", "Wright", "Green", "Harris", "Thorne", "Wyatt", "Power", "Leach", "Lord", "Nelson", "Hilton", "Adam", "Mcgregor", "Mclean", "Walters", "Jennings", "Lindsay", "Nash", "Hancock", "Hooper", "Carroll", "Silva", "Chadwick", "Abbott", "Stuart", "Mellor", "Seymour", "Boyd", "Perkins", "Dale", "Mann", "Mac", "Haines", "Whelan", "Peters", "Obrien", "Savage", "Barlow", "Sanders", "Mohamed", "Kenny", "Baldwin", "Mcgrath", "Thornton", "Joyce", "Blair", "Whitehouse", "Weaver", "Shepherd", "Whitehead", "Little", "Cullen", "Burrows", "Mcfarlane", "Sinclair", "Swift", "Fleming", "Buckley", "Welch", "Vaughan", "Bradshaw", "Naylor", "Summers", "Briggs", "Schofield", "Osborne", "Coles", "Akhtar", "Cassidy", "Rossi", "Giles", "Whittaker", "Başeren", "Codeove" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetDepartmentName()
        {
            string[] strArrays = new string[] { "Marketing", "Finance", "Operations", "Human Resources", "Sales", "Customer Service", "Information Technology", "Research and Development", "Public Relations", "Legal", "Supply Chain Management", "Quality Assurance", "Facilities Management", "Corporate Communications", "Product Development", "Business Development", "Accounting", "Purchasing", "Project Management", "Risk Management", "Environmental Health and Safety", "Logistics", "Training and Development", "Compliance", "International Business", "Strategic Planning", "Brand Management", "E-commerce", "Data Analytics", "Corporate Social Responsibility", "Government Relations", "Event Planning", "Advertising", "Investor Relations", "Internal Communications", "Executive Management", "Creative Services", "Merchandising", "Sustainability", "Media Relations", "Community Relations", "Mobile Development", "User Experience Design", "Application Development", "Cloud Computing", "Artificial Intelligence", "Blockchain" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetTitleName()
        {
            string[] strArrays = new string[] { "CEO", "COO", "CFO", "CTO", "CMO", "CIO", "VP of Marketing", "VP of Finance", "VP of Operations", "VP of Sales", "VP of Human Resources", "Director of Marketing", "Director of Finance", "Director of Operations", "Director of Sales", "Director of Human Resources", "Marketing Manager", "Finance Manager", "Operations Manager", "Sales Manager", "Human Resources Manager", "Account Manager", "Business Development Manager", "Project Manager", "Product Manager", "IT Manager", "Quality Assurance Manager", "Customer Service Manager", "Public Relations Manager", "Legal Counsel", "Supply Chain Manager", "Facilities Manager", "Training and Development Manager", "Compliance Manager", "Environmental Health and Safety Manager", "Logistics Manager", "Risk Manager", "International Business Manager", "Brand Manager", "E-commerce Manager", "Data Analyst", "Data Scientist", "Cloud Architect", "Artificial Intelligence Specialist", "Blockchain Developer", "Mobile Developer", "Web Developer", "User Experience Designer" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetBankName()
        {
            string[] strArrays = new string[] { "Yapı Kredi Bankası", "İş Bankası", "Garanti Bankası", "Akbank", "Finansbank", "Aktif Bank", "Halk Bankası", "HSBC", "JPMorgan Chase", "Bank of America", "Wells Fargo", "CitiBank", "Goldman Sachs", "Morgan Stanley", "Barclays", "Deutsche Bank", "UBS", "Credit Suisse", "Banco Santander", "BNP Paribas", "ING Group", "HSBC Holdings", "Standard Chartered", "UBI Banca", "Intesa Sanpaolo", "Banco BPM", "UniCredit", "Société Générale", "Crédit Agricole", "NatWest", "Lloyds Bank", "Royal Bank of Scotland", "Barclaycard", "Capital One", "Discover Financial Services", "American Express", "Chase Bank", "Fidelity Investments", "Merrill Lynch", "TD Bank", "Bank of Montreal", "Scotiabank", "Royal Bank of Canada", "National Bank of Canada", "BMO Harris Bank", "KeyBank", "PNC Bank", "SunTrust Bank", "Fifth Third Bank", "Ally Financial", "Synchrony Financial", "US Bank", "Bank of the West", "Union Bank", "Regions Bank", "BB&T Bank" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetUserName()
        {
            string[] strArrays = new string[] { "HappyPanda", "CoolCat", "CrazyDog", "PurpleButterfly", "RedDragon", "GreenTurtle", "BlueWhale", "YellowLion", "PinkFlamingo", "BlackPanther", "SilverFox", "GoldenEagle", "WhiteWolf", "BrownBear", "OrangeOctopus", "MightyMouse", "SuperSquirrel", "ThunderBird", "LightningBolt", "MagicMermaid", "WiseWizard", "BraveKnight", "FierceDragon", "SillyGoose", "LaughingHyena", "SneakySnake", "FriendlyFrog", "HappyHippo", "CleverRaccoon", "QuickRabbit", "SwiftCheetah", "FastPuma", "SlowSloth", "GentleGiraffe", "ToughTiger", "CuriousMonkey", "IntrepidExplorer", "DaringAdventurer", "CreativeArtist", "MusicalMaestro", "AthleticAce", "TechWhiz", "ScienceNerd", "BookWorm", "MovieBuff", "Foodie", "Traveler", "NatureLover", "Fashionista", "FitnessFanatic", "RainbowBubbles", "FunkyMonkey", "ElectricLion", "JungleTiger", "RockStar", "SoccerChamp", "SmartCookie", "CrazyPainter", "GamerGeek", "MoonWalker", "CoolRunner", "MagicMuffin", "PixelWizard", "MysterySolver", "CodeNinja", "CoffeeLover", "WildCard", "DreamWeaver", "GoldenHeart", "SonicBoom", "DanceFloorQueen", "KingOfSwing", "JazzMaster", "SurfingChampion", "TheRealDeal", "CaptainAdventure", "PixelPusher", "NightOwl", "CosmicGuru", "StreetWise", "InfiniteMind", "LifeArtist", "SkyHigh", "SunshineSmiles", "PixelPenguin", "FutureGazer", "RoadWarrior", "TechSavvy", "NatureExplorer", "WorldTraveler", "GameChanger", "SoundMaster", "PixelPal", "DigitalNomad", "NeonNinja", "RainbowWarrior", "StarGazer", "PixelProdigy", "EcoWarrior", "NeonNomad", "VirtualVoyager", "PixelPilot", "WordSmith", "PixelPerfectionist", "PixelPhoenix", "OceanOasis", "PixelProphet", "PixelPushover", "DreamCatcher", "TheRealHero", "PixelProdigal", "PixelPrincess", "TheRealRebel", "PixelPuppeteer", "PixelPatriarch", "PixelPundit", "PixelPractitioner", "PixelPaladin", "PixelPurist", "PixelPathfinder", "PixelPeacemaker", "PixelPinnacle", "PixelPrometheus", "PixelProdrome", "PixelPhenom", "PixelPhantom", "PixelPoncho", "PixelProtector", "PixelProclaimer", "PixelProdigee", "PixelPowerhouse", "PixelPacemaker", "PixelPolaris", "PixelPaparazzi", "PixelProfessor", "PixelPurveyor", "PixelPrankster", "PixelPathogen", "PixelPinballer", "PixelPunk", "PixelPumper", "PixelPacifist", "PixelProdigio", "PixelPalooza", "PixelProletariat", "PixelPizzazz", "PixelPandemonium" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetCarBrandName()
        {
            string[] strArrays = new string[] { "Ford", "Chevrolet", "Toyota", "Honda", "Nissan", "BMW", "Mercedes-Benz", "Audi", "Volvo", "Volkswagen", "Jeep", "Dodge", "Chrysler", "Mazda", "Subaru", "Lexus", "Infiniti", "Cadillac", "GMC", "Buick", "Hyundai", "Kia", "Mitsubishi", "Porsche", "Ferrari", "Lamborghini", "Tesla", "Jaguar", "Land Rover", "Mini", "Fiat", "Alfa Romeo", "Maserati", "Renault", "Peugeot", "Citroen", "Opel", "Suzuki", "Daihatsu", "Lada", "Smart", "Saab", "Hummer", "Pontiac", "Saturn", "Acura", "Scion", "Maybach", "Bentley", "Rolls-Royce", "Aston Martin", "McLaren", "Bugatti", "Pagani", "Koenigsegg", "Lotus", "Abarth", "AC Cars", "Aixam", "Brabus", "Caterham", "Dallara", "De Tomaso", "Donkervoort", "Faraday Future", "Ginetta", "Hennessey", "KTM", "Lancia", "Lykan Hypersport", "Marcos", "Morgan", "Noble", "Rimac", "Rossion", "Spyker", "TVR", "Ultima", "Wiesmann" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetECommerceCategoryName()
        {
            string[] strArrays = new string[] { "Electronics", "Fashion", "Books", "Home & Kitchen", "Sports & Outdoors", "Toys & Games", "Health & Beauty", "Automotive", "Baby & Toddler", "Jewelry", "Pet Supplies", "Food & Drink", "Office Supplies", "Tools & Home Improvement", "Movies & TV", "Musical Instruments", "Industrial & Scientific", "Arts, Crafts & Sewing", "Grocery & Gourmet", "Camera & Photo", "Software", "Video Games", "Luggage & Travel Gear", "Collectibles & Fine Art", "Cell Phones & Accessories", "Computers & Accessories", "Beauty & Personal Care Appliances", "Appliances", "Shoes & Handbags", "Kindle Store", "Digital Music", "Kitchen & Dining", "Patio, Lawn & Garden", "CDs & Vinyl", "Watches", "Office Products", "Home Audio & Theater", "Everything Else", "Arts & Photography", "Magazine Subscriptions", "Industrial & Scientific", "Pet Supplies", "Beauty", "Automotive Parts & Accessories", "Software & Services", "Musical Instruments & DJ Equipment", "Sports & Fitness", "Tools & Home Improvement" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetECommerceProductName()
        {
            string[] strArrays = new string[] { "Wireless Headphones", "Smartwatch", "Portable Bluetooth Speaker", "Wireless Earbuds", "Fitness Tracker", "Laptop Backpack", "Phone Case", "Smart Thermostat", "Robot Vacuum Cleaner", "Wireless Charging Pad", "Gaming Mouse", "Smart Home Security Camera", "Bluetooth Noise Cancelling Headphones", "Electric Toothbrush", "Air Fryer", "Wireless Keyboard", "Smart Doorbell", "Dash Cam", "Smart Plug", "Smart Lock", "Wireless Mouse", "Fitness Smart Scale", "Portable Charger", "Wireless Gaming Headset", "Bluetooth Shower Speaker", "Electric Shaver", "Smart Wi-Fi Router", "Coffee Maker", "Smart Light Bulb", "Smart Garage Door Opener", "Cordless Vacuum Cleaner", "Video Doorbell", "Wireless Security System", "Electric Kettle", "Air Purifier", "Wireless Outdoor Security Camera", "Smart TV", "Smartphone Gimbal", "Video Baby Monitor", "Robotic Lawn Mower", "Wireless HDMI Transmitter", "Smart Coffee Maker", "Gaming Headset Stand", "Smart Mirror", "Smart Bicycle Lock", "Wireless Projector", "Smart Weight Scale", "Wireless Home Theater System", "Smart Plant Pot", "Smart Fridge", "Smart Rice Cooker", "Smart Trash Can", "Electric Pressure Cooker", "Smart Suitcase", "Smart Pet Feeder", "Wireless Car Charger", "Smart Bike Helmet", "Wireless Earbud Case", "Smart Baby Swing", "Smart Wine Bottle Opener", "Wireless Bike Computer", "Smart Water Bottle", "Wireless Microphone", "Smart Bike Light", "Wireless Ear Hook Headphones", "Smart Clothes Hanger", "Smart Bike Lock", "Wireless Headphone Charging Case", "Smart Slow Cooker", "Smart Umbrella", "Wireless Barcode Scanner", "Wireless Smoke Detector", "Wireless Water Leak Detector", "Smart Grill", "Wireless Meat Thermometer", "Smart Smoke Alarm", "Wireless Bluetooth Headband", "Smart Golf Club Tracker", "Smart Pet Collar", "Smart Door Sensor", "Wireless Baby Monitor", "Wireless IP Camera", "Smart Bike Pump", "Wireless Meat Thermometer Fork", "Smart Skipping Rope", "Wireless Barcode Printer", "Smart Ski Helmet", "Wireless Digital Microscope", "Wireless Air Mouse", "Smart Jump Rope", "Wireless HDMI Adapter", "Wireless Barcode Reader", "Smart Football", "Wireless Audio Transmitter", "Smart Basketball", "Smart Cycling Helmet" };

            return ArrayData.GetElement(strArrays);
        }
    }
}