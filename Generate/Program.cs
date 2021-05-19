using System;
using System.Collections.Generic;
using System.IO;

namespace Generate
{
    class Program
    {
        public static void gen_lichhoc()
        {
            Random rand = new Random();
            string[] magv_toan = { "GV001", "GV002", "GV003", "GV004", "GV005" };
            string[] magv_ly = { "GV006", "GV007", "GV008", "GV009" };
            string[] magv_hoa = { "GV010", "GV011", "GV012", "GV013" };
            string[] magv_van = { "GV014", "GV015" };
            string[] magv_anh = { "GV016", "GV017", "GV018" };

            string[] lmh_toan = { "LMH001", "LMH002", "LMH003", "LMH004", "LMH005" };
            string[] lmh_ly = { "LMH006", "LMH007", "LMH008", "LMH009" };
            string[] lmh_hoa = { "LMH010", "LMH011", "LMH012", "LMH013" };
            string[] lmh_van = { "LMH014", "LMH015", "LMH016" };
            string[] lmh_anh = { "LMH017", "LMH018", "LMH019", "LMH020" };
        }

        static string convert_LH(int x)
        {
            string str = x.ToString();
            if (str.Length == 1)
            {
                return "LH00" + str; 
            }
            if (str.Length == 2)
            {
                return "LH0" + str;
            }
            return "LH" + str;
        }

        static string convert_HS(int x)
        {
            string str = x.ToString();
            if (str.Length == 1)
            {
                return "HS00" + str;
            }
            if (str.Length == 2)
            {
                return "HS0" + str;
            }
            return "HS" + str;
        }

        public static void gen_diemdanh()
        {
            Random rand = new Random();
            /* LMH001: toan_10 30 hs
              LH011,LH031, LH51, LH71...., LH611, LH631
              */
            rand = new Random();
            List<int> Khoi10 = new List<int>();
            for (int i = 1; i <= 60; i++) Khoi10.Add(i);
            for (int i = Khoi10.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi10[i]; Khoi10[i] = Khoi10[rand_idx]; Khoi10[rand_idx] = temp;
            }
            string data = "";
            data = data + @"-- Điểm danh cho lớp toán 10" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 11; i <= 631; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 30; j++)
                {
                    string para2 = convert_HS(Khoi10[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 631 && j == 29) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 11) % 20 == 0) data = data + "\n";
            }

