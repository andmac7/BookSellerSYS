﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookSeller
{
    class InstDb
    {
        public static Inst MapInsts(DataRow r)
        {
            Inst i = new Inst();
            i.instName = r["InstName"].ToString();

            return i;
        }
        public static List<Inst> MapInsts(DataRowCollection rows)
        {
            List<Inst> insts = new List<Inst>();
            foreach (DataRow r in rows)
            {
                insts.Add(MapInsts(r));
            }
            return insts;
        }

        public static List<Inst> Read()
        {
            List<Inst> insts = null;
            using (DataTable table = DataBaseConnect.ExecuteSelectCommand("SELECT * FROM Institution", CommandType.Text))
            {
                if (table.Rows.Count > 0)
                {
                    insts = MapInsts(table.Rows);
                }
            }
            return insts;
        }
    }
}
