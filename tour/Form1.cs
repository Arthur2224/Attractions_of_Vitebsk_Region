using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace tour
{
    public partial class Form1 : Form
    {
        // Define arrays for region points



        private static Point[] braslavRegionPoints = new Point[]
            {
              new Point(271, 465),
new Point(260, 462),
new Point(230, 454),
new Point(208, 446),
new Point(200, 454),
new Point(182, 456),
new Point(173, 457),
new Point(133, 442),
new Point(139, 430),
new Point(170, 419),
new Point(164, 393),
new Point(171, 383),
new Point(159, 356),
new Point(179, 348),
new Point(196, 329),
new Point(197, 313),
new Point(198, 287),
new Point(199, 264),
new Point(208, 259),
new Point(230, 259),
new Point(238, 269),
new Point(251, 272),
new Point(256, 263),
new Point(280, 257),
new Point(285, 242),
new Point(293, 235),
new Point(302, 217),
new Point(309, 215),
new Point(320, 200),
new Point(334, 195),
new Point(364, 195),
new Point(375, 183),
new Point(400, 190),
new Point(414, 206),
new Point(436, 214),
new Point(462, 206),
new Point(483, 213),
new Point(494, 211),
new Point(513, 218),
new Point(506, 239),
new Point(489, 238),
new Point(487, 250),
new Point(470, 260),
new Point(454, 260),
new Point(450, 279),
new Point(442, 287),
new Point(459, 314),
new Point(454, 330),
new Point(461, 350),
new Point(445, 364),
new Point(436, 378),
new Point(439, 391),
  new Point(427, 387),
            new Point(418, 398),
            new Point(414, 379),
            new Point(404, 373),
            new Point(399, 385),
            new Point(385, 384),
            new Point(373, 392),
            new Point(373, 405),
            new Point(354, 412),
            new Point(352, 423),
            new Point(340, 422),
            new Point(341, 432),
            new Point(335, 457),
            new Point(344, 466),
            new Point(326, 477),
            new Point(273, 475)




            };

        private static Point[] postavskiRegionPoints = new Point[]
            {
               
                new Point(48, 625), new Point(71, 649), new Point(92,642), new Point(98,632), new Point(92,625), new Point(116,632)
                , new Point(125,637), new Point(134,637), new Point(152,641), new Point(174,653)
                , new Point(190,640), new Point(182,629), new Point(201,626)
                , new Point(228,642), new Point(241,636), new Point(265,632), new Point(266,625)
                , new Point(260,624), new Point(260,612), new Point(271,612)
                , new Point(277,619), new Point(283,611), new Point(292,610)
                , new Point(304,618), new Point(316,638), new Point(330,635)
                ,  new Point(352,629), new Point(351,622), new Point(366,622), new Point(377,615)
                , new Point(384,623), new Point(389,616), new Point(389,617), new Point(407,626),

                new Point(424, 624),
                new Point(489, 628), new Point(501, 619),new Point(492, 602),


new Point(505, 590),
new Point(477, 567),
new Point(489, 558),
new Point(472, 506),
new Point(494, 496),
               new Point(489, 495), new Point(454,487), new Point(453,475),
                new Point(444,482),new Point(438,480),
                new Point(422, 459), new Point(401,465),new Point(387,470),new Point(383,478),
                new Point(369,469),new Point(352,467),
               
                new Point(342, 469), new Point(325,479),
                new Point(313,479),new Point(277,476),new Point(266,479),
                new Point(266,479),new Point(253,482),new Point(249,491),new Point(233,494),new Point(231,510),
                new Point(210,518),new Point(223,533),new Point(213,541),new Point(201,537),new Point(193,543),
                new Point(183,540),new Point(164,547),new Point(157,537),new Point(141,544),new Point(137,552),
                new Point(118,550),new Point(111,554),new Point(95,545),new Point(87,546),new Point(86,551),
                new Point(79,551),new Point(79,556),new Point(54,565),new Point(68,584),new Point(58,587),
                new Point(57,601)
            };

        private static Point[] verhnedvinskiRegionPoints = new Point[]
{
                new Point(553, 201),
new Point(559, 180),
new Point(550, 162),
new Point(561, 141),
new Point(590, 124),
new Point(592, 115),
new Point(607, 119),
new Point(618, 104),
new Point(626, 95),
new Point(617, 87),
new Point(631, 83),
new Point(644, 76),
new Point(662, 68),
new Point(668, 49),
new Point(678, 36),
new Point(697, 39),
new Point(710, 28),
new Point(722, 31),
new Point(736, 16),
new Point(743, 25),
new Point(764, 38),
new Point(777, 42),
new Point(775, 60),
new Point(787, 54),
new Point(794, 69),
new Point(810, 67),
new Point(824, 73),
new Point(827, 63),
new Point(821, 50),
new Point(831, 46),
new Point(840, 56),
new Point(841, 77),
new Point(844, 90),
new Point(856, 87),
new Point(841, 100),
new Point(844, 119),
new Point(831, 137),
new Point(820, 152),
new Point(816, 170),
new Point(809, 170),
new Point(796, 163),
new Point(798, 174),
new Point(794, 179),
new Point(811, 177),
new Point(816, 192),
new Point(829, 183),
new Point(843, 180),
new Point(856, 200),
new Point(854, 209),
new Point(879, 227),
new Point(881, 245),
new Point(850, 252),
new Point(853, 261),
new Point(838, 256),
new Point(832, 284),
new Point(824, 308),
new Point(813, 312),
new Point(807, 319),
new Point(809, 335),
new Point(802, 351),
new Point(767, 329),
new Point(741, 325),
new Point(722, 299),
new Point(685, 276),
new Point(678, 263),
new Point(662, 259),
new Point(656, 237),
new Point(654, 212),
new Point(654, 197),
new Point(640, 197),
new Point(624, 201),
new Point(587, 209),
new Point(554, 211),

};

        private static Point[]  miorskyRegionPoints = new Point[]
{
                new Point(462, 350), new Point(444, 282), new Point(515, 221),
                new Point(622, 203), new Point(657, 214), new Point(657, 257),
                new Point(736, 323), new Point(797, 351), new Point(781, 378),
                new Point(791, 416), new Point(779, 430), new Point(714, 442),
                new Point(691, 407), new Point(702, 381), new Point(645, 369),
                new Point(588, 368), new Point(548, 386), new Point(459, 352)
};

        private static Point[]  rossonkiRegionPoints = new Point[]
{
                new Point(887, 247), new Point(845, 183), new Point(809, 178),
                new Point(851, 107), new Point(851, 51), new Point(930, 50),
                new Point(916, 64), new Point(956, 118), new Point(992, 128),
                new Point(995, 114), new Point(1078, 87), new Point(1205, 129),
                new Point(1216, 145),
              new Point(1175, 219), new Point(1142, 226), new Point(1101, 233),
new Point(1050, 240), new Point(1043, 252), new Point(1012, 260),
new Point(993, 258), new Point(969, 238), new Point(948, 252),
new Point(931, 256), new Point(924, 261), new Point(908, 263),
new Point(895, 255), new Point(887,247)

};

        private static Point[] dokshinskiRegionPoints = new Point[]
{
                new Point(424, 628), new Point(441, 650), new Point(440, 687),
                new Point(500, 704), new Point(553, 738), new Point(576, 751),
                new Point(583, 784), new Point(575, 794), new Point(603, 815),
                new Point(640, 799), new Point(687, 829), new Point(759, 788),
                new Point(751, 766), new Point(771, 725), new Point(825, 729),
                new Point(839, 716), new Point(832, 690), new Point(831, 663),
                new Point(806, 664), new Point(757, 628), new Point(733, 598),
                new Point(630, 606), new Point(612, 598), new Point(523, 603),
                new Point(521, 617), new Point(501, 622), new Point(486, 629),
                new Point(424, 624)
};

        private static Point[] sharkovshinksiRegionPoints = new Point[]
{
               new Point(461, 350),
new Point(445, 364),
new Point(436, 378),
new Point(439, 391),
  new Point(427, 387),
            new Point(418, 398),
            new Point(414, 379),
            new Point(404, 373),
            new Point(399, 385),
            new Point(385, 384),
            new Point(373, 392),
            new Point(373, 405),
            new Point(354, 412),
            new Point(352, 423),
            new Point(340, 422),
            new Point(341, 432),
            new Point(342, 469),
new Point(352, 467),
new Point(369, 469),
new Point(383, 478),
new Point(387, 470),
new Point(401, 465),
new Point(422, 459),
new Point(438, 480),
new Point(444, 482),
new Point(453, 475),
new Point(454, 487),
new Point(489, 495),
new Point(494, 496),

new Point(523, 478),
new Point(515, 463),
new Point(591, 451),
new Point(626, 481),
new Point(639, 478),
new Point(657, 489),
new Point(681, 462),
new Point(670, 458),
new Point(708, 462),
new Point(715, 450),
  new Point(714, 442),
            new Point(779, 430),
            new Point(791, 416),
            new Point(781, 378),
            new Point(797, 351),
            new Point(736, 323),
            new Point(657, 257),
            new Point(657, 214),
            new Point(622, 203),





            new Point(515, 221),
            new Point(444, 282),
            new Point(462, 350)

};
        private static Point[] glubokskiRegionPoints = new Point[]
{
               new Point(504, 617),
new Point(492, 602),
new Point(505, 590),
new Point(477, 567),
new Point(489, 558),
new Point(472, 506),
new Point(494, 496),
new Point(523, 478),
new Point(515, 463),
new Point(591, 451),
new Point(626, 481),
new Point(639, 478),
new Point(657, 489),
new Point(681, 462),
new Point(670, 458),
new Point(708, 462),
new Point(715, 450),
new Point(718, 442),
new Point(776, 433),
new Point(791, 435),
new Point(814, 444),
new Point(812, 471),
new Point(812, 485),
new Point(790, 496),
new Point(797, 518),
new Point(802, 531),
new Point(787, 536),
new Point(765, 561),
new Point(776, 578),
new Point(751, 617),
new Point(734, 597),
new Point(625, 601),
new Point(613, 594),
new Point(594, 590),
new Point(581, 596),
new Point(571, 592),
new Point(537, 600),
new Point(526, 600),
new Point(523, 613),
new Point(504, 617)


};
        private static Point[] polotskRegionPoints = new Point[] {
    new Point(796, 509), new Point(794, 496), new Point(813, 487),
    new Point(816, 443), new Point(781, 429), new Point(794, 417),
    new Point(785, 379), new Point(805, 347), new Point(813, 347),
    new Point(826, 307), new Point(829, 288), new Point(836, 270),
    new Point(881, 255), new Point(895, 255), new Point(908, 263),
    new Point(924, 261), new Point(931, 256), new Point(948, 252),
    new Point(969, 238), new Point(993, 258), new Point(1012, 260),
    new Point(1043, 252), new Point(1050, 240), new Point(1101, 233),
    new Point(1142, 226), new Point(1175, 219), new Point(1211, 252),
    new Point(1227, 262), new Point(1242, 253), new Point(1246, 260),
    new Point(1256, 259), new Point(1255, 271), new Point(1231, 290),
    new Point(1247, 299), new Point(1247, 306), new Point(1262, 312),
    new Point(1241, 325), new Point(1235, 311), new Point(1225, 315),
    new Point(1220, 331), new Point(1198, 330), new Point(1198, 346),
    new Point(1188, 357), new Point(1168, 354), new Point(1169, 364),
    new Point(1149, 384), new Point(1139, 381), new Point(1114, 406),
    new Point(1113, 415), new Point(1100, 416), new Point(1074, 430),
    new Point(1049, 429), new Point(1045, 443), new Point(1031, 450),
    new Point(1017, 464), new Point(998, 473), new Point(969, 485),
    new Point(962, 496), new Point(945, 484), new Point(928, 489),
    new Point(909, 483), new Point(905, 491), new Point(893, 477),
    new Point(874, 476), new Point(864, 502), new Point(825, 501),
    new Point(796, 509)
};
        private static Point[] gorodokRegionPoints = new Point[] {
    new Point(1264, 312), new Point(1250, 305), new Point(1247, 298),
    new Point(1235, 289), new Point(1259, 266), new Point(1258, 258),
    new Point(1243, 249), new Point(1255, 232), new Point(1316, 209),
    new Point(1332, 218), new Point(1365, 177), new Point(1390, 178),
    new Point(1445, 195), new Point(1463, 171), new Point(1502, 177),
    new Point(1503, 191), new Point(1526, 191), new Point(1537, 202),
    new Point(1574, 202), new Point(1594, 235), new Point(1627, 246),
    new Point(1636, 277), new Point(1648, 293), new Point(1665, 286),

    new Point(1673, 308), new Point(1657, 314), new Point(1635, 340),
    new Point(1582, 344), new Point(1591, 383), new Point(1541, 395),
    new Point(1536, 389), new Point(1519, 401), new Point(1482, 419),
    new Point(1473, 435), new Point(1454, 435), new Point(1450, 417),
    new Point(1416, 439), new Point(1404, 429), new Point(1387, 439),
    new Point(1371, 436),
                new Point(1370, 427), new Point(1351, 433),
    new Point(1337, 429), new Point(1328, 422), new Point(1308, 431),
    new Point(1287, 416), new Point(1297, 410), new Point(1275, 374),
    new Point(1272, 331), new Point(1264, 312)
};

        private static  Point[] vitsebskRegionPoints = new Point[] {
    new Point(1673, 308), new Point(1657, 314), new Point(1635, 340),
    new Point(1582, 344), new Point(1591, 383), new Point(1541, 395),
    new Point(1536, 389), new Point(1519, 401), new Point(1482, 419),
    new Point(1473, 435), new Point(1454, 435), new Point(1450, 417),
    new Point(1416, 439), new Point(1404, 429), new Point(1387, 439),
    new Point(1371, 436), new Point(1370, 427), new Point(1351, 433),
    new Point(1343, 436), new Point(1336, 461), new Point(1340, 477),
    new Point(1334, 485), new Point(1349, 492), new Point(1334, 502),
    new Point(1337, 518),
                new Point(1355, 513), new Point(1359, 529),
    new Point(1391, 538), new Point(1388, 554), new Point(1401, 578),
    new Point(1413, 573), new Point(1418, 605), new Point(1397, 605),
    new Point(1417, 615), new Point(1434, 626), new Point(1455, 636),
    new Point(1458, 652), new Point(1470, 661), new Point(1535, 672),
    new Point(1548, 658), new Point(1527, 630), new Point(1532, 614),
    new Point(1547, 602), new Point(1541, 593), new Point(1544, 584),
    new Point(1561, 585), new Point(1561, 559), new Point(1578, 561),
    new Point(1579, 573), new Point(1589, 576), new Point(1600, 559),
    new Point(1592, 545), new Point(1599, 530), new Point(1635, 542),
    new Point(1653, 526), new Point(1644, 514), new Point(1667, 504),
    new Point(1667, 493), new Point(1687, 488), new Point(1691, 492),
    new Point(1718, 484), new Point(1717, 479), new Point(1696, 475),
    new Point(1695, 452), new Point(1728, 426), new Point(1735, 417),
    new Point(1719, 375), new Point(1745, 365), new Point(1728, 347),
    new Point(1743, 341), new Point(1736, 303), new Point(1704, 299),
    new Point(1690, 317), new Point(1673, 308)
};
        private static  Point[] lioznoRegionPoints = new Point[] {
    new Point(1535, 672), new Point(1548, 658), new Point(1527, 630),
    new Point(1532, 614), new Point(1547, 602), new Point(1541, 593),
    new Point(1544, 584), new Point(1561, 585), new Point(1561, 559),
    new Point(1578, 561), new Point(1579, 573), new Point(1589, 576),
    new Point(1600, 559), new Point(1592, 545), new Point(1599, 530),
    new Point(1635, 542), new Point(1653, 526), new Point(1644, 514),
    new Point(1667, 504), new Point(1667, 493), new Point(1687, 488),
    new Point(1691, 492), new Point(1718, 484), new Point(1733, 515),
    new Point(1760, 552), new Point(1754, 582), new Point(1767, 593),
    new Point(1762, 607), new Point(1734, 608), new Point(1732, 616),
    new Point(1744, 627), new Point(1734, 639), new Point(1723, 646),
    new Point(1694, 652), new Point(1686, 683), new Point(1670, 719),
    new Point(1604, 741), new Point(1604, 727), new Point(1598, 725),
    new Point(1568, 732), new Point(1565, 705), new Point(1563, 685)
, new Point(1535, 672)
};

        private static Point[] dubrovnoRegionPoints = new Point[] {
    new Point(1670, 719), new Point(1724, 750), new Point(1752, 768),
    new Point(1758, 762), new Point(1763, 773), new Point(1756, 785),
    new Point(1783, 791), new Point(1827, 793), new Point(1835, 808),
    new Point(1808, 848), new Point(1793, 869), new Point(1813, 882),
    new Point(1808, 900), new Point(1783, 908), new Point(1767, 924),  new Point(1768, 924), new Point(1763, 912),
    new Point(1741, 912), new Point(1731, 902), new Point(1721, 921),
    new Point(1711, 926), new Point(1698, 925), new Point(1683, 928),
    new Point(1683, 919), new Point(1669, 915), new Point(1660, 907),
    new Point(1653, 888), new Point(1639, 891), new Point(1635, 878),
    new Point(1623, 848), new Point(1600, 849), new Point(1598, 829),
    new Point(1588, 825), new Point(1604, 802), new Point(1597, 800),
    new Point(1621, 793), new Point(1621, 759), new Point(1646, 727),
    new Point(1670, 719)
};
        private static Point[] orshaRegionPoints = new Point[] {
    new Point(1669, 915), new Point(1660, 907), new Point(1653, 888),
    new Point(1639, 891), new Point(1635, 878), new Point(1623, 848),
    new Point(1600, 849), new Point(1598, 829), new Point(1588, 825),
    new Point(1604, 802), new Point(1597, 800), new Point(1621, 793),
    new Point(1621, 759), new Point(1646, 727), new Point(1605, 739),
    new Point(1603, 727), new Point(1569, 729), new Point(1560, 733),
    new Point(1555, 730), new Point(1543, 731), new Point(1526, 717),
    new Point(1507, 726), new Point(1501, 742), new Point(1503, 754),
    new Point(1489, 748), new Point(1469, 760), new Point(1480, 789),
    new Point(1472, 800), new Point(1436, 801), new Point(1418, 806),
    new Point(1402, 797), new Point(1390, 802), new Point(1387, 792),
    new Point(1371, 795), new Point(1364, 803), new Point(1371, 840),
    new Point(1401, 837), new Point(1417, 838), new Point(1426, 851),
    new Point(1438, 854), new Point(1445, 879), new Point(1435, 890),
    new Point(1440, 905), new Point(1430, 912), new Point(1436, 923),
    new Point(1443, 932), new Point(1470, 957), new Point(1481, 952),
    new Point(1476, 933), new Point(1505, 949), new Point(1519, 932),
    new Point(1503, 964), new Point(1495, 976), new Point(1513, 976),
    new Point(1524, 982), new Point(1531, 966), new Point(1546, 967),
    new Point(1553, 957), new Point(1567, 978), new Point(1570, 988),
    new Point(1580, 984), new Point(1592, 999), new Point(1594, 983),
    new Point(1607, 954), new Point(1619, 953), new Point(1603, 942),
    new Point(1646, 928), new Point(1647, 916), new Point(1669, 915)
};


        private static Point[] tolochinRegionPoints = new Point[] {
     new Point(1350, 806), new Point(1344, 811),
    new Point(1335, 803), new Point(1302, 806), new Point(1298, 809),
    new Point(1296, 801), new Point(1276, 807), new Point(1271, 802),
    new Point(1256, 810), new Point(1234, 800), new Point(1221, 809),
    new Point(1219, 826), new Point(1209, 853), new Point(1205, 870),
    new Point(1189, 893), new Point(1199, 908), new Point(1199, 922),
    new Point(1203, 933), new Point(1193, 932), new Point(1169, 944),
    new Point(1182, 966), new Point(1176, 988), new Point(1172, 987),
    new Point(1165, 1001), new Point(1172, 1008), new Point(1195, 1002),
    new Point(1216, 988), new Point(1233, 972), new Point(1248, 973),
    new Point(1246, 956), new Point(1265, 949), new Point(1292, 971),
    new Point(1318, 967), new Point(1324, 959), new Point(1335, 963),
    new Point(1344, 958), new Point(1356, 960), new Point(1363, 951),
    new Point(1370, 973), new Point(1382, 978), new Point(1394, 979),
    new Point(1410, 987), new Point(1405, 969), new Point(1419, 972),
    new Point(1418, 952), new Point(1435, 958), new Point(1446, 949),
    new Point(1433, 937), new Point(1444, 932),new Point(1443, 932), new Point(1436, 923), new Point(1430, 912),
    new Point(1440, 905), new Point(1435, 890), new Point(1445, 879),
    new Point(1438, 854), new Point(1426, 851), new Point(1417, 838),
    new Point(1401, 837), new Point(1371, 840), new Point(1364, 803),
    new Point(1358,806)

};
        private static Point[] sennenskRegionPoints = new Point[]
{
    new Point(1397, 605), new Point(1417, 615), new Point(1434, 626), new Point(1455, 636),
    new Point(1458, 652), new Point(1470, 661), new Point(1535, 672), new Point(1563, 685),
    new Point(1565, 705), new Point(1568, 732), new Point(1560, 733), new Point(1555, 730),
    new Point(1543, 731), new Point(1526, 717), new Point(1507, 726), new Point(1501, 742),
    new Point(1503, 754), new Point(1489, 748), new Point(1469, 760), new Point(1480, 789),
    new Point(1472, 800), new Point(1436, 801), new Point(1418, 806), new Point(1402, 797),
    new Point(1390, 802), new Point(1387, 792), new Point(1371, 795), new Point(1364, 803),
    new Point(1350, 806), new Point(1344, 811), new Point(1335, 803), new Point(1302, 806),
    new Point(1298, 809), new Point(1296, 801), new Point(1276, 807), new Point(1271, 802),
    new Point(1256, 810), new Point(1234, 800), new Point(1238, 787), new Point(1232, 766),
    new Point(1227, 756), new Point(1214, 754), new Point(1200, 747), new Point(1201, 743),
    new Point(1184, 740), new Point(1185, 734), new Point(1192, 727), new Point(1191, 720),
    new Point(1193, 715), new Point(1191, 698), new Point(1195, 686), new Point(1222, 674),
    new Point(1230, 679), new Point(1250, 669), new Point(1272, 650), new Point(1281, 635),
    new Point(1295, 639), new Point(1301, 627), new Point(1311, 625), new Point(1319, 622),
    new Point(1310, 613), new Point(1335, 624), new Point(1341, 621), new Point(1330, 607),
    new Point(1343, 606), new Point(1354, 626), new Point(1345, 632), new Point(1381, 627),
    new Point(1380, 613), new Point(1397, 605)
};


        private static Point[] chashnikiRegionPoints = new Point[]
{
    new Point(1234, 800), new Point(1238, 787), new Point(1232, 766),
    new Point(1227, 756), new Point(1214, 754), new Point(1200, 747),
    new Point(1201, 743), new Point(1184, 740), new Point(1185, 734),
    new Point(1192, 727), new Point(1191, 720), new Point(1193, 715),
    new Point(1191, 698), new Point(1195, 686), new Point(1188, 677),
    new Point(1172, 683), new Point(1177, 664), new Point(1177, 655),
    new Point(1165, 665), new Point(1159, 644), new Point(1164, 637),
    new Point(1152, 633), new Point(1143, 634), new Point(1125, 635),
    new Point(1121, 631), new Point(1110, 635), new Point(1100, 631),
    new Point(1090, 633), new Point(1087, 627), new Point(1073, 621),
    new Point(1070, 633), new Point(1060, 637), new Point(1054, 646),
    new Point(1046, 655), new Point(1050, 657), new Point(1043, 671),
    new Point(1028, 676), new Point(1021, 683), new Point(1017, 705),
    new Point(1023, 715), new Point(1051, 714), new Point(1060, 738),
    new Point(1049, 740), new Point(1042, 752), new Point(1027, 750),
    new Point(976, 778), new Point(955, 779), new Point(952, 783),
    new Point(958, 790), new Point(954, 795), new Point(937, 796),
    new Point(937, 784), new Point(910, 782), new Point(931, 819),
    new Point(927, 828), new Point(934, 838), new Point(950, 837),
    new Point(965, 835), new Point(987, 843), new Point(1003, 832),
    new Point(995, 820), new Point(1006, 819), new Point(1008, 813),
    new Point(1023, 823), new Point(1047, 832), new Point(1055, 830),
    new Point(1054, 815), new Point(1068, 812), new Point(1082, 804),
    new Point(1102, 809), new Point(1122, 805), new Point(1120, 834),
    new Point(1146, 844), new Point(1160, 832), new Point(1173, 833),
    new Point(1189, 831), new Point(1196, 814), new Point(1215, 822),
    new Point(1220, 808)
};
        private static Point[] lepelRegionPoints = new Point[]
{
    new Point(1073, 621),
    new Point(1080, 600),
    new Point(1068, 583),
    new Point(1074, 563),
    new Point(1053, 558),
    new Point(1051, 568),
    new Point(1037, 560),
    new Point(1032, 564),
    new Point(1024, 550),
    new Point(1013, 554),
    new Point(1005, 584),
    new Point(985, 590),
    new Point(978, 586),
    new Point(971, 595),
    new Point(938, 606),
    new Point(888, 615),
    new Point(850, 625),
    new Point(831, 663),
    new Point(832, 690),
    new Point(839, 716),
    new Point(825, 729),
    new Point(771, 725),
    new Point(751, 766),
    new Point(759, 788),
    new Point(782, 814),
    new Point(822, 848),
    new Point(841, 836),
    new Point(850, 788),
    new Point(883, 793),
    new Point(916, 791),
    new Point(910, 782),
    new Point(937, 784),
    new Point(937, 796),
    new Point(954, 795),
    new Point(958, 790),
    new Point(952, 783),
    new Point(955, 779),
    new Point(976, 778),
    new Point(1027, 750),
    new Point(1042, 752),
    new Point(1049, 740),
    new Point(1060, 738),
    new Point(1051, 714),
    new Point(1023, 715),
    new Point(1017, 705),
    new Point(1021, 683),
    new Point(1028, 676),
    new Point(1043, 671),
    new Point(1050, 657),
    new Point(1046, 655),
    new Point(1054, 646),
    new Point(1060, 637),
    new Point(1070, 633),
    new Point(1073, 621)
};


     /*   private Point[] beshenkovichiRegionPoints = new Point[]
{

    new Point(1337, 518), new Point(1330, 529), new Point(1308, 531),
    new Point(1308, 554), new Point(1299, 562), new Point(1282, 557),
    new Point(1258, 557), new Point(1243, 571), new Point(1219, 585),
    new Point(1207, 596), new Point(1195, 586), new Point(1201, 562),
    new Point(1179, 558), new Point(1170, 559), new Point(1154, 551),
    new Point(1154, 543), new Point(1145, 534), new Point(1141, 512),
    new Point(1122, 496), new Point(1116, 484), new Point(1096, 496),
    new Point(1082, 494), new Point(1100, 510), new Point(1115, 517),
    new Point(1102, 532), new Point(1079, 545), new Point(1086, 559),
    new Point(1074, 563), new Point(1068, 583), new Point(1080, 600),
    new Point(1073, 621), new Point(1087, 627), new Point(1090, 633),
    new Point(1100, 631), new Point(1110, 635), new Point(1121, 631),
    new Point(1125, 635), new Point(1143, 634), new Point(1152, 633),
    new Point(1164, 637), new Point(1159, 644), new Point(1165, 665),
    new Point(1177, 655), new Point(1177, 664), new Point(1172, 683),
    new Point(1188, 677), new Point(1195, 686), new Point(1195, 686),
    new Point(1222, 674), new Point(1230, 679), new Point(1250, 669),
    new Point(1272, 650), new Point(1281, 635), new Point(1295, 639),
    new Point(1301, 627), new Point(1311, 625), new Point(1319, 622),
    new Point(1310, 613), new Point(1335, 624), new Point(1341, 621),
    new Point(1330, 607), new Point(1343, 606), new Point(1354, 626),
    new Point(1345, 632), new Point(1381, 627), new Point(1380, 613),
    new Point(1397, 605),new Point(1418, 605), new Point(1413, 573), new Point(1401, 578),
new Point(1388, 554), new Point(1391, 538), new Point(1359, 529),
new Point(1355, 513)

};*/
        private static Point[] ushachyRegionPoints = new Point[] {
                new Point(797, 518),
new Point(802, 531),
new Point(787, 536),
new Point(765, 561),
new Point(776, 578),
new Point(751, 617),
                   new Point(757, 628),
            new Point(806, 664),

                new Point(831, 663),
new Point(850, 625),
new Point(888, 615),
new Point(938, 606),
new Point(971, 595),
new Point(978, 586),
new Point(985, 590),
new Point(1005, 584),
new Point(1013, 554),
new Point(1024, 550),
new Point(1032, 564),
new Point(1037, 560),
new Point(1051, 568),
new Point(1053, 558),
new Point(1074, 563),

            new Point(1086, 559),
            new Point(1079, 545),
            new Point(1102, 532),
            new Point(1115, 517),
            new Point(1100, 510),
            new Point(1082, 494),

                   new Point(1096, 496),
            new Point(1096, 496),
            new Point(1080, 476),
            new Point(1067, 471),
            new Point(1061, 453),
            new Point(1049, 429)
              ,
            new Point(1045, 443), new Point(1031, 450),
    new Point(1017, 464), new Point(998, 473), new Point(969, 485),
    new Point(962, 496), new Point(945, 484), new Point(928, 489),
    new Point(909, 483), new Point(905, 491), new Point(893, 477),
    new Point(874, 476), new Point(864, 502), new Point(825, 501),
    new Point(796, 509)};
        private static Point[] shumilinoRegionPoints = new Point[] {

                new Point(1262, 312),
        new Point(1241, 325), new Point(1235, 311), new Point(1225, 315),
        new Point(1220, 331), new Point(1198, 330), new Point(1198, 346),
        new Point(1188, 357), new Point(1168, 354), new Point(1169, 364),
        new Point(1149, 384), new Point(1139, 381), new Point(1114, 406),
        new Point(1113, 415), new Point(1100, 416), new Point(1074, 430),

                    new Point(1049, 429),
        new Point(1061, 453),
        new Point(1067,471),
        new Point(1080,476),
         new Point(1096, 496),
           new Point(1096, 496),
            new Point(1116, 484),
            new Point(1122, 496),
            new Point(1141, 512),
            new Point(1145, 534),
            new Point(1154, 543),
            new Point(1154, 551),
            new Point(1170, 559),
            new Point(1179, 558),
            new Point(1201, 562),
            new Point(1195, 586),
            new Point(1207, 596),
            new Point(1219, 585),
            new Point(1243, 571),
            new Point(1258, 557),
            new Point(1282, 557),
            new Point(1299, 562),
            new Point(1308, 554),
            new Point(1308, 531),
            new Point(1330, 529),
            new Point(1337, 518),
                 new Point(1355, 513),
            new Point(1337, 518),
            new Point(1334, 502),
            new Point(1349, 492),
            new Point(1334, 485),
            new Point(1340, 477),
            new Point(1336, 461),
            new Point(1343, 436)

        , new Point(1351, 433),
    new Point(1337, 429), new Point(1328, 422), new Point(1308, 431),
    new Point(1287, 416), new Point(1297, 410), new Point(1275, 374),
    new Point(1272, 331), new Point(1264, 312)
                };

        private static Point[] beshenkovichiRegionPoints = new Point[]
{

        new Point(1082, 494), new Point(1100, 510), new Point(1115, 517),
        new Point(1102, 532), new Point(1079, 545), new Point(1086, 559),
        new Point(1074, 563), new Point(1068, 583), new Point(1080, 600),
        new Point(1073, 621), new Point(1087, 627), new Point(1090, 633),
        new Point(1100, 631), new Point(1110, 635), new Point(1121, 631),
        new Point(1125, 635), new Point(1143, 634), new Point(1152, 633),
        new Point(1164, 637), new Point(1159, 644), new Point(1165, 665),
        new Point(1177, 655), new Point(1177, 664), new Point(1172, 683),
        new Point(1188, 677), new Point(1195, 686), new Point(1195, 686),
        new Point(1222, 674), new Point(1230, 679), new Point(1250, 669),
        new Point(1272, 650), new Point(1281, 635), new Point(1295, 639),
        new Point(1301, 627), new Point(1311, 625), new Point(1319, 622),
        new Point(1310, 613), new Point(1335, 624), new Point(1341, 621),
        new Point(1330, 607), new Point(1343, 606), new Point(1354, 626),
        new Point(1345, 632), new Point(1381, 627), new Point(1380, 613),
        new Point(1397, 605),new Point(1418, 605), new Point(1413, 573), new Point(1401, 578),
    new Point(1388, 554), new Point(1391, 538), new Point(1359, 529),
    new Point(1355, 513),
        new Point(1337, 518), new Point(1330, 529), new Point(1308, 531),
        new Point(1308, 554), new Point(1299, 562), new Point(1282, 557),
        new Point(1258, 557), new Point(1243, 571), new Point(1219, 585),
        new Point(1207, 596), new Point(1195, 586), new Point(1201, 562),
        new Point(1179, 558), new Point(1170, 559), new Point(1154, 551),
        new Point(1154, 543), new Point(1145, 534), new Point(1141, 512),
        new Point(1122, 496), new Point(1116, 484), new Point(1096, 496)


};

        Dictionary<string, Point[]> regions = new Dictionary<string, Point[]>
        {   {"ushachy",ushachyRegionPoints},
            {"shumilino",shumilinoRegionPoints},
            {"beshenkovichi",beshenkovichiRegionPoints},
            {"lepel",lepelRegionPoints},

            {"chashniki",chashnikiRegionPoints},
            {"sennensk",sennenskRegionPoints},
            {"tolochin",tolochinRegionPoints},

            {"orsha",orshaRegionPoints},

            {"dubrovno",dubrovnoRegionPoints},
            {"liozno",lioznoRegionPoints},
            {"vitsebsk",vitsebskRegionPoints},
            {"gorodok",gorodokRegionPoints},
            {"polotsk",polotskRegionPoints},
            {"glubokski",glubokskiRegionPoints},
            {"sharkovshinksi",sharkovshinksiRegionPoints},

              {"dokshinski",dokshinskiRegionPoints},
            {"rossonki",rossonkiRegionPoints},
            {"miorsky",miorskyRegionPoints},
            {"verhnedvinski",verhnedvinskiRegionPoints},
            {"postavski",postavskiRegionPoints},
             {"braslav",braslavRegionPoints}


        };
       

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);


           


        }


    


    private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackColor = Color.LightGray;

            // get Info from database insert into classes, insert into Dictionary, 
       
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // label1.Text = $"X: {e.X}, Y: {e.Y}";
            Point mousePosition = e.Location;
            string regionName = null;

            foreach (var region in regions)
            {
                string regionKey = region.Key;
                Point[] regionPoints = region.Value;

                if (IsPointInPolygon(mousePosition, regionPoints))
                {
                    
                    regionName = regionKey;
                    break;
                }
            }

            if (regionName != null)
            {
                label1.Text = regionName;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.FromArgb(1, 0, 0, 0), 5)) // Alfa vērtība ir 1, ļoti zema, praktiski neredzama
            {
                g.DrawPolygon(pen, braslavRegionPoints);
                g.DrawPolygon(pen, postavskiRegionPoints);
                g.DrawPolygon(pen, verhnedvinskiRegionPoints);
                g.DrawPolygon(pen, miorskyRegionPoints);
                g.DrawPolygon(pen, rossonkiRegionPoints);
                g.DrawPolygon(pen, dokshinskiRegionPoints);
                g.DrawPolygon(pen, sharkovshinksiRegionPoints);
                g.DrawPolygon(pen, glubokskiRegionPoints);
                g.DrawPolygon(pen, polotskRegionPoints);
                g.DrawPolygon(pen, gorodokRegionPoints);
                g.DrawPolygon(pen, vitsebskRegionPoints);
                g.DrawPolygon(pen, lioznoRegionPoints);
                g.DrawPolygon(pen, dubrovnoRegionPoints);
                g.DrawPolygon(pen, orshaRegionPoints);
                g.DrawPolygon(pen, tolochinRegionPoints);
                g.DrawPolygon(pen, sennenskRegionPoints);
                g.DrawPolygon(pen, chashnikiRegionPoints);
                g.DrawPolygon(pen, lepelRegionPoints);
                g.DrawPolygon(pen, beshenkovichiRegionPoints);
                g.DrawPolygon(pen, shumilinoRegionPoints);
                g.DrawPolygon(pen, ushachyRegionPoints);
            }
        }


        private bool IsPointInPolygon(Point p, Point[] polygon)
        {
            bool isInside = false;
            int polygonLength = polygon.Length;
            for (int i = 0, j = polygonLength - 1; i < polygonLength; j = i++)
            {
                if (((polygon[i].Y > p.Y) != (polygon[j].Y > p.Y)) &&
                    (p.X < (polygon[j].X - polygon[i].X) * (p.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    isInside = !isInside;
                }
            }
            return isInside;
        }   


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