            /* LMH006: lý_10 30 hs
              LH012,LH032, LH52, LH72...., LH612, LH632
              */
            rand = new Random();
            for (int i = Khoi10.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi10[i]; Khoi10[i] = Khoi10[rand_idx]; Khoi10[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp lý 10" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 12; i <= 632; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 30; j++)
                {
                    string para2 = convert_HS(Khoi10[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 632 && j == 29) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 12) % 20 == 0) data = data + "\n";
            }

            /* LMH010: hoá_10 30 hs
              LH007,LH027, LH47, LH67...., LH607, LH627
              */
            rand = new Random();
            for (int i = Khoi10.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi10[i]; Khoi10[i] = Khoi10[rand_idx]; Khoi10[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp hoá 10" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 7; i <= 627; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 30; j++)
                {
                    string para2 = convert_HS(Khoi10[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 627 && j == 29) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 27) % 40 == 0) data = data + "\n";
            }

            /* LMH017: anh_10 30 hs
              LH0020,LH040, LH60, LH80...., LH620, LH640
              */
            rand = new Random();
            for (int i = Khoi10.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi10[i]; Khoi10[i] = Khoi10[rand_idx]; Khoi10[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp anh 10" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 20; i <= 640; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 30; j++)
                {
                    string para2 = convert_HS(Khoi10[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 640 && j == 29) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if (i % 40 == 0) data = data + "\n";
            }
            File.WriteAllText(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\data_diemdanh_khoi10.txt", data);
            //.....................................................
            /* LMH002: toan_11 25 hs
             LH003,LH023, LH43, LH63...., LH603, LH623
             */
            rand = new Random();
            List<int> Khoi11 = new List<int>();
            for (int i = 61; i <= 120; i++) Khoi11.Add(i);
            for (int i = Khoi11.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi11[i]; Khoi11[i] = Khoi11[rand_idx]; Khoi11[rand_idx] = temp;
            }
            data = "";
            data = data + @"-- Điểm danh cho lớp toán 11" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 3; i <= 623; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 25; j++)
                {
                    string para2 = convert_HS(Khoi11[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 623 && j == 24) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 23) % 20 == 0) data = data + "\n";
            }

            /* LMH007: ly_11 25 hs
             LH016,LH036, LH56, LH76...., LH616, LH636
             */
            rand = new Random();
            for (int i = Khoi11.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi11[i]; Khoi11[i] = Khoi11[rand_idx]; Khoi11[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp lý 11" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 16; i <= 636; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 25; j++)
                {
                    string para2 = convert_HS(Khoi11[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 636 && j == 24) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 36) % 20 == 0) data = data + "\n";
            }

            /* LMH011: hoa_11 25 hs
             LH008,LH028, LH048, LH068...., LH608, LH628
             */
            rand = new Random();
            for (int i = Khoi11.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi11[i]; Khoi11[i] = Khoi11[rand_idx]; Khoi11[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp hoá 11" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 8; i <= 628; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 25; j++)
                {
                    string para2 = convert_HS(Khoi11[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 628 && j == 24) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 28) % 20 == 0) data = data + "\n";
            }

            /* LMH014: van_11 25 hs
             LH014,LH034, LH054, LH074...., LH614, LH634
             */
            rand = new Random();
            for (int i = Khoi11.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi11[i]; Khoi11[i] = Khoi11[rand_idx]; Khoi11[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp văn 11" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 14; i <= 634; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 25; j++)
                {
                    string para2 = convert_HS(Khoi11[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 634 && j == 24) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 34) % 20 == 0) data = data + "\n";
            }

            /* LMH018: anh_11 25 hs
             LH009,LH029, LH049, LH069...., LH609, LH629
             */
            rand = new Random();
            for (int i = Khoi11.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi11[i]; Khoi11[i] = Khoi11[rand_idx]; Khoi11[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp anh 11" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 9; i <= 629; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 25; j++)
                {
                    string para2 = convert_HS(Khoi11[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 629 && j == 24) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 29) % 20 == 0) data = data + "\n";
            }

            File.WriteAllText(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\data_diemdanh_khoi11.txt", data);
            //...............................................
            /* LMH003: toan_12_1 15 hs
             LH002,LH022,...., LH602, LH622
             */
            rand = new Random();
            List<int> Khoi12 = new List<int>();
            for (int i = 121; i <= 200; i++) Khoi12.Add(i);
            for (int i = Khoi12.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi12[i]; Khoi12[i] = Khoi12[rand_idx]; Khoi12[rand_idx] = temp;
            }
            data = "";
            data = data + @"-- Điểm danh cho lớp toán 12_1" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 2; i <= 622; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 15; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 622 && j == 14) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 22) % 20 == 0) data = data + "\n";
            }
            /* LMH004: toan_12_2 15 hs
             LH006,LH026,...., LH606, LH626
             */
            data = data + @"-- Điểm danh cho lớp toán 12_2" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 6; i <= 626; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 15; j < 30; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 626 && j == 29) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 26) % 20 == 0) data = data + "\n";
            }
            /* LMH005: toan_12_3 15 hs
             LH001,LH021,...., LH601, LH621
             */
            data = data + @"-- Điểm danh cho lớp toán 12_3" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 1; i <= 621; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 30; j < 45; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 621 && j == 44) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 21) % 20 == 0) data = data + "\n";
            }
            /* LMH008: ly_12_1 20 hs
             LH004,LH024,...., LH604, LH624
             */
            rand = new Random();
            for (int i = Khoi12.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi12[i]; Khoi12[i] = Khoi12[rand_idx]; Khoi12[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp lý 12_1" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 4; i <= 624; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 20; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 624 && j == 19) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 24) % 20 == 0) data = data + "\n";
            }
            /* LMH009: ly_12_2 20 hs
             LH017,LH037,...., LH617, LH637
             */
            data = data + @"-- Điểm danh cho lớp lý 12_2" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 17; i <= 637; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 20; j < 40; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 637 && j == 39) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 37) % 20 == 0) data = data + "\n";
            }
            /* LMH012: hoa_12_1 20 hs
             LH013,LH033,...., LH613, LH633
             */
            rand = new Random();
            for (int i = Khoi12.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi12[i]; Khoi12[i] = Khoi12[rand_idx]; Khoi12[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp hoá 12_1" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 13; i <= 633; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 20; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 633 && j == 19) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 33) % 20 == 0) data = data + "\n";
            }
            /* LMH013: hoa_12_2 20 hs
             LH018,LH038,...., LH618, LH638
             */
            data = data + @"-- Điểm danh cho lớp hoá 12_2" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 18; i <= 638; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 20; j < 40; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 638 && j == 39) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 38) % 20 == 0) data = data + "\n";
            }
            /* LMH015: van_12_1 20 hs
             LH005,LH025,...., LH605, LH625
             */
            rand = new Random();
            for (int i = Khoi12.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi12[i]; Khoi12[i] = Khoi12[rand_idx]; Khoi12[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp văn 12_1" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 5; i <= 625; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 20; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 625 && j == 19) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 25) % 20 == 0) data = data + "\n";
            }
            /* LMH016: van_12_2 20 hs
             LH019,LH039,...., LH619, LH639
             */
            data = data + @"-- Điểm danh cho lớp văn 12_2" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 19; i <= 639; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 20; j < 40; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 639 && j == 39) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 39) % 20 == 0) data = data + "\n";
            }
            /* LMH019: anh_12_1 20 hs
             LH015, LH035,...., LH615, LH635
             */
            rand = new Random();
            for (int i = Khoi12.Count - 1; i > 0; i--)
            {
                int rand_idx = rand.Next(0, i + 1);
                int temp = Khoi12[i]; Khoi12[i] = Khoi12[rand_idx]; Khoi12[rand_idx] = temp;
            }
            data = data + @"-- Điểm danh cho lớp anh 12_1" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 15; i <= 635; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 0; j < 20; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 635 && j == 19) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 35) % 20 == 0) data = data + "\n";
            }
            /* LMH020: anh_12_2 20 hs
             LH010,LH030,...., LH610, LH630
             */
            data = data + @"-- Điểm danh cho lớp anh 12_2" + "\n";
            data = data + "INSERT dbo.DIEMDANH (MaLichHoc, MaHS, DiemDanh)" + "\n";
            data = data + "VALUES" + "\n";
            for (int i = 10; i <= 630; i += 20)
            {
                string para1 = convert_LH(i);
                for (int j = 20; j < 40; j++)
                {
                    string para2 = convert_HS(Khoi12[j]);
                    string query = "('" + para1 + "', '" + para2 + "', N'" + @"Có')";
                    if (i == 630 && j == 39) { }
                    else query = query + ",";
                    data = data + query + "\n";
                }
                if ((i - 30) % 20 == 0) data = data + "\n";
            }
            File.WriteAllText(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\data_diemdanh_khoi12.txt", data);
        }

        public static void modify_giaovien()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\dataGV.txt");
                   
            string data = "";
            Random rand = new Random();
            foreach (string line in lines)
            {
                if (line.StartsWith("INSERT"))
                {
                    data = data + "INSERT dbo.GIAOVIEN(MaGV, HoTenGV, NgaySinh, DiaChi, GioiTinh, MaMH, MaDM, MatKhau, Email, SDT)";
                    data = data + "\n";
                } else if (line.StartsWith("(N'GV"))
                {
                    string sdt = "0";
                    for (int i = 0; i < 9; i++)
                    {
                        int num = rand.Next(0, 10);
                        sdt = sdt + num.ToString();
                    }
                    if (line[line.Length - 1] == ')')
                    {
                        data = data + line.Substring(0, line.Length - 2) + ", '" + sdt + "')";
                    } else
                    {
                        data = data + line.Substring(0, line.Length - 2) + ", '" + sdt + "'),";
                    }
                    data = data + "\n";
                } else
                {
                    data = data + line;
                    data = data + "\n";
                }
            }
            File.WriteAllText(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\data_GV_Shawn.txt", data);

        }

        public static void modify_hocsinh()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\dataHS.txt");

            string data = "";
            Random rand = new Random();
            foreach (string line in lines)
            {
                if (line.StartsWith("INSERT"))
                {
                    data = data + "INSERT dbo.HOCSINH (MaHS, HoTenHS, NgaySinh, DiaChi, GioiTinh, MatKhau, Email, SDT)";
                    data = data + "\n";
                }
                else if (line.StartsWith("('HS"))
                {
                    string sdt = "0";
                    for (int i = 0; i < 9; i++)
                    {
                        int num = rand.Next(0, 10);
                        sdt = sdt + num.ToString();
                    }
                   
                    data = data + line.Substring(0, line.Length - 2) + ", '" + sdt + "'),";
                    data = data + "\n";
                }
                else
                {
                    data = data + line;
                    data = data + "\n";
                }
            }
            File.WriteAllText(@"D:\University\State_3\HK_II\Data_base\BTL CSDL\BTL CSDL\DangNhap-TUYET\SQL_data\data_HS_Shawn.txt", data);

        }

        static void Main(string[] args)
        {
            modify_hocsinh();
        }
    }
}
