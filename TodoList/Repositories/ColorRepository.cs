using System;

namespace TodoList.Repositories
{
    public class ColorRepository
    {
        private ColorRepository Repository = null;
        private static string Color = "";
        private static DateTime LastUpdate = DateTime.MinValue;

        private ColorRepository() { }
        public ColorRepository Instance
        {
            get
            {
                if (Repository == null)
                    Repository = new ColorRepository();
                return Repository;
            }
        }

        private static string GenerateColor()
        {
            Random random = new Random();
            int red = random.Next(0, 128);
            int green = random.Next(0, 128);
            int blue = random.Next(0, 128);
            double alpha = random.NextDouble();
            return $"rgba({ red },{ green },{ blue },{ (Math.Round(100 * alpha) / 100).ToString().Replace(",", ".") })";
        }
        public static string GetLinearGradient()
        {
            Random random = new Random();
            string returnstring = $"linear-gradient({ random.Next(360) }deg,";
            returnstring += GenerateColor() + ",";
            System.Threading.Thread.Sleep(100);
            returnstring += GenerateColor();
            return returnstring + ")";
        }

        public static string GetColor()
        {
            if ((DateTime.Now - LastUpdate).TotalHours >= 1)
            {
                Random random = new Random();
                if (random.Next() % 2 == 0 || random.Next() % 2 == 0)
                    return "linear-gradient(45deg, rgba(255, 0, 0, 0.5), rgba(0, 255, 0, 0.5)), linear-gradient(135deg, rgba(0, 0, 255, 0.5), rgba(255, 255, 0, 0.5))";
                LastUpdate = DateTime.Now;
                Color = random.Next() % 2 == 0 ? GetLinearGradient() + "," + GetLinearGradient() + "," + GetLinearGradient() : GenerateColor();
            }
            return Color;
        }

        public static DateTime UpdateTime()
        {
            return LastUpdate.AddHours(1);
        }
    }
}

