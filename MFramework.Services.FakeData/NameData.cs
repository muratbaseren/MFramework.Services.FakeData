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
            string[] strArrays = new string[] { "Sophia", "Emma", "Isabella", "Olivia", "Ava", "Emily", "Abigail", "Mia", "Madison", "Elizabeth", "Chloe", "Ella", "Avery", "Addison", "Aubrey", "Lily", "Natalie", "Sofia", "Charlotte", "Zoey", "Grace", "Hannah", "Amelia", "Harper", "Lillian", "Samantha", "Evelyn", "Victoria", "Brooklyn", "Zoe", "Layla", "Hailey", "Leah", "Kaylee", "Anna", "Aaliyah", "Gabriella", "Allison", "Nevaeh", "Alexis", "Audrey", "Savannah", "Sarah", "Alyssa", "Claire", "Taylor", "Riley", "Camila", "Arianna", "Ashley", "Brianna", "Sophie", "Peyton", "Bella", "Khloe", "Genesis", "Alexa", "Serenity", "Kylie", "Aubree", "Scarlett", "Stella", "Maya", "Katherine", "Julia", "Lucy", "Madelyn", "Autumn", "Makayla", "Kayla", "Mackenzie", "Lauren", "Gianna", "Ariana", "Faith", "Alexandra", "Melanie", "Sydney", "Bailey", "Caroline", "Naomi", "Morgan", "Kennedy", "Ellie", "Jasmine", "Eva", "Skylar", "Kimberly", "Violet", "Molly", "Aria", "Jocelyn", "Trinity", "London", "Lydia", "Madeline", "Reagan", "Piper", "Andrea", "Annabelle" };
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
            string[] strArrays = new string[] { "Smith", "Jones", "Taylor", "Williams", "Brown", "Davies", "Evans", "Riddick", "Wilson", "Thomas", "Roberts", "Johnson", "Lewis", "Walker", "Robinson", "Wood", "Thompson", "White", "Watson", "Jackson", "Wright", "Green", "Harris", "Thorne", "Wyatt", "Power", "Leach", "Lord", "Nelson", "Hilton", "Adam", "Mcgregor", "Mclean", "Walters", "Jennings", "Lindsay", "Nash", "Hancock", "Hooper", "Carroll", "Silva", "Chadwick", "Abbott", "Stuart", "Mellor", "Seymour", "Boyd", "Perkins", "Dale", "Mann", "Mac", "Haines", "Whelan", "Peters", "Obrien", "Savage", "Barlow", "Sanders", "Mohamed", "Kenny", "Baldwin", "Mcgrath", "Thornton", "Joyce", "Blair", "Whitehouse", "Weaver", "Shepherd", "Whitehead", "Little", "Cullen", "Burrows", "Mcfarlane", "Sinclair", "Swift", "Fleming", "Buckley", "Welch", "Vaughan", "Bradshaw", "Naylor", "Summers", "Briggs", "Schofield", "Osborne", "Coles", "Akhtar", "Cassidy", "Rossi", "Giles", "Whittaker" };
            return ArrayData.GetElement<string>(strArrays);
        }

        public static string GetDepartmentName()
        {
            string[] strArrays = new string[] { "Yönetim", "Üretim", "Sekreterya", "Bilgi İşlem", "Ar-Ge", "Pazarlama", "Kurumsal İletişim", "Danışma", "Reklam", "Müşteri Hizmetleri", "Kalite Kontrol", "Satın Alma", "Faturalandırma", "Kargo", "Lojistik", "İnsan Kaynakları", "İdari İşler", "Güvenlik", "Eğitim ve Geliştirme", "Sosyal Hizmetler", "Hukuk" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetTitleName()
        {
            string[] strArrays = new string[] { "Yazılım Uzmanı", "Satış Danışmanı", "Muhasebe Elemanı", "Sorumlu Yönetici", "Satış Temsilcisi", "Mağaza Müdürü", "Sekreter", "Yönetici Asistanı", "Müşteri Temsilcisi", "Muhasebe Uzmanı", "Ön Muhasebe Elemanı", "Makine Mühendisi", "Stajyer", "Depo Elemanı", "İnsan Kaynakları Uzmanı", "Yazılım Geliştirme Uzmanı", "Güvenlik Görevlisi", "Pazarlama Asistanı", "Müşteri Hizmetleri Sorumlusu", "Yetkili", "Lojistik Müdürü", "Sigorta Uzmanı", "Satış Direktörü", "Bilgi Sistemleri Uzmanı", "Satınalma Personeli", "Fiyatlandırma Uzmanı", "Planlama Müdürü", "Koordinatör", "Saha Müdürü", "Güvenlik Müdürü", "Departman Müdürü", "İş Geliştirme Sorumlusu", "Kalite Operatörü" };

            return ArrayData.GetElement(strArrays);
        }

        public static string GetBankName()
        {
            string[] strArrays = new string[] { "Yapı Kredi Bankası", "İş Bankası", "Garanti Bankası", "Akbank", "Finansbank", "Ziraat Bankası", "Aktif Bank", "Kuveyt Türk", "Vakıfbank", "Halk Bankası", "Albaraka Türk" };

            return ArrayData.GetElement(strArrays);
        }
    }
}