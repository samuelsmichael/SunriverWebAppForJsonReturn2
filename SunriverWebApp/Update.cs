﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Runtime.Serialization;

namespace SunriverWebApp
{
    [DataContractAttribute]
    public class Update : WebServiceItem
    {
        [DataMemberAttribute]
        public int updateID { get; set; }
        [DataMemberAttribute]
        public DateTime updateCalendar { get; set; }
        [DataMemberAttribute]
        public DateTime updateActivity { get; set; }
        [DataMemberAttribute]
        public DateTime srActDate { get; set; }
        [DataMemberAttribute]
        public DateTime updateMaps { get; set; }
        [DataMemberAttribute]
        public DateTime updateServices { get; set; }
        [DataMemberAttribute]
        public DateTime updateWelcome { get; set; }
        [DataMemberAttribute]
        public DateTime updateData { get; set; }

        protected override WebServiceItem objectFromDatasetRow(System.Data.DataRow dr)
        {
            Update update = new Update();
            update.updateID = Utils.ObjectToInt(dr["updateID"]);
            update.updateCalendar = Utils.ObjectToDateTime(dr["updateCalendar"]);
            update.updateActivity = Utils.ObjectToDateTime(dr["updateActivity"]);
            update.updateMaps = Utils.ObjectToDateTime(dr["updateMaps"]);
            update.updateServices = Utils.ObjectToDateTime(dr["updateServices"]);
            update.updateWelcome = Utils.ObjectToDateTime(dr["updateWelcome"]);
            update.updateData = Utils.ObjectToDateTime(dr["updateData"]);
            return update;
        }

        public List<Update> buildList()
        {
            List<Update> list = new List<Update>();
            foreach (DataRow dr in getDataSet().Tables[0].Rows)
            {
                list.Add((Update)objectFromDatasetRow(dr));
            }
            return list;
        }
    }
}