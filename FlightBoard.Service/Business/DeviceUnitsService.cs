// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.DeviceUnitsService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace FlightBoard.Service.Business
{
    public class DeviceUnitsService : BusinessServiceBase<fb_DeviceUnits>
    {
        //private static DeviceUnitsService defaultInstance = new DeviceUnitsService((DbContext)ServiceFactory<FlightBoardEntities>.get_Instance());

        //public static DeviceUnitsService Default
        //{
        //    get
        //    {
        //        return DeviceUnitsService.defaultInstance;
        //    }
        //}

        //public DeviceUnitsService()
        //{
        //}

        //public DeviceUnitsService(Repository<fb_DeviceUnits> repository)
        //    : base(repository)
        //{
        //}

        //public DeviceUnitsService(DbContext dbContext)
        //    : base(dbContext)
        //{
        //}

        //public List<fb_DeviceUnits> GetDeviceunits()
        //{
        //    return Enumerable.ToList<fb_DeviceUnits>((IEnumerable<fb_DeviceUnits>)Queryable.Select<fb_DeviceUnits, fb_DeviceUnits>((IQueryable<fb_DeviceUnits>)new FlightBoardEntities().get_fb_DeviceUnits(), (Expression<Func<fb_DeviceUnits, fb_DeviceUnits>>)(d => d)));
        //}
    }
}
