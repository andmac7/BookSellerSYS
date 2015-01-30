﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BookSeller
{
    class CourseDb
    {
        public static Course MapCourses(DataRow r)
        {
            Course c = new Course();
            c.cName = r["CName"].ToString();
            c.cCode = r["CCode"].ToString();

            return c;
        }
        public static List<Course> MapCourses(DataRowCollection rows)
        {
            List<Course> courses = new List<Course>();
            foreach (DataRow r in rows)
            {
                courses.Add(MapCourses(r));
            }
            return courses;
        }

        public static List<Course> Read(string cmd)
        {
            List<Course> courses = null;
            using (DataTable table = DataBaseConnect.ExecuteSelectCommand(cmd, CommandType.Text))
            {
                if (table.Rows.Count > 0)
                {
                    courses = MapCourses(table.Rows);
                }
            }
            return courses;
        }
    }
}
