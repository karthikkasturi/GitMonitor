﻿using DataModel;
using System.Collections.Generic;
using System.Linq;
using DM = DomainModel.DTO;

namespace Repository
{
    public class SettingsRepository
    {
        public List<DM.Setting> GetAllSettings()
        {
            using (GitMonitorEntities db = new GitMonitorEntities())
            {
                return db.tblSettings
                         .Where(m => m.IsActive == true)
                         .Select((m) => new DM.Setting
                         {
                             SettingID = m.tblSettingID,
                             Key = m.Key,
                             Value = m.Value,
                             IsActive = m.IsActive
                         }
                ).ToList();
            }
        }
    }
}