// rgb(248, 146, 161)
// linear-gradient(117deg,rgba(83,51,140,0.45),rgba(111,200,65,0.51))
// rgba(65,42,220,0.17)
// linear-gradient(249deg,rgba(177,86,75,1),rgba(71,160,76,0.85))
// linear-gradient(319deg,rgba(227,227,150,0.36),rgba(90,41,121,0.84))
// rgba(50,82,138,0.37)
// rgba(224,212,57,0.14)
// rgba(179,37,143,0.83)
// rgba(103,215,24,0.54)
// rgba(238,70,90,0.83)
// rgba(83,1,220,0.24)
// linear-gradient(145deg,rgba(103,6,67,0.73),rgba(131,155,247,0.8))
// rgba(207,222,133,0.89)
// linear-gradient(267deg,rgba(189,113,82,0.13),rgba(53,183,53,0.61))
// rgba(2,249,94,0.35)
// rgba(114,5,132,0.4)
// rgba(117,116,148,0.48)
// linear-gradient(110deg,rgba(78,253,198,0.47),rgba(228,71,199,0.32))
// linear-gradient(55deg,rgba(39,59,89,0.47),rgba(189,133,91,0.32)),linear-gradient(266deg,rgba(189,133,91,0.32),rgba(52,203,62,0.8)),linear-gradient(74deg,rgba(52,203,62,0.8),rgba(130,121,158,0.48))
// linear-gradient(39deg,rgba(28,192,96,0.45),rgba(105,110,192,0.13)),linear-gradient(148deg,rgba(105,110,192,0.13),rgba(225,181,163,0.61)),linear-gradient(316deg,rgba(225,181,163,0.61),rgba(211,176,212,0.87))
// linear-gradient(85deg,rgba(61,238,176,0.14),rgba(180,52,147,0.61)),linear-gradient(254deg,rgba(180,52,147,0.61),rgba(166,48,196,0.88)),linear-gradient(234deg,rgba(166,48,196,0.88),rgba(152,43,244,0.15))
// linear-gradient(316deg,rgba(224,227,44,0.43),rgba(118,45,45,0.28)),linear-gradient(167deg,rgba(118,45,45,0.28),rgba(196,218,141,0.96)),linear-gradient(276deg,rgba(196,218,141,0.96),rgba(59,33,112,0.44))
// linear-gradient(310deg,rgba(220,139,36,0.64),rgba(84,209,7,0.12)),linear-gradient(118deg,rgba(84,209,7,0.12),rgba(70,205,56,0.39)),linear-gradient(98deg,rgba(70,205,56,0.39),rgba(55,201,105,0.65))
// linear-gradient(341deg,rgba(242,187,190,0.46),rgba(14,80,114,0.52)),linear-gradient(20deg,rgba(14,80,114,0.52),rgba(0,75,163,0.79)),linear-gradient(0deg,rgba(0,75,163,0.79),rgba(241,71,211,0.05))
// linear-gradient(233deg,rgba(166,150,99,0.76),rgba(151,145,148,0.03)),linear-gradient(213deg,rgba(151,145,148,0.03),rgba(137,141,196,0.29)),linear-gradient(193deg,rgba(137,141,196,0.29),rgba(1,212,168,0.77))
// linear-gradient(234deg,rgba(166,191,152,0.92),rgba(152,186,200,0.18)),linear-gradient(214deg,rgba(152,186,200,0.18),rgba(16,1,172,0.66)),linear-gradient(22deg,rgba(16,1,172,0.66),rgba(1,253,220,0.93))
// linear-gradient(233deg,rgba(166,150,99,0.76),rgba(151,145,148,0.03)),linear-gradient(213deg,rgba(151,145,148,0.03),rgba(137,141,196,0.29)),linear-gradient(193deg,rgba(137,141,196,0.29),rgba(1,212,168,0.77))
// linear-gradient(64deg,rgba(45,105,122,0.16),rgba(195,179,123,0.01)),linear-gradient(275deg,rgba(195,179,123,0.01),rgba(59,250,95,0.49)),linear-gradient(83deg,rgba(59,250,95,0.49),rgba(44,245,143,0.75))
// linear-gradient(33deg,rgba(23,152,246,0.91),rgba(9,148,39,0.18)),linear-gradient(13deg,rgba(9,148,39,0.18),rgba(251,143,87,0.44)),linear-gradient(353deg,rgba(251,143,87,0.44),rgba(114,214,59,0.92))
// linear-gradient(225deg,rgba(160,75,62,0.67),rgba(24,146,34,0.15)),linear-gradient(33deg,rgba(24,146,34,0.15),rgba(173,219,35,1)),linear-gradient(244deg,rgba(173,219,35,1),rgba(37,34,7,0.47))
// linear-gradient(263deg,rgba(187,40,206,0.61),rgba(173,35,254,0.88)),linear-gradient(243deg,rgba(173,35,254,0.88),rgba(36,106,226,0.35)),linear-gradient(51deg,rgba(36,106,226,0.35),rgba(186,180,227,0.2))
// rgba(40,133,150,0.32)
// linear-gradient(185deg,rgba(131,151,87,0.63),rgba(209,69,182,0.31)),linear-gradient(294deg,rgba(209,69,182,0.31),rgba(73,139,154,0.79)),linear-gradient(102deg,rgba(73,139,154,0.79),rgba(222,213,155,0.64))
// linear-gradient(22deg,rgba(15,81,73,0.65),rgba(1,76,122,0.91)),linear-gradient(2deg,rgba(1,76,122,0.91),rgba(121,147,93,0.39)),linear-gradient(170deg,rgba(121,147,93,0.39),rgba(106,142,142,0.66))
// rgba(10,131,144,0.41)
// linear-gradient(106deg,rgba(38,51,108,0.93),rgba(51,125,70,1)),linear-gradient(145deg,rgba(51,125,70,1),rgba(44,123,95,0.26)),linear-gradient(125deg,rgba(44,123,95,0.26),rgba(83,82,14,0.94))
// linear-gradient(338deg,rgba(120,57,98,0.99),rgba(113,55,123,0.25)),linear-gradient(318deg,rgba(113,55,123,0.25),rgba(24,14,42,0.93)),linear-gradient(67deg,rgba(24,14,42,0.93),rgba(62,101,90,0.61))









